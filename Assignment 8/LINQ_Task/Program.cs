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

            
            //3 - Get all products that belong to a category named "Mountain Bikes".
            var CategoryNAME = "Mountain Bikes";sa
            var ProductsInCategory = context.Products.Where(e => e.Category.CategoryName == CategoryNAME);
            foreach (var item in ProductsInCategory)
            {
                Console.WriteLine($"Product ID: {item.ProductId}, Product Name: {item.ProductName}, Category name: {}");
            }



            //4 - Count the total number of orders per store.
            //5 - List all orders that have not been shipped yet(shipped_date is null).
            //6 - Display each customer’s full name and the number of orders they have placed.
            //7 - List all products that have never been ordered(not found in order_items).
            //8 - Display products that have a quantity of less than 5 in any store stock.
            //9 - Retrieve the first product from the products table.
            //10 - Retrieve all products from the products table with a certain model year.
            //11 - Display each product with the number of times it was ordered.
            //12 - Count the number of products in a specific category.
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
