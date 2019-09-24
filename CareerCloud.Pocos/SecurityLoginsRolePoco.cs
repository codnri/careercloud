using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins_Roles")]
    public class SecurityLoginsRolePoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        //Login
        public Guid Login { get; set; }
        //Role
        public Guid Role { get; set; }
        //Time_Stamp
        [Column("Time_Stamp")]
        [Timestamp]
        public Byte[] TimeStamp { get; set; }

        [ForeignKey("Login")]
        public virtual SecurityLoginPoco SecurityLogins { get; set; }
        [ForeignKey("Role")]
        public virtual SecurityRolePoco SecurityRoles { get; set; }






    }
}
