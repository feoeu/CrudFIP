using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudFIP.Models
{
    public class Medico
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CodigoCRM { get; set; }
        public string EstadoCRM { get; set; }
        public string Especialidade { get; set; }
    }
}