using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapConsole
{ 
   
        public class Program
        {
            public static void Main()
            {
                int number1 = 20, number2 = 30;
                Console.WriteLine($"Before SWapping number1= {number1}, number2 = {number2}");
                number1 = number1 * number2; //number1=200 (10*20)      
                number2 = number1 / number2; //number2=10 (200/20)      
                number1 = number1 / number2; //number1=20 (200/10)    
                Console.WriteLine($"After swapping number1= {number1}, number2 = {number2}");
                Console.ReadKey();
            }
        }
    }
