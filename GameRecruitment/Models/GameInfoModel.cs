using System.ComponentModel.DataAnnotations;

namespace GameRecruitment.Models
{
    public class GameInfoModel
    {
        [Key]
       public Guid GameID { get; set; }

        [Display(Name = "Game Name")]
        [Required]
        [StringLength(150, ErrorMessage = "This field cannot get over 150 characters!")]
        public string GameName { get; set; }

        [Required]
        [Display(Name = "Added On")]
        public DateTime AddedOn { get; set; }

        [Required]
        [Display(Name = "Available for test?")]
        public bool AvailableForTest { get; set;}

        [Required]
        [Display(Name = "Dead Line")]
        public DateTime DeadLine { get; set; }

        [Required]
        [Display(Name = "Available for developing?")]
        public bool AvailableForDeveloping { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "This field cannot get over 250 characters!")]
        public string Developer { get; set; }

    }
}
