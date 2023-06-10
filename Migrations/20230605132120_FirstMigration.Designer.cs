﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModelViewController.Context;

#nullable disable

namespace ModelViewController.Migrations
{
    [DbContext(typeof(BooknowDbContext))]
    [Migration("20230605132120_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ModelViewController.Models.Booknow", b =>
                {
                    b.Property<int>("amount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("amount"));

                    b.Property<string>("hotelname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("amount");

                    b.ToTable("Booknows");
                });
#pragma warning restore 612, 618
        }
    }
}
