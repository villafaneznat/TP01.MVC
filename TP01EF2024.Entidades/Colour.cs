using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01EF2024.Entidades
{
    public class Colour
    {
        public int ColourId { get; set; }
        public string ColourName { get; set; } = null!;
        public bool Active { get; set; }
        public ICollection<Shoe> Shoes{ get; set; } = new List<Shoe>();
    }
}
