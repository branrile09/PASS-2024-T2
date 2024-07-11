namespace Week5
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ISE PASS wk5");

            /*TODO LIST:
             *
             *  ----- 5min intro/setup -----
             *
             *  Hellos,
             *  
             *
             *  ----- 25min to go through this -----
             *
             *  Loop Types recap (2min)
             *  Arrays (15min) from last week
             *  Lists (10min)
             *               
             *  ----- 25min to go through this -----
             *
             *  1. Discuss what is a Function
             *  2. Demonstrate and explain Structure
             *  3. Everyone builds there own function for a different purpose
             *                
             *  ----- 5-10 min Q&A -----
             * 
             *   ask anything
             *               
             *  ----- Next week -----
             *  
             *  revise Functions (Module 5)
             *  Objects and Classes (Module 6)
             *      
             * 
            */

            //first things first, everyone say Hello or share 1 thing. 
            //Console.WriteLine(

            Console.WriteLine("RB says hello, welcome to a late week5***");
            Console.WriteLine("Hello classmates Balazs is here");
            Console.WriteLine("Connor Says Evening, This is my first PASS class");
            Console.WriteLine("Hello. Hoang Bao here.");



            // ----- Arrays ----
            //1. go to Wk4's project to finish Arrays



            // resource -> https://www.w3schools.com/cs/cs_arrays.php
            // resource -> https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays (i like this one a little better)
            // ----- Arrays ----
            //1. Create an Array of intigers          

            //RB
            int[] intigers = { 1,2,3,4,5,6,7,8,9};

            //CR
            int[] CRintergets = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] no = { 0, 1, 2, 3, 4, 5 };
            //2. Create an Array of strings : 
            string[] cars = { "Toyota", "BMW", "Mazda" };
            //CR
            string[] bikes = { "Suzuki", "Royal Enfield", "Triumph" ,"Yamaha", "Harley", "Kawasaki"};

            //3. Create a 2d Array of intigers size 20x20
            int[,] array_2d = new int[20, 20];
            int[,] number =            new int[20, 20]
            ;


            int[,] A = new int[20, 20];            //a jagged array is like having an array of arrays, for each element we are using another array inside.

            int[][] dDJaggedArray = new int[6][];
            dDJaggedArray[0] = new int[4] { 1, 2, 3, 4 };


            //4. Create a list of boolean
            List<bool> list_of_bool = new List<bool>();
            list_of_bool.Add(true);
            list_of_bool.Add(false);
            list_of_bool.Add(true); list_of_bool.Add(false);
            bool newBool = list_of_bool[0];

             

            //5. explain the difference between list and array

            /*
            *Size flexibility
            *Syntax
            *Operations
            *Performance
            *
            */


            List<string> shoppingList = new List<string>() ;
            shoppingList.Add("Avocado");







            // ----- Nested Loops ----


            //1.
            // from the 2d array from earlier, assign random values between 1 and 100
            Random rnd = new Random();
            int month = rnd.Next(1, 13); // creates a number between 1 and 12
            int dice = rnd.Next(1, 7); // creates a number between 1 and 6
            int card = rnd.Next(52); // creates a number between 0 and 51

            int[,] number1 = new int[20,30];

            for (int i = 0; i < 20; i++)
            { 
                for (int j = 0; j < 30; j++) 
                {
                    number1[i, j] = rnd.Next(1,101);
                }
            }



            //
            //2.
            //from the 2d array from earlier, find the average.

            float k = 0;



            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    k += number1[i, j];
                }
            }

            float numberAVG = k / 600.0f;
            Console.WriteLine(numberAVG);

            Console.ReadLine();




            //using multidensional arrays can be used for all sorts of things, such as AI, Data Science, Game matrix tables, Path finding, etc




            // ----- Functions ----
            //Definition: 


            int x = addNumber(3, 4);
            Console.WriteLine(x);


            // resource -> https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions

            // ----- Functions to make/choose from ----
            // 1. calculate average of numbers from an array 
            int[] numbers = { 2, 4, 6, 8, 10 };


            // 2. a function that tells you if the number is even 
            // 3. fibonacci sequence
            // 4. sum of Numbers
            // 5. if the number is prime
            // 6. find the highest prime number
            // 7. reverse string 
            // 8. get number from user


        }


        // accessibility, return type, name, parameters, 
        static void hellowWorld(string name)
        {
            Console.WriteLine($"{name}: Hello World");
            //void has no return type
        }

        // accessibility, return type, name, parameters, 
        static int addNumber(int a, int b)
        {
            return a + b;
        }





    }
}