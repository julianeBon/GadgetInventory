using System.ComponentModel.DataAnnotations;

namespace GadgetInventory.Models
{
    public class Gadget
    {
        public int Id { get; set; } // what does this do?

        [Required(ErrorMessage = "Brand name is required.")] // what is this? why no sem colon at the end?
        public string Brand { get; set; }

        [Required(ErrorMessage = "Model name is required.")]
        [Display(Name = "Model Name")]
        public string ModelName { get; set; }

        [Range(1, 5000, ErrorMessage = "Price must be between $1 and $5000")]
        public decimal Price { get; set; }
    }
}