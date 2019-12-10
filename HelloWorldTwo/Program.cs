using System;

namespace HelloWorldTwo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a width: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Height: ");
            int height = int.Parse(Console.ReadLine());

            int area = width * height;
            Console.WriteLine("The area of the recanglt is " + area);
        }
    }   
}
 