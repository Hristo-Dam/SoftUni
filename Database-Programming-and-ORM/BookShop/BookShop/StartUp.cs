namespace BookShop
{
    using BookShop.Models.Enums;
    using BookShop.Models.ViewModels;
    using Data;
    using Initializer;
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            //DbInitializer.ResetDatabase(db);

            // 1. Age Restriction
            //string command = Console.ReadLine();
            //Console.WriteLine(GetBooksByAgeRestriction(db, command));

            // 2. Golden Books
            //Console.WriteLine(GetGoldenBooks(db));

            // 3. Books By Price
            //Console.WriteLine(GetBooksByPrice(db));

            // 8. Book Search


            // 9. Book Search By Author
            //string input = Console.ReadLine();
            //Console.WriteLine(GetBooksByAuthor(db, input));

            // 10. Book Count
            //int lengthCheck = int.Parse(Console.ReadLine());
            //Console.WriteLine(CountBooks(db, lengthCheck));

            // 11. Count Books
            //Console.WriteLine(CountCopiesByAuthor(db));

            // 14. Increase Prices
            //IncreasePrices(db);

        }
        // 1. Age Restriction
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            AgeRestriction ageRestriction = Enum.Parse<AgeRestriction>(command, true);

            var books = context.Books
                .Where(b => b.AgeRestriction == ageRestriction)
                .Select(b => b.Title)
                .OrderBy(b => b);

            StringBuilder sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book}");
            }

            return sb.ToString();
        }

        // 2. Golden Books
        public static string GetGoldenBooks(BookShopContext context)
        {
            var books = context.Books
                .Select(b => new GetGoldenBooks
                {
                    BookId = b.BookId,
                    Title = b.Title,
                    Copies = b.Copies,
                    EditionType = (int)b.EditionType
                })
                .Where(b => b.Copies < 5000 && b.EditionType == 2)
                .OrderBy(b => b.BookId)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title}");
            }

            return sb.ToString();
        }

        // 3. Books By Price
        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books
                .Select(b => new GetBooksByPrice
                {
                    Title = b.Title,
                    Price = b.Price
                })
                .Where(b => b.Price > 40)
                .OrderByDescending(b => b.Price)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - {book.Price}");
            }

            return sb.ToString();
        }

        // 8. Book Search
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var books = context.Books
                .Select(b => new
                {
                    b.Title
                })
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .OrderBy(b => b.Title)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString();
        }

        // 9. Book Search By Author
        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var books = context.Books
                .Select(b => new
                {
                    b.BookId,
                    b.Title,
                    b.Author
                })
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(b => b.BookId)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} ({book.Author.FirstName} {book.Author.LastName})");
            }

            return sb.ToString();
        }

        // 10 Book Count
        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var books = context.Books
                .Where(b => b.Title.Length > lengthCheck);

            return books.Count();
        }

        // 11. Count Books
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authors = context.Authors
                .Select(a => new
                {
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    TotalCopies = a.Books.Sum(b => b.Copies)
                })
                .OrderByDescending(a => a.TotalCopies)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var author in authors)
            {
                sb.AppendLine($"{author.FirstName} {author.LastName} - {author.TotalCopies}");
            }

            return sb.ToString();
        }

        // 14. Increase Prices
        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.Value.Year < 2010)
                .ToList();

            foreach (var book in books)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }
    }
}
