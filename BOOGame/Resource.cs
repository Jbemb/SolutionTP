using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOGame
{
    public class Resource : IDbEntity
    {
        private long id;
        public long Id { get => id; set => Id = value; }
        [MaxLength(20)]
        [MinLength(5)]
        public String Name { get; set; }
        public int? LastQuantity { get; set; }
        public DateTime LastUpdate { get; set; }
        
    }
}
