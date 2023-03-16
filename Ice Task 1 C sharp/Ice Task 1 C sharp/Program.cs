using System;

namespace ICE_Task_1
{
    public class Program
    {




        static void Main(string[] args)
        {

            int numOfScripts;
            int numOfQuestions;
            int numberOfLecturers;
            int subtotalQuestions;


            //prompt user:
            Console.WriteLine("Enter the number of scripts");

            // collects user input into a variable.
            numOfScripts = Convert.ToInt32(Console.ReadLine());

            //conditional loop 
            while (numOfScripts <= 0)
            {

                Console.WriteLine("Enter the number of scripts");
                numOfScripts = Convert.ToInt32(Console.ReadLine());
            }

            int totalnumOfScripts = numOfScripts;


            //prompt user
            Console.WriteLine("\nEnter the number of questions");

            // collect user data
            numOfQuestions = Convert.ToInt32(Console.ReadLine());

            // conditional loop 
            while (numOfQuestions < 1 || numOfQuestions > 10)
            {

                Console.WriteLine("\nEnter the number of questions");
                numOfQuestions = Convert.ToInt32(Console.ReadLine());
            }

            //prompt user
            Console.WriteLine("\nEnter the number of lectures");

            // collect user data
            int numOfLectures = Convert.ToInt32(Console.ReadLine());


            //conditional loop
            while (numOfLectures < 1)
            {
                Console.WriteLine("\nEnter the number of lectures");
                numOfLectures = Convert.ToInt32(Console.ReadLine());
            }


            int[] subtotal = new int[numOfQuestions];

            for (int i = 0; i < subtotal.Length; i++)
            {
                Console.WriteLine("Enter the subtotal of each question");
                subtotal[i] = Convert.ToInt32(Console.ReadLine());

                while (subtotal[i] < 1)
                {
                    Console.WriteLine("Enter the subtotal for each question. (must be greater than 0) :");
                    subtotal[i] = Convert.ToInt32(Console.ReadLine());
                }
            }


            DistributeScripts(totalnumOfScripts, numOfLectures);


            // time calculations
            int totalTime = 0;
            int numTests = totalnumOfScripts / numOfLectures;

            for (int j = 0; j < subtotal.Length; j++)
            {

                int k = subtotal[j] * 2;
                totalTime += k;
            }

            totalTime = totalTime * numTests;
            int minutes = totalTime / 60;
            int hours = minutes / 60;

            Console.WriteLine($"Total Time: {hours} hours, {minutes} minutes");

        }

        static void DistributeScripts(int totalnumOfScripts, int numOfLectures)
        {
            int scriptsPerLecturer = totalnumOfScripts / numOfLectures;

            Console.WriteLine("\nThere are {0} lecturers each marking {1} scripts each", numOfLectures, scriptsPerLecturer);

        }
    }
}

