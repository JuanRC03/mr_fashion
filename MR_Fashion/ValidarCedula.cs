using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR_Fashion
{
    class ValidarCedula
    {
        public ValidarCedula() { }
        public bool validar(string s)
        {
            int a = s.Length;
            if (a == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
