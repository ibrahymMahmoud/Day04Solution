namespace Demo
{
    internal class Program
    {
        // create function to print shape different number of times
        //static void PrintShape(int count = 5, string shape = "+**+") //if want deafualt prameters
        ///  static void PrintShape(int count , string shape) 
        ///  {
        ///      for (int i = 0; i < count; i++) { 
        ///          Console.WriteLine(shape);
        ///      }
        ///  }
        ///  

        //swap by pass value prameter
        ///    static void SwapingByValue(int y , int x)
        ///    {
        ///        Console.WriteLine("swap - pass by value");
        ///        int temp = y;
        ///        y = x;
        ///        x = temp;
        ///    }
        ///
        ///    static void SwapingByRef(ref int y,ref int x)
        ///    {
        ///        Console.WriteLine("swap- pass by Ref");
        ///        int temp = y;
        ///        y = x;
        ///        x = temp;
        ///    }
        ///    

        //function with Ref prameters
        //create function to sum array elements and change first element
        ///   static int Sum(int[] array) {
        ///       int sum = 0;
        ///       if (array != null) { 
        ///           array[0] = 100;
        ///           for (int i = 0; i < array.Length; i++)
        ///           {
        ///               sum += array[i];
        ///           }
        ///       }
        ///       return sum ;
        ///   
        ///   }
        ///   

        //create function to sum array elements and change on new array element
      ///       static int SumByvalue(int[] array) {
      ///           int sum = 0;
      ///           if (array != null) { 
      ///               array= new [] {3,5,11,14};
      ///               for (int i = 0; i < array.Length; i++)
      ///               {
      ///                   sum += array[i];
      ///               }
      ///           }
      ///           return sum ;
      ///       
      ///       }
      ///
      ///  static int SumByRef(int[] array)
      ///  {
      ///      int sum = 0;
      ///      if (array != null)
      ///      {
      ///          array = new[] { 3, 5, 3, 5 };
      ///          for (int i = 0; i < array.Length; i++)
      ///          {
      ///              sum += array[i];
      ///          }
      ///      }
      ///      return sum;
      ///
      ///  }
        
      ///  //create function take two integer and return sum and mul
         ///  static void calc(int a , int b , out int x , out int y) 
         ///  {
         ///      x=a +b;
         ///      y = a * b;
         ///  
         ///  }
        static void Main(string[] args)
        {
            #region Function(protoType,calling)
            /*why need functions
             *1.don't repeate your code (reusabaility)
             *2.maintainable
             *2.singel responsability (for one task)
             *3.consist of signature and body
             *(name , pramaters , body , return type)*/

            /*can write in function
             * class
             * struct
             * interface
             * Enum*/

            //to call method must create oject of class (class member(static))
            //void --> no return data type

            ///   string FolderPath = "E:\\ROUTE\\back end asp.net\\programming";
            ///          FolderPath = @"E:\ROUTE\back end asp.net\programming";
            ///    // to scape meaning of \ write before it \ as("hi\\hema") or @ before string like(@"hele\ya\yasta")
            ///    

            ///   //call function 
            ///   //PrintShape();//if want to use default prameters
            ///   //PrintShape(5);//if want to use part of default prameters
            ///   PrintShape(5, "-+-+-+-");//pass prameters by the same order
            ///   PrintShape(shape : "+-+-+", count : 5);//pass by prameters name
            ///
            #endregion

            #region function value type prameter
            //prameter of function
            //1.value type
            //2. referance type

            ///    int a = 5;
            ///    int b =8;
            ///    Console.WriteLine(" before swaping");
            ///    Console.WriteLine($" a= {a}");
            ///    Console.WriteLine($" b= {b}");  
            ///    SwapingByValue(a, b);
            ///    Console.WriteLine($" a= {a}");
            ///    Console.WriteLine($" b= {b}");
            ///    SwapingByRef(ref a,ref b);
            ///    Console.WriteLine($" a= {a}");
            ///    Console.WriteLine($" b= {b}");

            #endregion

            #region function Ref type prameter example
            // no different between call by Ref and by value with Ref prameter 
            //but behavior is different
            ///  int[] array = { 1 ,5,8,10,20 };
            ///  int sum = Sum(array);
            ///  Console.WriteLine($"the sum of array : {sum}");
            ///  Console.WriteLine($"the first element in  array : {array[0]}");

            #endregion

            #region function Ref type prameter example2
            /// int[] array = {4,5,11,14,14,14};
            /// Console.WriteLine("with pass by value");
            /// int sum = SumByvalue(array);
            /// Console.WriteLine($" sum of array = {sum}");
            /// Console.WriteLine("display array after pass by value");
            /// for(int i =0 ; i < array.Length; i++)
            ///     Console.WriteLine($" array[{i}]= {array[i]}");
            /// Console.WriteLine("display by Ref");
            /// int sum2 = SumByRef(array);
            /// Console.WriteLine($" sum or array = {sum2}");
            /// for (int i = 0; i < array.Length; i++)
            ///     Console.WriteLine($" array[{i}]= {array[i]}");
            ///
            #endregion

            #region passing by out
              ///   int a = 5; int b=5;
              ///   int x; int y;
              ///   calc(a , b ,out x ,out y  );
              ///   Console.WriteLine(x);
              ///   Console.WriteLine(y);
              ///   calc(a , b ,out _ ,out _  );
                 
            /// if not need out put of function , can instead it put _

            #endregion


        }
    }
}
