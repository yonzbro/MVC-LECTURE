using System.ComponentModel.DataAnnotations;

namespace MVCDERSLERİ_BTK_AKADEMİ_SAYFASI_.Models
{
    public class Candidates
    {
        [Required(ErrorMessage = "E-Mail is required")]
        public String? Email { get; set; } = String.Empty;
        [Required(ErrorMessage = "FirstName is required")]
        public String? FirstName { get; set; } = String.Empty;
        [Required(ErrorMessage = "LatName is required")]
        public String? LastName { get; set; } = String.Empty;
        [Required(ErrorMessage = "FullName is required")]
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        [Required(ErrorMessage = "Age is required")]
        public int? Age { get; set; }
        [Required(ErrorMessage = "Selected Course is required")]
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt {  get; set; }
        
        public Candidates()
        {
            ApplyAt = DateTime.Now;
        }
    }
    
}
