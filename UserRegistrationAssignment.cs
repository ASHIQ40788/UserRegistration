using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserRegistrationAssignment
    {
        string pattern = "^[A-Z]{1}[a-z]{2,25}$"; //UC1-FirstName
         //writing the valid pattern
        string[] inputs = { "Ashiq", "Ameer", "ashiq", "ameer", "Revanth", "Susank", "susank" };//Validating some Example


        /// <summary>
        /// Verifying the process
        /// </summary>
        public void Validating()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Verifying Email address: ");
            IterationLoop(inputs, regex);
        }
        public static void IterationLoop(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool result = regex.IsMatch(arr[i]);
                if (result)
                {
                    Console.WriteLine(arr[i] + " It is --->" + "Valid");
                }
                else
                {
                    Console.WriteLine(arr[i] + " It is --->" + "Invalid");
                }
            }
        }
    }



    
}
  