﻿using Microsoft.EntityFrameworkCore;

namespace KursASPMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>
            options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
