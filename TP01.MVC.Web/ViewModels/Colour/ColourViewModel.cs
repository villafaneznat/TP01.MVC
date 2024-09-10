﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TP01.MVC.Web.ViewModels.Colour
{
    public class ColourViewModel
    {
        public int ColourId { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [StringLength(50, ErrorMessage = "No se admiten más de 50 caracteres")]
        [DisplayName("Color")]
        public string? ColourName { get; set; }
    }
}
