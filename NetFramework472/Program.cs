using System;
using System.ComponentModel.DataAnnotations;

namespace NetFramework472
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var attribute = new EmailAddressAttribute();
            const string candidate = " email@address.net";

            // Act
            var result = attribute.IsValid(candidate);

            // Assert
            Console.WriteLine($"Result: {result}");

            Console.ReadKey();
        }
    }
}