using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TP01.MVC.Web.ViewModels.Size
{
    public class ShoeStockViewModel
    {
        public int ShoeId { get; set; }
        public int SizeId { get; set; }
        public decimal SizeNumber { get; set; }
        [DisplayName("Marca")]
        public string? BrandName { get; set; }
        [DisplayName("Deporte")]

        public string? SportName { get; set; }
        [DisplayName("Genero")]

        public string? GenreName { get; set; }
        [DisplayName("Color")]

        public string? ColourName { get; set; }
        [DisplayName("Modelo")]

        public string? Model { get; set; }
        [DisplayName("Descripcion")]

        public string? Description { get; set; }
        public int QuantityInStock { get; set; }
        [DisplayName("Precio")]

        public string Price { get; set; }
    }
}
