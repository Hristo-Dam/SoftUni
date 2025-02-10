using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.DTOs;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ProductShopContext context = new ProductShopContext();
            #region Import Logic

            //string path = $"../../../Datasets";
            //string rawJson = "";

            //// 1. Import Users
            //string usersJsonFile = "users.json";
            //rawJson = ReadJsonFile(path, usersJsonFile);
            //string ImportUsersResult = ImportUsers(context, rawJson);
            //Console.WriteLine(ImportUsersResult);

            //// 3. Import Categories
            //string categoriesJsonFile = "categories.json";
            //rawJson = ReadJsonFile(path, categoriesJsonFile);
            //string ImportCategoriesResult = ImportCategories(context, rawJson);
            //Console.WriteLine(ImportCategoriesResult);

            //// 2. Import Products
            //string productsJsonFile = "products.json";
            //rawJson = ReadJsonFile(path, productsJsonFile);
            //string ImportProductsResult = ImportProducts(context, rawJson);
            //Console.WriteLine(ImportProductsResult);

            //// 4. Import CategoriesProducts
            //string categoriesProductsJsonFile = "categories-products.json";
            //rawJson = ReadJsonFile(path, categoriesProductsJsonFile);
            //string ImportCategoryProductsResult = ImportCategoryProducts(context, rawJson);
            //Console.WriteLine(ImportCategoryProductsResult);
            #endregion
            #region Export Logic

            GetProductsInRange(context);

            #endregion
        }
        #region Export Methods
        public static string GetProductsInRange(ProductShopContext context)
        {
            // STEP 1: Write query to export data from database
            var queryResult = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .OrderBy(p => p.Price)
                .Select(p => new ProductExportDTO
                {
                    Name = p.Name,
                    Price = p.Price,
                    SellerFullName = $"{p.Seller.FirstName} {p.Seller.LastName}"
                })
                .ToList();

            // STEP 2: Convert to JSON
            string jsonResult = JsonConvert.SerializeObject(queryResult, Formatting.Indented);
            string fullPath = "../../../Datasets/ExportData/products-in-range.json";
            File.WriteAllText(fullPath, jsonResult);

            return "Exported products in range!";
        }
        #endregion
        #region Import Methods
        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            List<UsersDTO> usersDTOs = JsonConvert
                .DeserializeObject<List<UsersDTO>>(inputJson);

            List<User> users = usersDTOs
                .Select(uDto => new User
                {
                    FirstName = uDto.FirstName,
                    LastName = uDto.LastName,
                    Age = uDto.Age
                })
                .ToList();

            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Count} users!";
        }
        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            List<ProductsDTO> productsDTOs = JsonConvert
                .DeserializeObject<List<ProductsDTO>>(inputJson);

            List<Product> products = productsDTOs
                .Select(pDto => new Product
                {
                    Name = pDto.Name,
                    Price = pDto.Price,
                    SellerId = pDto.SellerId,
                    BuyerId = pDto.BuyerId
                })
                .ToList();

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Count} products!";
        }
        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            //STEP 1: Deserialize the raw JSON file into DTOs
            List<CategoriesDTO> categoriesDTOs = JsonConvert
                .DeserializeObject<List<CategoriesDTO>>(inputJson)
                .Where(cDto => cDto.Name != null)
                .ToList();

            //STEP 2: Mapping to Entity class (Categories.cs) - Manial mapping
            List<Category> categories = categoriesDTOs
                .Select(cDto => new Category
                {
                    Name = cDto.Name
                })
                .ToList();

            //STEP 3: Import categories to Database
            context.Categories.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {categories.Count} categories!";
        }
        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            List<CategoriesProductsDTO> categoriesProductsDTOs = JsonConvert
                .DeserializeObject<List<CategoriesProductsDTO>>(inputJson);

            List<CategoryProduct> categoriesProducts = categoriesProductsDTOs
                .Select(cpDto => new CategoryProduct
                {
                    CategoryId = cpDto.CategoryId,
                    ProductId = cpDto.ProductId
                })
                .ToList();

            context.CategoryProducts.AddRange(categoriesProducts);
            context.SaveChanges();

            return $"Successfully imported {categoriesProducts.Count} category products!";
        }
        private static string ReadJsonFile(string path, string fileName)
        {
            string fullPath = $"{path}/{fileName}";

            string rawJson = File.ReadAllText(fullPath);

            return rawJson;
        }
        #endregion
    }
}