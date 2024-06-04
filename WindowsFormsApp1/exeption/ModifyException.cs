using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.exeption
{
    class ModifyException : Exception
    {
        public ModifyException(string message, Exception err) : base (message, err)
        {

        }
    }
}
