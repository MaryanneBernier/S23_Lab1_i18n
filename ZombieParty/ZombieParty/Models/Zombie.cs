using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ZombieParty.Models
{
    public class Zombie
    {
        public int Id { get; set; }


        [Display(Name = "Name")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "StringLengthValidation")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public string Name { get; set; }

        [Display(Name = "ShortDesc")]
        [StringLength(255, ErrorMessage = "StringLengthMaxValidation")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public string ShortDesc { get; set; }

        [Display(Name = "Point")]
        [Range(1, 20, ErrorMessage = "RangeValidation")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public int Point { get; set; }

        [Display(Name = "Force")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public int Force { get; set; }

        [Display(Name = "Image")]
        [ValidateNever]
        public string Image { get; set; }

        // FACULTATIF on peut formellement identifier le champ lien
        // sinon le champ de foreignKey sera auto généré dans la BD
        [Display(Name = "ZombieType")]
        [ForeignKey("ZombieType")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public int ZombieTypeId { get; set; }

        [ValidateNever]
        [Display(Name = "ZombieType")]
 
        public virtual ZombieType? ZombieType { get; set; }

        [ValidateNever]
        [Display(Name = "HuntingLogs")]
        public virtual List<HuntingLog> HuntingLogs { get; set; }
    }
}
