using System;
using System.Collections.Generic;
using System.Text;

namespace ACT3_Events
{
    internal class Math
    {
        public void trimone(int a, int b, int c, out string type)
        {
            type = null;
            double d;
            double x1;
            double x2;

            d = System.Math.Pow(b, 2) - 4 * a * c;
            if(d >= 0)
            {
                if(d > 0)
                {
                    x1 = (-b + System.Math.Sqrt(d) / (-2 * a));
                    x2 = (-b - System.Math.Sqrt(d) / (-2 * a));
                    type = "Il y a deux racines réelles :" + x1 + " et " + x2; 
                }
                else
                {
                    x1 = (-b) / (2 * a);
                    type = "Il y a une seule racine : "  + x1;
                }
            }
            else
            {
                type = "Il n'y a pas de racine";
            }
        }
    }
    
}
