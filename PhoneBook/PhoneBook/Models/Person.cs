namespace PhoneBook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            Addresses = new HashSet<Address>();
            Emails = new HashSet<Email>();
            Phones = new HashSet<Phone>();
        }

        [Key]
        public int IdPerson { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string FirstName { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string LastName { get; set; }

        [Column(TypeName = "text")]
        public string Patronymic { get; set; }

        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Addresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Email> Emails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phone> Phones { get; set; }
    }
}
