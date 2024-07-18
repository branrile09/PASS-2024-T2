namespace Week7
{

    //revising thorugh functions
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("RB is here as always, READY TO do some Programming");
            Console.WriteLine("Hoang Bao is here feeling very sleep-deprived.");
            Console.WriteLine("Akasha is here for his first PASS session");

            int i = 572941232;


            float a = 36.9f;
            float b = 42.0f;

            float newFloaty = AddNumber(a, b);

            int newInt = AddNumber((int)a, (int)b);

            Console.WriteLine(newFloaty);
            Console.WriteLine(newInt);



            Console.WriteLine(isEven(i));
            //Function/method Description. 
            // code to complete a task
            // re-usable, and dynamic (change inputs to affect output)
            // Accessibility, return type (e.g float, bool, void(none), name, arguments/parameters

            List<int> ints = createList(1);

            //create 1 function, with a return datatype that hasnt been used yet.


            //create an overload for someone-elses function

            Console.WriteLine(FibonacciIterative(100));

            Console.ReadLine();



        }


        //access, return type, name, Parameters
        static int AddNumber(int i, int j)
        {
            //we may want some other code here


            //return value reflective of pre-definied return type
            return i + j;
        }

        static float AddNumber(float i, float j)
        {
            //we may want some other code here


            //return value reflective of pre-definied return type
            return i + j;
        }


        static bool isEven(int i)
        {
            //we may want some other code here

            bool isEvenSteven = i % 2 == 0;

            //return value reflective of pre-definied return type
            return isEvenSteven;
        }


        //we can set default values for param/args
        static List<int> createList(int i, int j = 2, int k = 1, int l = 0)
        {
            return new List<int> { i, j, k, l };
        }

        //ryan
        static int Mymethod(int x , int y)
        {
            return x + y;
        }




        //Akasha
        static string FibonacciIterative(int n)
        {
            string fib = "";
            if (n <= 1) return "";

            int a = 0, b = 1, c = 0;

            for (int i = 2; i <=n; i++)
            {
                c = a + b;
                fib += $"{c},";
                a = b;
                b = c;
            }

            return fib;
        }



        //Bao








    }
}
