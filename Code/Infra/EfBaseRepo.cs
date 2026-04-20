using Abc.Data.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Reflection;

namespace Abc.Infra
{
    public class EfBaseRepo<TContext, TEntity>(TContext c) : IRepo<TEntity>
        where TContext : DbContext
        where TEntity : BaseEntity
    {
        protected readonly TContext db = c;
        public async Task<int> CountAsync(Query q) => await db.Set<TEntity>().CountAsync();
        public async Task<TEntity> CreateAsync(TEntity e)
        {
            await db.AddAsync(e);
            await db.SaveChangesAsync();
            return e;
        }
        public async Task<TEntity> GetAsync(Guid id) => await db.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);

        public Task DeleteAsync(Guid id) => deleteAsync(id);
        public async Task<IEnumerable<TEntity>> GetAsync(Query q) => await getAsync(q);
        public async Task<TEntity> UpdateAsync(TEntity e)
        {
            db.Update(e);
            await db.SaveChangesAsync();
            return e;
        }
        private async Task deleteAsync(Guid id)
        {
            var entity = await GetAsync(id);
            if (entity is null) return;
            db.Remove(entity);
            await db.SaveChangesAsync();
        }
        private async Task<IEnumerable<TEntity>> getAsync(Query q)
        {
            var s = (q.Page - 1) * q.PageSize;
            var t = q.PageSize;
            var dir = q.SortDir;
            var n = q.SortBy;
            var key = (n is null) ? null : sortBy(n);
            var r = key == null
                ? db.Set<TEntity>().Skip(s).Take(t).AsNoTracking() // if property is null it wont sort
                : (dir == "desc")
                    ? db.Set<TEntity>().OrderByDescending(key).Skip(s).Take(t).AsNoTracking() // needs to be sorted first then skip and take
                    : db.Set<TEntity>().OrderBy(key).Skip(s).Take(t).AsNoTracking();
            return await r.ToListAsync();
        }
        private static readonly BindingFlags flags = BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance;
        private static Expression<Func<TEntity, object>> sortBy(string propName)
        {
            var p = typeof(TEntity).GetProperty(propName, flags);
            if (p is null) return null;
            var parameter = Expression.Parameter(typeof(TEntity), "x"); // we define that we have a parameter 
            var member = Expression.Property(parameter, p);
            var converted = Expression.Convert(member, typeof(object));
            return Expression.Lambda<Func<TEntity, object>>(converted, parameter); // x => x.ValidTo
        }
    }
}
