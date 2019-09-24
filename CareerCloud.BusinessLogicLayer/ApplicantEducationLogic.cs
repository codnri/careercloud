using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer    
{
    public class ApplicantEducationLogic : BaseLogic<ApplicantEducationPoco>
    {
        public ApplicantEducationLogic(IDataRepository<ApplicantEducationPoco> repository) : base(repository)
        {
        }

        public override void Add(ApplicantEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(ApplicantEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(ApplicantEducationPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (ApplicantEducationPoco poco in pocos) {

                Console.WriteLine(poco.Major);

                //Major	Cannot be empty or less than 3 characters   107
                if (string.IsNullOrEmpty(poco.Major)||poco.Major.Length <3)
                 {

                        exceptions.Add(new ValidationException(107, $"Major	Cannot be empty or less than 3 characters"));
                }
                //StartDate	Cannot be greater than today     108
                if (poco.StartDate > DateTime.Today)
                {
                    exceptions.Add(new ValidationException(108, $"StartDate	Cannot be greater than today :Id = ${poco.Id}"));
                }
                //CompletionDate	CompletionDate cannot be earlier than StartDate  109
                if (poco.CompletionDate < poco.StartDate)
                {
                    exceptions.Add(new ValidationException(109, $"CompletionDate cannot be earlier than StartDate :Id = ${poco.Id}"));
                }


            }

            //if (exceptions.Count > 0)
            if (exceptions.Any())
            {
                throw new AggregateException(exceptions);
            }
            return;
        }

    }
}
