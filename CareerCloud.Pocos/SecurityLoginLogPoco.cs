﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins_Log")]
    public class SecurityLoginsLogPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        //Login
        public Guid Login { get; set; }
        //Source_IP
        
        [Column("Source_IP")]
        public string SourceIP { get; set; }

        //Logon_Date
        [Column("Logon_Date")]
        public DateTime LogonDate { get; set; }
        //Is_Succesful
        [Column("Is_Succesful")]
        public Boolean IsSuccesful { get; set; }

        [ForeignKey("Login")]
        public virtual SecurityLoginPoco SecurityLogins { get; set; }







    }
}
