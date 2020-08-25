using System;

namespace Struct_1
{
    /// <summary>
    /// Static class
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Person person = new Person() { Name = "Name", Surname = "Surname", Age = 18 };

            do
            {
                Console.Clear();
                Console.Write("Enter age: ");
                string input = Console.ReadLine();
                try
                {
                    int n = int.Parse(input);
                    Console.WriteLine(person.CheckAge(n));
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect input!");
                }
                Console.WriteLine("\nPress Esc to exit or any other key to continue");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}