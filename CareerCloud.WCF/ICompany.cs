﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{

    [ServiceContract]
    interface ICompany
    {


        //CompanyDescription
        [OperationContract]
        void AddCompanyDescription(CompanyDescriptionPoco[] items);

        [OperationContract]
        void RemoveCompanyDescription(CompanyDescriptionPoco[] items);

        [OperationContract]
        void UpdateCompanyDescription(CompanyDescriptionPoco[] items);
        [OperationContract]
        List<CompanyDescriptionPoco> GetAllCompanyDescription();

        [OperationContract]
        CompanyDescriptionPoco GetSingleCompanyDescription(string Id);

        //CompanyJobDescription
        [OperationContract]
        void AddCompanyJobDescription(CompanyJobDescriptionPoco[] items);

        [OperationContract]
        void RemoveCompanyJobDescription(CompanyJobDescriptionPoco[] items);

        [OperationContract]
        void UpdateCompanyJobDescription(CompanyJobDescriptionPoco[] items);
        [OperationContract]
        List<CompanyJobDescriptionPoco> GetAllCompanyJobDescription();

        [OperationContract]
        CompanyJobDescriptionPoco GetSingleCompanyJobDescription(string Id);

        //CompanyJobEducation

        [OperationContract]
        void AddCompanyJobEducation(CompanyJobEducationPoco[] items);

        
        [OperationContract]
        void RemoveCompanyJobEducation(CompanyJobEducationPoco[] items);

        [OperationContract]
        void UpdateCompanyJobEducation(CompanyJobEducationPoco[] items);
        [OperationContract]
        List<CompanyJobEducationPoco> GetAllCompanyJobEducation();

        [OperationContract]
        CompanyJobEducationPoco GetSingleCompanyJobEducation(string Id);

        //CompanyJob

        [OperationContract]
        void AddCompanyJob(CompanyJobPoco[] items);

        [OperationContract]
        void RemoveCompanyJob(CompanyJobPoco[] items);

        [OperationContract]
        void UpdateCompanyJob(CompanyJobPoco[] items);
        [OperationContract]
        List<CompanyJobPoco> GetAllCompanyJob();

        [OperationContract]
        CompanyJobPoco GetSingleCompanyJob(string Id);

        //CompanyJobSkill

        [OperationContract]
        void AddCompanyJobSkill(CompanyJobSkillPoco[] items);

        
        [OperationContract]
        void RemoveCompanyJobSkill(CompanyJobSkillPoco[] items);

        [OperationContract]
        void UpdateCompanyJobSkill(CompanyJobSkillPoco[] items);
        [OperationContract]
        List<CompanyJobSkillPoco> GetAllCompanyJobSkill();

        [OperationContract]
        CompanyJobSkillPoco GetSingleCompanyJobSkill(string Id);


        //CompanyLocation

        [OperationContract]
        void AddCompanyLocation(CompanyLocationPoco[] items);
        [OperationContract]
        void RemoveCompanyLocation(CompanyLocationPoco[] items);

        [OperationContract]
        void UpdateCompanyLocation(CompanyLocationPoco[] items);
        [OperationContract]
        List<CompanyLocationPoco> GetAllCompanyLocation();

        [OperationContract]
        CompanyLocationPoco GetSingleCompanyLocation(string Id);

        //CompanyProfile
        [OperationContract]
        void AddCompanyProfile(CompanyProfilePoco[] items);        

        [OperationContract]
        void RemoveCompanyProfile(CompanyProfilePoco[] items);

        [OperationContract]
        void UpdateCompanyProfile(CompanyProfilePoco[] items);
        [OperationContract]
        List<CompanyProfilePoco> GetAllCompanyProfile();

        [OperationContract]
        CompanyProfilePoco GetSingleCompanyProfile(string Id);

    }
}
