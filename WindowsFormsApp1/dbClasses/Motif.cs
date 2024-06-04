namespace WindowsFormsApp1.personnel
{
    public class Motif
    {
        public int IdMotif { get; set; }
        public string Libelle { get; set; }

        public override string ToString()
        {
            return Libelle;
        }
    }
}
