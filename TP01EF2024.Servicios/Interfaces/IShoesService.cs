using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Dtos;
using TP01EF2024.Entidades.Enums;

namespace TP01EF2024.Servicios.Interfaces
{
    public interface IShoesService
    {
        IEnumerable<Shoe>? GetAll(Expression<Func<Shoe,
            bool>>? filter = null,
            Func<IQueryable<Shoe>,
            IOrderedQueryable<Shoe>>? orderBy = null,
            string? propertiesNames = null);

        void Guardar(Shoe shoe);

        void Eliminar(Shoe shoe);

        Shoe? Get(Expression<Func<Shoe,
            bool>>? filter = null,
            string? propertiesNames = null,
            bool tracked = true);

        bool Existe(Shoe shoe);

        bool EstaRelacionado(int id);

        public List<ShoeSize> GetAllShoesSizes(int shoeId);
        public ShoeSize? GetShoeSizeBySizeNumber(decimal sizeNumber, int shoeId);

        public void UpdateShoeSize(ShoeSize ss);
        public void InsertShoeSize(ShoeSize shoeSize);
    }
}
