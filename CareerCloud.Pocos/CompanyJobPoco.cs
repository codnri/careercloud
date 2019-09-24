using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Jobs")]
    public class CompanyJobPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        //Company
        public Guid Company { get; set; }
        //Profile_Created
        [Column("Profile_Created")]
        public DateTime ProfileCreated { get; set; }
        //Is_Inactive
        [Column("Is_Inactive")]
        public Boolean IsInactive { get; set; }
        //Is_Company_Hidden
        [Column("Is_Company_Hidden")]
        public Boolean IsCompanyHidden { get; set; }
        //Time_Stamp
        [Column("Time_Stamp")]
        [Timestamp]
        public Byte[] TimeStamp { get; set; }


        public virtual ICollection<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        public virtual ICollection<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }
        public virtual ICollection<CompanyJobEducationPoco> CompanyJobEducations { get; set; }
        public virtual ICollection<CompanyJobSkillPoco> CompanyJobSkills { get; set; }

        [ForeignKey("Company")]
        public virtual CompanyProfilePoco CompanyProfile { get; set; }






    }
}
