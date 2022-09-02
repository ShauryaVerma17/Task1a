using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assembly reference (Update logging incase we change log4net ?
[assembly: log4net.Config.XmlConfigurator(Watch = true)]


namespace Task1a
{

    class Program
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);  //Big line inside getlogger points to the class we are in 
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("Program.cs");
        static void Main(string[] args)
        {
            double sideA;
            double sideB;
            double sideC;
            double length;
            double width;
            try
            {
                Console.WriteLine("Enter the side lengths for the Triangle\n");
                Console.Write("Side A:");
                sideA = Convert.ToDouble(Console.ReadLine());
                Console.Write("Side B:");
                sideB = Convert.ToDouble(Console.ReadLine());
                Console.Write("Side C:");
                sideC = Convert.ToDouble(Console.ReadLine());


                Console.Clear();
                Console.WriteLine("Enter the length and width for the Rectangle\n");
                Console.Write("Length:");
                length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Width:");
                width = Convert.ToDouble(Console.ReadLine());

                if (sideA <= 0 || sideB <= 0 || sideC <= 0 || length <= 0 || width <= 0)
                {
                    Console.WriteLine("Negative lengths are not allowed");
                    log.Error("Invalid Length/s provided (Non Positive Lengths)");
                }
                else
                {
                    Rectangle rectangle = new Rectangle(length, width);
                    Triangle triangle = new Triangle(sideA, sideB, sideC);

                    Console.WriteLine("The Rectangle's area is {0}", rectangle.CalcArea());
                    Console.WriteLine("The Triangle's area is {0}", triangle.CalcArea());

                    log.Info($"The area of the rectangle with sides {rectangle.Length} and {rectangle.Width} is {rectangle.CalcArea()}");
                    log.Info($"The area of the triangle with sides {triangle.SideA}, {triangle.SideB} and {triangle.SideC} is {triangle.CalcArea()}");

                }


            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Side Length");
                log.Error("Invalid Length/s provided");
            }

            // Trying functionality
            //Rectangle rectangle = new Rectangle(5.5, 10);
            //Triangle triangle = new Triangle(sideA, sideB, sideC);

            //Console.WriteLine("The Rectangle's area is {0}", rectangle.CalcArea());
            //Console.WriteLine("The Triangle's area is {0}", triangle.CalcArea());

            //log.Info($"The area of the rectangle with sides {rectangle.Length} and {rectangle.Width} is {rectangle.CalcArea()}");
            //log.Info($"The area of the triangle with sides {triangle.SideA}, {triangle.SideB} and {triangle.SideC} is {triangle.CalcArea()}");


            log.Debug("Application has reached the end");
            Console.ReadLine();

            
        }
    }
}

