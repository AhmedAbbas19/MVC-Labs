using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace aspMVC_lab1.Models.Entities
{
    [Table("Employee")]
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(22)]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
        
        public bool Gender { get; set; }
        
        public int Salary { get; set; }
    }
}