using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Job_Skills")]
    public class CompanyJobSkillPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        //Job
        public Guid Job { get; set; }
        //Skill
        public string Skill { get; set; }
        //Skill_Level
        [Column("Skill_Level")]
        public string SkillLevel { get; set; }
        //Importance
        public int Importance { get; set; }
        //Time_Stamp
        [Column("Time_Stamp")]
        [Timestamp]
        public Byte[] TimeStamp { get; set; }

        [ForeignKey("Job")]

        public virtual CompanyJobPoco CompanyJobs { get; set; }



    }
}
