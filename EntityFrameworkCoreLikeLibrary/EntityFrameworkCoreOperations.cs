using System.Collections.Generic;
using System.Linq;
using EntityFrameworkCoreLikeLibrary.Models;

namespace EntityFrameworkCoreLikeLibrary
{
    public class EntityFrameworkCoreOperations
    {
        public List<CustomerEntity> GetCustomersWithContains(string pContains)
        {
            using (var context = new NorthWindContext())
            {
                var customerData = (
                    from customer in context.Customers
                    join contactType in context.ContactType on customer.ContactTypeIdentifier equals contactType.ContactTypeIdentifier
                    join contact in context.Contact on customer.ContactIdentifier equals contact.ContactIdentifier
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
                        CountyName = customer.CountryIdentfierNavigation.CountryName
                    }).ToList();

                return customerData;
            }
        }
    }
}
