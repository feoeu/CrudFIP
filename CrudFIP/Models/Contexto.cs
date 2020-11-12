using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace CrudFIP.Models
{
    public class Contexto : DbContext 
    {
        public DbSet<Medico> Medicos { get; set; }
    }
}