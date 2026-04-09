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

            //Another Way 
            //var result = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);
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

            #region Question10
            //var result = ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(result); 
            #endregion

            #region Question11
            //CHEAPEST
            //var cheapest = ProductList.Min(p=> p.UnitPrice);
            //Console.WriteLine(cheapest);

            //Another Way
            //var cheapest = ProductList.OrderBy(p => p.UnitPrice).Take(1);
            //foreach (var item in cheapest)
            //    Console.WriteLine(item);

            //MOST EXPENSIVE
            //var mostExpensive = ProductList.Max(p=> p.UnitPrice);
            //Console.WriteLine(mostExpensive);

            //Another Way
            //var mostExpensive = ProductList.OrderByDescending(p => p.UnitPrice).Take(1);
            //foreach (var item in mostExpensive)
            //    Console.WriteLine(item); 
            #endregion

            #region Question12
            //var result = ProductList.Select(p => p.Category).Distinct(); 
            #endregion

            #region Question13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB); 
            #endregion

            #region Question14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(list2 , StringComparer.OrdinalIgnoreCase); 
            #endregion

            #region Question15
            //var productDict = ProductList.ToDictionary(p => p.ProductID);

            //var product = productDict[18];
            //Console.WriteLine(product); 
            #endregion

            #region Question16
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 50m);
            //Console.WriteLine(result); 
            #endregion

            #region Question17
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //Console.WriteLine(result); 
            #endregion

            #region Question18
            //var result = Enumerable.Range(1, 12).Select(n => $"{n} * {7} =  {n*7}");
            #endregion

            #region Question19
            //var result = Enumerable.Range(1, 30).Where(n => n % 2 == 0);
            #endregion

            #region Question20
            //var result = ProductList.Take(3).Select(p => p.ProductName).Concat(CustomerList.Take(3).Select(c => c.CompanyName));
            #endregion

            #region Question21
            //var result = ProductList.Select(p => p.ProductName).Zip(CustomerList.Select(c => c.CompanyName), (p,c) => $"({p}) Sold To ({c})");
            #endregion

            //foreach (var item in result)
            //    Console.WriteLine(item);
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
