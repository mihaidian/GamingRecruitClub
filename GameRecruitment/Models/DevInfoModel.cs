using System.ComponentModel.DataAnnotations;

namespace GameRecruitment.Models
{
    public class DevInfoModel
    {
        [Key]
        public Guid DevID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DevExperienceInYears { get; set; }
        public string GameChoice { get; set; }
    }
}
