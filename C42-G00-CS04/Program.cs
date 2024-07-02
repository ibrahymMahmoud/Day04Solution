using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C42_G00_CS04
{
    internal class Program
    {

        //Explain the difference between passing (Value type parameters) by value and by reference
        //then write a suitable c# example.
        static void AddOneToPrametersByValue(int x , int y) 
        {
            x = x + 1;
            y=y+1;  
        }
        static void AddOneToPrametersByRef(ref int x,ref int y)
        {
            x = x + 1;
            y = y + 1;
        }

        //Explain the difference between passing (Reference type parameters) by value and by reference
        //then write a suitable c# example.
        static void AddOneArrayElementByValue(int[] array)
        {
            for (int i = 0; i < array?.Length; i++) 
            { 
                array[i] = array[i]+1;
            }
            for (int a = 0; a < array?.Length; a++)
            {
                Console.Write(array[a] + " ");
            }
        }

        //Write a c# Function that accept 4 parameters from user
        //and return result of summation and subtracting of two numbers

        static void Calc (int x, int y , out int sum , out int abs)
        {
            sum = x +y;
            abs = x - y;
        }

        static void AddOneArrayElementByRef( ref int[] array)
        {
            for (int i = 0; i < array?.Length; i++)
            {
                array[i] = array[i]+1;
            }
            for (int a = 0; a < array?.Length; a++)
            {
                Console.Write(array[a] + " ");
            }
        }

        //Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        //Output should be like
        //Enter a number: 25
        //The sum of the digits of the number 25 is: 7

        static int GetSumOfInteger (int number)
        {
            int sum =0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return  sum;

        }

        // Create a function named "IsPrime", which receives an integer number and
        // retuns true if it is prime, or false if it is not:

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            if (number <= 3 )
                return true;

         
            for (int i = 2 ; i < number/2 ; i++ )
            {
                if (number % i == 0 )
                    return false;
            }

            return true;

        }


        static void Main(string[] args)
        {
            #region Q1
            //Explain the difference between passing (Value type parameters) by value and by reference
            //then write a suitable c# example.

            /*
             -in by value
             --When you pass a parameter by value, you are passing a copy of the value of the variable to the method.
             --Changes made to the parameter within the method do not affect the original variable outside the method. 
             -by reference
             --When you pass a parameter by reference, you are passing a reference to the original variable, not a copy of its value.
             --Changes made to the parameter within the method will affect the original variable outside the method.
             */

            ///   int x = 1;
            ///   int y = 1;
            ///   Console.WriteLine($" x = {x} ");
            ///   Console.WriteLine($" y = {y} ");
            ///   Console.WriteLine(" by value");
            ///   AddOneToPrametersByValue(x, y);
            ///   Console.WriteLine($" x = {x} ");
            ///   Console.WriteLine($" y = {y} ");
            ///   Console.WriteLine(" by Ref");
            ///   AddOneToPrametersByRef(ref x,ref y);
            ///   Console.WriteLine($" x = {x} ");
            ///   Console.WriteLine($" y = {y} ");


            #endregion

            #region Q2
            //Explain the difference between passing (Reference type parameters) by value and by reference
            //then write a suitable c# example.

            /*
             -in by value
             --When you pass a parameter by value, you are passing a copy of the reference  method.
             --Changes made to the parameter within the method will affect the original variable outside the method. 
             --because both the method and the caller are referring to the same object in memory
             -by reference
             --When you pass a parameter by reference, you are passing a reference to the method, not a copy of its reference.
             --Changes made to the parameter within the method will affect the original variable outside the method.
             */

            ///  int[] arr = { 1, 1, 1, 1, 1, 1, 1 };
            ///  for (int a = 0; a < arr?.Length; a++)
            ///  {
            ///      Console.Write(arr[a]+" ");
            ///  }
            ///  Console.WriteLine("\nafter pass by value");
            ///  AddOneArrayElementByValue(arr);
            ///  Console.WriteLine("\nafter pass by Reference");
            ///  AddOneArrayElementByRef(ref arr);


            #endregion

            #region Q3
            //Write a c# Function that accept 4 parameters from user
            //and return result of summation and subtracting of two numbers

            /// int x = 10 ; int y = 5;
            /// Calc(x, y, out int sum, out int abs);
            /// Console.WriteLine($"sum = {sum}");
            /// Console.WriteLine($"subtracting = {abs}");


            #endregion

            #region Q4
            //Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Output should be like
            //Enter a number: 25
            //The sum of the digits of the number 25 is: 7

            ///  int num ;
            ///  do
            ///  {
            ///      Console.Write("Enter the number: ");
            ///  } while (!int.TryParse(Console.ReadLine(), out num) || num<=0);
            ///  
            ///  Console.WriteLine("the sum of integer: "+ GetSumOfInteger(num));



            #endregion

            #region Q5
            // Create a function named "IsPrime", which receives an integer number and
            // retuns true if it is prime, or false if it is not:

        ///      int num ;
        ///      do
        ///      {
        ///          Console.Write("Enter the number: ");
        ///      } while (!int.TryParse(Console.ReadLine(), out num) );
        ///      
        ///      Console.WriteLine(" is prime: "+ IsPrime(num));
           
            #endregion


        }
    }
}
