using System;
using System.Text;

namespace ConsoleApp7
{
    class Program
    {
        
        static void Main(string[] args)

        {
            var name = Console.ReadLine();
            string AdminName = Environment.UserName;
          string currentDate = DateTime.Now.ToShortDateString();
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Привет "+ AdminName + " сегодня " + currentDate);

            
                        Console.WriteLine(name);

        }
    }
}
