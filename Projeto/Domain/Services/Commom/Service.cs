using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Portal.Domain.Entities;
using Portal.Domain.Interfaces.Repository.Commom;
using Portal.Domain.Interfaces.Service.Commom;

namespace Portal.Domain.Services.Commom
{
    public class Service<TEntity> : IService<TEntity>
        where TEntity : class
    {
        #region Properties

        protected IRepository<TEntity> Repository { get; }

        #endregion

        #region Constructor

        private readonly IReadOnlyRepository<TEntity> _readOnlyRepository;

        public Service(IRepository<TEntity> repository,
            IReadOnlyRepository<TEntity> readOnlyRepository)
        {
            Repository = repository;
            _readOnlyRepository = readOnlyRepository;
        }

        #endregion

        #region Read Methods

        public virtual TEntity Get(int id, bool @readonly = false)
        {
            return @readonly
                ? _readOnlyRepository.Get(id)
                : Repository.Get(id);
        }

        public virtual IEnumerable<TEntity> All(bool @readonly = false)
        {
            return @readonly
                ? _readOnlyRepository.All()
                : Repository.All();
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, bool @readonly = false)
        {
            return Repository.Find(predicate, @readonly);
        }

        public virtual IEnumerable<TEntity> ConsultaAutoComplete(Expression<Func<TEntity, bool>> predicate)
        {
            return Repository.ConsultaAutoComplete(predicate);
        }

        #endregion

        #region CRUD Methods

        public virtual void Add(TEntity obj)
        {
            Repository.Add(obj);
        }

        public virtual void Update(TEntity obj)
        {
            Repository.Update(obj);
        }

        #endregion
    }
}