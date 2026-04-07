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
