﻿using InterfaceAbstractDemo1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo1.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db! : " + customer.FirstName + " " +  customer.LastName + " " + customer.NationalityId);

        }
    }
}
