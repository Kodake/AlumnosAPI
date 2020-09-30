using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Alumno
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
    }
}
