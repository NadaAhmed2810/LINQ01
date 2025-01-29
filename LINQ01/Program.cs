﻿using System.Collections;

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
            #region Extension Method 
            //int Number = 12345;
            //int ReverseNumber = IntExtension.Reverse(Number);
            //ReverseNumber = Number.Reverse();
            //Console.WriteLine(ReverseNumber);
            #endregion
            #region LINQ
            //LINQ:Stands for  Language Integrated Query 
            //LINQ:+60 Extension Methods for Built_in In Interface "IEnumerable" into 13 Category 
            //    : Named as "LINQ Operators" Existed in Class "Enumerable"
            //    :Categorized into 13 Categories
            //Use LINQ Operators against Data(Stored in Sequence) ,Regardless Data Store (File,DataBase Provider [SQl Server])
            //Sequence: Is an Object from Class Implement "IEnumerable" interface like list 
            //1. Local Sequence :L2O (Linq to object) L2XML
            //2. Remote Sequence Like Data Base: L2EF

            //List<int> Numbers = new List<int>(10) {1,2,3,4,5,6,7,8,9,10 };
            //var OddNumbers=Numbers.Where(x => x %2!= 0);
            //Numbers.AddRange([11, 12, 13, 14, 15]);
            //foreach (int number in OddNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion
            #region LINQ Syntax
            //List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            #region Fluent Syntax
            ////1.Fluent Syntax  

            ////1.Call LINQ Operator as static method 

            //var OddNumbers = Enumerable.Where(Numbers, n => n % 2 == 1);
            //Numbers.AddRange([11, 12, 13, 14, 15]);

            ////2.Call LINQ Operator as Extension  method 
            //OddNumbers = Numbers.Where(n => n % 2 == 1); 
            #endregion
            #region Query syntax Or Query Expression
            ///Starting With From 
            ///Introducing Range Variable (N) :Represent each and every Element in Input Sequence
            ///Ended By Select or Group By
            /*
             *Select N
             *From Numbers N
             *Where N%2=1
             *
             ***/
            //var OddNumbers=from N in Numbers
            //           where N % 2 ==1 
            //           select N;
            #endregion
            //foreach (int n in OddNumbers)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion
            #region LINQ Execution Way

            #region 1.Differed Execution
            //1.Differed Execution (latest Version of data)
            // List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var OddNumbers = Numbers.Where( n => n % 2 == 1);
            //Numbers.AddRange([11, 12, 13, 14, 15]);
            //foreach (int n in OddNumbers)
            //{
            //    Console.WriteLine(n);
            //} 
            #endregion
            #region Immediate Execution
            //Immediate Execution(Element Operator,Casting Operator,Aggregate Operator
            //.first(),.Count(),.TOList()
            List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var OddNumbers = Numbers.Where(n => n % 2 == 1).ToList();
            Numbers.AddRange([11, 12, 13, 14, 15]);
            foreach (int n in OddNumbers)
            {
                Console.WriteLine(n);
            }
            #endregion

            #endregion
        }
    }
}
