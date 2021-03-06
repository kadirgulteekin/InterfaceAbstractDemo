using InterfaceAbstractDemo1.Abstract;
using InterfaceAbstractDemo1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

using MernisServiceReference;

namespace InterfaceAbstractDemo1.Adapter
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(customer.NationalityId),customer.FirstName.ToUpper(),customer.LastName.ToUpper(), customer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
