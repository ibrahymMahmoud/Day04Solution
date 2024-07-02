namespace Demo
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? age { get; set; }

        public Department?Department { get; set; }    
    }
    public class Department 
    {
        public int code { get; set; }
        public string Name { get; set; }
    }

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
        ///  

        //can pass aray as element in call function
        //if their prameter else must write before params
        //(pass first)
        ///  static int Sum(int x , int y , params int[] nums)
        ///  {
        ///      int sum = 0;
        ///      for (int i = 0; i < nums.Length; i++)
        ///      {
        ///
        ///          sum += nums[i];
        ///      }
        ///      return sum;
        ///  }

        static void DoSomeCode()
        {
            int y;
            int x;
            int z;
            y = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            z = y / x;

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            numbers[100] = 1;
        }
        // to make protective code

        static void ProtectiveCode()
        {
            int y;
            int x;
            int z;
            do
            {
                Console.WriteLine("Enter the first number");

            } while (!int.TryParse(Console.ReadLine(), out y));
            do
            {
                Console.WriteLine("Enter the second number");

            } while (!int.TryParse(Console.ReadLine(), out x ) || x==0);
           
            z = y / x;

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            if(numbers?.Length > 100)
                numbers[100] = 1;
        }

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

            #region function params
            /// int[] nums = { 1, 2, 3, 4, 5, 12};
            /// Console.WriteLine(Sum(5,6,7,8,9,10));//pass as params
            /// Console.WriteLine(Sum(5, 6,nums));//pass as array
            /// 
            //                                         0    1    2      3         4
            /// Console.WriteLine("{0},{1},{2},{3},{4}","hello",45,"ahmed","mahmoud","ali");
            ///  Console.Read();

            #endregion

            #region Boxing ans unBoxing
            //Boxing : casting from datatype [value type] to data type [reference type]
            //unBoxing casting from datatype [reference type] to data type [value type]

            /// object obj;
            //declare for reference of type'OBJECT', refering to the default value of reference type null
            //this reference will allocated at stack with size = 4 bytes
            //this reference can refere to an instance of type object [or another type from "object"]

            ///  obj=new object();
            ///  obj = new string("hema");
            ///  obj = "ibrahym";
            ///
            ///  obj = 'A'; // casting from char  [value type ] to object[reference type] ---> Boxing
            ///  obj = 5;   // casting from int   [value type ] to object[reference type] ---> Boxing
            ///  obj = 7.5; // casting from double[value type ] to object[reference type] ---> Boxing
            ///  obj = true;// casting from bool  [value type ] to object[reference type] ---> Boxing  
            ///             //boxing is implicitly
            ///
            ///
            ///  char b = (char)obj;    // casting from object[reference type] to char  [value type ] ---> unBoxing
            ///  int a = (int)obj;      // casting from object[reference type] to int   [value type ] ---> unBoxing
            ///  double y= (double)obj; // casting from object[reference type] to double[value type ] ---> unBoxing
            ///  bool flag = (bool)obj; // casting from object[reference type] to bool  [value type ] ---> unBoxing
            //unboxing is explicitly // unsafe casting

            #endregion

            #region Nullable - value types
            // null is not a valid value for the variables of datatype:value type(struct,enum)
            // Nullable value type : value type + allow null as a valid value

            #region part 1
            ///  //Nullable<int> Age;
            ///  int? age; //syntax suger
            ///  age = null;
            ///  age = 22;
            ///
            ///  //Nullable<decimal> salary;
            ///  decimal? salary = null;
            ///
            ///  salary = null;
            ///  salary = 5_000; 
            #endregion

            #region part2
            ///  int x =5;
            ///  // x:int           -> allow integers only
            ///  // y:Nullable<int> -> allow integers + null
            ///  int? y = x;
            ///
            ///  // casting from int to Nullable<int> implicitly
            ///  // safe casting
            ///  //Console.WriteLine(y);
            ///
            ///  x =(int) y;
            ///  //casting from Nullable<int> to int Explicitly
            ///  //unsafe casting
            ///
            ///  //protective code
            ///  if (y != null || y.HasValue) 
            ///  {
            ///      x = y.Value;
            ///  }
            ///  else
            ///      x = 0;
            ///
            ///  x = y.HasValue ? y.Value : 0;
            ///
            ///  x = y ?? 0;  //?? --> Null coalescing Operator [synatax sugar]

            #endregion


            #endregion

            #region Nullable reference types [ C# 10.0 (2021)]
            ///  //null is a valid value for the variables of dataType:referenceType (class , interface)
            ///  string message01 = null; // null is disable in project -- default
            ///         message01 = null!;// null for business operator (once at this time)
            ///  Console.WriteLine(message01);
            ///
            ///  string ? message02 = null; //? Nullable
            ///  Console.WriteLine(message02);



            #endregion

            #region Null propagation operator

            #region Example01
            ///   int[] ? Numbers = [1,2,3,4,5];
            ///   int ? length = Numbers?.Length ;
            ///
            ///   for (int i = 0; i < Numbers.Length; i++)
            ///       Console.WriteLine(i);


            #endregion

            #region Example02
            ///    Employee employee = new Employee()
            ///    {
            ///        Id = 1,
            ///        Name = "Test",
            ///        age= 30,
            ///        Department = new Department {
            ///            code = 1,
            ///            Name = "hr",
            ///        }
            ///    };
            ///    Console.WriteLine(employee?.Department?.Name ?? "no name");
            ///
            ///    // instead of 
            ///    if (employee != null) {
            ///        if (employee.Department is not null ) {
            ///            if (employee.Department.Name is not null )
            ///            {
            ///                Console.WriteLine(employee.Department.Name);
            ///            }else
            ///                Console.WriteLine("no name");
            ///        }
            ///    }

            #endregion


            #endregion


            #region Exception handling and protective code

          ///  try
          ///  {
          ///      DoSomeCode();
          ///  }
          ///  catch (Exception ex)
          ///  {
          ///      Console.WriteLine(ex.Message);
          ///  }finally
          ///  {
          ///      Console.WriteLine("finally occurs if and not if happen exception");
          ///  }
               /*Exception 
                *   1.SystemException
                *      1.FormatException
                *      2.IndexOutOfRangeException
                *      3.NullReferenceException
                *      4.InvalidOperationException
                *      5.ArithmeticException
                *         5.1 DivideByZeroException
                *         5.2 OverflowException
                *   2.ApplicationException   
                */
            #endregion

        }
    }
}
