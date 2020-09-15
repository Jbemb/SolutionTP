using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpOne.Entities
{
    class Carre : Rectangle
    {
        public override int Largeur
        {
            get { return this.Longeur; }
        }     


        public override string ToString()
        {
            return String.Format("Carre - width: {0} and height: {1} \n ", this.Largeur, this.Longeur);
        }
    }
}
