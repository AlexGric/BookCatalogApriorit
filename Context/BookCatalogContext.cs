using BookCatalogApriorit.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalogApriorit.Context
{
    public class BookCatalogContext : DbContext
    {
        public BookCatalogContext(DbContextOptions<BookCatalogContext> options) : base(options)
        {
            // Database.EnsureDeleted(); // on program strart delete database
            Database.EnsureCreated(); // on program strart create database
        }
        public DbSet<Book> Books { set; get; }
        public DbSet<Genre> Genres { get; set; }
    }
}
