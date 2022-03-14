using BlazorDB.Data.INTERFACES;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace BlazorDB.Data.SERVICES
{
    public class EMPLOYESERVICE : IEMPOYEESERVICE
     { 
        private readonly SqlConnectionConfiguration _config;
        public EMPLOYESERVICE(SqlConnectionConfiguration conf)
        {
            _config = conf;
        }
   
        public async Task<bool> CreateEmployee(Employee employee)
        {
            var parameters = new DynamicParameters();
            parameters.Add("NAME", employee.name, DbType.String);
            parameters.Add("DEPARTEMENT", employee.departement, DbType.String);
            parameters.Add("DESIGNATION", employee.designation, DbType.String);
            parameters.Add("COMPANY", employee.company, DbType.String);
            parameters.Add("CITYID", employee.cityId, DbType.Int32);
            using(var conn=new SqlConnection(_config.value))
            {
                if (conn.State==ConnectionState.Closed)
                {
                    conn.Open();
                }
                try {
                    await conn.ExecuteAsync("ADD_EMPLOYEE", parameters, commandType: CommandType.StoredProcedure);
                }
                catch(Exception ex) {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
            return true;
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("ID", id, DbType.Int32);
            using (var conn = new SqlConnection(_config.value))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                try
                {
                    await conn.ExecuteAsync("DELETE_EMPLOYEE", parameters, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
            return true;
        }

        public async Task<bool> EditEmployee(int id, EmployeeModel employee)
        {
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.String);

            parameters.Add("NAME", employee.name, DbType.String);
            parameters.Add("DEPARTEMENT", employee.departement, DbType.String);
            parameters.Add("DESIGNATION", employee.designation, DbType.String);
            parameters.Add("COMPANY", employee.company, DbType.String);
            parameters.Add("CITYID", employee.cityId, DbType.Int32);
            using (var conn = new SqlConnection(_config.value))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                try
                {
                    await conn.ExecuteAsync("UPDATEEMPLOYEES", parameters, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
            return true;
        }

        public async Task<IEnumerable<EmployeeModel>> GetEmployees()
        {
            IEnumerable<EmployeeModel> employees;
            using(var conn=new SqlConnection(_config.value))
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                try {
                    employees = await conn.QueryAsync<EmployeeModel>("GET_ALLEMPLOYEES", commandType: CommandType.StoredProcedure);

                }
                catch (SqlException ex) { throw ex; }
                finally { if (conn.State == ConnectionState.Open) conn.Close(); }

            }

            return employees;
        }
    }
}
