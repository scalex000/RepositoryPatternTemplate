using Microsoft.EntityFrameworkCore;
using Sofymatic.Repository.Core.Domain;
using Sofymatic.Repository.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using(var unitOfWork = new UnitOfWork(new SofymaticContext()))
            {

                //example 1
                //Console.WriteLine("Add Customer");
                //unitOfWork.Customers.Add(new Customer()
                //{
                //    Name = "Guillermo",
                //    LastName = "Aquino"
                //});
                //Console.WriteLine("Save Customer");
                //unitOfWork.Complete();
                //var custom = unitOfWork.Customers.Get(1);

                var found = unitOfWork.Customers.Find(c => c.LastName == "Aquino").ToList();
                Console.WriteLine(found.FirstOrDefault().Name);
                Console.ReadLine();

                var found1 = unitOfWork.Customers.Find(c => c.LastName == "Aquino").ToList();
                Console.WriteLine(found1.FirstOrDefault().Name);
                Console.ReadLine();

                var found2 = unitOfWork.Customers.Find(c => c.LastName == "Julio").ToList();
                Console.WriteLine(found2.FirstOrDefault().Name);
                Console.ReadLine();

                Console.WriteLine("Get all Customer");
                var customers = unitOfWork.Customers.GetAll();
                foreach(var customer in customers)
                {
                    Console.WriteLine($"CustomerId={customer.CustomerId}, Name={customer.Name}, LastName={customer.LastName}");
                }

                
                Console.ReadKey();
            }
        }
    }
}
