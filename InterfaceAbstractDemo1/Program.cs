using InterfaceAbstractDemo1.Abstract;
using InterfaceAbstractDemo1.Adapter;
using InterfaceAbstractDemo1.Concrete;
using InterfaceAbstractDemo1.Entities;
using System;

namespace InterfaceAbstractDemo1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            BaseCustomerManager baseCustomerManager1 = new NeroCustomerManager(new MernisServiceAdapter());
            baseCustomerManager.Save(new Customer { DateOfBirth = new System.DateTime(1995, 8, 5), FirstName = "Kadir", LastName = "Gültekin", NationalityId = "12345678910" });
            baseCustomerManager1.Save(new Customer { DateOfBirth = new System.DateTime(1995, 5, 27), FirstName = "Kadir", LastName = "Gültekin", NationalityId = "12345678910" });

            Console.ReadLine();   

        }
        
    }
}
