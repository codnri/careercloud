using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Profiles")]
    public class ApplicantProfilePoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Login { get; set; }
        //Current_Salary
        [Column("Current_Salary")]
        public Decimal? CurrentSalary { get; set; }
        //Current_Rate
        [Column("Current_Rate")]
        public Decimal? CurrentRate { get; set; }
        //Currency
        public string Currency { get; set; }
        //Country_Code
        [Column("Country_Code")] 
        public string Country { get; set; }
        //State_Province_Code
        [Column("State_Province_Code")]
        public string Province { get; set; }
        //Street_Address
        [Column("Street_Address")]
        public string Street { get; set; }
        //City_Town
        [Column("City_Town")]
        public string City { get; set; }
        //Zip_Postal_Code
        [Column("Zip_Postal_Code")]
        public string PostalCode { get; set; }
        //Time_Stamp
        [Column("Time_Stamp")]
        [Timestamp]
        public Byte[] TimeStamp { get; set; }

        public virtual ICollection<ApplicantEducationPoco> ApplicantEducations { get; set; }
        public virtual ICollection<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }

        [ForeignKey("Login")]
        public virtual SecurityLoginPoco SecurityLogins { get; set; }

        [ForeignKey("Country")]
        public virtual SystemCountryCodePoco SystemCountryCodes { get; set; }

        public virtual ICollection<ApplicantResumePoco> ApplicantResumes { get; set; }
        public virtual ICollection<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public virtual ICollection<ApplicantWorkHistoryPoco> ApplicantWorkHistory { get; set; }
  
        
    }
}
