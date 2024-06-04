using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.exeption
{
    class DeletionException : Exception
    {
        public DeletionException(string message, Exception err) : base (message, err)
        {

        }
    }
}
