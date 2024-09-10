using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TP01EF2024.Entidades
{
    public class Sport
    {
        public int SportId { get; set; }
        public string SportName { get; set; } = null!;
        public bool Active { get; set; }
        public ICollection<Shoe> Shoes { get; set; } = new List<Shoe>();

    }
}
