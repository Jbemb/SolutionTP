

using BO;
using System.Collections.Generic;

namespace BODojo
{
    public class Samourai : DbEntity
    {
        public int Force { get; set; }
        public string Nom { get; set; }
        public virtual Arme Arme { get; set; }

        public virtual List<ArtMartial> Artmartials { get; set; }
}
}
