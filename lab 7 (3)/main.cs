using System;
namespace Ferrari
{
    public class Startup 
    {
       static void Main(string[] args)
        {
            string driverName = Console.ReadLine();

            var ferrari = new Ferrari(driverName);

            Console.WriteLine(ferrari);
        }
    }
}