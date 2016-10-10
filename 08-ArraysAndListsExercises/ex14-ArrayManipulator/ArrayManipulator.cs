using System;
using System.Collections.Generic;
using System.Linq;

class ArrayManipulator
{

    private static void CommAdd(List<int> arrList, string[] command)
    {
        int index = int.Parse(command[1]);
        int element = int.Parse(command[2]);

        arrList.Insert(index, element);
    }

    private static void CommAddMany(List<int> arrList, string[] command)
    {
        int fromIndex = int.Parse(command[1]);
        List<int> addRange = command.Skip(2).Select(int.Parse).ToList();
        arrList.InsertRange(fromIndex, addRange);

        // Checked and working fine, but other method seems nicer
        //int range = command.Length - 2;
        //int addIndex = 2;
        //for (int i = fromIndex; i < fromIndex +range; i++)
        //{
        //    arrList.Insert(i, int.Parse(command[addIndex]));
        //    addIndex++;
        //}
    }

    private static void CommContntains(List<int> arrList, string[] command)
    {
        int element = int.Parse(command[1]);
        if (arrList.Contains(element)) Console.WriteLine(arrList.IndexOf(element));
        else Console.WriteLine(-1);
    }

    private static void CommRemove(List<int> arrList, string[] command)
    {
        int index = int.Parse(command[1]);
        arrList.RemoveAt(index);
    }

    private static void CommShift(List<int> arrList, string[] command)
    {
        int position = int.Parse(command[1]);
        int[] temp = new int[arrList.Count];
        temp = arrList.ToArray();
        for (int i = 0; i < temp.Length; i++)
        {
            arrList[i] = temp[(i + position) % temp.Length];
        }

    }
    private static void CommSumPairs(List<int> arrList)
    {
        int len = arrList.Count;
        if (len%2 != 0) arrList.Add(0);
        len += len % 2;
        int resultLen = len/2;
        
        for (int i = 0, j = 0; i < resultLen; i++, j += 2)
        {
            arrList[i] = arrList[j] + arrList[j + 1];
        }

        arrList.RemoveRange(resultLen, resultLen);
    }

    static void Main(string[] args)
    {
        char[] sep = new char[] { ' ' };
        List<int> arrList = Console.ReadLine().Split(sep).Select(int.Parse).ToList();

        string[] command = Console.ReadLine().Split(sep).ToArray();

        while (command[0] != "print")
        {
            switch (command[0])
            {
                case "add":             CommAdd(arrList, command); break;
                case "addMany":     CommAddMany(arrList, command); break;
                case "contains": CommContntains(arrList, command); break;
                case "remove":       CommRemove(arrList, command); break;
                case "shift":         CommShift(arrList, command); break;
                case "sumPairs":   CommSumPairs(arrList); break;

                default:
                    Console.WriteLine("Wrong command or parameters!"); break;
            }



            command = Console.ReadLine().Split(sep).ToArray();
        }

        Console.WriteLine('[' + string.Join(", ", arrList) + ']');
    }


}
