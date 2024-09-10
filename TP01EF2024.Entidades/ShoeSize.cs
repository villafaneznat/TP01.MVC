using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TP01EF2024.Entidades
{
    public class ShoeSize
    {
        public int ShoeSizeId { get; set; }
        public int ShoeId { get; set; }
        public Shoe Shoe { get; set; } = null!;
        public int SizeId { get; set; }
        public Size Size { get; set; } = null!;
        public int QuantityInStock { get; set; }

    }
}
