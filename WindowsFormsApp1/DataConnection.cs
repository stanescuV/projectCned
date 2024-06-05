using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.exeption;
using WindowsFormsApp1.personnel;

namespace WindowsFormsApp1
{
    class DataConnection
    {
        private MySqlConnection connection;
        private MySqlDataReader reader;
        private MySqlCommand command;
        private readonly string connectionString = "server=localhost;user id=victor;password=qwerty123;persistsecurityinfo=True;database=cned;SslMode=none";

        public DataConnection()
        {
            InitConnection();
        }

        private void InitConnection()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }

        public Boolean validateLogin(string login, string hashedPassword)
        {
            string query = "SELECT COUNT(*) FROM responsable WHERE login = @login AND pwd = @pwd";

            // Execute the query
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@pwd", hashedPassword);

                int userCount = Convert.ToInt32(command.ExecuteScalar());

                // If userCount is greater than 0, the credentials are valid
                return userCount > 0;
            }
        }

        public List<Personnel> RecupPersonnel()
        {
            string query = "SELECT idpersonnel, nom, prenom, mail, tel, idservice FROM personnel";
            command = new MySqlCommand(query, connection);
            command.Prepare();
            reader = command.ExecuteReader();

            List<Personnel> personnels = new List<Personnel>();

            while (reader.Read())
            {
                Personnel personnel = new Personnel
                {
                    IdPersonnel = Convert.ToInt32(reader["idpersonnel"]),
                    Nom = reader["nom"].ToString(),
                    Prenom = reader["prenom"].ToString(),
                    Mail = reader["mail"].ToString(),
                    Tel = reader["tel"].ToString(),
                    IdService = Convert.ToInt32(reader["idservice"]) // Add IdService property
                };
                personnels.Add(personnel);
            }
            reader.Close();
            return personnels;
        }

        public void DeletePersonnel(Personnel selectedPersonnel)
        {
            try
            {
                // Start a transaction
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    // Delete from absence table
                    string deleteAbsenceQuery = "DELETE FROM absence WHERE idpersonnel = @idpersonnel";
                    MySqlCommand deleteAbsenceCommand = new MySqlCommand(deleteAbsenceQuery, connection, transaction);
                    deleteAbsenceCommand.Parameters.AddWithValue("@idpersonnel", selectedPersonnel.IdPersonnel);
                    deleteAbsenceCommand.ExecuteNonQuery();

                    // Delete from personnel table
                    string deletePersonnelQuery = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel";
                    MySqlCommand deletePersonnelCommand = new MySqlCommand(deletePersonnelQuery, connection, transaction);
                    deletePersonnelCommand.Parameters.AddWithValue("@idpersonnel", selectedPersonnel.IdPersonnel);
                    deletePersonnelCommand.ExecuteNonQuery();

                    // Commit the transaction
                    transaction.Commit();
                }
            }
            catch (MySqlException ex)
            {
                throw new DeletionException("Une erreur lors de la suppression du personnel", ex);
            }
        }

        public List<Service> RecupServices()
        {
            string query = "SELECT idservice, nom FROM service";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Prepare();
            MySqlDataReader reader = command.ExecuteReader();
            List<Service> services = new List<Service>();
            while (reader.Read())
            {
                Service service = new Service
                {
                    IdService = Convert.ToInt32(reader["idservice"]),
                    Nom = reader["nom"].ToString()
                };
                services.Add(service);
            }
            reader.Close();
            return services;
        }

        public List<Motif> RecupMotifs()
        {
            string query = "SELECT idmotif, libelle FROM motif";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Prepare();
            MySqlDataReader reader = command.ExecuteReader();
            List<Motif> motifs = new List<Motif>();
            while (reader.Read())
            {
                Motif motif = new Motif
                {
                    IdMotif = Convert.ToInt32(reader["idmotif"]),
                    Libelle = reader["libelle"].ToString()
                };
                motifs.Add(motif);
            }
            reader.Close();
            return motifs;
        }

        


        public void UpdatePersonnel(int idpersonnel, string nom, string prenom, string mail, string tel, int idservice)
        {
            string query = "UPDATE personnel SET nom = @nom, prenom = @prenom, mail = @mail, tel = @tel, idservice = @idservice WHERE idpersonnel = @idpersonnel";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@tel", tel);
            command.Parameters.AddWithValue("@idservice", idservice);
            command.Parameters.AddWithValue("@idpersonnel", idpersonnel);

            try
            {
                command.ExecuteNonQuery();
                if (app_screen.instance != null)
                {
                    app_screen.instance.RecupPersonnel();
                }
            }
            catch (MySqlException ex)
            {
                throw new ModifyException("Une erreur lors de la modification du personnel", ex);
            }
        }

        public void InsertPersonnel(Service selectedService, string nom, string prenom, string mail, string tel, int idservice)
        {
            string query = "INSERT INTO personnel (nom, prenom, mail, tel, idservice) VALUES (@nom, @prenom, @mail, @tel, @idservice)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@tel", tel);
            command.Parameters.AddWithValue("@idservice", idservice);

            try
            {
                command.ExecuteNonQuery();
                if (app_screen.instance != null)
                {
                    app_screen.instance.RecupPersonnel();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void InsertAbsence(int idPersonnel, DateTime dateDebut, DateTime dateFin, int idMotif)
        {
            string query = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES (@idpersonnel, @datedebut, @datefin, @idmotif)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@idpersonnel", idPersonnel);
            command.Parameters.AddWithValue("@datedebut", dateDebut);
            command.Parameters.AddWithValue("@datefin", dateFin);
            command.Parameters.AddWithValue("@idmotif", idMotif);

            try
            {
                command.ExecuteNonQuery();
                if (app_screen.instance != null)
                {
                    app_screen.instance.GetAbsences(idPersonnel);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public bool VerifyAbsence(int idPersonnel, DateTime dateDebut, DateTime dateFin)
        {
            string query = @"SELECT COUNT(*) AS count
                            FROM absence
                            WHERE idpersonnel = @idpersonnel
                            AND (datedebut <= @dateFin AND datefin >= @dateDebut)";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idpersonnel", idPersonnel);
                command.Parameters.AddWithValue("@dateFin", dateFin);
                command.Parameters.AddWithValue("@dateDebut", dateDebut);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count < 1; // return un boolean s'il existe déjà des absences sur cetter période 
            }
        }

        public bool VerifyAbsence(int idPersonnel, DateTime dateDebut, DateTime dateFin, int idAbsence)
        {
            string query = @"SELECT COUNT(*) AS count
                            FROM absence
                            WHERE idpersonnel = @idpersonnel
                            AND (datedebut <= @dateFin AND datefin >= @dateDebut)
                            AND idabsence != @idAbsence";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idpersonnel", idPersonnel);
                command.Parameters.AddWithValue("@idAbsence", idAbsence);
                command.Parameters.AddWithValue("@dateFin", dateFin);
                command.Parameters.AddWithValue("@dateDebut", dateDebut);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count < 1; // return un boolean s'il existe déjà des absences sur cetter période 
            }
        }

        public string GetTextMotif(int idMotif)
        {
            string message = "";
            string query = @"select libelle from motif where idmotif = @idMotif";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idMotif", idMotif);
                command.Prepare();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        message = reader["libelle"].ToString();
                    }
                }
                return message;
            }
        }

        public List<Absence> GetAbsences(int idPersonnel)
        {
            string query = @"
        SELECT * 
        FROM absence a
        JOIN motif m ON a.idmotif = m.idmotif
        WHERE a.idpersonnel = @idpersonnel";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idpersonnel", idPersonnel);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    List<Absence> absences = new List<Absence>();
                    while (reader.Read())
                    {
                        Absence absence = new Absence
                        {
                            IdAbsence = Convert.ToInt32(reader["idabsence"]),
                            IdPersonnel = Convert.ToInt32(reader["idpersonnel"]),
                            DateDebut = Convert.ToDateTime(reader["datedebut"]),
                            DateFin = Convert.ToDateTime(reader["datefin"]),
                            IdMotif = Convert.ToInt32(reader["idmotif"])

                        };
                        absences.Add(absence);
                    }
                    return absences;
                }
            }
        }

        public void UpdateAbsence(int idAbsence, int idPersonnel, int idMotif, DateTime dateDebut, DateTime dateFin)
        {

            string query = "UPDATE absence SET datedebut = @dateDebut, datefin = @dateFin, idmotif =@idMotif WHERE idabsence = @idAbsence";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@dateDebut", dateDebut);
            command.Parameters.AddWithValue("@dateFin", dateFin);
            command.Parameters.AddWithValue("@idMotif", idMotif);
            command.Parameters.AddWithValue("@idAbsence", idAbsence);

            try
            {
                command.ExecuteNonQuery();
                if (app_screen.instance != null)
                {
                    app_screen.instance.GetAbsences(idPersonnel);
                }
            }
            catch (MySqlException ex)
            {
                throw new ModifyException("Une erreur lors de la modification de l'absence", ex);
            }
        }

        public void DeleteAbsence(Absence selectedAbsence)
        {
            try
            {
                // Start a transaction
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    // Delete from absence table
                    string deleteAbsenceQuery = "DELETE FROM absence WHERE idabsence = @idAbsence";
                    MySqlCommand deleteAbsenceCommand = new MySqlCommand(deleteAbsenceQuery, connection, transaction);
                    deleteAbsenceCommand.Parameters.AddWithValue("@idAbsence", selectedAbsence.IdAbsence);
                    deleteAbsenceCommand.ExecuteNonQuery();
                    
                    // Commit the transaction
                    transaction.Commit();
                }
            }
            catch (MySqlException ex)
            {
                throw new DeletionException("Une erreur lors de la suppression du personnel", ex);
            }
        }
    }
}
