using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_object
{
    internal class Car
    {
        private string name;
        private int HP;
        public Car(string name ,int HP)
        {
            
            this.name = name;
            this.HP = HP;
            
            Console.WriteLine(name + "The car is created");

        }
        public void Detail()

        {
            
            Console.WriteLine( "The detail of car is" + HP);
        }
        public void stop()
        {
            Console.WriteLine(name + "the car is Stop" + HP);
        }
        

        }
    }

