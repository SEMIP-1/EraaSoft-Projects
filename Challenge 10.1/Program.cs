using Azure;
using Challenge_10._1.Data;
using Challenge_10._1.Models;
using System.Collections.Generic;

namespace Challenge_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ApplicationDbContext context = new ApplicationDbContext();
            var _Customers = context.Customers.AsQueryable();

            _Customers = context.Customers.Where(e=> e.State=="NY");
            #region Challenge1

            //AsQueryable
            //
            //(contains) in C# is (Like) in SQL
            //(them by == (order by)
            //Skip and take
            //
            //(First()) == (Top())
            // ()FirstorDefult
            // Offset fetch == 
            // last or last by
            // single or single 
            //find(primary key)
            ////
            //foreach (var a in _Customers)
            //{
            //    Console.WriteLine($"Id: {a.CustomerId}, Name: {a.FirstName} {a.LastName}");
            //}
            ////1.Select all data from product table
            //var _products = context.Products.AsQueryable();
            //foreach (var a in _products)
            //{
            //    Console.WriteLine($"Product Id: {a.ProductId}, PName: {a.ProductName}, Product Price: {a.ListPrice},Order Items: {a.OrderItems}" +
            //        $"Brand: {a.Brand}");
            //}
            ////2.Order Data By list Price(DESC)
            //_products = context.Products.AsQueryable().OrderByDescending(e=>e.ListPrice);
            //foreach (var a in _products)
            //{
            //    Console.WriteLine($"Product Id: {a.ProductId}, PName: {a.ProductName}, Product Price: {a.ListPrice}");
            //}
            ////3.Select product => 1(5 ways)
            //var _products1 = context.Products.AsQueryable().First(e=>e.ProductId==1);
            //Console.WriteLine(_products);
            //_products = context.Products.AsQueryable().Where(e => e.ProductId == 1);
            //Console.WriteLine(_products);
            //_products = context.Products.Skip(0).Take(1);
            //Console.WriteLine(_products);
            //_products1 = context.Products.Find();
            //Console.WriteLine(_products);
            //_products1 = context.Products.Contains(e=>e.pr);
            //Console.WriteLine(_products);
            //_products1 = context.Products.Contains(e => e.pr);
            //Console.WriteLine(_products); 
            #endregion

            // select(e=>new())
            // distect()
            // joint() join,
            // egerLoading(), lazyLoading()


            #region Challenge2
            ////Challage 2
            //var _products = context.Products;
            ////1.Select Product Name, Category Name => using Join
            //var _productCategory = context.Categories.Join(context.Products,
            //    c=>c.CategoryId,
            //    p=>p.CategoryId,
            //    (c, p) => new
            //    { p.ProductName,
            //    c.CategoryName}) ;
            //foreach (var item in _productCategory)
            //{
            //    Console.WriteLine($"Product Name: {item.ProductName}, Category Name: {item.CategoryName}");
            //}
            //Console.WriteLine("++++++++++++++++++++++++++++++");
            ////2.Select Product Name, Category Name, Brand Name  => Eager loading
            //var _productCategoryBrand = context.Products.Select(e => new
            //{
            //    e.ProductName,
            //    e.Category.CategoryName,
            //    e.Brand.BrandName
            //}
            //);
            //foreach (var item in _productCategoryBrand)
            //{
            //    Console.WriteLine($"Product Name: {item.ProductName}, Category Name: {item.CategoryName}, Brand Name: {item.BrandName}");
            //}
            //Console.WriteLine("++++++++++++++++++++++++++++++");

            ////3.Avg list price in product table in each year
            //var _avgListPrice = context.Products
            //    .GroupBy(e => e.ModelYear).Select(e => new
            //    {
            //        Year = e.Key,
            //        AvgPrice = e.Average(p => p.ListPrice)
            //    });
            //foreach (var item in _avgListPrice) { Console.WriteLine($"Year: {item.Year}, Avg Price: {item.AvgPrice}"); } 
            #endregion


            #region Challenge3
            //Challenge 3







            #endregion
        }
    }
}
