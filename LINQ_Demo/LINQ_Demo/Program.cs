using LINQ_Demo.Models;
using Microsoft.EntityFrameworkCore;
using LINQ_Demo.Services;

var connectionString = @"Server=.\\sqlexpress;Database=AdventureWorksLT2019;Trusted_Connection=True;TrustServerCertificate=True;";

var sqlOption = new DbContextOptionsBuilder<AdventureWorksLt2019Context>().UseSqlServer(connectionString).Options;

using var db = new AdventureWorksLt2019Context(sqlOption);

var mod1 = new Module1(db);
mod1.Select();