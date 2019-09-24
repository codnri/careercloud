using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    [ServiceContract]
    interface ISecurity
    {

        //SecurityLogin
        [OperationContract]
        void AddSecurityLogin(SecurityLoginPoco[] items);
        [OperationContract]
        void RemoveSecurityLogin(SecurityLoginPoco[] items);

        [OperationContract]
        void UpdateSecurityLogin(SecurityLoginPoco[] items);

        [OperationContract]
        List<SecurityLoginPoco> GetAllSecurityLogin();

        [OperationContract]
        SecurityLoginPoco GetSingleSecurityLogin(string Id);

        //SecurityLoginsLog
        [OperationContract]
        void AddSecurityLoginsLog(SecurityLoginsLogPoco[] items);

        [OperationContract]
        void RemoveSecurityLoginsLog(SecurityLoginsLogPoco[] items);

        [OperationContract]
        void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] items);
        [OperationContract]
        List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog();

        [OperationContract]
        SecurityLoginsLogPoco GetSingleSecurityLoginsLog(string Id);

        //SecurityLoginsRole

        [OperationContract]
        void AddSecurityLoginsRole(SecurityLoginsRolePoco[] items);
        [OperationContract]
        void RemoveSecurityLoginsRole(SecurityLoginsRolePoco[] items);

        [OperationContract]
        void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] items);
        [OperationContract]
        List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole();

        [OperationContract]
        SecurityLoginsRolePoco GetSingleSecurityLoginsRole(string Id);

        //SecurityRole

        [OperationContract]
        void AddSecurityRole(SecurityRolePoco[] items);
        [OperationContract]
        void RemoveSecurityRole(SecurityRolePoco[] items);

        [OperationContract]
        void UpdateSecurityRole(SecurityRolePoco[] items);
        [OperationContract]
        List<SecurityRolePoco> GetAllSecurityRole();

        [OperationContract]
        SecurityRolePoco GetSingleSecurityRole(string Id);
    }
}
