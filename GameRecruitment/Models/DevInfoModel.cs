using System.ComponentModel.DataAnnotations;

namespace GameRecruitment.Models
{
    public class DevInfoModel
    {
        [Key]
        public Guid DevID { get; set; }
        [Required]
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Developer Experience (In years)")]
        public int DevExperienceInYears { get; set; }
        [Display(Name = "Game Choice")]
        public string GameChoice { get; set; }
    }
}
