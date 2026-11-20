using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class HuntingLog
    {
        public int Id { get; set; }


        [StringLength(25, MinimumLength = 5, ErrorMessage = "StringLengthValidation")]
        [Display(Name = "Title")]
        public string Title { get; set; }


        [StringLength(255, ErrorMessage = "StringLengthMaxValidation")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Zombies")]
        [ValidateNever]
        public virtual List<Zombie> Zombies { get; set; }
    }
}
