using Abc.Aids;
using Abc.Data;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra
{
    public sealed class SeedDb(ApplicationDbContext db, int recCnt = 20)
    {

        public async Task Seed()
        {
            //if(db.ProductTypes.Any()) return;







        }

        //private async Task seedTable<T>(DbSet<T> set, string[] exclude = null) where T : class
        //{
        //    if (set.Any()) return;
        //    var items = new List<T>();
        //    for (var i = 1; i <= recCnt; i++)
        //    {
        //        var item = (T)GetRandom.Object(typeof(T), exclude);
        //        items.Add(item);
        //    }
        //    await set.AddRangeAsync(items);
        //    await db.SaveChangesAsync();
        //}
    }
}
