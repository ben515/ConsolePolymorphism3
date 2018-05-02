using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePolymorphism3
{
    class Traffic
    {
        protected static int _miles;
        public virtual void SpeedUp()
        {

        }
    }
    class Car : Traffic
    {
        public override void SpeedUp()
        {
            _miles += 2;
            Console.WriteLine("\n 駕駛車子，加速中，前進{0}公里 .", _miles);
            Console.WriteLine("----------------------------------------");
        }
    }
    class Airplane : Traffic
    {
        public override void SpeedUp()
        {
            _miles += 15;
            Console.WriteLine("\n 駕駛飛機，加速中，前進{0} 公里  .", _miles);
            Console.WriteLine("----------------------------------------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Traffic r;
            Car myCar = new Car();
            Airplane myAirplane = new Airplane();
            int input;
            while(true)
            {
                Console.Write("請問要駕駛->1.車子  2.飛機  其他.離開 :");
                input = int.Parse(Console.ReadLine());
                if(input ==1)
                {
                    r = myCar;
                }
                else if(input == 2)
                {
                    r = myAirplane;
                }
                else
                {
                    break;
                }
                r.SpeedUp();
                Console.WriteLine();
            }
            

        }
    }
}
