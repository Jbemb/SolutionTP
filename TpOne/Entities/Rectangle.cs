using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpOne.Entities
{
    class Rectangle : Forme
    {
        private int largeur;
        private int longeur;

        public virtual int Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }

        public int Longeur
        {
            get { return longeur; }
            set { longeur = value; }
        }

        public override double Aire => longeur * largeur;

        public override double Perimetre => 2 * longeur + 2 * largeur;
    }

        public override string ToString()
        {
            return "Rectangle - width: {0} and height: {1} \n " + base.ToString();
        }
    }
}
