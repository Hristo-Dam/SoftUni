
using ShopDatabase.Data;

namespace ShopDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShopDbContext db = new ShopDbContext();

            db.SaveChanges();
        }
    }
}
