using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Program
    {
        struct Rectangle2D
        {
            int width;
            int height;
            int x;
            int y;
        }
        Rectangle2D rectangle = new Rectangle2D();

        struct Rectangle2DMassive
        {
            public int width;
            public int height;
            public Rectangle2DMassive(int width, int height)
            {
                this.width = width;
                this.height = height;
            }
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<Rectangle2DMassive> RectangleArray=new List<Rectangle2DMassive>();
            for (int i = 0; i < 100; i++)
            {
                Rectangle2DMassive rectangle2=new Rectangle2DMassive(rand.Next(1, 11), rand.Next(1, 11));
                RectangleArray.Add(rectangle2);
            }

            for (int i = 0; i < RectangleArray.Count; i++)
            {
                Console.WriteLine(RectangleArray[i].height+" "+RectangleArray[i].width);
            }

            int DuplicateCount = 0;
            int j = 0;
            for (int i = 0; i < RectangleArray.Count; i++)
            {
                j = 1;
                while (i + j < 100)
                {
                    //if ((Convert.ToInt32(RectangleArray[i].height) == Convert.ToInt32(RectangleArray[j + i].height)) && Convert.ToInt32(RectangleArray[i].width) == Convert.ToInt32(RectangleArray[j + i].width))
                    if (RectangleArray[i].Equals(RectangleArray[i+j]))
                    {
                        DuplicateCount= DuplicateCount+1;
                        break;
                    }
                    j++;
                }
            }
            Console.WriteLine("Number of Duplicates: "+DuplicateCount);

            Console.ReadLine();
        }
    }
}
