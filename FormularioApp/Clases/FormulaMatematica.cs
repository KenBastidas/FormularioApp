using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioApp.Clases
{
    class FormulaMatematica
    {
        public static double Formula(int k, int d)
        {
            double total = 0;
            double calula = 0;
            for (int x = k; x<=d; x++)
            {
                calula +=((Math.Pow(2, x + 1)) - (Math.Pow(2, x))) / (x + 1);
            }
            total=total + calula;


            return total;
        }
    }
}
