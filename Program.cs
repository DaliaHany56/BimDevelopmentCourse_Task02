 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vowels = "AEIOU";
            Console.WriteLine("Enter any word or phrase");
            string userrespond01 = Console.ReadLine();
            int count = 0;
            foreach (char x in vowels)
            {
                bool checkIfwordHaveVowels = userrespond01.ToUpper().Contains(x);
                if (checkIfwordHaveVowels == true)
                {
                    count++;
                }
            }

            Console.WriteLine($"your text have {count} vowels");

            Console.ReadLine();

            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("enter list of names and separated them by comma(,)");
            string names = Console.ReadLine().ToUpper();
          
            string[] n = names.Split(',');
            foreach(string name in n) 
            {

                Console.WriteLine(name);
                
                Thread.Sleep(1000);

            }

            Console.Read();


            



        }

    }
}
