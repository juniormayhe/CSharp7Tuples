using System;

namespace CSharp7Tuples
{
    class Program
    {

        //if it is not intended to make this method static, you should move it to 
        //the same level where it is being called.
        static (int sum, int count) calculate(int[] values)
        {
            //Create tuple items "sum" and "count" 
            //and assign both items with 0 as default value
            var tuple = (sum: 0, count: 0);

            //loop int array
            foreach (var v in values)
            {
                //you can assign directly a tuple with sum and count calculations
                //tuple = (tuple.sum + v, tuple.count + 1);

                //or you can use a local function
                SumAndCount(v, 1);
            }
            
            //return tuple with final results
            return tuple;

            //creates a local function for sum
            void SumAndCount(int sum, int count)
            {
                Console.WriteLine($"Using SumAndCount(int {sum}, int {count}) local function...");
                tuple.sum += sum;
                tuple.count += count;
            }
        }//calculate


        static void Main(string[] args)
        {
            //declare your array with dummy data
            int[] numbers = { 10, 20, 30, 40, 50 };

            //deconstruct tuple
            var (sum, count) = calculate(numbers);

            Console.WriteLine(@"
   _____  _  _     ______ ___    _______          _           
  / ____|| || |_  |____  / _ \  |__   __|        | |          
 | |   |_  __  _|     / / | | |    | |_   _ _ __ | | ___  ___ 
 | |    _| || |_     / /| | | |    | | | | | '_ \| |/ _ \/ __|
 | |___|_  __  _|   / / | |_| |    | | |_| | |_) | |  __/\__ \
  \_____||_||_|    /_(_) \___/     |_|\__,_| .__/|_|\___||___/
                                           | |                
                                           |_|                
             ");

            Console.WriteLine("C# 7.0 Tuples sample. Don't forget to add in nuget System.ValueType library!\n");
            Console.WriteLine($"We'll compute Sum and Count of these numbers: {String.Join(",",numbers)}:\n");

            Console.WriteLine($"-> Sum is {sum} and the Count is {count}\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
