﻿using Business.Abstract;
using Business.Cocrete;
using DataAccess.Cocrete.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "   /   " + product.CategoryName);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
       
        ;


        }
    }
}

