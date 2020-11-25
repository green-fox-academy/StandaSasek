﻿// <auto-generated />
using System;
using LibrarianSystem.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibrarianSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LibrarianSystem.Models.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Destroyed")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registered")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RegisteredById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegisteredById");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LibrarianSystem.Models.Entities.Borrow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int?>("BorrowedByClientId")
                        .HasColumnType("int");

                    b.Property<int>("BorrowerClientId")
                        .HasColumnType("int");

                    b.Property<int>("Penalty")
                        .HasColumnType("int");

                    b.Property<DateTime>("PlannedEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("RealEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("BorrowedByClientId");

                    b.ToTable("Borrows");
                });

            modelBuilder.Entity("LibrarianSystem.Models.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CategorizedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CategorizedBookId")
                        .HasColumnType("int");

                    b.Property<int>("CategorizedById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategorizedBookId");

                    b.HasIndex("CategorizedById");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("LibrarianSystem.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Librarian")
                        .HasColumnType("bit");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registered")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LibrarianSystem.Models.Entities.Book", b =>
                {
                    b.HasOne("LibrarianSystem.Models.Entities.User", "RegisteredBy")
                        .WithMany("RegisteredBooks")
                        .HasForeignKey("RegisteredById");

                    b.Navigation("RegisteredBy");
                });

            modelBuilder.Entity("LibrarianSystem.Models.Entities.Borrow", b =>
                {
                    b.HasOne("LibrarianSystem.Models.Entities.Book", "BorrowedBook")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibrarianSystem.Models.Entities.User", "BorrowedByClient")
                        .WithMany("BorrowedBooks")
                        .HasForeignKey("BorrowedByClientId");

                    b.Navigation("BorrowedBook");

                    b.Navigation("BorrowedByClient");
                });

            modelBuilder.Entity("LibrarianSystem.Models.Entities.Category", b =>
                {
                    b.HasOne("LibrarianSystem.Models.Entities.Book", "CategorizedBook")
                        .WithMany("Categories")
                        .HasForeignKey("CategorizedBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibrarianSystem.Models.Entities.User", "CategorizedBy")
                        .WithMany("CategorizedBooks")
                        .HasForeignKey("CategorizedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategorizedBook");

                    b.Navigation("CategorizedBy");
                });

            modelBuilder.Entity("LibrarianSystem.Models.Entities.Book", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("LibrarianSystem.Models.Entities.User", b =>
                {
                    b.Navigation("BorrowedBooks");

                    b.Navigation("CategorizedBooks");

                    b.Navigation("RegisteredBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
