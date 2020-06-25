using System.Collections.Generic;
using System.Linq;

namespace Class
{
    public class Rectangle
    {
        private double sideA;
        private double sideB;

        public Rectangle(double a, double b)
        {
            sideA = a;
            sideB = b;
        }

        public Rectangle(double a)
        {
            sideA = a;
            sideB = 5;
        }

        public Rectangle()
        {
            sideA = 4;
            sideB = 3;
        }

        public double GetSideA()
        {
            return sideA;
        }

        public double GetSideB()
        {
            return sideB;
        }

        public double Area()
        {
            return sideA * sideB;
        }

        public double Perimeter()
        {
            return 2 * sideA + 2 * sideB;
        }

        public bool IsSquare()
        {
            if (sideA == sideB)
                return true;
            else return false;
        }

        public void ReplaceSides()
        {
            sideA += sideB;
            sideB = sideA - sideB;
            sideA -= sideB;
        }
    }

    public class ArrayRectangles
    {
        private readonly Rectangle[] rectangle_array;

        public ArrayRectangles(int n)
        {
            rectangle_array = new Rectangle[n];
        }

        public ArrayRectangles(IEnumerable<Rectangle> rects)
        {
            rectangle_array = Enumerable.ToArray(rects);
        }

        public bool AddRectangle(Rectangle rect)
        {
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] == null)
                {
                    rectangle_array[i] = rect;
                    return true;
                }
            }
            return false;
        }

        public int NumberMaxArea()
        {
            double maxArea = rectangle_array[0].Area();
            int number = 0;

            for (int i = 1; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] == null)
                    continue;

                if (rectangle_array[i].Area() > maxArea)
                {
                    maxArea = rectangle_array[i].Area();
                    number = i;
                }
            }
            return number;
        }

        public int NumberMinPerimeter()
        {
            double minPerimeter = rectangle_array[0].Perimeter();
            int number = 0;

            for (int i = 1; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] == null)
                    continue;

                if (rectangle_array[i].Perimeter() < minPerimeter)
                {
                    minPerimeter = rectangle_array[i].Perimeter();
                    number = i;
                }
            }
            return number;
        }

        public int NumberSquare()
        {
            int numberSquare = 0;

            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] == null)
                    continue;

                if (rectangle_array[i].IsSquare())
                {
                    numberSquare++;
                }
            }
            return numberSquare;
        }
    }
}