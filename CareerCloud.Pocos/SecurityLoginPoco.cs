using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins")]
    public class SecurityLoginPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        //Login
        public string Login { get; set; }
        //Password
        public string Password { get; set; }
        //Created_Date
        [Column("Created_Date")]
        public DateTime Created { get; set; }
        //Password_Update_Date
        [Column("Password_Update_Date")]
        public DateTime? PasswordUpdate { get; set; }

        //Agreement_Accepted_Date
        [Column("Agreement_Accepted_Date")]
        public DateTime? AgreementAccepted { get; set; }

        //Is_Locked
        [Column("Is_Locked")]
        public Boolean IsLocked { get; set; }
        //Is_Inactive
        [Column("Is_Inactive")]
        public Boolean IsInactive { get; set; }
        //Email_Address
        [Column("Email_Address")]
        public string EmailAddress { get; set; }
        //Phone_Number
        [Column("Phone_Number")]
        public string PhoneNumber { get; set; }
        //Full_Name
        [Column("Full_Name")]
        public string FullName { get; set; }
        //Force_Change_Password
        [Column("Force_Change_Password")]
        public Boolean ForceChangePassword { get; set; }
        //Prefferred_Language
        [Column("Prefferred_Language")]
        public string PrefferredLanguage { get; set; }
        
        //Time_Stamp
        [Column("Time_Stamp")]
        [Timestamp]
        public Byte[] TimeStamp { get; set; }

        public virtual ICollection<ApplicantProfilePoco> ApplicantProfiles { get; set; }
        public virtual ICollection<SecurityLoginsLogPoco> SecurityLoginsLogs { get; set; }
        public virtual ICollection<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }


        



    }
}
