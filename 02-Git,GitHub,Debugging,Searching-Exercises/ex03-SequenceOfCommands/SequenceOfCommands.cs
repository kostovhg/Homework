using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());
        long[] array = new long[sizeOfArray]; // add sizeOfArray as array dimention
        array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string[] command = Console.ReadLine().Split(ArgumentsDelimiter);

        while (!command[0].Equals("stop")) // change command from "over" to "stop"
        {
            int[] args = new int[2];

            if (command[0].Equals("add") ||
                command[0].Equals("subtract") || // "substract" to "subtract"
                command[0].Equals("multiply"))
            {
                args[0] = int.Parse(command[1]);
                args[1] = int.Parse(command[2]);

                PerformAction(ref array, command[0], args);
            }
            else
            {
                PerformAction(ref  array, command[0]);
            }

            PrintArray(ref array);
            Console.Write('\n'); // "WriteLine" to "Write"

            command = Console.ReadLine().Split(ArgumentsDelimiter);
        }
    }

    static void PerformAction(ref long[] array, string action, int[] args = null )
    {
        //long[] array = arr.Clone() as long[];
        int pos = 0;
        int value = 0;
        if (args != null)
        {
            pos = args[0];
            value = args[1];
        }

        switch (action)
        {
            case "multiply":
                array[pos-1] *= value;
                break;
            case "add":
                array[pos-1] += value;
                break;
            case "subtract":
                array[pos-1] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(ref array);
                break;
            case "rshift":
                ArrayShiftRight(ref array);
                break;
        }

    }

    private static void ArrayShiftRight(ref long[] array)
    {
        long tmp = array[array.Length - 1];

        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = tmp;
    }

    private static void ArrayShiftLeft(ref long[] array)
    {
        long tmp = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = tmp;
    }

    private static void PrintArray(ref long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " "); // WriteLine to Write. To not print members on new line
        }
    }
}
