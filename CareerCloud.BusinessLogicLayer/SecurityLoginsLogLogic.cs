﻿using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class SecurityLoginsLogLogic : BaseLogic<SecurityLoginsLogPoco>
    {
        public SecurityLoginsLogLogic(DataAccessLayer.IDataRepository<SecurityLoginsLogPoco> repository) : base(repository)
        {
        }

        public override void Add(SecurityLoginsLogPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(SecurityLoginsLogPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(SecurityLoginsLogPoco[] pocos)
        {
            //List<ValidationException> exceptions = new List<ValidationException>();
            //foreach (SecurityLoginsLogPoco poco in pocos) {
 

            //}

            //if (exceptions.Count > 0)
            //{
            //    throw new AggregateException(exceptions);
            //}

        }

    }
}
