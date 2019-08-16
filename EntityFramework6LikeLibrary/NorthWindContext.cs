using System.Data.Entity;

namespace EntityFramework6LikeLibrary
{
    public partial class NorthWindContext : DbContext
    {
        public NorthWindContext()
            : base("name=NorthWindContextConnection")
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactContactDevice> ContactContactDevices { get; set; }
        public virtual DbSet<ContactType> ContactTypes { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<PhoneType> PhoneTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.Country)
                .HasForeignKey(e => e.CountryIdentfier);
        }
    }
}
