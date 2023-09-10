using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR_Fashion
{
    class validarFecha
    {
        public validarFecha() { }
        public bool validarf(string d)
        {
            bool dd=false;
            bool mm = false;
            bool aa = false;
            bool bisiesto=false;
            if (d.Length == 10)
            {
                string dia = "";
                string mes = "";
                string anio = "";
                int cont = d.Length;
                int i = 0;
                do
                {
                    if (d[i] != '/')
                    {
                        dia = dia + d[i];
                    }
                    i++;
                } while (d[i] != '/');
                do
                {
                    if (d[i] != '/')
                    {
                        mes = mes + d[i];
                    }
                    i++;
                } while (d[i] != '/');
                do
                {
                    if (d[i] != '/')
                    {
                        anio = anio + d[i];
                    }
                    i++;
                } while (i != cont);
                int d1 = int.Parse(dia);
                int m1 = int.Parse(mes);
                int a1 = int.Parse(anio);

                //año
                if ((a1 >= 1880) && (a1 <= 2000))
                {
                    if (a1 % 4 == 0 && a1 % 100 != 100 || a1 % 400 == 0)
                    {
                        bisiesto = true;
                    }
                    aa = true;
                }
                else
                {
                    aa = false;
                }

                //mes
                if ((m1 >= 1) && (m1 <= 12))
                {
                    mm = true;
                }
                else
                {
                    mm = false;
                }

                //dia

                if (m1 == 1 || m1 == 3 || m1 == 5 || m1 == 7 || m1 == 8 || m1 == 10 || m1 == 12)
                {
                    if (d1 > 0 && d1 < 32)
                    {
                        dd = true;
                    }
                    else
                    {
                        dd = false;
                    }
                }
                else if (m1 == 4 || m1 == 6 || m1 == 9 || m1 == 11)
                {
                    if (d1 > 0 && d1 < 31)
                    {
                        dd = true;
                    }
                    else
                    {
                        dd = false;
                    }
                }
                else
                {
                    if ((m1 == 2) && (d1 < 30) && bisiesto)
                    {
                        dd = true;
                    }
                    else if (m1 == 2 && d1 < 29 && !bisiesto)
                    {
                        dd = true;
                    }
                    else if (bisiesto == true)
                    {
                        dd = false;
                    }

                    else
                    {
                        dd = false;
                    }
                }
                if(dd==true && mm==true && aa == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
