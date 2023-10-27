using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_object
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Car audi = new Car("Audi A3 " ,450);
            audi.Detail();
            
            Car BMW = new Car("BMW S4 ", 489);
            BMW.Detail();
            audi.stop();
            BMW.stop();
           
          
            string userinput = Console.ReadLine();
            if (userinput == "1")
            {
                Console.WriteLine("The audi is stop");
            }
            else
            {
                Console.WriteLine("The Bmw is stop");
            }
                
            
            Console.ReadLine();
        }
    }
}
