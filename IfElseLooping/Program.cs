using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseLooping
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            int age;
            Console.WriteLine("Enter Your Name");
            
            Name = Console.ReadLine();
            Console.WriteLine("EnterYOur Age");
            age =  Convert.ToInt32( Console.ReadLine());
            if(Name.Length>5)
            {
                Console.Write("Your Name is Too short {0}",Name.ToLower());
               

            }
            else
            {
                Console.WriteLine("YOur Name has enough of Lenght {0}" , Name.ToUpper());
            }
            Console.ReadKey();
           

        }
    }
}
