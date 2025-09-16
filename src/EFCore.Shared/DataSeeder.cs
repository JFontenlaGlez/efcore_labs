using EFCore.Shared;

namespace EfCore.Shared;

public static class DataSeeder
{
    public static async Task EnsureSeedAsync(AppDbContext db, int customers = 100000, int products = 25000, int orders = 100000)
    {
        await db.Database.EnsureCreatedAsync();

        if (!db.Products.Any())
        {
            var rnd = new Random(42);
            db.Products.AddRange(Enumerable.Range(1, products)
                .Select(i => new Product { Name = $"Product {i}", Price = Math.Round((decimal)(rnd.NextDouble() * 100 + 1), 2) }));
        }
        if (!db.Customers.Any())
        {
            db.Customers.AddRange(Enumerable.Range(1, customers)
                .Select(i => new Customer { Name = $"Customer {i}", Email = $"c{i}@test.local" }));
        }
        await db.SaveChangesAsync();

        if (!db.Orders.Any())
        {
            var rnd = new Random(99);
            for (int i = 0; i < orders; i++)
            {
                var custId = rnd.Next(1, customers + 1);
                var itemsCount = rnd.Next(1, 6);
                var order = new Order { CustomerId = custId };
                for (int j = 0; j < itemsCount; j++)
                {
                    var prodId = rnd.Next(1, products + 1);
                    var qty = rnd.Next(1, 5);
                    var price = db.Products.Find(prodId)!.Price;
                    order.Items.Add(new OrderItem { ProductId = prodId, Quantity = qty, UnitPrice = price });
                }
                db.Orders.Add(order);
            }
            await db.SaveChangesAsync();
        }
    }
}
