using PasswordGenerator;
using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var passwordGenerator = new PasswordGenerator();
            string password = passwordGenerator.Next();
            Console.WriteLine($"Generated Password: {password}");
        }
    }
}