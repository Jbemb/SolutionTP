using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpOne.Entities
{


    public abstract class Forme
    {
		
		public abstract void Aire();

		public abstract void Perimetre();

		public override string ToString()
		{
			return //$"Area = {Aire} Perimeter = {Perimetre}" + 
				base.ToString();
		}
	}
}
