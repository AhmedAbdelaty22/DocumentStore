﻿using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{
    public class DocumentStoreDbContext : DbContext
    {
        public DocumentStoreDbContext(DbContextOptions<DocumentStoreDbContext> options) : base(options)
        {
            // .....
        }

        public DbSet<Document> Documents { get; set; }
        public DbSet<Priority> Priorities { get; set; }
    }
}
