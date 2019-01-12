using System;
using System.Runtime.InteropServices;
namespace GraceMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            string clas;
            int failed_Subjects;
            Console.WriteLine("Enter your class: \n");
            clas = Console.ReadLine();
            
            Console.WriteLine("Enter the number of subjects failed in: \n");
            failed_Subjects =Convert.ToInt32(Console.ReadLine());
            if (clas == "First" || clas == "first")
            {
                switch (failed_Subjects)
                {
                    case 1:
                        Console.WriteLine("Grace is 5 marks per subject");
                        break;
                    case 2:
                        Console.WriteLine("Grace is 4 marks per subject");
                        break;
                    case 3:
                        Console.WriteLine("Grace is 3 marks per subject");
                        break;
                    default:
                        Console.WriteLine("No Grace Marks!!!");
                        break;
                }
            }
            else if (clas == "Second" || clas == "second")
            {
                switch (failed_Subjects)
                {
                    case 1:
                        Console.WriteLine("Grace is 2 marks per subject");
                        break;
                    case 2:
                        Console.WriteLine("Grace is 1 marks per subject");
                        break;
                    default:
                        Console.WriteLine("No Grace Marks!!!");
                        break;
                }
            }

            Console.ReadLine();
        }
    }

    internal class CharConverter
    {

    }
}
