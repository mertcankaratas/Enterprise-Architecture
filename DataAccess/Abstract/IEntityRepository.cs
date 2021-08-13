using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic Constraint
    //class : referans tip
    //IEntity : IEntity olabilir  veya IEntity olanbir nesne olabilir
    //new(): new'lene bilir olmalı 
   public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);
       
    }
}
