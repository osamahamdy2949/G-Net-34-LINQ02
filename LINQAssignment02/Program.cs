using static LINQ.DataSources.Source;
//using static LINQ.DataSources.Source;

namespace LINQAssignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01
            //var result = ProductList.OrderBy(p => p.UnitPrice).Reverse().Take(3);
            #endregion

            #region Question02
            //Soulution01
            //var result = ProductList.OrderBy(p=>p.ProductName).Skip(5).Take(5);

            //Another Soulution
            //GetProduct(2, 5); 
            #endregion

            #region Question03
            //var result = ProductList.TakeWhile(p => p.UnitPrice < 25).OrderBy(p => p.UnitPrice); 
            #endregion

            #region Question04
            //var result = ProductList.Where(p => p.Category == "Seafood").Any(s => s.UnitsInStock > 0);
            //Console.WriteLine(result);
            #endregion

            #region Question05
            //int[] ids = { 3, 9, 13, 18 };

            //var result = ids.Contains(9);
            //Console.WriteLine(result); 
            #endregion

            #region Question06
            //var result = ProductList.GroupBy(p => p.Category);

            //foreach (var products in result)
            //{
            //    Console.WriteLine($"Category : {products.Key}");
            //    Console.WriteLine($"  Number Of Product : {products.Count()}");

            //    foreach (var item in products)
            //        Console.WriteLine($"     {item}");
            //    Console.WriteLine("-------------------------------------------------------------");
            //}
            #endregion

            #region Question07
            //var groups = ProductList.GroupBy(p => p.Category);

            //foreach (var products in groups)
            //{
            //    Console.WriteLine($"Category : {products.Key}");
            //    Console.WriteLine($"  Number Of Product : {products.Count()}");

            //    var result = products.Select(p => p.ProductName);

            //    foreach (var item in result)
            //        Console.WriteLine($"     {item}");
            //    Console.WriteLine("-------------------------------------------------------------");
            //} 
            #endregion

            #region Question08
            //var result = ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3);
            //foreach (var products in result)
            //{
            //    Console.WriteLine($"Category : {products.Key}");
            //    Console.WriteLine($"  Number Of Product : {products.Count()}");

            //    Console.WriteLine("-------------------------------------------------------------");
            //} 
            #endregion

            #region Question09
            //var result =
            //            from customer in CustomerList
            //            group customer by customer.Country into countryGroup
            //            select new
            //            {
            //                Country = countryGroup.Key,
            //                Count = countryGroup.Count(),
            //                TotalOrderValue = countryGroup.Sum(c => c.Orders.Sum(o => o.Total))
            //            }; 
            #endregion 


            foreach (var item in result)
                Console.WriteLine(item);
        }

        static void GetProduct(int page , int pageSize)
        {
            var result = ProductList.OrderBy(p=> p.ProductName)
                                    .Skip((page - 1) * pageSize)
                                    .Take(pageSize);


            foreach (var item in result)
                Console.WriteLine(item);
        }
    }
}
