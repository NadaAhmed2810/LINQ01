using LINQ01;
using static LINQ01.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Restriction Operators

            #region Q1:Find all products that are out of stock.
            //var Result = ProductList.Where(P => P.UnitsInStock == 0);

            //Result =from P in ProductList
            //        where P.UnitsInStock == 0
            //        select P;

            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}
            #endregion
            #region Q2:. Find all products that are in stock and cost more than 3.00 per unit.
            //var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);
            //Result = from P in ProductList
            //         where P.UnitsInStock > 0 && P.UnitPrice>3
            //         select P;

            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}

            #endregion
            #region Q3. Returns digits whose name is shorter than their value.
            //var Result = (ProductList.Where(P => P.ProductName.Length < P.UnitPrice).Select(P=>P.ProductName.Length)).ToHashSet();
            //Result =(from P in ProductList
            //        where P.ProductName.Length < P.UnitPrice
            //        select P.ProductName.Length).ToHashSet();
            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}


            #endregion
            #endregion
            #region Ordering Operators
            #region Q1:Sort a list of products by name
            //var Result = ProductList.OrderBy(P => P.ProductName);
            //Result=from P in ProductList
            //       orderby P.ProductName
            //       select P;
            //foreach (var Product in Result) {
            //    Console.WriteLine(Product.ProductName);
            //}


            #endregion
            #region Q2: Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //var Result = CustomerList.Order().ToArray();
            //Result=(from C in CustomerList
            //       orderby C.CustomerName
            //       select C).ToArray();
            //foreach (var Customer in Result)
            //{
            //    Console.WriteLine(Customer);
            //}
            #endregion
            #region Sort a list of products by units in stock from highest to lowest.
            //var Result = ProductList.OrderByDescending(P => P.UnitsInStock);
            //Result= from P in ProductList
            //        orderby P.UnitsInStock descending
            //        select P;

            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}


            #endregion
            #endregion

        }
    }
}
