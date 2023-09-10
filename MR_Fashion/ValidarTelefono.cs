using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR_Fashion
{
    class ValidarTelefono
    {
        public ValidarTelefono() { }
        public bool validart(string s)
        {
            int a = s.Length;
            if (a == 12) { return true; }
            else {return false; }
        }
    }
}
