using System.ComponentModel.DataAnnotations;

namespace GameRecruitment.Models
{
    public class TesterInfoModel
    {
        [Key]
        public Guid TesterID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool TestedBefore { get; set; }
        public string GameChoice { get; set; }
    }
}
