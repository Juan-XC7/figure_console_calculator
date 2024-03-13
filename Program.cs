using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = GetValidFigure();
            string operation = GetValidOperationType();

            if (operation == "perimeter")
            {
                CalculatePerimeter(figure);
            }
            else
            {
                CalculateArea(figure);
            }

            Console.ReadLine();
        }

        public static void CalculatePerimeter(string figure)
        {
            if (figure == "circle")
            {
                double radius = GetFigureRadius();
                double perimeter = CalculateCirclePerimeter(radius);
                Console.WriteLine($"result: {perimeter}");
            }

            if (figure == "triangle")
            {
                double side1 = GetFigureSide("first");
                double side2 = GetFigureSide("second");
                double side3 = GetFigureSide("third");

                double perimeter = CalculateTrianglePerimeter(side1, side2, side3);
                Console.WriteLine($"result: {perimeter}");
            }

            if (figure == "rectangle")
            {
                double lenght = GetFigureLength();
                double width = GetFigureWidth();
                double perimeter = CalculateRectanglePerimeter(lenght, width);
                Console.WriteLine($"result: {perimeter}");
            }

            if (figure == "square")
            {
                double lenght = GetFigureLength();
                double width = GetFigureWidth();
                double perimeter = CalculateSquarePerimeter(lenght, width);
                Console.WriteLine($"result: {perimeter}");
            }
        }

        public static void CalculateArea(string figure)
        {
            if (figure == "circle")
            {
                double radius = GetFigureRadius();
                double area = CalculateCircleArea(radius);
                Console.WriteLine($"result: {area}");
            }

            if (figure == "triangle")
            {
                double length = GetFigureLength();
                double width = GetFigureWidth();
                double area = CalculateTriangleArea(length, width);
                Console.WriteLine($"result: {area}");
            }

            if (figure == "rectangle")
            {
                double length = GetFigureLength();
                double width = GetFigureWidth();
                double area = CalculateTriangleArea(length, width);
                Console.WriteLine($"result: {area}");
            }

            if (figure == "square")
            {
                double length = GetFigureLength();
                double width = GetFigureWidth();
                double area = CalculateTriangleArea(length, width);
                Console.WriteLine($"result: {area}");
            }
        }

        public static string SelectAreaFigure()
        {
            string selectedOperation;
            Console.Write("You want to calculate perimeter or area? ");
            selectedOperation = Console.ReadLine();
            Console.WriteLine(selectedOperation);

            return selectedOperation.ToLower();
        }


        public static string GetOperationType()
        {
            string selectedOperation;
            Console.Write("You want to calculate perimeter or area? ");
            selectedOperation = Console.ReadLine();

            return selectedOperation.ToLower();
        }

        public static string GetValidOperationType()
        {
            string[] allowedOperations = { "area", "perimeter" };
            string operation;

            do
            {
                operation = GetOperationType();

                if (!ArrayContainsValue(allowedOperations, operation))
                {
                    Console.WriteLine($"Invalid operation selected. {operation}");
                }
            } while (!ArrayContainsValue(allowedOperations, operation));

            return operation;
        }

        public static string GetFigure()
        {
            string figure;
            Console.Write("Select your figure, allowed figures: circle, square, rectangle, triangle: ");
            figure = Console.ReadLine();

            return figure.ToLower();
        }

        public static string GetValidFigure()
        {
            string[] allowedFigures = { "circle", "square", "rectangle", "triangle" };
            string figure;

            do
            {
                figure = GetFigure();

                if (!ArrayContainsValue(allowedFigures, figure))
                {
                    Console.WriteLine($"Invalid figure selected: {figure}");
                }
            } while (!ArrayContainsValue(allowedFigures, figure)) ;


            return figure;
        }
        static bool ArrayContainsValue(string[] array, string value)
        {
            return Array.IndexOf(array, value) != -1;
        }

        public static double CalculateCircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public static double CalculateRectangleArea(double length, double width)
        {
            double area = length * width;
            return area;
        }

        public static double CalculateSquareArea(double length, double width)
        {
            double area = length * width;
            return area;
        }

        public static double CalculateTriangleArea(double length, double width)
        {
            double area = (length * width)/2;
            return area;
        }

        public static double CalculateCirclePerimeter(double radius)
        {
            double perimeter = Math.PI * (radius * 2);
            return perimeter;
        }

        public static double CalculateRectanglePerimeter(double length, double width)
        {
            double perimeter = (length * 2) + (width * 2);
            return perimeter;
        }

        public static double CalculateSquarePerimeter(double length, double width)
        {
            double perimeter = (length * 2) + (width * 2);
            return perimeter;
        }

        public static double CalculateTrianglePerimeter(double side1, double side2, double side3)
        {
            double perimeter = side1 + side2 + side3;
            return perimeter;
        }

        public static double GetFigureLength()
        {
            Console.Write("Enter the figure length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            return length;
        }

        public static double GetFigureWidth()
        {
            Console.Write("Enter the figure width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            return width;
        }
        public static double GetFigureSide(string number)
        {
            Console.Write($"Enter the {number} figure side: ");
            double side = Convert.ToDouble(Console.ReadLine());
            return side;
        }

        public static double GetFigureRadius()
        {
            Console.Write("Enter the figure radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            return radius;
        }
    }
}
