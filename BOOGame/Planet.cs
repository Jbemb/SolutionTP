using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOGame
{
    public class Planet : IDbEntity
    {
		private long id;
		public long Id { get => id; set => Id = value; }
		[MaxLength(20)]
		[MinLength(5)]
		private String name;
		private int? caseNb;
		[NotMapped]
		private List<Building> buildings;
		private Resource energy;
		private Resource oxygen;
		private Resource uranium;
		private Resource steel;


		public virtual Resource Steel
		{
			get { return steel; }
			set { steel = value; }
		}


		public virtual Resource Uranium
		{
			get { return uranium; }
			set { uranium = value; }
		}


		public virtual Resource Oxygen
		{
			get { return oxygen; }
			set { oxygen = value; }
		}


		public virtual Resource Energy
		{
			get { return energy; }
			set { energy = value; }
		}

		[NotMapped]
		public List<Building> Buildings
		{
			get { return buildings; }
			set { buildings = value; }
		}


		public int? CaseNb
		{
			get { return caseNb; }
			set { caseNb = value; }
		}


		public String Name
		{
			get { return name; }
			set { name = value; }
		}
	}
}
