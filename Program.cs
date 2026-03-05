using System;

namespace Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestRefactor();
           RunEnumTest();
        }

        // Method to run the interactive enum program
        static void RunEnumTest()
        {
            // Create an instance of EnumTest
            EnumTest enumTest = new EnumTest();

            // Show instructions
            enumTest.ShowInstructions();

            // Start the interactive loop
            enumTest.Run();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        static void TestRefactor()
        {
            new Refactoring();
        }
    }
}