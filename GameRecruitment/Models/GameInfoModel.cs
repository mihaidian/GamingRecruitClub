using System.ComponentModel.DataAnnotations;

namespace GameRecruitment.Models
{
    public class GameInfoModel
    {
        [Key]
       public Guid GameID { get; set; }
        public string GameName { get; set; }
        public DateTime AddedOn { get; set; }
        public bool AvailableForTest { get; set; }
        public DateTime DeadLine { get; set; }
        public bool AvailableForDeveloping { get; set; }
        public string Developer { get; set; }

    }
}
