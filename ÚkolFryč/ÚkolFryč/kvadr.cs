using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÚkolFryč
{
    internal class Kvadr
    {
        public double StranaA { get; set; }
        public double StranaB { get; set; }
        public double StranaC { get; set; }

        public Kvadr(double a, double b, double c) {
            StranaA= a;
            StranaB= b;
            StranaC= c;
        }
        public double VypocetObjemu()
        {
            double vysledek = StranaA * StranaB * StranaC;
            return vysledek;
        }
        public double VypocetPovrchu()
        {
            double vysledek = 2 * (StranaA*StranaB + StranaA*StranaC + StranaB*StranaC);
            return vysledek;
        }
        public double VypocetTelesoveUhlopricky()
        {
            double vysledek = Math.Sqrt(Math.Pow(StranaA, 2) + Math.Pow(StranaB, 2) + Math.Pow(StranaC, 2));
            return vysledek;
        }
        public double VypocetStenoveUhlopricky()
        {
            double vysledek = Math.Sqrt(Math.Pow(StranaA, 2) + Math.Pow(StranaB, 2));
            return vysledek;
        }
    }
}
