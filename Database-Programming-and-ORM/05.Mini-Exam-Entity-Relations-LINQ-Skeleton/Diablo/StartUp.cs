using System;
using System.Linq;
using System.Text;
using System.Globalization;
using Diablo.Data;
using Diablo.Data.Models;
using Diablo.Data.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Diablo
{
    public class StartUp
    {
        static void Main()
        {
            DiabloContext context = new DiabloContext();
            //Console.WriteLine(CharactersInformation(context, 17));
            //Console.WriteLine(GameTypesInformation(context, 5));
            Console.WriteLine(UserGamesInformation(context, 10));
        }

        public static string CharactersInformation(DiabloContext context, int luck)
        {
            var result = context.Characters
                .ToArray()
                .Where(c => c.Statistic.Luck > luck)
                .Select(c => new CharactersInformation
                {
                    Name = c.Name,
                    GamesCount = c.UsersGames.Count,
                    Games = c.UsersGames
                    .Select(ug => ug.Game.Name)
                    .ToList()
                })
                .OrderBy(c => c.GamesCount)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var character in result)
            {
                sb.AppendLine($"Name: {character.Name}");
                sb.AppendLine($"Games: {character.GamesCount}");

                foreach (var game in character.Games)
                {
                    sb.AppendLine($"Game name: {game}");
                }
            }

            return sb.ToString().Trim();
        }

        public static string GameTypesInformation(DiabloContext context, int idGameType)
        {
            var result = context.GameTypes
                // .ToArray() for judge
                .Where(gt => gt.Id == idGameType)
                .Select(gt => new GameTypesInformation
                {
                    Name = gt.Name,
                    GamesNames = gt.Games.Select(g => g.Name).ToList()
                })
                .OrderBy(gt => gt.Name)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var gameType in result)
            {
                sb.AppendLine($"Name: {gameType.Name}");

                foreach (var game in gameType.GamesNames)
                {
                    sb.AppendLine($"Game name: {game}");
                }
            }

            return sb.ToString().Trim();
        }
        public static string UserGamesInformation(DiabloContext context, int userId)
        {
            var result = context.UsersGames
            //.Include(ug => ug.Game)
            //.Include(ug => ug.Character)
            //.Include(ug => ug.UserGameItems)
            //.ThenInclude(ugi => ugi.Item)
            //.ToArray()
            .Where(ug => ug.UserId == userId)
            .Select(ug => new
            {
                GameName = ug.Game.Name,
                CharacterName = ug.Character.Name,
                ItemsNames = ug.UserGameItems.Select(ugi => new
                {
                    ItemName = ugi.Item.Name
                })

            })
            .OrderBy(i => i.ItemsNames.Count())
            .ThenBy(g => g.GameName)
            .ToList();

            //------------------------------------------------------

            //var usersGames = context.UsersGames
            //    //.ToArray()
            //    .Where(ug => ug.UserId == userId)
            //    .Select(ug => new
            //    {
            //        GameName = ug.Game.Name,
            //        CharacterName = ug.Character.Name,
            //        ItemsNames = ug.UserGameItems.Select(ugi => new
            //        {
            //            ItemName = ugi.Item.Name
            //        }).ToList()
            //    })
            //    .ToArray();

            //var result = usersGames
            //    //.ToArray()
            //    .OrderBy(i => i.ItemsNames.Count)
            //    .ThenBy(g => g.GameName)
            //    .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var userGame in result)
            {
                sb.AppendLine($"Game: {userGame.GameName}");
                sb.AppendLine($"  Character Name: {userGame.CharacterName}");
                sb.AppendLine("   Items:");

                foreach (var item in userGame.ItemsNames)
                {
                    sb.AppendLine($"   -{item.ItemName}");
                }
            }

            return sb.ToString().Trim();
        }
    }
}
