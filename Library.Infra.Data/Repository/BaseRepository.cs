using Library.Domain.Entities;
using Library.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Library.Infra.Data.Repository
{
    public class BaseRepository<TEntity, TKeyType> where TEntity : BaseEntity<TKeyType>
    {
        protected readonly EFCoreContext _sqlContext;

        public BaseRepository(EFCoreContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        protected virtual void Insert(TEntity obj)
        {
            _sqlContext.Set<TEntity>().Add(obj);
            _sqlContext.SaveChanges();
        }

        protected virtual void Update(TEntity obj)
        {
            _sqlContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _sqlContext.SaveChanges();
        }

        protected virtual void Delete(int id)
        {
            _sqlContext.Set<TEntity>().Remove(Select(id));
            _sqlContext.SaveChanges();
        }

        protected virtual IList<TEntity> Select() =>
            _sqlContext.Set<TEntity>().ToList();

        protected virtual TEntity Select(int id) =>
            _sqlContext.Set<TEntity>().Find(id);
    }
}
