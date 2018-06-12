using DapperExtensions;
using SolutionPastel.Domain.Interface.Repositorios;
using SolutionPastelDomain.core.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPastel.Infra.Data.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositorioBase<TEntity>
        where TEntity : Entity
    {
        private const string _connectionString = "Data Source=WKSJUN000264;Initial Catalog =Pastel; Integrated Security = True";
        public async Task AddAsync(TEntity entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.InsertAsync(entity);
            }
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.DeleteAsync(entity);

            }
        }

        public async Task<TEntity> GetByIdAsync(int id)

        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.GetAsync<TEntity>(id);
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.UpdateAsync(entity);
            }

        }
    }
}