using Forum.Data;
using Forum.DTO;
using Forum.Models;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Collections.Generic;
using Forum.Models.ViewModels;

namespace Forum
{
    public class StartUp
    {

        static void Main(string[] args)
        {
            var context = new ForumDbContext();

            // 1. Import Users
            // STEP 1. Get the path to users.json
            //string path = $"../../../Datasets/users.json";

            // STEP 2. Read the content
            //string json = File.ReadAllText(path);
            //Console.WriteLine(ImportUsers(context, json));

            // 2. Import Posts
            //string path = $"../../../Datasets/posts.json";
            //string json = File.ReadAllText(path);
            //Console.WriteLine(ImportPosts(context, json));

            // 3. Import PostAnswers
            //string path = $"../../../Datasets/postsAnswers.json";
            //string json = File.ReadAllText(path);
            //Console.WriteLine(ImportPostsAnswers(context, json));


        }
        public static string ImportUsers(ForumDbContext context, string inputJson)
        {
            // STEP 3. Deserialize the data
            UsersImportModel[] usersDTO =
                JsonSerializer.Deserialize<UsersImportModel[]>(inputJson);

            // STEP 4. Convert to DB entity class
            User[] users = usersDTO.Select(uDTO => new User()
            {
                UserName = uDTO.UserName    
            }).ToArray();

            // STEP 5. Add data to the DB
            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Imported users: {users.Length}";
        }

        public static string ImportPosts(ForumDbContext context, string inputJson)
        {
            PostsImportModel[] postsDTO =
                JsonSerializer.Deserialize<PostsImportModel[]>(inputJson);

            Post[] posts = postsDTO.Select(pDTO => new Post()
            {
                Id = pDTO.Id,
                PostContent = pDTO.PostContent,
                UserId = pDTO.UserId
            }).ToArray();

            context.Posts.AddRange(posts);
            context.SaveChanges();

            return $"Imported posts: {posts.Length}";
        }

        public static string ImportPostsAnswers(ForumDbContext context, string inputJson)
        {
            PostAnswersImportModel[] postAnswersDTO =
                JsonSerializer.Deserialize<PostAnswersImportModel[]>(inputJson);

            PostAnswer[] postAwnsers = postAnswersDTO.Select(paDTO => new PostAnswer()
            {
                Id = paDTO.Id,
                AnswerContent = paDTO.AnswerContent,
                PostId = paDTO.PostId
            }).ToArray();

            context.PostAnswers.AddRange(postAwnsers);
            context.SaveChanges();

            return $"Imported post answers {postAwnsers.Length}";
        }

        public static string GetPostsWithPostAnswers(ForumDbContext context)
        {
            //var posts = context.Posts
            //    .Select(p => new PostViewModel
            //    {
            //        PostContent = p.PostContent,
            //        User = p.User
            //    })
            return "";
        }

    }
}
