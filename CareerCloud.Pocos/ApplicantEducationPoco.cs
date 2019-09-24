using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel.Annotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Educations")]
    public class ApplicantEducationPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public string Major { get; set; }
        //Certificate_Diploma
        [Column("Certificate_Diploma")]
        public string CertificateDiploma { get; set; }
        //Start_Date
        [Column("Start_Date")]
        public DateTime? StartDate { get; set; }
        //Completion_Date
        [Column("Completion_Date")]
        public DateTime? CompletionDate { get; set; }
        //Completion_Percent
        [Column("Completion_Percent")]
        public Byte? CompletionPercent { get; set; }
        //Time_Stamp
        [Column("Time_Stamp")]
        [Timestamp]
        public Byte[] TimeStamp { get; set; }

        [ForeignKey("Applicant")]
        public virtual ApplicantProfilePoco ApplicantProfiles { get; set; }
    }
}
