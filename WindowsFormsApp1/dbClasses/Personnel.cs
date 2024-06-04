using System;

namespace WindowsFormsApp1
{
    public class Personnel
    {
        public int IdPersonnel { get; set; }
        public int IdService { get; set; } // Add IdService property
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }

        public override string ToString()
        {
            return $"{Nom} {Prenom} - {Mail} - {Tel}";
        }
    }
}
