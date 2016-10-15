using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06_RectanglePosition
{
    class RectanglePosition
    {
        class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            int CalcArea()
            {
                return Width * Height;
            }

            public int Bottom
            {
                get
                {
                    return Top + Height;
                }
            }

            public int Right
            {
                get
                {
                    return Left + Width;
                }
            }

            
            public bool IsInside(Rectangle r)
            {
                return (r.Left <= Left) && (r.Right >= Right) && (r.Bottom >= Bottom) && (r.Top <= Top);
            }

        }

        static void Main(string[] args)
        {

            Rectangle r1 = ReadRectangle();
            Rectangle r2 = ReadRectangle();

            Console.WriteLine(r1.IsInside(r2)? "Inside" : "Not inside");


        }

        static Rectangle ReadRectangle()
        {

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Rectangle rec = new Rectangle();
            rec.Left = input[0];
            rec.Top = input[1];
            rec.Width = input[2];
            rec.Height = input[3];
            return rec;
        }
    }
}
