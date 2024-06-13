﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using core.Data;

#nullable disable

namespace core.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240611144745_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("core.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("TodoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TodoId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("core.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Todo");
                });

            modelBuilder.Entity("core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "email1@email.com",
                            Lastname = "Lastname 1",
                            Name = "User 1"
                        },
                        new
                        {
                            Id = 2,
                            Email = "email1@email.com",
                            Lastname = "Lastname 2",
                            Name = "User 2"
                        },
                        new
                        {
                            Id = 3,
                            Email = "email1@email.com",
                            Lastname = "Lastname 3",
                            Name = "User 3"
                        },
                        new
                        {
                            Id = 4,
                            Email = "email1@email.com",
                            Lastname = "Lastname 4",
                            Name = "User 4"
                        },
                        new
                        {
                            Id = 5,
                            Email = "email1@email.com",
                            Lastname = "Lastname 5",
                            Name = "User 5"
                        },
                        new
                        {
                            Id = 6,
                            Email = "email1@email.com",
                            Lastname = "Lastname 6",
                            Name = "User 6"
                        },
                        new
                        {
                            Id = 7,
                            Email = "email1@email.com",
                            Lastname = "Lastname 7",
                            Name = "User 7"
                        },
                        new
                        {
                            Id = 8,
                            Email = "email1@email.com",
                            Lastname = "Lastname 8",
                            Name = "User 8"
                        },
                        new
                        {
                            Id = 9,
                            Email = "email1@email.com",
                            Lastname = "Lastname 9",
                            Name = "User 9"
                        },
                        new
                        {
                            Id = 10,
                            Email = "email1@email.com",
                            Lastname = "Lastname 10",
                            Name = "User 10"
                        },
                        new
                        {
                            Id = 11,
                            Email = "email1@email.com",
                            Lastname = "Lastname 11",
                            Name = "User 11"
                        },
                        new
                        {
                            Id = 12,
                            Email = "email1@email.com",
                            Lastname = "Lastname 12",
                            Name = "User 12"
                        },
                        new
                        {
                            Id = 13,
                            Email = "email1@email.com",
                            Lastname = "Lastname 13",
                            Name = "User 13"
                        },
                        new
                        {
                            Id = 14,
                            Email = "email1@email.com",
                            Lastname = "Lastname 14",
                            Name = "User 14"
                        },
                        new
                        {
                            Id = 15,
                            Email = "email1@email.com",
                            Lastname = "Lastname 15",
                            Name = "User 15"
                        },
                        new
                        {
                            Id = 16,
                            Email = "email1@email.com",
                            Lastname = "Lastname 16",
                            Name = "User 16"
                        },
                        new
                        {
                            Id = 17,
                            Email = "email1@email.com",
                            Lastname = "Lastname 17",
                            Name = "User 17"
                        },
                        new
                        {
                            Id = 18,
                            Email = "email1@email.com",
                            Lastname = "Lastname 18",
                            Name = "User 18"
                        },
                        new
                        {
                            Id = 19,
                            Email = "email1@email.com",
                            Lastname = "Lastname 19",
                            Name = "User 19"
                        },
                        new
                        {
                            Id = 20,
                            Email = "email1@email.com",
                            Lastname = "Lastname 20",
                            Name = "User 20"
                        });
                });

            modelBuilder.Entity("core.Models.Comment", b =>
                {
                    b.HasOne("core.Models.Todo", "Todo")
                        .WithMany()
                        .HasForeignKey("TodoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Todo");
                });

            modelBuilder.Entity("core.Models.Todo", b =>
                {
                    b.HasOne("core.Models.User", "User")
                        .WithMany("Tasks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("core.Models.User", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
