using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wcanaam.CleanArchitectureBasic.Domain.Entities;

namespace Wcanaam.CleanArchitectureBasic.Application.DTOs {
    public class ProductDTO {

        public int Id { get; set; }

        [Required(ErrorMessage = "The name is required")]
        [MinLength(5)]
        [MaxLength(50)]
        public string Name { get; private set; }

        [MaxLength(150)]
        public string Description { get; private set; }

        [Required(ErrorMessage = "The price is required")]
        [Column(TypeName = "decimal(10, 2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        public decimal Price { get; private set; }

        [Required(ErrorMessage = "The price is required")]
        [Range(1, 999)]
        public int Stock { get; private set; }

        [Display(Name = "Categories")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }
}
