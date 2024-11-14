using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Dtos;
using TP01EF2024.Entidades.Enums;

namespace TP01EF2024.Datos.Interfaces
{
    public interface IShoesRepository : IGenericRepository<Shoe>
    {
        void Update(Shoe shoe);
        bool Exist(Shoe shoe);
        bool ItsRelated(int id);
        public List<ShoeSize> GetAllShoesSizes(int shoeId);
        public ShoeSize? GetShoeSizeBySizeNumber(decimal sizeNumber, int shoeId);
        public void UpdateShoeSize(ShoeSize ss);
        public void InsertShoeSize(ShoeSize shoeSize);
    }
}
