using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOGame
{
    public abstract class Building : IDbEntity
    {
        private long id;
        public long Id { get => id; set => Id = value; }
        private String name;
        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }


        public abstract int? CellNb();
        public abstract List<Resource> TotalCost();
        public abstract List<Resource> NextCost();
    }
}
