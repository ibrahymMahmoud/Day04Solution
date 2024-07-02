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


        }
    }
}
