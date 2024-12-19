﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace GUI
{
    internal class Validation
    {

        internal int AskForInteger()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int result))
            {
                Console.WriteLine("Felaktigt val, välj en siffra"); 

            }
            return result;  
        }
        internal double AskForDouble()
        {
            string input = Console.ReadLine();

            if (!double.TryParse(input, out double result))
            {
                Console.WriteLine("Felaktigt val, välj en siffra");

            }
            return result;
        }
        internal string AskForString()
        {
            string input = Console.ReadLine();

            return input;
        }
    }
}