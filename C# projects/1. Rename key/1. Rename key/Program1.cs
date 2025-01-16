using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Rename_key
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            Dictionary<string, int> groceries = new Dictionary<string, int>();
            groceries["apple"] = 10;
            groceries["kiwi"] = 7;
            groceries["orange"] = 2;

            Dictionary<string, int> grades = new Dictionary<string, int>();
            grades.Add("Simo", 2);
            grades.Add("Bela", 6);
            grades.Add("Bobi", 5);

            Dictionary<string, int> rooms = new Dictionary<string, int>()
            {
                {"Harmony", 20 },
                {"Love", 84 },
                {"Sensibility", 170 },
            };

            RenameKey(groceries, "kiwi", "coconut");
            RenameKey(grades, "Bela", "Simo");
            RenameKey(rooms, "Empathy", "Solidarity");

            //Groceries
            foreach (KeyValuePair<string, int> product in groceries)
            {
                Console.WriteLine(product.Key + ": " + product.Value);
            }
            Console.WriteLine();

            //Grades
            foreach (string name in grades.Keys)
            {
                Console.WriteLine(name + ": " + grades[name]);
            }
            Console.WriteLine();

            //Rooms
            foreach (string room in rooms.Keys)
            {
                Console.WriteLine(room + ": " + rooms[room]);
            }

        }
        static void RenameKey(Dictionary<string, int> dict, string oldKey, string newKey)
        {
            if (!dict.ContainsKey(newKey) && dict.ContainsKey(oldKey))
            {
                int value = dict[oldKey];

                dict.Remove(oldKey);

                dict.Add(newKey, value);
            }
        }
    }
}
