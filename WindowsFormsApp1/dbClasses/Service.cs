using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.personnel
{
    public class Service
    {
        public int IdService { get; set; }
        public string Nom { get; set; }

        public override string ToString()
        {
            return Nom; // Adjust this to display the appropriate information in the ComboBox
        }
    }
}
