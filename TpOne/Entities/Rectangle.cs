using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpOne.Entities
{
    class Rectangle : Forme
    {
        private int width;
        public virtual int Height { get; set; }
        private double aire;
        private double perimetre;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public override void Aire()
        {
            aire = width*Height;
        }

        public override void Perimetre()
        {
            perimetre = (2 * width) + (2 * Height);
        }
    }
}
