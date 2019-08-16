using System.ComponentModel.DataAnnotations;

namespace EntityFramework6LikeLibrary
{
    public partial class ContactContactDevice
    {
        [Key]
        public int Identifier { get; set; }

        public int? ContactIdentifier { get; set; }

        public int? PhoneTypeIdenitfier { get; set; }

        public string PhoneNumber { get; set; }

        public bool? Active { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual PhoneType PhoneType { get; set; }
    }
}
