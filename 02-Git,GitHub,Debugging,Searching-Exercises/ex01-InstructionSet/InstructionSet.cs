using System;

class InstructionSet // remove remark "broken" from class name
{
    static void Main()
    {
        string opCode = Console.ReadLine().ToUpper(); // convert input string to Capital Letters

        while (opCode != "END") // Change string from condition with capital letters
        {
            string[] codeArgs = opCode.Split(' ');

            long result = 0;
            // all arguments from array are changet from int to long
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = ++operandOne; // add 1 before assigin value (++ operator before variable)
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = --operandOne; // remuve 1 before assigin value (-- operator before variable)
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = (operandOne * operandTwo); // remuve unneeded parsing
                        break;
                    }
            }
            Console.WriteLine(result);
            opCode = Console.ReadLine().ToUpper(); // add another user input for next instruction
        }
        
    }
}
