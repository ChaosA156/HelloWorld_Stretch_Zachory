 using System;

namespace HelloWorld_Stretch_Zachory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Declares variable called favorite Variable
            int favoriteNumber;
            //Initializes two boolean variables to false
            bool isJumping = false, isRunning = false;
            //Declares floating variable called balloon
            float balloon;
            //Gives Value to favoriteNumber
            favoriteNumber = 56;
            //Gives value to balloon
            balloon = 1.56f;
            //Initializes variable called finalGrade with a value
           const double finalGrade = 86.0;
            //Prints all the variables out to the console
            Console.WriteLine(favoriteNumber);
            Console.WriteLine(isJumping);
            Console.WriteLine(isRunning);
            Console.WriteLine(balloon);
            Console.WriteLine(finalGrade);
        }
    }
}
