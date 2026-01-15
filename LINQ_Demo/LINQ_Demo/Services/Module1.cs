using LINQ_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demo.Services
{
    public class Module1
    {
        private readonly AdventureWorksLt2019Context db;

        public Module1(AdventureWorksLt2019Context _db)
        {
            db = _db;
        }

        public void Select()
        {
            TableHelper tableHelper = new();

            // SELECT * FROM SalesLT.Product;

            var q1ms = db.Products.ToList();
            var q1qs = (from p in db.Products select p).ToList();

            //tableHelper.Print("1. Select All", q1qs.Take(5));

            //var q2ms = db.Products.Select(p=> new
            //{
            //    p.Name,
            //    p.ListPrice,
            //    p.StandardCost
            //}).ToList();

            //tableHelper.Print("2. Select specifig", q2ms.Take(10));

            //var q3ms = db.Customers.Select(p => new
            //{
            //    FullName = (p.FirstName + " " + p.MiddleName + " " + p.LastName),
            //    p.EmailAddress,
            //    p.Phone
            //}).ToList();

            //tableHelper.Print("3. Select specifig", q3ms.Take(10));



            //SELECT Name AS ProductName, ListPrice - StandardCost AS Markup FROM SalesLT.Product;

            //var q4ms = db.Products.Select(p => new
            //{
            //    ProductName = p.Name,
            //    TotalPrice = p.ListPrice - p.StandardCost
            //}).ToList();

            //tableHelper.Print("2. Product details", q4ms.Take(10));



            //SELECT ProductNumber, Color, Size, Color + ', ' + Size AS ProductDetails FROM SalesLT.Product;

            //var q5ms = db.Products.Select(p => new
            //{
            //    p.ProductNumber,
            //    p.Color,
            //    p.Size,
            //    Total = p.Color + "," + p.Size
            //}).ToList();

            //tableHelper.Print("5. Product details", q5ms.Take(10));



            //

            //var q6ms = db.Products.Select(p => new
            //{
            //    Product = p.ProductId + "," + p.Name
            //}).ToList();

            //tableHelper.Print("2. Product name ", q6ms);



            //SELECT SellStartDate, CONVERT(nvarchar(30), SellStartDate) AS ConvertedDate, CONVERT(nvarchar(30), SellStartDate, 126) AS ISO8601FormatDate FROM SalesLT.Product;

            //var date = db.Products.Select(p => new
            //{
            //    FormattedDate = p.SellStartDate.ToString(" MM-dd-yyyy")
            //});

            //tableHelper.Print("Date", date);

            //var qcase = db.Products.Select(p => new
            //{
            //    p.Name,
            //    ProductSize = p.Size == "S" ? "Small"
            //                : p.Size == "L" ? "Large"
            //                : p.Size == "M" ? "Medium"
            //                : p.Size == "XL" ? "Extra-Large"
            //                : p.Size ?? "NotA"
            //});

            //tableHelper.Print("Switch", qcase.Take(100));

            // Sorting and Filtering

            //var sortbyName = db.Products.OrderBy(p => p.ListPrice).Select(p => new
            //{
            //    Name = p.Name,
            //    ListPrice = p.ListPrice
            //});

            //tableHelper.Print("ordering", sortbyName);


            var qlms = db.Products
                .Join(db.ProductCategories,


                p => p.ProductCategoryId,
                c => c.ProductCategoryId,
                (p, c) => new
                {
                    ProductName = p.Name,
                    Category = p.ProductCategory
                }
                ).ToList();

            var qlqs = (
                        from p in db.Products
                        join c in db.ProductCategories
                        on
                        p.ProductCategoryId equals c.ProductCategoryId
                        select new { ProductName = p.Name,
                                    Category = p.ProductCategory}
                        ).ToList();
        }
    }
}
