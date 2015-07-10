using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//start namespace TimeAndClassifications
namespace TimeAndClassifications
{
    /// <summary> 
    /// This program will retrieve the current time from System.DateTime.
    /// Based on the designated number of seconds in the current time, it will write out a message
    /// </summary>

    //start class Program
    class Program
    {
        //start main method
        static void Main(string[] args)
        {
            //Declaring the variable sec and retrieving the number of seconds using System DateTime
            int sec = DateTime.Now.Second;

            //Using switch statements to switch between the designated number of seconds
            switch (sec)
            {
                case 0:
                    Console.WriteLine("The new minute is just beginning");
                    break;
                case 15:
                    Console.WriteLine("We're one quarter done.");
                    break;
                case 30:
                    Console.WriteLine("Half way there.");
                    break;
                case 45:
                    Console.WriteLine("Getting close to done");
                    break;
                default:
                    Console.WriteLine("Working on it.");
                    break;
            }//end switch statement
        }//end main method
    }//end class Program
}//end namespace TimeAndClassifications