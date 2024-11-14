using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TP01.MVC.Web.ViewModels.Shoe
{
    public class ShoeEditViewModel
    {
        public int ShoeId { get; set; }

        [Required(ErrorMessage = "Brand is required")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a Brand")]
        [DisplayName("Brand")]
        public string? BrandId { get; set; }

        [Required(ErrorMessage = "Sport is required")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a Sport")]
        [DisplayName("Sport")]
        public string? SportId { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a Genre")]
        [DisplayName("Genre")]
        public string? GenreId { get; set; }

        [Required(ErrorMessage = "Color is required")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a Color")]
        [DisplayName("Color")]
        public string? ColourId { get; set; }

        [Required(ErrorMessage = "Model is required")]
        [DisplayName("Model")]

        public string Model { get; set; } = null!;

        [Required(ErrorMessage = "Description is required")]
        [DisplayName("Description")]
        public string Description { get; set; } = null!;
        [Required(ErrorMessage = "Price is required")]
        [Range(1, int.MaxValue, ErrorMessage = "You must enter a Price")]
        [DisplayName("Price")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public bool Active { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> Brands { get; set; } = null!;
        [ValidateNever]
        public IEnumerable<SelectListItem> Sports { get; set; } = null!;
        [ValidateNever]
        public IEnumerable<SelectListItem> Genres { get; set; } = null!;
        [ValidateNever]
        public IEnumerable<SelectListItem> Colours { get; set; } = null!;
    }
}
