using Abc.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra
{
    public class EfBaseRepo<TContext, TEntity>(TContext c) : IRepo<TEntity>
        where TContext : DbContext
        where TEntity : BaseEntity
    {
        protected readonly TContext db = c;
        public async Task<int> CountAsync() => await db.Set<TEntity>().CountAsync();
        public async Task<TEntity> CreateAsync(TEntity e)
        {
            await db.AddAsync(e);
            await db.SaveChangesAsync();
            return e;
        }
        public async Task<TEntity> GetAsync(Guid id) => await db.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);

        public Task DeleteAsync(Guid id) => deleteAsync(id);
        public async Task<IEnumerable<TEntity>> GetAsync() => await getAsync();
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
        private async Task<IEnumerable<TEntity>> getAsync() => await db.Set<TEntity>().ToListAsync();
    }
}
