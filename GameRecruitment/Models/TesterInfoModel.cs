using System.ComponentModel.DataAnnotations;

namespace GameRecruitment.Models
{
    public class TesterInfoModel
    {
        [Key]
        public Guid TesterID { get; set; }
        [Required]
        [Display(Name="First Name")]
        [StringLength(150, ErrorMessage = "This field cannot get over 150 characters!")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(150, ErrorMessage = "This field cannot get over 150 characters!")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Tested Before")]
        public bool TestedBefore { get; set; }
        [Required]
        [StringLength(150, ErrorMessage = "This field cannot get over 150 characters!")]
        [Display(Name = "Game Choice")]
        public string GameChoice { get; set; }
        [StringLength(150, ErrorMessage = "This field cannot get over 150 characters!")]
        [Required]
        public string Email { get; set; }
    }
}
