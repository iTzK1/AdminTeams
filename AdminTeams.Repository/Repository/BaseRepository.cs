using AdminTeams.Domain.Base;
using AdminTeams.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AdminTeams.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity<int>
    {
        protected readonly AdminTeamsContext _context;

        public BaseRepository(AdminTeamsContext context)
        {
            _context = context;
        }

        public void AttachObject(object obj)
        {
            _context.Attach(obj);
        }

        public void ClearChangeTracker()
        {
            _context.ChangeTracker.Clear();
        }

        public void Insert(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(object id)
        {
            var entity = Select(id);
            if (entity != null)
            {
                _context.Set<TEntity>().Remove(entity);
                _context.SaveChanges();
            }
        }

        public IList<TEntity> Select(IList<string>? includes = null)
        {
            var query = _context.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return query.ToList();
        }

        public TEntity Select(object id, IList<string>? includes = null)
        {
            var query = _context.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return query.FirstOrDefault(e => e.Id.Equals(id))!;
        }
    }
}