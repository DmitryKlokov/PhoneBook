namespace PhoneBook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phone")]
    public partial class Phone
    {
        [Column(TypeName = "text")]
        [Required]
        public string NumberPhone { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string DescriptionPhone { get; set; }

        [Key]
        public int IdPhone { get; set; }

        public int? IdPerson { get; set; }

        public virtual Person Person { get; set; }
    }
}
