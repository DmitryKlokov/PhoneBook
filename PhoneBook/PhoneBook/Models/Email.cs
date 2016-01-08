namespace PhoneBook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Email")]
    public partial class Email
    {
        [Column(TypeName = "text")]
        [Required]
        public string EmailAddress { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string DescriptionEmail { get; set; }

        [Key]
        public int IdEmail { get; set; }

        public int? IdPerson { get; set; }

        public virtual Person Person { get; set; }
    }
}
