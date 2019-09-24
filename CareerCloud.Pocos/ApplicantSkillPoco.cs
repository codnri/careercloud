using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Skills")]
    public class ApplicantSkillPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        //Applicant
        public Guid Applicant { get; set; }

        //Skill
        public string Skill { get; set; }

        //Skill_Level
        [Column("Skill_Level")]
        public string SkillLevel { get; set; }
        //Start_Month
        [Column("Start_Month")]
        public Byte StartMonth { get; set; }
        //Start_Year
        [Column("Start_Year")]
        public int StartYear { get; set; }
        //End_Month
        [Column("End_Month")]
        public Byte EndMonth { get; set; }
        //End_Year
        [Column("End_Year")]
        public int EndYear { get; set; }
        //Time_Stamp
        [Column("Time_Stamp")]
        [Timestamp]
        public Byte[] TimeStamp { get; set; }

        [ForeignKey("Applicant")]
        public virtual ApplicantProfilePoco ApplicantProfiles { get; set; }




    }
}
