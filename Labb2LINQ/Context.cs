using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Labb2LINQ
{
    public class Context : DbContext
    {

        public DbSet<Ämne> Ämnen { get; set; }
        public DbSet<Klass> Klasser { get; set; }
        public DbSet<Lärare> lärare { get; set; }
        public DbSet<LärareÄmne> lärareÄmnen { get; set; }
        public DbSet<Student> student { get; set; }
        public DbSet<StudentÄmne> studentÄmne { get; set; }
        public DbSet<StudentLärare> Studentgrupp { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = SPELDATOR; Initial Catalog = Labb2_linq_v5; Integrated Security = True");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            // Relation Lärare - Ämne
            builder.Entity<LärareÄmne>()
                .HasKey(l => new { l.LärarID, l.ÄmneID });
            builder.Entity<LärareÄmne>()
                .HasOne(l => l.lärare)
                .WithMany(l => l.Ämnen)
                .HasForeignKey(l => l.LärarID);

            // Relation Ämne - Lärare
            builder.Entity<LärareÄmne>()
                .HasKey(l => new { l.ÄmneID, l.LärarID });
            builder.Entity<LärareÄmne>()
                .HasOne(l => l.Ämnen)
                .WithMany(l => l.Lärare)
                .HasForeignKey(l => l.ÄmneID);

            // Relation Student - Ämne
            builder.Entity<StudentÄmne>()
                .HasKey(s => new { s.StudentID, s.ÄmneID });
            builder.Entity<StudentÄmne>()
                .HasOne(s => s.student)
                .WithMany(s => s.Ämnen)
                .HasForeignKey(s => s.StudentID);

            // Relation Ämne - Student
            builder.Entity<StudentÄmne>()
                .HasKey(s => new { s.ÄmneID, s.StudentID });
            builder.Entity<StudentÄmne>()
                .HasOne(s => s.ämne)
                .WithMany(s => s.Ämnen)
                .HasForeignKey(s => s.ÄmneID);

            // Relation Student - Lärare
            builder.Entity<StudentLärare>()
                .HasKey(s => new { s.StudentID, s.LärarID });
            builder.Entity<StudentLärare>()
                .HasOne(s => s.student)
                .WithMany(s => s.StudentGrupp)
                .HasForeignKey(s => s.StudentID);

            // Relation Lärare - Student
            builder.Entity<StudentLärare>()
                .HasKey(s => new { s.LärarID, s.StudentID });
            builder.Entity<StudentLärare>()
                .HasOne(s => s.lärare)
                .WithMany(s => s.StudentGrupp)
                .HasForeignKey(s => s.LärarID);






        }
    }
}