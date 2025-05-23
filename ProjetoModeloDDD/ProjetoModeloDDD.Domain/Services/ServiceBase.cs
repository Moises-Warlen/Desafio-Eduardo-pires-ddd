﻿using System;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Interfaces;

namespace ProjetoModeloDDD.Domain.Services
{
   public class ServiceBase<TEntity>: IDisposable, IServicesBase<TEntity> where TEntity :class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;

        }




        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }




        public TEntity GetByid(int id)
        {
            return _repository.GetById(id);
        }


        public IEnumerable<TEntity>GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEntity obj)
        {
          _repository.Update(obj);
        }

       
       
        public void Remove(TEntity obj)
        {
           _repository.Remove(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
