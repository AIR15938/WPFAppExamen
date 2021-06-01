using System;
using System.ComponentModel.DataAnnotations;

namespace WPFAppExamen.Model
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }
    }
}
