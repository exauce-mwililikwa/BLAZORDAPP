using BlazorDB.Data.INTERFACES;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDB.Data.SERVICES
{
    public class CITYSERVICE : ICITYSERVICES
    {
        private readonly SqlConnectionConfiguration _Configuration;
        public CITYSERVICE(SqlConnectionConfiguration configuration)
        {
            _Configuration = configuration;
        }
        public async Task<bool> CreateCity(City city)
        {
          using(var conn=new SqlConnection(_Configuration.value))
            {
                const string query = @"insert into city(name,state) values(@name,@state)";
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                try {
                    await conn.ExecuteAsync(query, new { city.name, city.state }, commandType: System.Data.CommandType.Text);
                }
                catch (Exception ex) {
                    throw ex;
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open) conn.Close();
                }
            }
            return true;
        }

        public async Task<bool> DeleteCity(int id)
        {
          using (var conn=new SqlConnection(_Configuration.value))
            {
                const string query = @"delete from dbo.city where id=@id";
                //on utilise SQLConnection avec la chaine de connexion en parametre
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                try
                {
                await conn.ExecuteAsync(query, new { id }, commandType: CommandType.Text);
                }
                catch(Exception ex) { throw ex; }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
            return true;
        }

        public async Task<bool> EditCity(int id, City city)
        {
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string query = @"update city set name=@name,state=@state where id=@id";
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                  await  conn.ExecuteAsync(query, new { city.name, city.state, city.id }, commandType: CommandType.Text);
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
            
       

        public async Task<IEnumerable<City>> GetCities()
        {
            IEnumerable<City> cities;
            using (var conn=new SqlConnection(_Configuration.value))
            {
                const string query = @"select * from dbo.city";
                if (conn.State == ConnectionState.Closed) conn.Open();
                try {
                  cities= await conn.QueryAsync<City>(query);
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
            return cities;
        }

        public async Task<City> SingleCity(int id)
        {
            City city = new City();
            using (var conn =new SqlConnection(_Configuration.value))
            {
                const string query = @"select * from city where id=@id";
                if (conn.State == ConnectionState.Closed) conn.Open();
                try {
                    city = await conn.QueryFirstOrDefaultAsync<City>(query, new { id }, commandType: CommandType.Text);
                }
                catch (Exception ex) { }
                finally
                {

                }
            }
            return city;
        }
    }
}
