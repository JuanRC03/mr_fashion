using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR_Fashion
{
    class IVA
    {
        public IVA() { }

        public double resul(double s, double p)
        {
            double h;
            double sum;
            h = s * p;
            sum = h + s;
            return sum;
        }
    }
}
