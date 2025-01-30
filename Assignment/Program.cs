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
            #endregion

        }
    }
}
