using System;
using System.Linq;

public class DeBugSequenceOfCommands 
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

        string[] command = Console.ReadLine().Split(ArgumentsDelimiter); // convert command to string array, and split it

        while (!command[0].Equals("stop")) // change command from "over" to "stop", and choose command from first index of array
        {
            int[] args = new int[2];
            // use command array first index as command
            if (command[0].Equals("add") ||
                command[0].Equals("subtract") || // "substract" to "subtract"
                command[0].Equals("multiply"))
            {
                args[0] = int.Parse(command[1]); // change arguments to second index of array "command"
                args[1] = int.Parse(command[2]); // change arguments to third index of array "command"

                PerformAction(ref array, command[0], args); // add "ref" 
            }
            else // add else, to call method without "args"
            {
                PerformAction(ref array, command[0]); // add "ref"
            }

            PrintArray(ref array); // add "ref"
            Console.Write('\n'); // "WriteLine" to "Write"

            command = Console.ReadLine().Split(ArgumentsDelimiter); // again command to string array, and split
        }
    }

    static void PerformAction(ref long[] array, string action, int[] args = null)
    {
        //long[] array = arr.Clone() as long[];
        int pos = 0;
        int value = 0;
        if (args != null) // asign arguments if there is any
        {
            pos = args[0];
            value = args[1];
        }

        switch (action)
        {
            case "multiply":
                array[pos - 1] *= value; // lower the index of array with 1
                break;
            case "add":
                array[pos - 1] += value; // lower the index of array with 1
                break;
            case "subtract":
                array[pos - 1] -= value; // lower the index of array with 1
                break;
            case "lshift":
                ArrayShiftLeft(ref array); // add "ref"
                break;
            case "rshift":
                ArrayShiftRight(ref array); // add "ref"
                break;
        }
    }

    private static void ArrayShiftRight(ref long[] array) // add "ref"
    {
        long tmp = array[array.Length - 1]; // save last index value to tmp

        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = tmp; // asign tmp value to first index 
    }

    private static void ArrayShiftLeft(ref long[] array) // add "ref"
    {
        long tmp = array[0]; // save first index of array 
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = tmp; // assign tmp value to last index
    }

    private static void PrintArray(ref long[] array) // add "ref"
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " "); // WriteLine to Write. To not print members on new line
        }
    }
}

