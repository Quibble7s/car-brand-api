using System.ComponentModel.DataAnnotations;

namespace Web.API.Models.ValueObjects
{
    public class CarBrand
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
