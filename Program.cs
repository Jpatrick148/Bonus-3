using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userNum;
            int num, rndNum;
            Console.WriteLine("Hello and welcome to the Numbers Games! GLHF");
            
            Random rnd = new Random();
            rndNum = rnd.Next(1, 100);

            Console.WriteLine(rndNum);

            Console.WriteLine("Enter your first guess! ");
            userNum = Console.ReadLine();
            num = int.Parse(userNum);

            int diff = GetIntWithInRange()

        }

        public static int GetIntWithInRange(int num, int rndNum)
        {
            int total1;

            if (num == rndNum)
            {
                Console.WriteLine("Correct! You did it!");
            }
            else if (num < rndNum)
            {
                total1 = num - rndNum;
                if (total1 >= -10)
                {
                    Console.WriteLine("Too Low...");
                }
                else if (total1 <= 10)
                {
                    Console.WriteLine("Too High...");
                }

                return total1;
            }

        }
    }
    
}
