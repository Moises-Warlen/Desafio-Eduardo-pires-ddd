﻿using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using ProjetoModeloDDD.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ProjetoModeloDDD.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {

        private readonly IServicesBase<TEntity> _serviceBase;



        public AppServiceBase(IServicesBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }
             
        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }


        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }


        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }


        public void Dispose()
        {
            _serviceBase.Dispose();
        }

       

       

       
    }
}
