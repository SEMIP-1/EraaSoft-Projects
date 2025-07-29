using LINQ_Task.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LINQ_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ApplicationDbContext context = new ApplicationDbContext();

            #region Q1_Ans
            //1 - List all customers' first and last names along with their email addresses.
            /*
            var customers = context.Customers;
            foreach (var item in customers)
            {
                Console.WriteLine($"Customer Full Name: {item.FirstName} {item.LastName}, Customer email: {item.Email} ");
            }
            */
            #endregion

            #region Q2_Ans
            //2 - Retrieve all orders processed by a specific staff member(e.g., staff_id = 3).
            /*
            var StaffID = 3;
            var OrdersByStaff = context.Orders.Where(e => e.StaffId == 3); 
            Console.WriteLine($"Orders processed by staff member with ID: {StaffID}");
            foreach (var item in OrdersByStaff)
            {
                Console.WriteLine($"Staff ID: {item.StaffId}, Order ID: {item.OrderId}, Order Date: {item.OrderDate}, Shipped Date: {item.ShippedDate}");
            }
            */
            #endregion

            #region Q3_Ans
            //3 - Get all products that belong to a category named "Mountain Bikes".
            /*
            var CategoryNAME = "Mountain Bikes";
            var ProductsInCategory = context.Products.Where(e => e.Category.CategoryName == CategoryNAME);
            foreach (var item in ProductsInCategory)
            {
                Console.WriteLine($"Product ID: {item.ProductId}, Product Name: {item.ProductName}, Category ID: {item.CategoryId}");
            } 
            */
            #endregion

            #region Q4_Ans
            //4 - Count the total number of orders per store.
            /*
            var totalOrdersPerStore = context.Orders.GroupBy(o => o.StoreId).Select(o=> new 
            {
                StoreId = o.Key,
                TotalOrders = o.Count()
            });
            foreach (var store in totalOrdersPerStore)
                {
                Console.WriteLine($"Store ID: {store.StoreId}, Total Orders: {store.TotalOrders}");
            }
            */
            #endregion

            #region Q5_Ans
            //5 - List all orders that have not been shipped yet(shipped_date is null).
            /*
            var OredersNotShipped = context.Orders.Where(o => o.ShippedDate == null);
            foreach (var item in OredersNotShipped)
            {
                Console.WriteLine($"Order ID: {item.OrderId}, Order Date: {item.OrderDate}, Shipped Date: {item.ShippedDate}");
            } 
            */
            #endregion

            #region Q6_Ans
            //6 - Display each customer’s full name and the number of orders they have placed.
            /*
            var CostomersOrder = context.Orders.Join(
                context.Customers,
                o => o.CustomerId,
                c => c.CustomerId,
                (o, c) => new
                {
                    FullName = $"{c.FirstName} {c.LastName}",
                    OrderCount = context.Orders.Count(x => x.CustomerId == c.CustomerId)
                }
                );
            foreach (var item in CostomersOrder)
            {
                Console.WriteLine($"Customer Full Name: {item.FullName}, Number of Orders: {item.OrderCount}");
            }
            */
            #endregion


            //7 - List all products that have never been ordered(not found in order_items).




            #region Q8_Ans
            //8 - Display products that have a quantity of less than 5 in any store stock.
            /*
            var quantity= 5;
            var ProductsWithLowStock = context.Stocks.Where(p => p.Quantity < quantity);
            foreach (var item in ProductsWithLowStock)
            {
                Console.WriteLine($"Product ID: {item.ProductId}, Total Quantity : {item.Quantity}");
            }
            */
            #endregion

            #region Q9_Ans
            //9 - Retrieve the first product from the products table.
            /*
            var firstProduct = context.Products.FirstOrDefault();
            Console.WriteLine($"First Product ID: {firstProduct.ProductId}, Name: {firstProduct.ProductName}");
            */
            #endregion

            #region Q10_Ans
            //10 - Retrieve all products from the products table with a certain model year.
            /*
            var modelYear = 2016;
            var productsWithModelYear = context.Products.Where(p => p.ModelYear == modelYear);
            foreach (var item in productsWithModelYear)
            {
                Console.WriteLine($"Product ID: {item.ProductId}, Name: {item.ProductName}, Model Year: {item.ModelYear}");
            }
            */
            #endregion

            #region Q11_Ans
            //11 - Display each product with the number of times it was ordered.
            /*
            var productOrderCounts = context.OrderItems
                .GroupBy(oi => oi.ProductId)
                .Select(g => new
                {
                    ProductId = g.Key,
                    OrderCount = g.Count()
                });
            foreach (var item in productOrderCounts)
            {
                Console.WriteLine($"Product ID: {item.ProductId}, Number of Times Ordered: {item.OrderCount}");
            }
            */
            #endregion

            #region Q12_Ans
            //12 - Count the number of products in a specific category.
            /*
            var CategoryNAME = "Mountain Bikes";
            var productCountInCategory = context.Products
                .Where(p => p.Category.CategoryName == CategoryNAME)
                .Count();
            Console.WriteLine($"Number of products in category {CategoryNAME}: {productCountInCategory}");
            */ 
            #endregion

            //13 - Calculate the average list price of products.



            //14 - Retrieve a specific product from the products table by ID.

            //15 - List all products that were ordered with a quantity greater than 3 in any order.

            //16 - Display each staff member’s name and how many orders they processed.

            //17 - List active staff members only(active = true) along with their phone numbers.

            //18 - List all products with their brand name and category name.

            //19 - Retrieve orders that are completed.

            //20 - List each product with the total quantity sold(sum of quantity from order_items).



        }
    }
}
