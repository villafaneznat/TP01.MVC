using AutoMapper;
using TP01.MVC.Web.ViewModels.Brand;
using TP01.MVC.Web.ViewModels.Colour;
using TP01.MVC.Web.ViewModels.Shoe;
using TP01.MVC.Web.ViewModels.Sport;
using TP01EF2024.Entidades;

namespace TP01.MVC.Web.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            LoadBrandsMap();
            LoadColoursMap();
            LoadSportsMap();
            LoadShoesMap();
            LoadShoeSizesMap();

        }

        private void LoadBrandsMap()
        {
            CreateMap<Brand, BrandViewModel>().ReverseMap();
        }
        private void LoadColoursMap()
        {
            CreateMap<Colour, ColourViewModel>().ReverseMap();
        }
        private void LoadSportsMap()
        {
            CreateMap<Sport, SportViewModel>().ReverseMap();
        }
        private void LoadShoesMap()
        {
            CreateMap<Shoe, ShoeViewModel>()
            .ForMember(dest => dest.BrandName,
                opt => opt.MapFrom(src => src.Brand.BrandName))
            .ForMember(dest => dest.SportName,
                opt => opt.MapFrom(src => src.Sport.SportName))
            .ForMember(dest => dest.GenreName,
                opt => opt.MapFrom(src => src.Genre.GenreName))
            .ForMember(dest => dest.ColourName,
                opt => opt.MapFrom(src => src.Colour.ColourName))
            .ReverseMap();

            CreateMap<Shoe, ShoeEditViewModel>().ReverseMap();
        }

        private void LoadShoeSizesMap()
        {
            CreateMap<ShoeSize, SizeStockViewModel>()
                .ForMember(dest => dest.SizeNumber, opt => opt.MapFrom(src => src.Size.SizeNumber))
                .ForMember(dest => dest.QuantityInStock, opt => opt.MapFrom(src => src.QuantityInStock))
                .ForMember(dest => dest.ShoeId, opt => opt.MapFrom (src => src.ShoeId))
                .ReverseMap();
        }

    }
}
