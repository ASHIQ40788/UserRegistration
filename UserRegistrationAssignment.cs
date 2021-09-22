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
        string pattern = "^[0-9]{2}[  ]*[0-9]{10}$";//UC4-MobileNumber
        //writing the valid pattern
        string[] inputs = { "91 8074334664", "918074334664", "91 9959189632", "919959189632", "1234567899", "917013665324", "91 7013655324", "2967400734328", "918886334768" };//Validating some Example


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
  