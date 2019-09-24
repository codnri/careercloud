using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Profiles")]
    public class CompanyProfilePoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        //Registration_Date
        [Column("Registration_Date")]
        public DateTime RegistrationDate { get; set; }
        //Company_Website
        [Column("Company_Website")]
        public string CompanyWebsite { get; set; }
        //Contact_Phone
        [Column("Contact_Phone")]
        public string ContactPhone { get; set; }
        //Contact_Name
        [Column("Contact_Name")]
        public string ContactName { get; set; }
        //Company_Logo
        [Column("Company_Logo")]
        public Byte[] CompanyLogo { get; set; }
        //Time_Stamp
        [Column("Time_Stamp")]
        [Timestamp]
        public Byte[] TimeStamp { get; set; }



        public virtual ICollection<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
        public virtual ICollection<CompanyJobPoco> CompanyJobs { get; set; }
        public virtual ICollection<CompanyLocationPoco> CompanyLocations { get; set; }



    }
}
