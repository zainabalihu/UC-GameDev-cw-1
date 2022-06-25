using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroAge = 15, villainAge = 30, Difference = 30 % 15, heroAge1 = 5 + 15;
            string heroName = "Jimmy", villainName = "Simon";
            double heroHight = 180.5, heroSuperPower = 1500.6, villainHight = 190.8, villainSuperPower = 130;
            Console.WriteLine("Hello I am " + heroName + "   age is " + heroAge + "   hight is " + heroHight + "   super Power is " + heroSuperPower);

            Console.WriteLine("Hello I am " + villainName + "   age is " + villainAge + "   hight is " + villainHight + "  super Power is " + villainSuperPower );
            Console.WriteLine("Age difference between hero and villain is " + Difference);
            Console.WriteLine("my age after 5 years is " + heroAge1);







        }
    }
}
