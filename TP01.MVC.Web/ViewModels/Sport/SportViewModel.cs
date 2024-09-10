using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TP01.MVC.Web.ViewModels.Sport
{
    public class SportViewModel
    {
        public int SportId { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [StringLength(50, ErrorMessage = "No se admiten más de 50 caracteres")]
        [DisplayName("Deporte")]
        public string? SportName { get; set; }
    }
}
