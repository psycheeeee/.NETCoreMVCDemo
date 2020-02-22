﻿// <auto-generated />
using MVCTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCTest.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200222133136_seedMigration")]
    partial class seedMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCTest.Models.StudentModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassName")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("StudentModels");

                    b.HasData(
                        new
                        {
                            id = 1,
                            ClassName = 0,
                            Email = "admin@syinpo.com",
                            Name = "admin"
                        },
                        new
                        {
                            id = 2,
                            ClassName = 0,
                            Email = "psyche@syinpo.com",
                            Name = "psycheeeee"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
