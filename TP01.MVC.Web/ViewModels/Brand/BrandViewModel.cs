using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TP01.MVC.Web.ViewModels.Brand
{
    public class BrandViewModel
    {
        public int BrandId { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [StringLength(50, ErrorMessage ="No se admiten más de 50 caracteres")]
        [DisplayName("Nombre de marca")]
        public string? BrandName { get; set; }
    }
}
