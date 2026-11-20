using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class ZombieType
    {
        public int Id { get; set; }
        [Display(Name ="TypeName")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "StringLengthValidation")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public string TypeName { get; set; }

        [Display(Name = "Point")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        [Range(2, 5, ErrorMessage = "RangeValidation")]
        public int Point { get; set; }

        [Display(Name = "Zombies")]
        [ValidateNever]
        public virtual List<Zombie>? Zombies { get; set; }
    }
}
