﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
//ADODataAccessLayer
{

    public class SecurityLoginsRoleRepository : IDataRepository<SecurityLoginsRolePoco>
    {

        
        string _connStr = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        public void Add(params SecurityLoginsRolePoco[] items)
        {
            //using (SqlConnection conn = new SqlConnection(_connStr))
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (SecurityLoginsRolePoco item in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Security_Logins_Roles]
                            ([Id],[Login],[Role])
                            VALUES 
                            (@Id,@Login,@Role)";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Login", item.Login);
                    cmd.Parameters.AddWithValue("@Role", item.Role);
                    
                    conn.Open();
                    int rowEffected = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<SecurityLoginsRolePoco> GetAll(params Expression<Func<SecurityLoginsRolePoco, object>>[] navigationProperties)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = @"SELECT [Id],[Login],[Role],[Time_Stamp]
                FROM [JOB_PORTAL_DB].[dbo].[Security_Logins_Roles]";
                conn.Open();
                int x = 0;
                SqlDataReader rdr = cmd.ExecuteReader();
                SecurityLoginsRolePoco[] appPocos = new SecurityLoginsRolePoco[2000];
                while (rdr.Read())
                {
                    SecurityLoginsRolePoco poco = new SecurityLoginsRolePoco();
                    poco.Id = rdr.GetGuid(0);
                    poco.Login = rdr.GetGuid(1);
                    poco.Role = rdr.GetGuid(2);                    
                    poco.TimeStamp = (byte[])rdr[3];



                    appPocos[x] = poco;
                    x++;
                }
                return appPocos.Where(a => a != null).ToList();

            }
            //throw new NotImplementedException();
        }

        public IList<SecurityLoginsRolePoco> GetList(Expression<Func<SecurityLoginsRolePoco, bool>> where, params Expression<Func<SecurityLoginsRolePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginsRolePoco GetSingle(Expression<Func<SecurityLoginsRolePoco, bool>> where, params Expression<Func<SecurityLoginsRolePoco, object>>[] navigationProperties)
        {
            IQueryable<SecurityLoginsRolePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
            //throw new NotImplementedException();
        }

        public void Remove(params SecurityLoginsRolePoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand() { Connection = conn };
                foreach (SecurityLoginsRolePoco item in items)
                {


                    cmd.CommandText = @"DELETE FROM  [dbo].[Security_Logins_Roles] WHERE  ID = @ID";
                    cmd.Parameters.AddWithValue("@ID", item.Id);
                    conn.Open();
                    int rowEffected = cmd.ExecuteNonQuery();
                    conn.Close();

                }
                //throw new NotImplementedException();
            }
        }
        public void Update(params SecurityLoginsRolePoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (SecurityLoginsRolePoco item in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Security_Logins_Roles]
                            SET [Id] = @Id
                                ,[Company] = @Company
                                ,[Login] = @Login
                                ,[Role] = @Role                                                                
                            WHERE Id = @Id
                                ";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Login", item.Login);
                    cmd.Parameters.AddWithValue("@Role", item.Role);

                    conn.Open();
                    int rowEffected = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //throw new NotImplementedException();
        }
    }
}



