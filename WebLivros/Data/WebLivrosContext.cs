using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebLivros.Models;

namespace WebLivros.Data
{
    public class WebLivrosContext : DbContext
    {
        public WebLivrosContext (DbContextOptions<WebLivrosContext> options)
            : base(options)
        {
        }

        public DbSet<WebLivros.Models.Livro> Livro { get; set; }
    }
}
