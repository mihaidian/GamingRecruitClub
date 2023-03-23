using System.ComponentModel.DataAnnotations;

namespace GameRecruitment.Models
{
    public class TesterInfoModel
    {
        [Key]
        public Guid TesterID { get; set; }
        [Required]
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Tested Before")]
        public bool TestedBefore { get; set; }
        [Display(Name = "Game Choice")]
        public string GameChoice { get; set; }
    }
}
