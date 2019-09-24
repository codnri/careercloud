using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Resumes")]
    public class ApplicantResumePoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        //Applicant
        public Guid Applicant { get; set; }
        //Resume
        public string Resume { get; set; }
        //Last_Updated
        [Column("Last_Updated")]
        public DateTime? LastUpdated { get; set; }

        [ForeignKey("Applicant")]
        public virtual ApplicantProfilePoco ApplicantProfiles { get; set; }


    }
}
