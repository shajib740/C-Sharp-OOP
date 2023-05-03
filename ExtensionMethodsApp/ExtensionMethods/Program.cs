﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PersonModel person = new PersonModel();

            person.FirstName = "What is your first name: ".RequestString(); ;
           
            person.LastName = "What is your last name: ".RequestString();

            person.Age = "What is your age: ".RequestInt(0,120);

            Console.ReadLine();
        }
    }
}
