﻿using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class SecurityLoginsRoleLogic : BaseLogic<SecurityLoginsRolePoco>
    {
        public SecurityLoginsRoleLogic(DataAccessLayer.IDataRepository<SecurityLoginsRolePoco> repository) : base(repository)
        {
        }

        public override void Add(SecurityLoginsRolePoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(SecurityLoginsRolePoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(SecurityLoginsRolePoco[] pocos)
        {
            //List<ValidationException> exceptions = new List<ValidationException>();
            //foreach (SecurityLoginsRolePoco poco in pocos) {
 

            //}

            //if (exceptions.Count > 0)
            //{
            //    throw new AggregateException(exceptions);
            //}

        }

    }
}
