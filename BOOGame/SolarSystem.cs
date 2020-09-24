using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOGame
{
    public class SolarSystem : IDbEntity
    {
        private long id;
        public long Id { get => id; set => Id = value; }
        [MaxLength(20)]
        [MinLength(5)]
        private String name;
        private List<Planet> planets;

        public virtual List<Planet> Planets
        {
            get { return planets; }
            set { planets = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
