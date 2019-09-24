using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.WCF
{
    [ServiceContract]
    public interface IApplicant
    {
        //ApplicantEducation
        [OperationContract]
        void AddApplicantEducation(ApplicantEducationPoco [] item);

        [OperationContract]
        void UpdateApplicantEducation(ApplicantEducationPoco[] item);
        [OperationContract]
        void RemoveApplicantEducation(ApplicantEducationPoco[] item);

        [OperationContract]
        ApplicantEducationPoco GetSingleApplicantEducation(string id);

        [OperationContract]
        List<ApplicantEducationPoco> GetAllApplicantEducation();


        //ApplicantJobApplication
        [OperationContract]
        void AddApplicantJobApplication(ApplicantJobApplicationPoco[] items);
        
        [OperationContract]
        void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] items);

        [OperationContract]
        void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] items);
        [OperationContract]
        List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication();

        [OperationContract]
        ApplicantJobApplicationPoco GetSingleApplicantJobApplication(string Id);

        //ApplicantProfile        

        [OperationContract]
        ApplicantProfilePoco GetSingleApplicantProfile(string Id);

        [OperationContract]
        void RemoveApplicantProfile(ApplicantProfilePoco[] items);

        [OperationContract]
        void UpdateApplicantProfile(ApplicantProfilePoco[] items);
        [OperationContract]
        void AddApplicantProfile(ApplicantProfilePoco[] items);

        [OperationContract]
        List<ApplicantProfilePoco> GetAllApplicantProfile();


        //ApplicantResume

        [OperationContract]
        void AddApplicantResume(ApplicantResumePoco[] items);

         [OperationContract]
        void RemoveApplicantResume(ApplicantResumePoco[] items);

        [OperationContract]
        void UpdateApplicantResume(ApplicantResumePoco[] items);
        [OperationContract]
        List<ApplicantResumePoco> GetAllApplicantResume();

        [OperationContract]
        ApplicantResumePoco GetSingleApplicantResume(string Id);

        //ApplicantSkill

        [OperationContract]
        void AddApplicantSkill(ApplicantSkillPoco[] items);

        [OperationContract]
        void RemoveApplicantSkill(ApplicantSkillPoco[] items);

        [OperationContract]
        void UpdateApplicantSkill(ApplicantSkillPoco[] items);
        [OperationContract]
        List<ApplicantSkillPoco> GetAllApplicantSkill();

        [OperationContract]
        ApplicantSkillPoco GetSingleApplicantSkill(string Id);


        //ApplicantWorkHistory
        [OperationContract]
        void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] items);

        [OperationContract]
        void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] items);

        [OperationContract]
        void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] items);
        [OperationContract]
        List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory();

        [OperationContract]
        ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(string Id);

    }
}
