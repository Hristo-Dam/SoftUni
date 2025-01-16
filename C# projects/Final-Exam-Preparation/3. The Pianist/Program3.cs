using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Piece> results = new Dictionary<string, Piece>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");

                Piece piece = new Piece();
                piece.Name = input[0];
                piece.Composer = input[1];
                piece.Note = input[2];

                results.Add(input[0], piece);
            }

            string[] command = Console.ReadLine().Split("|");

            while (command[0] != "Stop")
            {
                if (command[0] == "Add")
                {
                    string name = command[1];
                    string composer = command[2];
                    string note = command[3];

                    if (results.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} is already in the collection!");
                    }
                    else
                    {
                        Piece piece = new Piece();
                        piece.Name = name;
                        piece.Composer = composer;
                        piece.Note = note;

                        results.Add(command[1], piece);
                        Console.WriteLine($"{name} by {composer} in {note} added to the collection!");
                    }
                }
                else if (command[0] == "Remove")
                {
                    string name = command[1];
                    if (results.ContainsKey(name))
                    {
                        results.Remove(name);
                        Console.WriteLine($"Successfully removed {name}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
                    }
                }
                else if (command[0] == "ChangeKey")
                {
                    string name = command[1];
                    string newNote = command[2];

                    if (results.ContainsKey(name))
                    {
                        // results is of type Dictionary<string, Piece>
                        // results[name] is of type Piece
                        // results[name].Note is the .Note property of the current piece
                        results[name].Note = newNote;
                        Console.WriteLine($"Changed the key of {name} to {newNote}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
                    }
                }

                command = Console.ReadLine().Split("|");
            }

            List<Piece> sortedResults = results.Values.OrderBy(piece => piece.Name)
                .ThenBy(piece => piece.Composer)
                .ToList<Piece>();

            foreach (Piece piece in sortedResults)
            {
                Console.WriteLine($"{piece.Name} -> Composer: {piece.Composer}, Key: {piece.Note}");
            }
        }
    }

    class Piece
    {
        public string Name;
        public string Composer;
        public string Note;
    }
}
