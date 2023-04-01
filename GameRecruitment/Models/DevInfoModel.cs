using System.ComponentModel.DataAnnotations;

namespace GameRecruitment.Models
{
    public class DevInfoModel
    {
        [Key]
        public Guid DevID { get; set; }
        [Required]
        [StringLength(150, ErrorMessage="This field cannot get over 150 characters!")]
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [StringLength(150, ErrorMessage = "This field cannot get over 150 characters!")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Developer Experience (In years)")]
        [Required]
        public int DevExperienceInYears { get; set; }
        [Display(Name = "Game Choice")]
        [Required]
        [StringLength(150, ErrorMessage = "This field cannot get over 150 characters!")]
        public string GameChoice { get; set; }
        [StringLength(150, ErrorMessage = "This field cannot get over 150 characters!")]
        [Required]

        public string Email { get; set; }
    }
}
