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
            #region Anonymous Type
            #region with Keyword 
            ////The object That Will be Created from "Anonymous Type" => is an Immutable Object [Cannot Changed ]
            //var employee = new {Id=3333,Name="Nada" };
            ////employee.Id = 50;//not valid 
            //employee = new { Id = 4444, employee.Name };
            //employee = employee with { Id = 4444 };// [Syntax Suger] 
            #endregion
            ///Employee employee = new Employee() {Id =1111,Name="Noura",Salary=20000 };
            ///object  employee = new  { Id = 1111, Name = "Noura", Salary = 20000 }; //not valid 
            ///var employee = new { Id = 1111, Name = "Noura", Salary = 20000 };
            //Console.WriteLine(employee.GetType());//AnonymousType0`3 0 order 3 to number of Attribute 
            //var employee2 = new { Id = 2222, Name = "Nour", Salary = 50_000F };
            //Console.WriteLine(employee2.GetType());
            //var employee03 = new { Id = 3333, Salary = 8000, Name = "Nadeen" };
            //Console.WriteLine(employee03.GetType());//AnonymousType1`3
            //var employee04 = new { id = 3333, Name = "Nadeen" , Salary = 8000 };
            //Console.WriteLine(employee04.GetType());//AnonymousType2`3
            ////The Same AnonymousType as long as :
            ////1. The Same Naming[Case Sensitive]
            ////2. The Same Order 
            ////3. The Same Number 



            #endregion

        }
    }
}
