using linq_1.DataSources;
using linq_1.Models;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            //var result = Source.ProductList
            //.OrderByDescending(p => p.UnitPrice).Take(3);

            //foreach (var p in result)
            //Console.WriteLine(p);


            //2.
            //var result = Source.ProductList.Skip(5).Take(5);

            //foreach (var p in result)
            //Console.WriteLine(p);


            //3.
            // var result = Source.ProductList.Where(p => p.UnitPrice < 25)
            //.OrderBy(p => p.UnitPrice);

            //foreach (var p in result)
            //Console.WriteLine(p);


            //4.
            //var result = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category== "Seafood");

            //foreach (var p in result)
            //Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

            //5.
            //int[] ids = { 3, 9, 13, 18 };
            //bool result = ids.Contains(9);

            //Console.WriteLine(result);


            //6.
            //var result = Source.ProductList.GroupBy(p => p.Category);

            //foreach (var group in result)
            //Console.WriteLine($"{group.Key}: {group.Count()}");

            //7.
            //var result = Source.ProductList.GroupBy(p => p.Category);

            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var p in group)
            //    Console.WriteLine(p.ProductName);
            //}


            //8.
            //var result = Source.ProductList.GroupBy(p => p.Category)
            //.Where(g => g.Count() > 3)
            //.Select(g => g.Key);

            //foreach (var p in result)
            //Console.WriteLine(p);


            //9.
            //var result = from c in Source.CustomerList 
            //             group c by c.Country into g
            //             select new
            //             {
            //                 Country = g.Key,
            //                 Count = g.Count(),
            //                 TotalOrderValue = g.SelectMany(c => c.Orders).Sum(o => o.Total)
            //             };

            //foreach (var x in result)
            //    Console.WriteLine($"{x.Country} , {x.Count} , {x.TotalOrderValue}");


            //10.
            //var result = Source.ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(result);


            //11.
            //var min = Source.ProductList.Min(p => p.UnitPrice);
            //Console.WriteLine($"Cheapest: {min}");
            //var max = Source.ProductList.Max(p => p.UnitPrice);
            //Console.WriteLine($"Most Expensive: {max}");


            //12.
            //var result = Source.ProductList.Select(p => p.Category).Distinct();
            //foreach (var c in result)
            //    Console.WriteLine(c);


            //13.
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            //foreach (var n in result)
            //    Console.WriteLine(n);


            //14.
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Select(c => c.ToLower())
            //       .Except(list2.Select(c => c.ToLower()));

            //foreach (var n in result)
            //    Console.WriteLine(n);


            //15.
            // Dictionary<int, Product> productsDictionary =
            //Source.ProductList.ToDictionary(p => p.ProductID);

            // productsDictionary.TryGetValue(18, out Product product);
            // Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");

            //16.
            //var result = Source.ProductList.First(p => p.UnitPrice > 50);
            //Console.WriteLine(result);

            //17.
            //var result = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 5000);
            //if (result == null)
            //    Console.WriteLine("null");
            //else
            //    Console.WriteLine(result);

            //18.
            //var result = Enumerable.Range(1, 12)
            //          .Select(x => x * 7);

            //foreach (var n in result)
            //    Console.WriteLine(n);

            //19.
            //        var result = Enumerable.Range(1, 30)
            //.Where(n => n % 2 == 0);

            //        foreach (var n in result)
            //            Console.WriteLine(n);

            //20.
            //       var result = Source.ProductList.Take(3)
            //.Select(p => p.ProductName)
            //.Concat(Source.CustomerList.Take(3)
            //        .Select(c => c.CustomerName)
            //);

            //       foreach (var name in result)
            //           Console.WriteLine(name);

            //21.
            //        var result = Source.ProductList
            //.Zip(Source.CustomerList,
            //    (p, c) => $"{p.ProductName} sold to {c.CustomerName}");

            //        foreach (var name in result)
            //            Console.WriteLine(name);

            

        }
    }
}
