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

            //1 - List all customers' first and last names along with their email addresses.
            #region Q1_Ans
            /*
            var customers = context.Customers;
            foreach (var item in customers)
            {
                Console.WriteLine($"Customer Full Name: {item.FirstName} {item.LastName}, Customer email: {item.Email} ");
            }
            */
            #endregion

            //2 - Retrieve all orders processed by a specific staff member(e.g., staff_id = 3).
            #region Q2_Ans
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
            #region Q3_Ans
            /*
            var CategoryNAME = "Mountain Bikes";
            var ProductsInCategory = context.Products.Where(e => e.Category.CategoryName == CategoryNAME);
            foreach (var item in ProductsInCategory)
            {
                Console.WriteLine($"Product ID: {item.ProductId}, Product Name: {item.ProductName}, Category ID: {item.CategoryId}");
            }
            */
            #endregion

            //4 - Count the total number of orders per store.
            #region Q4_Ans
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

            //5 - List all orders that have not been shipped yet(shipped_date is null).
            #region Q5_Ans
            /*
            var OredersNotShipped = context.Orders.Where(o => o.ShippedDate == null);
            foreach (var item in OredersNotShipped)
            {
                Console.WriteLine($"Order ID: {item.OrderId}, Order Date: {item.OrderDate}, Shipped Date: {item.ShippedDate}");
            }
            */
            #endregion

            //6 - Display each customer’s full name and the number of orders they have placed.
            #region Q6_Ans
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
            //ask about this//

            //8 - Display products that have a quantity of less than 5 in any store stock.
            #region Q8_Ans
            /*
            var quantity = 5;
            var ProductsWithLowStock = context.Stocks.Where(p => p.Quantity < quantity);
            foreach (var item in ProductsWithLowStock)
            {
                Console.WriteLine($"Product ID: {item.ProductId}, Total Quantity : {item.Quantity}");
            }
            */
            #endregion

            //9 - Retrieve the first product from the products table.
            #region Q9_Ans
            /*
            var firstProduct = context.Products.FirstOrDefault();
            Console.WriteLine($"First Product ID: {firstProduct?.ProductId}, Name: {firstProduct?.ProductName}");
            */
            #endregion
            
            //10 - Retrieve all products from the products table with a certain model year.
            #region Q10_Ans
            /*
            var modelYear = 2016;
            var productsWithModelYear = context.Products.Where(p => p.ModelYear == modelYear);
            foreach (var item in productsWithModelYear)
            {
                Console.WriteLine($"Product ID: {item.ProductId}, Name: {item.ProductName}, Model Year: {item.ModelYear}");
            }
            */
            #endregion

            //11 - Display each product with the number of times it was ordered.
            #region Q11_Ans
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

            //12 - Count the number of products in a specific category.
            #region Q12_Ans
            /*
            var CategoryNAME1 = "Mountain Bikes";
            var productCountInCategory = context.Products
                .Where(p => p.Category.CategoryName == CategoryNAME1)
                .Count();
            Console.WriteLine($"Number of products in category {CategoryNAME1}: {productCountInCategory}");
            */
            #endregion

            //13 - Calculate the average list price of products.
            #region Q13_Ans
            /*
            var AvreagePrice = context.Products.Average(p => p.ListPrice);
            Console.WriteLine($"Average List Price of Products: {AvreagePrice}");
            */
            #endregion

            //14 - Retrieve a specific product from the products table by ID.
            #region Q14_Ans
            /*
            var SelectedProductId = 5;
            var selectedProduct = context.Products.FirstOrDefault(p => p.ProductId == SelectedProductId);
            //var selectedProduct = context.Products.Where(p=>p.ProductId== SelectedProductId);//won't as it returns a list
            Console.WriteLine($"Product Name: {selectedProduct?.ProductId}");
            */
            #endregion

            //15 - List all products that were ordered with a quantity greater than 3 in any order.
            #region Q15_Ans
            /*
            var quantityThreshold = 3;
            var productsOrderedWithHighQuantity = context.OrderItems
                .Where(oi => oi.Quantity > quantityThreshold)
                .Select(oi => oi.Product)
                .Distinct();
            foreach (var product in productsOrderedWithHighQuantity)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.ProductName}, Quantity Ordered: {product.OrderItems.Sum(oi => oi.Quantity)}");
            }
            */
            #endregion

            //16 - Display each staff member’s name and how many orders they processed. 
            //ask about this//
            #region Q16_Ans
            /*
            var StaffProcessedOrder = context.Orders
                .Select(s =>
                    new
                    {
                        FullName = $"{s.Staff.FirstName} {s.Staff.LastName}",
                        OrderCount = context.Orders.Count(o => o.StaffId == s.StaffId)
                    }
                );
                    .Join
                    (
                        context.Staffs,
                        o => o.StaffId,
                        s => s.StaffId,
                        (o, s) => new
                        {
                            FullName = $"{s.FirstName} {s.LastName}",
                            OrderCount = context.Orders.Count(o => o.StaffId == s.StaffId)
                        }
                    );
            foreach (var item in StaffProcessedOrder)
            {
                Console.WriteLine($"Staff Full Name: {item.FullName}, Number of Orders Processed: {item.OrderCount}");
            }
            */
            #endregion

            //17 - List active staff members only(active = true) along with their phone numbers.
            #region Q17_Ans
            /*
            var ActivStuff = context.Staffs.Where(s => s.Active == 1)
                    .Select
                    (s => new
                    {
                        FullNmae = $"{s.FirstName} {s.LastName}"
                            ,
                        s.Phone
                    }
                    );
            foreach (var item in ActivStuff)
            {
                Console.WriteLine($"Staff Full Name: {item.FullNmae}, Phone: {item.Phone}");
            }
            */
            #endregion

            //18 - List all products with their brand name and category name.
            #region Q18_Ans
            /*
            var productsWithBrandAndCategory = context.Products
                    .Select
                    (p => new
                    {
                        p.ProductId,
                        p.ProductName,
                        BrandName = p.Brand.BrandName,
                        CategoryName = p.Category.CategoryName
                    }
                    ).Distinct();
            foreach (var item in productsWithBrandAndCategory)
            {
                Console.WriteLine($"Product ID: {item.ProductId}, Name: {item.ProductName}, Brand: {item.BrandName}, Category: {item.CategoryName}");
            }
            */
            #endregion

            //19 - Retrieve orders that are completed.
            //ask about this//

            //20 - List each product with the total quantity sold(sum of quantity from order_items).



        }
    }
}
