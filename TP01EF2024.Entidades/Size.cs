using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01EF2024.Entidades
{
    public class Size
    {
        public int SizeId { get; set; }
        public decimal SizeNumber { get; set; }
        public ICollection<ShoeSize> ShoesSizes { get; set; } = new List<ShoeSize>();

    }
}
