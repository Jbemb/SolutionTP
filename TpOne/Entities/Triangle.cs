using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpOne.Entities
{
    class Triangle : Forme
    {
        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        private double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        private double c;

        public double C
        {
            get { return c; }
            set { c = value; }
        }

    
        private double p => (A + B + C) / 2;
  
        public override double Aire => Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));
    

        public override double Perimetre=> A + B + C;
        
    }
}
