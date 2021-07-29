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
            baseCustomerManager.Save(new Customer { DateOfBirth = new System.DateTime(1998, 1, 26), FirstName = "Kadir", LastName = "Gültekin", NationalityId = "57532053752" });
            baseCustomerManager1.Save(new Customer { DateOfBirth = new System.DateTime(1998, 1, 26), FirstName = "Kadir", LastName = "Gültekin", NationalityId = "57532053752" });

            Console.ReadLine();   

        }
        
    }
}
