using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class Weapon : IValidatableObject
    {
        public int WeaponId { get; set; }

        [Display(Name = "Name")]
        [StringLength(250, MinimumLength = 2, ErrorMessage = "ValidationStringMinMax")]
        [Required(ErrorMessage = "ValidationRequired")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [MaxLength(2500, ErrorMessage = "ValidationStringMax")]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }

        [Display(Name = "Force")]
        [Range(0, Double.MaxValue, ErrorMessage = "ValidationRange")]
        [Required(ErrorMessage = "ValidationRequired")]
        public decimal Force { get; set; }

        [Display(Name = "Price")]
        [Range(0, 100000, ErrorMessage = "ValidationRange")]

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "CreatedDate")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Display(Name = "Image")]
        [DataType(DataType.ImageUrl)]
        public string? Image { get; set; }

        [Display(Name = "Qty")]
        [Required(ErrorMessage = "ValidationRequired")]
        public int Qty { get; set; }

        [Display(Name = "QtyBought")]
        [Required(ErrorMessage = "ValidationRequired")]
        public int QtyBought { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var item = validationContext.ObjectInstance as Weapon;
            if (item == null) yield break;
            if (string.IsNullOrWhiteSpace(item.Description)) yield break;
            if (item.Description.Split(" ").Length <= 3)
                yield return new ValidationResult("DescriptionMinWordsValidation", new[] { "Description" });
        }
    }
}
