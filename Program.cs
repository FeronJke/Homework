using System;
using System.Data.SqlTypes;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {

            MyProfile();
            Console.ReadKey();
            Console.Clear();
            double result = CoorLen(); //CoorLen(x1, y1, x2, y2);
            Console.WriteLine($"Length between point 1 and point 2 = {result}");
        }

        static double CoorLen()//double x1, double y1, double x2,double y2//)
        {
            Console.WriteLine("Enter coordinate first point:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coordinate second point:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return (r);
        }

        //profile
        static void MyProfile()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your hight:");
            double hight = Convert.ToDouble(Console.ReadLine()) * 0.01;
            Console.WriteLine("Enter your weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Hello {surname} {name}! You are {age} years old, your hight = {hight * 100} and your weight = {weight} ");
            //Console.WriteLine("Hello {0} {1}! You are {2} years old, your hight = {3} and your weight = {4}", surname, name, age, hight, weight); //formatString
            double IndexBW = weight / (hight * hight);
            Console.WriteLine($"Your Body Weight Index = {IndexBW}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
