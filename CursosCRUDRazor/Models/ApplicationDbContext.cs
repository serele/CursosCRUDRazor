using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursosCRUDRazor.Models
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Curso> Curso { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }        
    }
}
