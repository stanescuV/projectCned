using System;

namespace WindowsFormsApp1
{
    public class Absence
    {
        private DataConnection connectionDb = new DataConnection();
        public int IdAbsence { get; set; }
        public int IdPersonnel { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int IdMotif { get; set; }

        public override string ToString()
        {
            return $"{DateDebut.ToShortDateString()} - {DateFin.ToShortDateString()} - {connectionDb.GetTextMotif(IdMotif)}";
        }
    }
}
