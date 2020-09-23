

using BO;
using System;
using System.Collections.Generic;

namespace BODojo
{
    public class Samourai : DbEntity
    {
        public int Force { get; set; }
        public string Nom { get; set; }
        public virtual Arme Arme { get; set; }
        public virtual List<ArtMartial> Artmartials { get; set; }
        public int Potentiel { get => GetPotentiel(); }

        private int GetPotentiel()
        {
            int degat = 0;
            if (this.Arme != null) 
            {
                degat = this.Arme.Degats;
            }
            int ma = 0;
            if(this.Artmartials != null) 
            {
                ma = this.Artmartials.Count;
            }
            return (this.Force + degat) * (ma + 1);
        }

        
            
    }
}
