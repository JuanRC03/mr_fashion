using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR_Fashion
{
    class VerificarCodigoProducto
    {
        public VerificarCodigoProducto() { }
        public bool verificarp(string s)
        {
            int a = s.Length;
            if (a == 9)
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
