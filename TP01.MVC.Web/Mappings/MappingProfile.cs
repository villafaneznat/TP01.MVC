using AutoMapper;
using TP01.MVC.Web.ViewModels.Brand;
using TP01.MVC.Web.ViewModels.Colour;
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

    }
}
