using System;
using System.Collections.Generic;
using System.Text;

namespace TommyGun
{
    class StaticToolbox
    {

     public   static int ReadInt(int UsedValue, string prompt)
        {
            Console.WriteLine($"{prompt}, Default Value: {UsedValue}");
            string enteredValue = Console.ReadLine();
            if (int.TryParse(enteredValue, out int number))
            {
                Console.WriteLine("Using: " + number);
                return number;
            }
            else
            {
                Console.WriteLine("Not an integer, using default value of " + UsedValue);
                return UsedValue;
            }

        }
    }
}
