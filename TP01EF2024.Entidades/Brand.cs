using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01EF2024.Entidades
{
    
    public class Brand
    {
        public int BrandId { get; set; }

        public string BrandName { get; set; } = null!;

        public bool Active { get; set; }

        public ICollection<Shoe> Shoes { get; set; } = new List<Shoe>();

    }
}
