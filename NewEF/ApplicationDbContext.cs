using Microsoft.EntityFrameworkCore;
using NewEF.Configration;
using NewEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEF
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFCore; Integrated Security = True");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // anthor way to tell EF  translate tis class to a table in DB
            modelBuilder.Entity<AuditEntry>();


            //----------------------


            //    // flount API ==> make code more clean  
            //    modelBuilder.Entity<Blog>()
            //        .Property(m => m.URL
            //        .IsRequired();

            new BlogEntityConfig().Configure(modelBuilder.Entity<Blog>());

            //------------------------
             
            //use flount API to drop table from DB
          //  modelBuilder.Ignore<Posts>();


            //---------------------------

            //table Blog still in DB but the EF not listen to any changes 
            //will made on it 

            modelBuilder.Entity<Blog>().ToTable("Blogs" , b =>b.ExcludeFromMigrations());


            //-------------------------------

            //To chang table name in DB by flount API
            //  modelBuilder.Entity<Posts>().ToTable("MyPosts");

            modelBuilder.Entity<Posts>()
                .ToTable("Posts", schema: "blogging");


            modelBuilder.HasDefaultSchema("blogging");
            //-------------------------



        }

        // EF start to translate tis class to a table in DB
        public DbSet<Blog> Blogs { get; set; }

    }
}
