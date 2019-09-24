using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Work_History")]
    public class ApplicantWorkHistoryPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }



        //Applicant
        public Guid Applicant { get; set; }

        //Company_Name
        [Column("Company_Name")]
        public string CompanyName { get; set; }
        //Country_Code
        [Column("Country_Code")]
        public string CountryCode { get; set; }
        //Location
        public string Location { get; set; }
        //Job_Title
        [Column("Job_Title")]
        public string JobTitle { get; set; }
        //Job_Description
        [Column("Job_Description")]
        public string JobDescription { get; set; }
        //Start_Month
        [Column("Start_Month")]
        public Int16 StartMonth { get; set; }
        //Start_Year        
        [Column("Start_Year")]
        public int StartYear { get; set; }
        //End_Month
        [Column("End_Month")]
        public Int16 EndMonth { get; set; }
        
        //End_Year
        [Column("End_Year")]
        public int EndYear { get; set; }
        //Time_Stamp
        [Column("Time_Stamp")]
        [Timestamp]
        public Byte[] TimeStamp { get; set; }

        [ForeignKey("Applicant")]
        public virtual ApplicantProfilePoco ApplicantProfiles { get; set; }

        [ForeignKey("CountryCode")]
        public virtual SystemCountryCodePoco SystemCountryCodes { get; set; }




    }
}
