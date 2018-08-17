using Microsoft.EntityFrameworkCore;
using nmtLibrary.Domain.Models;
using nmtLibrary.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nmtLibrary.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
        {
        }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Writer> Writers { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
