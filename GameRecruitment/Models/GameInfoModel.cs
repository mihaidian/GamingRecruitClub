﻿using System.ComponentModel.DataAnnotations;

namespace GameRecruitment.Models
{
    public class GameInfoModel
    {
        [Key]
       public Guid GameID { get; set; }

        [Display(Name = "Game Name")]
        [Required]
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
        public string Developer { get; set; }

    }
}
