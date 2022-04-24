#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BuiXuanToan.Model;

    public class CategoryContext : DbContext
    {
        public CategoryContext (DbContextOptions<CategoryContext> options)
            : base(options)
        {
        }

        public DbSet<BuiXuanToan.Model.Category> Category { get; set; }
        public DbSet<BuiXuanToan.Model.comment> comment { get; set; }
        public DbSet<BuiXuanToan.Model.News> News { get; set; }
    }
