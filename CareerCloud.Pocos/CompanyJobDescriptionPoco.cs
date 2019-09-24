using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Jobs_Descriptions")]
    public class CompanyJobDescriptionPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        //Job
        public Guid Job { get; set; }
        //Job_Name
        [Column("Job_Name")]
        public string JobName { get; set; }
        //Job_Descriptions
        [Column("Job_Descriptions")]
        public string JobDescriptions { get; set; }
        //Time_Stamp
        [Column("Time_Stamp")]
        [Timestamp]
        public Byte[] TimeStamp { get; set; }

        [ForeignKey("Job")]
        public virtual CompanyJobPoco CompanyJobs { get; set; }






    }
}
