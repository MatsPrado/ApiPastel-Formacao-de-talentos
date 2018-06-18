using AutoMapper;
using SolutionPastel.Application.Service.Interface.AppService;
using SolutionPastel.Domain.Interface.Services;
using SolutionPastelDomain.core.Models;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

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
        public async Task<List<TEntity>> GetListAsync()
        {
            var entity = await _domainServiceBase.GetListAsync();
            return Mapper.Map<List<TEntity>>(entity);
        }

        //TODO
        public virtual async Task DeleteAsync(TViewModel entityViewModel, int id)
        {
            var entity = Mapper.Map<TEntity>(entityViewModel);
            entity.Id = id;
            await _domainServiceBase.DeleteAsync(entity);
        }

        //public virtual async Task<IEnumerable<TEntity>> GetAllAsync(TEntity entity)
        //{
        //    var entity = await _domainServiceBase.GetAllAsync(entity);
        //    return Mapper.Map<TViewModel>(entity);
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TViewModel> GetByIdAsync(int id)
        {
            var entity = await _domainServiceBase.GetByIdAsync(id);
            return Mapper.Map<TViewModel>(entity);
        }

       

        public virtual async Task UpdateAsync( TViewModel entityViewModel , int id)
        {
            var entity = Mapper.Map<TEntity>(entityViewModel);

            entity.Id = id;

            await _domainServiceBase.UpdateAsync(entity);


        }
    }
}
