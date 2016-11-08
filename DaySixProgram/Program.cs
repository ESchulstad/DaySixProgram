using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySixProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                
                Console.WriteLine("Type a number.");
            int number = int.Parse(Console.ReadLine());
            decimal factorial = 1; 

            while (true)
            {
                if(number<=1)
                {
                    break;
                }
                factorial *=number;
                number--;
            }
            Console.WriteLine("n! = " + factorial);
            

            Console.WriteLine("Please type a number.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please pick a second numner");
            int m = int.Parse(Console.ReadLine());
            decimal factorial = 1;
            
            do
            {
                if (n > m)
                {
                    break;
                }
                factorial *= m;
                m--;

            }while (true);
            Console.WriteLine("product [n...m] = " + factorial);
            

            do
            {
                factorial *= m;
                m--;
            } while (n <= m);

            Console.WriteLine(factorial);
            

            //count from 1 to 10

            for(int i = 1;i<=10; i++)
            {
                Console.WriteLine(i);
                //loop in body, print number (i)
            }
            

            Console.WriteLine("Pick a number.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("To the power of...");
            int m = int.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 0; i < m; i++)
            {
                result *= n;
            }
            Console.WriteLine(result);
            

            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 2; i <= n; i += 2)
            {
                if(i%6==0)
                {
                    continue;
                }
                sum += i;
                
            }
            Console.WriteLine(sum);
            */

            string[] foods = { "pizza", "bananas", "strawberries","ice cream" };

            foreach(string fav in foods)
            {
                //prints list of array of food in fav
                Console.WriteLine(fav);
            }
        }
    }
}
