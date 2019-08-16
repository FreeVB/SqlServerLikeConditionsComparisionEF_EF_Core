using System.Collections.Generic;
using System.Linq;
using EntityFrameworkCoreLikeLibrary.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.EF;

namespace EntityFrameworkCoreLikeLibrary
{
    public class EntityFrameworkCoreOperations
    {
        public List<CustomerEntity> GetCustomersStartsWithLambda(string pContains)
        {
            using (var context = new NorthWindContext())
            {
                var customerData = (context.Customers
                    .Join(context.ContactType, customer => customer.ContactTypeIdentifier,contactType => contactType.ContactTypeIdentifier,(customer, contactType) => new {customer, contactType}) 
                    .Join(context.Contact, cust => cust.customer.ContactIdentifier, contact => contact.ContactIdentifier,(custContType, contact) => new {item = custContType, contact})
                    .Where(items =>
                        /*
                         * Looking for Marketing managers
                         */
                        items.@item.customer.ContactTypeIdentifier == 5 && 
                        /*
                         * Here is the starts with clause
                         */
                        Functions.Like(items.@item.customer.CompanyName, pContains))

                    .Select(item => new CustomerEntity
                    {
                        CustomerIdentifier = item.@item.customer.CustomerIdentifier,
                        CompanyName = item.@item.customer.CompanyName,
                        ContactIdentifier = item.@item.customer.ContactIdentifier,
                        FirstName = item.contact.FirstName,
                        LastName = item.contact.LastName,
                        ContactTypeIdentifier = item.@item.contactType.ContactTypeIdentifier,
                        ContactTitle = item.@item.contactType.ContactTitle,
                        City = item.@item.customer.City,
                        PostalCode = item.@item.customer.PostalCode,
                        CountryIdentifier = item.@item.customer.CountryIdentfier,
                        CountyName = item.@item.customer.CountryIdentfierNavigation.CountryName
                    })).ToList();

                return customerData;

            }
        }
        public List<CustomerEntity> GetCustomersStartWithLinq(string pContains)
        {
            using (var context = new NorthWindContext())
            {
                var customerData = (
                    from customer in context.Customers
                    join contactType in context.ContactType on customer.ContactTypeIdentifier equals contactType.ContactTypeIdentifier
                    join contact in context.Contact on customer.ContactIdentifier equals contact.ContactIdentifier
                    where Functions.Like(customer.CompanyName, pContains) && customer.ContactTypeIdentifier == 5
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
