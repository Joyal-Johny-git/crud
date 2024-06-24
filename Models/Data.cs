using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Crud.Models
{
    [Table("Data_table")]
    public class Data
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        public string Department { get; set; }
        public int Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        
    }
}