using Entities.Abstrack;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstrack
{
    //class referans tip demek
    //IEntity IEntity olabilir yada ondan implement edilen bir class olabilir.
    //new demek ise newlenebilir olamalıdır. Ancak IEntity interface olduğu ve newlenemediği için istediğimiz gibi olur.
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter =null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
