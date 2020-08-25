using System;

namespace Struct_2
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
            Rectangle rectangle = new Rectangle() { Width = 2, Height = 3 };
            Console.WriteLine(rectangle.Perimeter());
        }
    }
}