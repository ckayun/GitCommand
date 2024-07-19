// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
namespace HiBangkok01Prj {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hi Bangkok.");
            Console.WriteLine("Now it is {0}.", DateTime.Now.ToString());
            Console.WriteLine("Random number (1-1000): {0}.", new Random().Next(1, 1000));
        }
    }
}