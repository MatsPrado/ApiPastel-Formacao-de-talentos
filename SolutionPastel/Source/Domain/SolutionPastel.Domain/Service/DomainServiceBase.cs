using SolutionPastel.Domain.Interface.Repositorios;
using SolutionPastel.Domain.Interface.Services;
using SolutionPastelDomain.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPastel.Domain.Service
{
        public abstract class DomainServiceBase<TEntity> : IDomainServiceBase<TEntity> where TEntity : Entity
        {
        private IPedidoRepositorio repositoryBase;
        private IPedidoItemRepositorio repositoryBase1;
        private readonly IRepositorioBase<TEntity> _repositoryBase;

        public DomainServiceBase(IPedidoItemRepositorio repositoryBase1)
        {
            this.repositoryBase1 = repositoryBase1;
        }

        public DomainServiceBase(IPedidoRepositorio repositoryBase)
        {
            this.repositoryBase = repositoryBase;
        }

        protected DomainServiceBase(IRepositorioBase<TEntity> repositoryBase)
            {
                _repositoryBase = repositoryBase;
            }

            public async Task AddAsync(TEntity entity)
            {
                await _repositoryBase.AddAsync(entity);
            }

            public async Task DeleteAsync(TEntity entity)
            {
                await _repositoryBase.DeleteAsync(entity);
            }

            public async Task<TEntity> GetByIdAsync(int id)
            {
                return await _repositoryBase.GetByIdAsync(id);


            }
            public async Task UpdateAsync(TEntity entity)
            {
                await _repositoryBase.UpdateAsync(entity);
            }


        }
    }

