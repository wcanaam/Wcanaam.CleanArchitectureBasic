using System.ComponentModel.DataAnnotations;

namespace Wcanaam.CleanArchitectureBasic.Application.DTOs {
    public class CategoryDTO {

        public int Id { get; set; }

        [Required(ErrorMessage = "The name is required")]
        [MinLength(5)]
        [MaxLength(50)]
        public string Name { get; set; }

    }
}
