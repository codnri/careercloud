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

    public class CompanyJobSkillRepository : IDataRepository<CompanyJobSkillPoco>
    {

       
        string _connStr = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        public void Add(params CompanyJobSkillPoco[] items)
        {
            //using (SqlConnection conn = new SqlConnection(_connStr))
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (CompanyJobSkillPoco item in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Company_Job_Skills]
                            ([Id],[Job],[Skill],[Skill_Level],[Importance])
                            VALUES 
                            (@Id,@Job,@Skill,@Skill_Level,@Importance)";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Job", item.Job);
                    cmd.Parameters.AddWithValue("@Skill", item.Skill);
                    cmd.Parameters.AddWithValue("@Skill_Level", item.SkillLevel);
                    cmd.Parameters.AddWithValue("@Importance", item.Importance);
                    
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

        public IList<CompanyJobSkillPoco> GetAll(params Expression<Func<CompanyJobSkillPoco, object>>[] navigationProperties)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = @"SELECT [Id],[Job],[Skill],[Skill_Level],[Importance],[Time_Stamp]
                FROM [JOB_PORTAL_DB].[dbo].[Company_Job_Skills]";
                conn.Open();
                int x = 0;
                SqlDataReader rdr = cmd.ExecuteReader();
                CompanyJobSkillPoco[] appPocos = new CompanyJobSkillPoco[6000];
                while (rdr.Read())
                {
                    CompanyJobSkillPoco poco = new CompanyJobSkillPoco();
                    poco.Id = rdr.GetGuid(0);
                    poco.Job = rdr.GetGuid(1);
                    poco.Skill = rdr.GetString(2);
                    poco.SkillLevel = rdr.GetString(3);
                    poco.Importance = rdr.GetInt32(4);
                    poco.TimeStamp = (byte[])rdr[5];



                    appPocos[x] = poco;
                    x++;
                }
                return appPocos.Where(a => a != null).ToList();

            }
            //throw new NotImplementedException();
        }

        public IList<CompanyJobSkillPoco> GetList(Expression<Func<CompanyJobSkillPoco, bool>> where, params Expression<Func<CompanyJobSkillPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobSkillPoco GetSingle(Expression<Func<CompanyJobSkillPoco, bool>> where, params Expression<Func<CompanyJobSkillPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyJobSkillPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
            //throw new NotImplementedException();
        }

        public void Remove(params CompanyJobSkillPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand() { Connection = conn };
                foreach (CompanyJobSkillPoco item in items)
                {


                    cmd.CommandText = @"DELETE FROM  [dbo].[Company_Job_Skills] WHERE  ID = @ID";
                    cmd.Parameters.AddWithValue("@ID", item.Id);
                    conn.Open();
                    int rowEffected = cmd.ExecuteNonQuery();
                    conn.Close();

                }
                //throw new NotImplementedException();
            }
        }
        public void Update(params CompanyJobSkillPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (CompanyJobSkillPoco item in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Company_Job_Skills]
                            SET [Id] = @Id
                                ,[Job] = @Job
                                ,[Skill] = @Skill
                                ,[Skill_Level] = @Skill_Level                                                                
                                ,[Importance] = @Importance                                                                
                            WHERE Id = @Id
                                ";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Job", item.Job);
                    cmd.Parameters.AddWithValue("@Skill", item.Skill);
                    cmd.Parameters.AddWithValue("@Skill_Level", item.SkillLevel);
                    cmd.Parameters.AddWithValue("@Importance", item.Importance);

                    conn.Open();
                    int rowEffected = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //throw new NotImplementedException();
        }
    }
}



