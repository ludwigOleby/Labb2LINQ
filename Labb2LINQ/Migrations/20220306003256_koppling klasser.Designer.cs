﻿// <auto-generated />
using System;
using Labb2LINQ;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Labb2LINQ.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220306003256_koppling klasser")]
    partial class kopplingklasser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Labb2LINQ.Klass", b =>
                {
                    b.Property<int>("KlassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KlassNamn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KlassID");

                    b.ToTable("Klasser");
                });

            modelBuilder.Entity("Labb2LINQ.Lärare", b =>
                {
                    b.Property<int>("LärarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LärarNamn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LärarID");

                    b.ToTable("lärare");
                });

            modelBuilder.Entity("Labb2LINQ.LärareÄmne", b =>
                {
                    b.Property<int>("ÄmneID")
                        .HasColumnType("int");

                    b.Property<int>("LärarID")
                        .HasColumnType("int");

                    b.HasKey("ÄmneID", "LärarID");

                    b.HasIndex("LärarID");

                    b.ToTable("lärareÄmnen");
                });

            modelBuilder.Entity("Labb2LINQ.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KlasserKlassID")
                        .HasColumnType("int");

                    b.Property<string>("StudentNamn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.HasIndex("KlasserKlassID");

                    b.ToTable("student");
                });

            modelBuilder.Entity("Labb2LINQ.StudentÄmne", b =>
                {
                    b.Property<int>("ÄmneID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ÄmneID", "StudentID");

                    b.HasIndex("StudentID");

                    b.ToTable("studentÄmne");
                });

            modelBuilder.Entity("Labb2LINQ.Ämne", b =>
                {
                    b.Property<int>("ÄmneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Namn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ÄmneID");

                    b.ToTable("Ämnen");
                });

            modelBuilder.Entity("Labb2LINQ.LärareÄmne", b =>
                {
                    b.HasOne("Labb2LINQ.Lärare", "lärare")
                        .WithMany("Ämnen")
                        .HasForeignKey("LärarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb2LINQ.Ämne", "Ämnen")
                        .WithMany("Lärare")
                        .HasForeignKey("ÄmneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Labb2LINQ.Student", b =>
                {
                    b.HasOne("Labb2LINQ.Klass", "Klasser")
                        .WithMany()
                        .HasForeignKey("KlasserKlassID");
                });

            modelBuilder.Entity("Labb2LINQ.StudentÄmne", b =>
                {
                    b.HasOne("Labb2LINQ.Student", "student")
                        .WithMany("Ämnen")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb2LINQ.Ämne", "ämne")
                        .WithMany("Ämnen")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
