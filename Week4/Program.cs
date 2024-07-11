namespace Week4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*TODO LIST:
 *
 
 *  ----- 25min to go through this -----
 *
 *  Loop Types (10min)
 *  Arrays (10min)
 *  Lists (5min)
 *  
 *  ----- 5 min Break -----
 *
 *  Go make a coffee and get some biscuits maybe??
 *
 *  ----- 25min to go through this -----
 *
 *  Switch (5min)
 *  Enums   (5min)
 *  
 *  Nested Loops (10-15min)
 * 
 *  ----- 5-10 min Q&A -----
 * 
 * ask anything
 *               
 *  ----- Form/Survey(anon) -----

 *  ----- Next week -----
 *  
 *  Functions/Methods
 *      Explanation
 *      Structure
 *      Building
 *      
 * 
*/

            // write our hello messages

            Console.WriteLine("Hello everyone Ryan is here");
            Console.WriteLine("RB is here as always");
            Console.WriteLine("Jordan is in the code");
            Console.WriteLine("Hello everyone Balazs is here");
            Console.WriteLine("Tim was here");
            Console.WriteLine("Greetings. Hoang Bao is here.");

            //---------------------------------------------------------------- newish stuffs

            // Task1: write an if, else if, else statement
            //Jordan P
            int i = 1;
            int j = 0;
            if (i == 0)
            {
                Console.WriteLine("the number is: {0}", i);
            }
            else if (i == 1)
            {
                Console.WriteLine("the number is: {0}", i);
            }
            else
            {
                Console.WriteLine("the number isn't binary!");
                j = 1;
            }



            // Balazs
            string passWord1 = "Potatoes1234!!!";
            if (passWord1.Length > 0)
            {
                Console.WriteLine("Confirm your password");
            }
            else if (passWord1.Any(char.IsUpper))
            {
                Console.WriteLine(" Your password has upper case, good work");

            }
            else
            {
                Console.WriteLine("Password does not satisfy the requiremenst");
                Console.WriteLine(" Press any key to exit ");
                Console.ReadKey();

            }


            // Task 2, write if statements using ANDs aswell as ORs. 
            //if you want to be fancy, include some nots
            // Jordan P
            if (i > 0 && j != 0)
            {
                Console.WriteLine("the values exist i: {0} j:{1}", i, j);
            }

            //Hoang Bao

            bool hasDriverLicense = true;
            int age = 28;
            if (age >= 18 && age <= 60)
            {
                Console.WriteLine("You are qualified to drive.");
            }
            else
            {
                Console.WriteLine("You are not qualified to drive.");
            }




            // Balazs
            passWord1 = "Potatoes1234!!!";
            string passWord2 = "";
            if (passWord1.Length > 0)
            {
                Console.WriteLine("Confirm your password");
                passWord2 = Console.ReadLine();
            }
            else if (passWord1.Any(char.IsUpper))
            {
                Console.WriteLine(" Your password has upper case, good work");

            }
            else if (passWord1 == passWord2 && passWord2.Any(char.IsDigit))
            {
                Console.WriteLine("Password has digit and match with first password");

            }
            else
            {
                Console.WriteLine("Password does not satisfy the requiremenst");
                Console.WriteLine(" Press any key to exit ");
                Console.ReadKey();

            }


            //------- Loops ---------

            //(Balazs)
            //1. while loop
            //a) explanation:  while loop execute the statement until it is valid
            //b) example code (loop while meaning of life is != 42 )
            int meaning_of_life = 52;
           while ( meaning_of_life != 42)
           {
            meaning_of_life --;
            Console.WriteLine("going backwards until 42");
           }

              



            //(jordan)
            //2. Do While 
            //a) explanation:

            /* Do while is used when we need to execute the code within the while block atleast once before the
             * Boolean condition is evaluated. the statements within the loop will continue execute until the
             * boolean condition evaluates 
             * 
             * do{//dosomething}while(True);
             */
            //b) example code (loop while meaning of life is != 42 )
            int meaningOfLife = 50;
            do
            {
                meaningOfLife--;
            } while (meaningOfLife != 42);


            // (Hoang)
            //3. For loop
            //a) explanation : very useful for arrays, things with a predetermined size
            //b) example code (100 iterations, number starts at 1, triple it, then half it) 

            int k = 1;
            for (int p = 0; p < 100; p++)
            {
                k *= 3;
                k /= 2;
                Console.WriteLine(k);
            }

            //(first in firrst serve)
            //4, Foreach
            //a) explanation
            //  Allows you to go through the elements of a collection. e.g lists & maps
            //b) example code (iterate through each char in "HiPpoPlatyroo", then output how many vowels in the word  )


            string letters = "HiPpoPlatyrOo";
            string vowels = "aeiou";
            string tempLetters = letters.ToLower();
            int vowelQuantity = 0;

            foreach (char c in tempLetters)
            {
                foreach (char c2 in vowels)
                {
                    if (c2 == c)
                    {
                        vowelQuantity++;
                        break;
                    }
                }
            }

            Console.WriteLine(vowelQuantity);






            // resource -> https://www.w3schools.com/cs/cs_arrays.php
            // resource -> https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays (i like this one a little better)
            // ----- Arrays ----
            //1. Create an Array of intigers          


            //2. Create an Array of strings : 
            string[] cars = { "Toyota", "BMW", "Mazda" };

            //3. Create a 2d Array of intigers size 20x20

            //a jagged array is like having an array of arrays, for each element we are using another array inside.

            //4. Create a list of boolean

            //5. explain the difference between list and array


            // ----- Nested Loops ----
            //1.
            // from the 2d array from earlier, assign random values between 1 and 100

            //example code for random


            //
            //2.
            //from the 2d array from earlier, find the average.


            //using multidensional arrays can be used for all sorts of things, such as AI, Data Science, Game matrix tables, Path finding, etc




        }
    }
}