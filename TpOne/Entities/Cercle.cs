using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpOne.Entities
{
    public class Cercle : Forme
    {
        private double rayon;
        private double aire;
        private double perimetre;

        public double Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }

        public override void Aire()
        {
            aire = Math.PI*rayon*rayon;
        }

        public override void Perimetre()
        {
            perimetre = 2 * Math.PI * rayon;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
