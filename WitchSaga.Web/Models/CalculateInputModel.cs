using System.ComponentModel.DataAnnotations;

namespace WitchSaga.Web.Models
{
    public class CalculateInputModel
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Age must be positive")]
        [Display(Name = "Person A - Age of Death")]
        public int AgeOfDeathA { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Year must be positive")]
        [Display(Name = "Person A - Year of Death")]
        public int YearOfDeathA { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Age must be positive")]
        [Display(Name = "Person B - Age of Death")]
        public int AgeOfDeathB { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Year must be positive")]
        [Display(Name = "Person B - Year of Death")]
        public int YearOfDeathB { get; set; }
    }
}