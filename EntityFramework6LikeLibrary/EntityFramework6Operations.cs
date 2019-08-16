using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework6LikeLibrary
{
    public class EntityFramework6Operations
    {
        public List<CustomerEntity> GetCustomersWithContains(string pContains)
        {
            using (var context = new NorthWindContext())
            {
                var customerData = (
                    from customer in context.Customers
                    join contactType in context.ContactTypes on customer.ContactTypeIdentifier equals contactType.ContactTypeIdentifier
                    join contact in context.Contacts on customer.ContactIdentifier equals contact.ContactIdentifier
                    where customer.CompanyName.StartsWith(pContains) && customer.ContactTypeIdentifier == 5
                    select new CustomerEntity
                    {
                        CustomerIdentifier = customer.CustomerIdentifier,
                        CompanyName = customer.CompanyName,
                        ContactIdentifier = customer.ContactIdentifier,
                        FirstName = contact.FirstName,
                        LastName = contact.LastName,
                        ContactTypeIdentifier = contactType.ContactTypeIdentifier,
                        ContactTitle = contactType.ContactTitle,
                        City = customer.City,
                        PostalCode = customer.PostalCode,
                        CountryIdentifier = customer.CountryIdentfier, 
                        CountyName = customer.Country.CountryName
                    }).ToList();

                return customerData;
            }
        }
    }
}
