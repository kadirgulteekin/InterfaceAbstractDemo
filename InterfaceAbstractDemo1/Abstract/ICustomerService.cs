using InterfaceAbstractDemo1.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace InterfaceAbstractDemo1.Abstract
{
    public interface ICustomerService   //Temel bir Interface görevi görecek.
    {
        void Save(Customer customer);   //İnterface implemantosyonunu yapan herkes bunu kullanmak zorundaır.
    }
}
