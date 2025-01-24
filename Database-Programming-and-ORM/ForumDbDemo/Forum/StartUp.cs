using Forum.Data;
using Forum.DTO;
using Forum.Models;
using System;
using System.IO;
using System.Linq;


//using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Forum
{
    public class StartUp
    {

        static void Main(string[] args)
        {
            var context = new ForumDbContext();

            // 1. Get the path to users.json
            string path = "../../../Datasets/users.json";

            // 2. Read the content
            string json = File.ReadAllText(path);

            Console.WriteLine(ImportUsers(context, json));
        }
        public static string ImportUsers(ForumDbContext context, string inputJson)
        {
            // 3. Deserialize the data
            UsersImportModel[] usersDTO =
                JsonSerializer.Deserialize<UsersImportModel[]>(inputJson);
            
            // 4. Convert to DB entity class
            User[] users = usersDTO.Select(uDTO => new User()
            {
                UserName = uDTO.UserName
            }).ToArray();

            // 5. Add data to the DB
            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Imported users: {users.Length}";
        }

        public static string ImportPosts(ForumDbContext context, string inputJson)
        {
            //TODO ...
            return $"";
        }

        public static string ImportPostsAnswers(ForumDbContext context, string inputJson)
        {
            //TODO ...
            return $"";
        }

        public static string GetPostsWithPostAnswers(ForumDbContext context)
        {
            //TODO ...
            return "";
        }

    }
}
