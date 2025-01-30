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
            //string[] Words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr" , "cHeRry" };
            //var Result = Words.OrderBy(W =>W.ToLower());
            //foreach (var word in Result)
            //{
            //    Console.WriteLine(word);
            //}


            #endregion
            #region Q3:Sort a list of products by units in stock from highest to lowest.
            //var Result = ProductList.OrderByDescending(P => P.UnitsInStock);
            //Result= from P in ProductList
            //        orderby P.UnitsInStock descending
            //        select P;

            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}


            #endregion
            #region Q4:Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string [] Array = { "zero", "one","two","three","four","five","six","seven","eight","nine" };
            //var Result = Array.OrderBy(D => D.Length).ThenBy(D => D);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Q5:Sort first by word length and then by a case-insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result =words.OrderBy(W=>W.Length)
            //                 .ThenBy(W=>W.ToLower());
            //Result=from W in words
            //       orderby W.Length ,W.ToLower()
            //       select W;
            //foreach (var word in Result)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion
            #region Q6:. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var Result = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);
            //Result=from P in ProductList
            //       orderby P.Category,P.UnitPrice descending
            //       select P;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Q7: Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(W => W.Length)
            //                 .ThenByDescending(W => W.ToLower());
            //Result = from A in Arr
            //         orderby A.Length, A.ToLower() descending
            //         select A;
            //foreach (var word in Result)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion
            #region Q8: Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.Where(A => A[1] == 'i').Reverse();
            //foreach (var A in Result)
            //{
            //    Console.WriteLine(A);
            //}
            #endregion
            #endregion
            #region Transformation Operators
            #region Q1. Return a sequence of just the names of a list of products
            //var Result=ProductList.Select(x => x.ProductName);
            //Result = from P in ProductList
            //         select P.ProductName;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region  Q2:Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var Result =words.Select(word => new
            //{
            //    UpperCase = word.ToUpper(),
            //    LowerCase = word.ToLower()
            //});
            //foreach (var word in Result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region Q3:Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var Result = ProductList.Select(P => new
            //{
            //    P.ProductName,
            //    P.Category,
            //    Price = P.UnitPrice,
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q4: Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Select((A, I) => A == I);
            //foreach (var A in Result)
            //{
            //    Console.WriteLine(A);
            //}

            #endregion
            #region Q5:Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var Result = numbersA.SelectMany(a=>numbersB.Where(b=>a<b),(a,b)=> $"{a} Is Less Than {b}");
            // Result  = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select ($"{a} Is Less Than {b}");
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion
            #region Q6:Select all orders where the order total is less than 500.00.
            //var Result = CustomerList.SelectMany(C => C.Orders).Where(O => O.Total < 500);
            //Result = from C in CustomerList
            //         from O in C.Orders
            //         where O.Total < 500
            //         select O;

            //foreach (var Customer in Result)
            //{
            //    Console.WriteLine(Customer);
            //}

            #endregion
            #region Q7:Select all orders where the order was made in 1998 or later.
            //var Result = CustomerList.SelectMany(C => C.Orders).Where(O => O.OrderDate.Year > 1998);
            //Result = from C in CustomerList
            //         from O in C.Orders
            //         where O.OrderDate.Year >= 1998
            //         select O;

            //foreach (var O in Result)
            //{
            //    Console.WriteLine(O);
            //}
            #endregion
            #endregion

        }
    }
}

