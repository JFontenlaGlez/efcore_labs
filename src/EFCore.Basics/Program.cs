//using EfCore.Shared;

//var options = Db.Sqlite();
//using var db = new AppDbContext(options);
//await DataSeeder.EnsureSeedAsync(db);
//Console.WriteLine("Seed listo.");


using System.Threading.Tasks;
using EfCore.Shared;

namespace EfCore.Basics
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var options = Db.Sqlite("eflab.db");
            using var db = new AppDbContext(options);
            await DataSeeder.EnsureSeedAsync(db);
            System.Console.WriteLine("Seed OK");
        }
    }
}
