namespace Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*TODO LIST:
             *
             *  ----- 5min intro/setup -----
             *
             *  compare todo list to Assessment
             *
             *  ----- 25min to go through this -----
             *
             *  1. console in/out
             *  2. variable & operations
             *   a. math on numbers
             *   b. string concatination
             *   c. enums (me don't like this one)
             *   d. understanding scope and object permanance
             *  
             *
             *
             *  ----- 25 min to go through this -----
             *
             *  3. Conditions / logic (if, else if, else, Switch)
             *  4. LOOPS
             *  5. show is alpha num??             
             * 
             *  ----- 5 min Q&A -----
             * 
             *  maybe discuss some programming langauges??
             *  
            */



            //write a Hello message here (hint, you can use ctrl+d to duplicate lines of code for quicker writing)
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World! this is RB here");
            Console.WriteLine("Hello, World! This is Hoang Bao here.");
            Console.WriteLine("Hey peoples.");
            Console.WriteLine("BB is in, Hello everyone");
            




            // Task1. read user input and save to a variable. (ideally use string)
            string a = Console.ReadLine();
            string timsString = Console.ReadLine();
            string questString = Console.ReadLine();
            //task2. ask for a number between 1 and 100
            Console.WriteLine("Enter a number between 1 & 100");
            int numb = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter an int 1 to 100");
            Console.WriteLine("Please enter a number between 1 and 100");
            double number1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter a number between 1 & 100");
            string newNumber = Console.ReadLine();


            // save the string to an intiger
            //int newNumb = int.TryParse(newNumber);
            int newNumberi = int.Parse(newNumber);
            newNumberi = int.Parse(newNumber);

            //double the intiger
            int b = newNumberi * 2;
            
            //output intiger
            Console.WriteLine("newNumberi");

        
            //Task3. string concatination
            //output "your value doubled is: {value}"
            //there is 2 ways to do this. 
            Console.WriteLine("your value doubled is: " + newNumberi);
            Console.WriteLine($"your value doubled is: {newNumberi}" );
            



            //task4. Discuss Variable scope and permanance. 

           

           //---------------------------------------------------------------- newish stuffs

           // Task5: write an if, else if, else statement


           // Task 6, write if statements using ANDs aswell as ORs. 
           //if you want to be fancy, include some nots

           // Task 7 list 3 or 4 loop types (in comments)

           
           //Task 8. Create loop examples from task 7


        }


        static void functionForshiz()
        {
            bool firstBool = true;
            int a = 0;
            if (firstBool)
            { 
                a = 3;
            
            
            }
            else if (!firstBool) 
            {
                a = 4;
            
            }
            else
            {
                
            }




        }




    }
}
