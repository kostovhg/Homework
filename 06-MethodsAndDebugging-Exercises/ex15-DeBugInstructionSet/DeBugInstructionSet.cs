using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15_DeBugInstructionSet
{
    class DeBugInstructionSet
    {
        static void Main(string[] args)
        {
            string opCode = Console.ReadLine().ToUpper(); //add .ToUpper()

            while (opCode != "END") // Use capital leters for command "END"
            {
                string[] codeArgs = opCode.Split(' ');

                long result = 0; // change int to long for all variables
                switch (codeArgs[0]) 
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = ++operandOne; // first increase, after asign  
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = --operandOne;
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
                            result =operandOne * operandTwo;
                            break;
                        }
                }

                Console.WriteLine(result);
                opCode = Console.ReadLine().ToUpper(); // assign new string for opCode
            }
        }
    }
}
