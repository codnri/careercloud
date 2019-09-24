using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Locations")]
    public class CompanyLocationPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        //Company
        public Guid Company { get; set; }
        //Country_Code
        [Column("Country_Code")]
        public string CountryCode { get; set; }
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


        [ForeignKey("Company")]
        public virtual CompanyProfilePoco CompanyProfile { get; set; }




    }
}
