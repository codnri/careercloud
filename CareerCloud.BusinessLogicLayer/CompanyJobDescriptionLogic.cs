using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyJobDescriptionLogic : BaseLogic<CompanyJobDescriptionPoco>
    {
        public CompanyJobDescriptionLogic(DataAccessLayer.IDataRepository<CompanyJobDescriptionPoco> repository) : base(repository)
        {
        }

        public override void Add(CompanyJobDescriptionPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(CompanyJobDescriptionPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(CompanyJobDescriptionPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (CompanyJobDescriptionPoco poco in pocos) {
                //JobName	JobName cannot be empty	300
                if (poco.JobName=="")
                {
                    exceptions.Add(new ValidationException(300,
                        $"JobName cannot be empty: Id = ${poco.Id}"));
                }
                //JobDescriptions JobDescriptions cannot be empty 301
                if (poco.JobDescriptions == "")
                {
                    exceptions.Add(new ValidationException(301,
                        $"JobDescriptions cannot be empty: Id = ${poco.Id}"));
                }
                //JobName	JobName cannot be null	300
                if (poco.JobName==null)
                {
                    exceptions.Add(new ValidationException(300,
                        $"JobName cannot be null: Id = ${poco.Id}"));
                }
                //JobDescriptions JobDescriptions cannot be null  301
                if (poco.JobDescriptions == null)
                {
                    exceptions.Add(new ValidationException(301,
                        $"JobDescriptions cannot be null: Id = ${poco.Id}"));
                }






            }

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }

        }

    }
}
