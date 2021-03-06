﻿using BO;
using BODojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dojo.Models
{
    public class SamouraiVM
    {
        public Samourai Samourai { get; set; }
        public List<Arme> Armes { get; set; }
        public int? ArmesId { get; set; }
        public IEnumerable<ArtMartial> ArtMartials { get; set; }
        public List<int> ArtMartialsId { get; set; } = new List<int>();

    }
}