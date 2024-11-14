using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace TP01.MVC.Web.ViewModels.Shoe
{
    public class ShoeFilterViewModel
    {
        public IPagedList<ShoeViewModel>? Shoes { get; set; }
        public List<SelectListItem>? Brands { get; set; }
        public List<SelectListItem>? Sports { get; set; }
        public List<SelectListItem>? Genres { get; set; }
        public List<SelectListItem>? Colours { get; set; }
    }
}
