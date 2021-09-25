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
        //string pattern = "^[A-Z]{1}[a-z]{2,25}$"; //UC1-FirstName
        //string pattern = "^[A-Z]{1}[a-z]{2,30}[  ]*[A-Z]{1}[a-z]{2,20}$"; //UC2-FirstAndLastName
        //string pattern = "^[a-zA-Z0-9]+[._+]{0,1}[a-zA-Z0-9]*@[a-zA-Z0-9]{1,15}.[a-zA-Z]{2,10}[.]*[a-zA-Z]*$";//UC3-E-mail.
        //string pattern = "^[0-9]{2}[  ]*[0-9]{10}$";//UC4-MobileNumber
        //string pattern = "^[a-zA-z]{8,}$"; //UC5-Password rules(minimum 8 Characters)
        //string pattern = "^[a-zA-Z]{1,}[A-Z]{1,}[a-zA-Z]*";//UC6-at least 1 Upper Case
        // string pattern = "^[a-zA-Z0-9]{1,}[A-Z]*[0-9]*[a-zA-Z0-9]*$";//UC7-at least 1 numeric number in the password.
        //string pattern = "^[a-zA-Z0-9]{1,}[A-Z]*[0-9]*[@&*?_-]{1}[a-zA-Z0-9]*$"; //UC8-Has exactly 1 Special Character.
        //UC8
        //string[] inputs = { "A1S&Ashiq788","ASHIQ8@123","8ASHIQshaiks","1ASHII40788ashi","A1S&Ameer788","#)ashiq1213","8A788aShiq40788", "Ashiq40788" };//Validating some Example

        string pattern = "^[a-zA-Z0-9]+[._+]{0,1}[a-zA-Z0-9]*@[a-zA-Z0-9]{1,10}.[a-zA-Z]{2,10}[.]*[a-zA-Z]*$";//UC9-clear all email samples.
        //writing the valid pattern
        string[] inputs = { "ashiq.8shaik@gmail.com.au", "ashIqS?haik", "Ashiq788", "ashiqshaiksvali8@gmail.com", "SADNIJOQWN788BD", "ashiq.100@yahoo.com", "ashiq@1.com", "bridgelabz100+@gmail.com" };//Validating some Example
        //string[] inputs = { "abc@yahoo.com", "abc100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com", "abc+100@gmail.com" };

        /// <summary>
        /// Verifying the process
        /// </summary>
        public void Validating()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Verifying inputs: ");
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
  
