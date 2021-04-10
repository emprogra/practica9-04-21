using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace practica1._9_04.Models
{
    public class Person
    {
        [Key]
        public int Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Direccion { get; set; }
    }
}