using System;
using System.Linq;

namespace Telephony
{
    public class Startup 
    {
        static void Main(string[] args)
        {
            var smartphone = new Smartphone();

            var numbers = Console.ReadLine().Split();
            var urls = Console.ReadLine().Split();

            try
            {
                numbers.ToList().ForEach(x => Console.WriteLine(smartphone.Call(x)));
                urls.ToList().ForEach(x => Console.WriteLine(smartphone.Browse(x)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}