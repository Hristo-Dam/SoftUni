using System;
using System.Linq;
using System.Text;
using System.Globalization;
using Diablo.Data;
using Diablo.Models;
using System.Collections.Generic;

namespace Diablo
{
    public class StartUp
    {
        static void Main()
        {
            // 1.Games Information
            //var context = new DiabloContext();
            //var result = GetGamesInformation(context);
            //Console.WriteLine(result);

            // 2. Items with Price Over 790
            //var context = new DiabloContext();
            //var result = GetItemsWithPriceOver790(context);
            //Console.WriteLine(result);

            // 3. Items with Type Axe
            //var context = new DiabloContext();
            //var result = GetItemWithTypeAxe(context);
            //Console.WriteLine(result);

            // 4. Adding a New Game
            //var context = new DiabloContext();
            //var result = AddNewGame(context);
            //Console.WriteLine(result);

            // 5. Users And Games Information
            var context = new DiabloContext();
            var result = GetUsersAndGamesInformation(context);
            Console.WriteLine(result);
        }

        // 1.Games Information
        public static string GetGamesInformation(DiabloContext context)
        {
            StringBuilder sb = new StringBuilder();

            var games = context.Games
                .Select(x => new
                {
                    x.Name,
                    x.Start,
                    x.Duration,
                    x.IsFinished
                })
                .OrderBy(x => x.Start)
                .ToList();

            foreach (var game in games)
            {
                string finished = "Finished";

                if (game.IsFinished == false)
                {
                    finished = "Unfinished";
                }
                sb.AppendLine($"{game.Name} {game.Start} {game.Duration} {finished}");
            }

            return sb.ToString().Trim();
        }

        // 2. Items with Price Over 790
        public static string GetItemsWithPriceOver790(DiabloContext context)
        {
            StringBuilder sb = new StringBuilder();

            var items = context.Items
                .Where(p => p.Price > 790)
                .Select(x => new
                {
                    x.Name,
                    x.Price
                })
                .OrderBy(x => x.Name)
                .ToList();

            foreach (var item in items)
            {
                sb.AppendLine($"{item.Name}-{item.Price:F2}");
            }

            return sb.ToString().Trim();
        }

        // 3. Items with Type Axe
        public static string GetItemWithTypeAxe(DiabloContext context)
        {
            StringBuilder sb = new StringBuilder();

            int typeId = context.ItemTypes
                .Where(i => i.Name == "Axe")
                .Select(i => i.Id)
                .First();

            var typeName = context.ItemTypes
                .Where(i => i.Id == 1)
                .Select (i => i.Name)
                .ToList();

            var items = context.Items
                .Where(i => i.ItemTypeId == typeId)
                .Select(i => new
                {
                    i.Name,
                    i.Price
                })
                .OrderBy(i => i.Price)
                .ThenByDescending(i => i.Name)
                .ToList();

            foreach ( var item in items)
            {
                sb.AppendLine($"{item.Name} with type {typeName[0]} - ${item.Price:F2}");
            }

            return sb.ToString().Trim();
        }

        // 4. Adding a New Game
        public static string AddNewGame(DiabloContext context)
        {
            StringBuilder sb = new StringBuilder();

            var game = new Game
            {
                Name = "Demo",
                Start = new DateTime(2016,02,13),
                Duration = 7,
                GameTypeId = 5,
                IsFinished = false
            };

            context.Games.Add(game);
            context.SaveChanges();

            var games = context.Games
                .Select(x => new
                {
                    x.Id,
                    x.Name
                })
                .OrderByDescending(x => x.Id)
                .ToList();

            for (int i = 0; i < 10; i++)
            {
                sb.AppendLine(games[i].Name);
            }

            return sb.ToString().Trim();
        }

        public static string GetUsersAndGamesInformation(DiabloContext context)
        {
            StringBuilder sb = new StringBuilder();

            DateTime isAfterDate = new DateTime(2013, 01, 01);
            DateTime isBeforeDate = new DateTime(2014, 12, 31);

            var users = context.Users
                .Select(u => new
                {
                    u.Id,
                    u.Username,
                    u.FirstName,
                    u.LastName,
                    u.RegistrationDate,
                    Games = u.UsersGames
                        .Select(ug => new
                        {
                            ug.Level,
                            ug.JoinedOn,
                            ug.Game.Id,
                            ug.Game.Name,
                            ug.Game.IsFinished,
                            ug.Game.Duration
                        })
                        .ToList()
                })
                .Where(x => x.RegistrationDate > isAfterDate && x.RegistrationDate < isBeforeDate)
                .OrderBy(x => x.Id)
                .ToList();

            for (int i = 0; i < 10; i++)
            {
                var currentUser = users[i];
                sb.AppendLine
                (
                    $"Username: {currentUser.Username} " +
                    $"Names: {currentUser.FirstName} {currentUser.LastName}" +
                    $" - Registration Date: {currentUser.RegistrationDate}"
                );

                foreach (var user in users)
                {
                    foreach (var game in user.Games)
                    {
                        sb.AppendLine
                        (
                            $"  -- Game: {game.Name}, " +
                            $"Level: {game.Level} - {game.JoinedOn}, " +
                            $"Duration: {game.Duration}"
                        );
                    }
                   
                }
            }

            return sb.ToString().Trim();
        }

        //public static string GetUsersGames(DiabloContext context)
        //{
        //}

        //public static string GetUsersWithMoreThan5Games(DiabloContext context)
        //{
        //}

        //public static string IncreasePrice(DiabloContext context)
        //{

        //}

    }
}
