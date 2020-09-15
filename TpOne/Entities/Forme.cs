using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpOne.Entities
{


    public abstract class Forme
    {
        public abstract double Aire { get; }
        public abstract double Perimetre { get; }

        public virtual String Print()
        {
            return displayAP(Aire, Perimetre);
        }

        protected Func<double, double, string> displayAP = new Func<double, double, string>((a, p) => {
            return "Aire = " + a + "\nPérimètre = " + p + "\n";
        });

        public override string ToString()
        {
           return Print();
           //return String.Format("\n Perimeter: {2} \n Area: {3}\n", this.Perimetre, this.Aire);
        }
    }
}
