using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpOne.Entities
{
    class Carre : Rectangle
    {
        private int width;
        private int height;

        public int Height
        {
            get { return height; }
            set { height = this.width; }
        }

        private double aire;
        private double perimetre;


        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public override void Aire()
        {
            aire = width * Height;
        }

        public override void Perimetre()
        {
            perimetre = (2 * width) + (2 * height);
        }
    }
}
