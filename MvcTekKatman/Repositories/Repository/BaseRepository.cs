using Microsoft.EntityFrameworkCore;
using MvcTekKatman.Context;
using MvcTekKatman.Entities;
using MvcTekKatman.Repositories.IRespository;

namespace MvcTekKatman.Repositories.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly MvcContext _db;
        private readonly DbSet<T> _set;
        
        public BaseRepository(MvcContext db)
        {
            _db = db;
            _set = _db.Set<T>();
        }

        public void Create(T entity)
        {
            _set.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(T entity)
        {
            _set.Remove(entity);
            _db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _set;
        }

        public T GetById(int id)
        {
            return _set.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Update(T entity)
        {
            _set.Update(entity);
            _db.SaveChanges();
        }
    }
}
