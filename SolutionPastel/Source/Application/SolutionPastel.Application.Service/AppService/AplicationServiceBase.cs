using AutoMapper;
using SolutionPastel.Application.Service.Interface.AppService;
using SolutionPastel.Domain.Interface.Services;
using SolutionPastelDomain.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPastel.Application.Service.AppService
{
    public abstract class AplicationServiceBase<TEntity, TViewModel>
        : IAplicationServiceBase<TViewModel>
        where TEntity : Entity
       where TViewModel : class
    {
        private IClienteDomainService domainServiceBase;
        private IDomainServiceBase<TEntity> _domainServiceBase;

        
        protected AplicationServiceBase(IDomainServiceBase<TEntity> domainServiceBase)
        {
            _domainServiceBase = domainServiceBase;
        }
        public async Task<TViewModel> AddAsync(TViewModel ViewModel)
        {
            var entity = Mapper.Map<TEntity>(ViewModel);
            await _domainServiceBase.AddAsync(entity);
            return ViewModel;

        }

        //TODO
        public async Task DeleteAsync(TViewModel entityViewModel)
        {
            var entity = Mapper.Map<TEntity>(entityViewModel);

            await _domainServiceBase.DeleteAsync(entity);
        }

        //public Task DeleteAsync(TViewModel entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<TViewModel> GetByidAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}
        /// <summary>
        /// PEGA POKEMON POR ID E RETORNA POKEMONVIEWMODEL
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TViewModel> GetByIdAsync(int id)
        {
            var entity = await _domainServiceBase.GetByIdAsync(id);
            return Mapper.Map<TViewModel>(entity);
        }

        //TODO
        public async Task UpdateAsync(TViewModel entityViewModel)
        {
            var entity = Mapper.Map<TEntity>(entityViewModel);
            await _domainServiceBase.UpdateAsync(entity);
        }
    }
}
