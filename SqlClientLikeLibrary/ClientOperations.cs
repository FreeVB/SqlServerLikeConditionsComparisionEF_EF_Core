using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseConnectionLibrary.ConnectionClasses;
using DataProviderCommandHelpers;

namespace SqlClientLikeLibrary
{
    public class ClientOperations : SqlServerConnection
    {
        public ClientOperations()
        {
            DatabaseServer = "KARENS-PC";
            DefaultCatalog = "NorthWindAzure2";
            
        }
        /*
         * Looking for Marketing managers
         */
        private string SelectStatement() =>
            @"SELECT  Cust.CustomerIdentifier ,
                        Cust.CompanyName ,
                        Contact.FirstName + ' ' + Contact.LastName AS ContactName ,
                        ContactType.ContactTitle ,
                        Devices.PhoneNumber ,
                        PhoneType.PhoneTypeDescription ,
		                Devices.PhoneTypeIdenitfier,
                        Cust.Street ,
                        Cust.City ,
                        Cust.PostalCode ,
                        Countries.CountryName ,
                        Cust.ModifiedDate
                FROM    dbo.Customers AS Cust
                        INNER JOIN dbo.ContactType ON Cust.ContactTypeIdentifier = dbo.ContactType.ContactTypeIdentifier
                        INNER JOIN dbo.Countries   ON Cust.CountryIdentfier = dbo.Countries.id
                        INNER JOIN dbo.Contact     ON Cust.ContactIdentifier = dbo.Contact.ContactIdentifier
                        INNER JOIN dbo.ContactContactDevices AS Devices ON dbo.Contact.ContactIdentifier = Devices.ContactIdentifier
                        INNER JOIN dbo.PhoneType   ON Devices.PhoneTypeIdenitfier = PhoneType.PhoneTypeIdenitfier
                WHERE   ( Cust.CompanyName LIKE @LikeCondition
		                  AND Devices.Active = @Active
                          AND Cust.ContactTypeIdentifier = @ContactType 
                        );";

        public DataTable GetCustomersWithContains(string pContains)
        {
            mHasException = false;
            var table = new DataTable();

            using (var cn = new SqlConnection {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand {Connection = cn, CommandText = SelectStatement() })
                {
                    cmd.Parameters.AddWithValue("@PhoneType", 3);
                    cmd.Parameters.AddWithValue("@Active", 1);
                    cmd.Parameters.AddWithValue("@ContactType", 5);
                    cmd.Parameters.AddWithValue("@ContactId", 2);
                    cmd.Parameters.AddWithValue("@LikeCondition", $"{pContains}%");
                    cn.Open();
                    table.Load(cmd.ExecuteReader());

                }
            }

            return table;
        }
    }
}
