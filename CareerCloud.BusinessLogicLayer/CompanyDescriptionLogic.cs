using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyDescriptionLogic : BaseLogic<CompanyDescriptionPoco>
    {
        public CompanyDescriptionLogic(DataAccessLayer.IDataRepository<CompanyDescriptionPoco> repository) : base(repository)
        {
        }

        public override void Add(CompanyDescriptionPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(CompanyDescriptionPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(CompanyDescriptionPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (CompanyDescriptionPoco poco in pocos) {
                //CompanyDescription must be greater than 2 characters	107
                if (poco.CompanyDescription?.Length <= 2)
                {
                    exceptions.Add(new ValidationException(107,
                        $"CompanyDescription must be greater than 2 characters : Id = ${poco.Id}"));
                }
                //CompanyName CompanyName must be greater than 2 characters   106
                if (poco.CompanyName?.Length <= 2)
                {
                    exceptions.Add(new ValidationException(106,
                        $"CompanyDescription must be greater than 2 characters : Id = ${poco.Id}"));
                }




            }

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }

        }

    }
}
