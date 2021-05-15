using System;
using System.ComponentModel.DataAnnotations;

namespace RestApiCRUD.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        [MaxLength(50, ErrorMessage = "Name can only 50 characters long")]
        public string Name { get; set; }
    }
}
