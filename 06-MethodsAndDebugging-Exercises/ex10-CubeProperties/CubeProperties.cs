using System;

namespace ex10_CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string paramOfCube = Console.ReadLine().ToLower();

            switch (paramOfCube)
            {
                case "face": CalcCubeFace(sideOfCube); break;
                case "space": CalcCubeSpace(sideOfCube); break;
                case "volume": CalcCubeVol(sideOfCube); break;
                case "area": CalcCubeArea(sideOfCube); break;
                default:
                    break;
            }

        }

        private static void CalcCubeFace(double side)
        {
            Console.WriteLine("{0:f2}", Math.Sqrt(2*(side * side)));
        }
        private static void CalcCubeSpace(double side)
        {
            Console.WriteLine("{0:f2}", Math.Sqrt(3 * (side * side)));
        }

        private static void CalcCubeVol(double side)
        {
            Console.WriteLine("{0:f2}", side * side * side);
        }

        private static void CalcCubeArea(double side)
        {
            Console.WriteLine("{0:f2}", 6 * (side * side));
        }


    }
}
