using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClass5202
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter your user name: ");
            string name = Console.ReadLine();
            Console.Write("please enter your address: ");
            string address = Console.ReadLine();
            Console.Write("please enter your age:");
            double age = double.Parse(Console.ReadLine());
            Console.Write("please enter your email address:");
            string email = Console.ReadLine();
            Console.Write(" please enter your 4 digit pin:");
            int pin = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n...Details...\nName: {name}\nAddress: {address}\nAge: {age}\nEmail: {email}\nPin: {pin}");
            Console.ReadLine();






        }
    }
}
