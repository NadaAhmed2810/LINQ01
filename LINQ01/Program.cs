namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly Typed Local variable
            #region Var
            ////Var : Is a C# keyword [C# 3.0 feature]
            //var Name = "Ahmed";
            ////Compiler Can detect The type of variable on its Initial Value at a complier
            ////Must be Initialized
            ////Can not  be Initialized with Null
            ////After Initialization, We Can not Change the DataType
            ////new object  =>Complier Generate in il
            ////type safe and can not effect on performance 
            //var Employee = new { Id = 10, Name = "Nour" };
            //Console.WriteLine(Employee.Id);
            //Console.WriteLine(Employee.Age);

            #endregion
            #region Dynamic 
            //dynamic; is a c# keyword [C# 4.0 Feature]
            // dynamic Data = "Nada";
            //Complier Will Escape Type Checking at Compilation Timw=e
            //CLR will Resolve the actual type of a Dynamic Variable at Run time and Will be changed Based on assign value 
            // Not must be initialized 
            // Can be initializes with NuLL
            //After Initialization,U Can Change its DataType
            //Data = 10;
            //Data = 10.5;
            //Data = true;
            //Data = 'a';
            //dynamic x = null;
            //Console.WriteLine(x);
            //dynamic Employee = new { Id = 10, Name = "Nour" };
            //Console.WriteLine(Employee.Id);
            //Console.WriteLine(Employee.Age);


            #endregion
            #endregion
        }
    }
}
