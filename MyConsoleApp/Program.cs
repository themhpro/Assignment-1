﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, address, contact;
            int age;
  
            Console.Write("Enter your Name    : ");
            name = Console.ReadLine();
            Console.Write("Enter your Age     : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Address : ");
            address = Console.ReadLine();
            Console.Write("Enter your Con. No.: ");
            contact = Console.ReadLine();

            Console.WriteLine("\n\t\t\tOutput");
            Console.WriteLine("Name\t\tAge\tAddress\t\tContact No.");
            Console.WriteLine(name +"\t"+ age +"\t"+ address +"\t\t"+ contact);
            Console.ReadKey();
        }
    }
}
