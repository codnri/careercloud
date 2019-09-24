using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Descriptions")]
    public class CompanyDescriptionPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        //Company
        public Guid Company { get; set; }
        //LanguageID
        [Column("LanguageID")]
        public string LanguageId { get; set; }
        //Company_Name
        [Column("Company_Name")]
        public string CompanyName { get; set; }
        //Company_Description
        [Column("Company_Description")]
        public string CompanyDescription { get; set; }
        //Time_Stamp
        [Column("Time_Stamp")]
        [Timestamp]
        public Byte[] TimeStamp { get; set; }



        [ForeignKey("Company")]
        public virtual CompanyProfilePoco CompanyProfile { get; set; }
        [ForeignKey("LanguageId")]
        public virtual SystemLanguageCodePoco SystemLanguageCode { get; set; }






    }
}
