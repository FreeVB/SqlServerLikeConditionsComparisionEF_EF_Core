using System.Collections.Generic;
using System.Linq;
using EntityFrameworkCoreLikeLibrary.Models;
using LikeConditionsWithEntityFrameworkCore.Classes;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.EF;

namespace EntityFrameworkCoreLikeLibrary
{
    public class EntityFrameworkCoreOperations
    {
        public List<ContactType> ContactTypesList()
        {
            using (var context = new NorthWindContext())
            {
                var resultsContactTypes = context.ContactType.ToList();
                resultsContactTypes.Insert(0, new ContactType() {ContactTypeIdentifier = 0, ContactTitle = "None"});
                return resultsContactTypes;
            }
        }

        public List<CustomerEntity> GetCustomersStartsWithLambda(LikeOptions pNameCondition, string pName, int pContactType)
        {
            var nameFilter = "";
            switch (pNameCondition)
            {
                case LikeOptions.StartsWith:
                    nameFilter = $"{pName}%";
                    break;
                case LikeOptions.Contains:
                    nameFilter = $"%{pName}%";
                    break;
                case LikeOptions.EndsWith:
                    nameFilter = $"{pName}%";
                    break;

            }
            using (var context = new NorthWindContext())
            {
                var customerData = (
                    from customer in context.Customers
                    join contactType in context.ContactType on customer.ContactTypeIdentifier equals contactType.ContactTypeIdentifier
                    join contact in context.Contact on customer.ContactIdentifier equals contact.ContactIdentifier
                    where Functions.Like(customer.CompanyName, nameFilter)
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

                if (pContactType > 0)
                {
                    customerData = customerData.Where(x => x.ContactTypeIdentifier == pContactType).ToList();
                }
                return customerData;
            }
        }

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
        public List<CustomerEntity> GetCustomersStartWithEndWithLinq(string pCondition)
        {
            using (var context = new NorthWindContext())
            {
                var customerData = (
                    from customer in context.Customers
                    join contactType in context.ContactType on customer.ContactTypeIdentifier equals contactType.ContactTypeIdentifier
                    join contact in context.Contact on customer.ContactIdentifier equals contact.ContactIdentifier
                    where Functions.Like(customer.CompanyName, pCondition) && customer.ContactTypeIdentifier == 5
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
        public List<CustomerEntity> GetCustomersWhereSecondLetterIs(string pCondition)
        {
            using (var context = new NorthWindContext())
            {
                
                var customerData = (
                    from customer in context.Customers
                    join contactType in context.ContactType on customer.ContactTypeIdentifier equals contactType.ContactTypeIdentifier
                    join contact in context.Contact on customer.ContactIdentifier equals contact.ContactIdentifier
                    where Functions.Like(customer.CompanyName, pCondition) 
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

        public List<Customers> GetCustomersWhereNameBeginsWithRange(string pCondition)
        {
            using (var context = new NorthWindContext())
            {

                var customerData = (
                    from customer in context.Customers
                    where Functions.Like(customer.CompanyName, pCondition)
                    select customer
                    
                ).OrderBy(x => x.CompanyName).ToList();

                return customerData;
            }

        }
    }
}
