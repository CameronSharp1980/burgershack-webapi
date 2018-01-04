using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using burgershack_c.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace burgershack_c
{
    public class Program
    {

        //VERY VERY VERY BAD NEVER DO THIS-----------------
        // public static List<IMenuItem> Burgers = new List<IMenuItem>() {
        //         new Burger() {
        //             Id = 1,
        //             Name = "Straight Up",
        //             Description = "A plain old burger seasoned to perfection",
        //             Price = 9.99 },
        //         new Burger() {
        //             Id = 2,
        //             Name = "Cheese Burger",
        //             Description = "Straight up with cheese, (Choose One: Provolone, Gouda, Munster, Swiss, Cheddar, Merican)",
        //             Price = 10.99 } };

        // public static List<IMenuItem> Drinks = new List<IMenuItem>() {
        //         new Drink() {
        //             Id = 1,
        //             Name = "Pepsi",
        //             Description = "Pepsi Cola",
        //             Price = 1.99 },
        //         new Drink() {
        //             Id = 2,
        //             Name = "Mountain Dew",
        //             Description = "Mountain Dew",
        //             Price = 2.99 } };

        // public static List<IMenuItem> Sides = new List<IMenuItem>() {
        //         new Side() {
        //             Id = 1,
        //             Name = "French Fries",
        //             Description = "French Fries",
        //             Price = 2.99 },
        //         new Side() {
        //             Id = 2,
        //             Name = "Chili Cheese Fries",
        //             Description = "French Fries with Chili and Cheese",
        //             Price = 4.99 } };

        //------------------------------------------------

        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
