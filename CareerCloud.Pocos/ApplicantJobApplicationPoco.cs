﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Job_Applications")]

    public class ApplicantJobApplicationPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public Guid Job { get; set; }

        //Application_Date
        [Column("Application_Date")]
        public DateTime ApplicationDate { get; set; }
        //Time_Stamp
        [Column("Time_Stamp")]
        [Timestamp]
        public Byte[] TimeStamp { get; set; }

        [ForeignKey("Applicant")]
        public virtual ApplicantProfilePoco ApplicantProfiles { get; set; }
        [ForeignKey("Job")]
        public virtual CompanyJobPoco CompanyJobs { get; set; }

    }
}
