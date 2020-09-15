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

       
        public override double Aire => Math.PI*rayon*rayon;

        public override double Perimetre => 2 * Math.PI * rayon; 
        
        
        public override string ToString()
        {
            return "Circle " + Rayon + base.ToString();
        }
    }
}
