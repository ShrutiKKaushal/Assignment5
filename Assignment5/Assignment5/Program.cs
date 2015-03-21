using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Mandatory to access System I/O functionality

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuMethod();
        }

          //************************* Menu Method **********************************
        private static void MenuMethod()
        {
            string pathName = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName; //updates the current working path as Path Name
            string fileName = "GradeFile.txt"; //declare the file name

            int choice = 0; 

            while (choice != 2) //menu
            {
                Console.WriteLine("+++++++++++++++++++++++++++");
                Console.WriteLine("+           Menu          +");
                Console.WriteLine("+     1.Display Grades    +");
                Console.WriteLine("+     2.Exit              +");
                Console.WriteLine("+++++++++++++++++++++++++++");
                Console.Write("Enter your choice: ");
                
                //Try-catch Block for handling Exceptions
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    choice = 0;
                    Console.WriteLine(error.Message);
                }

    }
}
