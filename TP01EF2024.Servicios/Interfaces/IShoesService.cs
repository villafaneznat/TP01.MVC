using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Dtos;
using TP01EF2024.Entidades.Enums;

namespace TP01EF2024.Servicios.Interfaces
{
    public interface IShoesService
    {
        void Guardar(Shoe shoe);
        void Eliminar(Shoe shoe);
        bool EstaRelacionado(Shoe shoe);
        bool Existe(Shoe shoe);
        Shoe? GetShoePorId(int id);
        List<Shoe> GetShoes();
        List<ShoeDto> GetListaDto();
        int GetCantidad();
        List<Shoe> GetListaShoesPaginadaOrdenadaFiltrada(
            int page,
            int pageSize,
            Orden? orden = null,
            string? textFil = null,
            Brand? brand = null,
            Sport? sport = null,
            Genre? genre = null,
            Colour? colour = null,
            decimal? maximo = null,
            decimal? minimo = null);
        int GetCantidadFiltrada(Brand? brand = null,
            Sport? sport = null,
            Genre? genre = null,
            Colour? colour = null,
            decimal? maximo = null,
            decimal? minimo = null);
        List<ShoeDto> GetListaShoesDtosPaginadaOrdenadaFiltrada(int page,
            int pageSize,
            Orden? orden = null,
            string? textFil = null,
            Brand? brand = null,
            Sport? sport = null,
            Genre? genre = null,
            Colour? colour = null,
            decimal? maximo = null,
            decimal? minimo = null,
            Size? size = null);
        void AgregarShoeSize(ShoeSize nuevaRelacion);
        void ActualizarShoeSize(ShoeSize shoeSize);
        void EliminarShoeSize(ShoeSize shoeSize);
        bool ExisteShoeSize(ShoeSize shoesize);
        ShoeSize? GetShoeSize(Shoe shoe, Size size);
        List<Size> GetSizesForShoe(int shoeId);
        List<ShoeSize> GetShoesSizesPaginados(int page, int pageSize, Shoe shoe);
    }
}
