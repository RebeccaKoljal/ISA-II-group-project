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

            //var typeValmistoit = new ProductType { Name = "Valmistoit" };
            //var typeKoostisosa = new ProductType { Name = "Koostisosa" };

            //db.ProductTypes.Add(typeKoostisosa);
            //db.ProductTypes.Add(typeValmistoit);
            await db.Database.MigrateAsync();

            await seedTable(db.Currencies, [
                nameof(Currency.Timestamp)]);

            await seedTable(db.Countries, [
                nameof(Country.Currencies),
                    nameof(Country.Timestamp)]);

            await seedTable(db.Monies, [
                nameof(Money.CurrencyId),
                    nameof(Money.Currency),
                    nameof(Money.Timestamp)]);

            await seedTable(db.CountryCurrencies, [
                nameof(CountryCurrency.CurrencyId),
                    nameof(CountryCurrency.CountryId),
                    nameof(CountryCurrency.Currency),
                    nameof(CountryCurrency.Timestamp)]);

            await seedTable(db.Movies, [
                nameof(Movie.Country),
                    nameof(Movie.Money),
                    nameof(Movie.Timestamp)]);
        }
        private async Task seedTable<T>(DbSet<T> set, string[] exclude = null) where T : class
        {
            if (set.Any()) return;
            var items = new List<T>();
            for (var i = 1; i <= recCnt; i++)
            {
                var item = (T)GetRandom.Object(typeof(T), exclude);
                items.Add(item);
            }
            await set.AddRangeAsync(items);
            await db.SaveChangesAsync();
        }
    }
}
