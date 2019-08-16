using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework6LikeLibrary
{
    public partial class Customer
    {
        [Key]
        public int CustomerIdentifier { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        public int? ContactIdentifier { get; set; }

        public int? ContactTypeIdentifier { get; set; }

        [StringLength(60)]
        public string Street { get; set; }

        [StringLength(15)]
        public string City { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        public int? CountryIdentfier { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool? InUse { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual ContactType ContactType { get; set; }

        public virtual Country Country { get; set; }
    }
}
