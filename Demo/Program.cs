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
        }
    }
}
