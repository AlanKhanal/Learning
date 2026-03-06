using System;

/// <summary>
/// Multidimensional Array in C#:
/// A multidimensional array is an array with more than one dimension.
/// It is used to store data in rows and columns like a table or matrix.
/// </summary>
public class MultiDimenstionalArray
{
    int[,] numbers = new int[,] { { 1, 2, 4 }, { 2, 3, 4 } };

    public MultiDimenstionalArray()
    {
        def();
    }

    private void abc()
    {
        Console.WriteLine("Element at [0,2]: " + numbers[0, 2]);

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.WriteLine("numbers[" + i + "," + j + "] = " + numbers[i, j]);
            }
        }
    }
    private void def()
    {
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}