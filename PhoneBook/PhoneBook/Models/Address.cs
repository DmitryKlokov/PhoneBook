namespace PhoneBook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Address")]
    public partial class Address
    {
        [Column(TypeName = "text")]
        [Required]
        public string AddressA { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string DesctiptionAddress { get; set; }

        [Key]
        public int IdAddress { get; set; }

        public int? IdPerson { get; set; }

        public virtual Person Person { get; set; }
    }
}
