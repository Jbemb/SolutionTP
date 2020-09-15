using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpOne.Entities
{
    class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int perimetre { get; private set; }
        private double p;
        private double aire { get; set; }
       



        public override void Aire()
        {
            p = (this.A + this.B + this.C) / 2;
            aire = Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));
    }

        public override void Perimetre()
        {
            perimetre = this.A + this.B + this.C;
        }
    }
}
