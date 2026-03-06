using System;

namespace Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestRefactor();
            //RunEnumTest();
            //RunPropertiesTest();
            //MultiDimenstionalArrayTest();
            //RecursionTest();
            //DictionaryTest();
            new ParamsTest();
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

        static void RunPropertiesTest() 
        {
            //PropertiesTest.SetPlayerName("Alan"); //This throws error
            PropertiesTest.SetPlayerName("Zlan");
            Console.WriteLine(PropertiesTest.PlayerName);
        }
        static void MultiDimenstionalArrayTest()
        {
            new MultiDimenstionalArray();
        }
        static void RecursionTest()
        {
            new RecursionTest();
        }
        static void DictionaryTest()
        {
            new DictionaryTest();
        }
    }
}