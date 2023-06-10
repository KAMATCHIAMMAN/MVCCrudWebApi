﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModelViewController.Context;

#nullable disable

namespace ModelViewController.Migrations
{
    [DbContext(typeof(BooknowDbContext))]
    partial class BooknowDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ModelViewController.Models.Booknow", b =>
                {
                    b.Property<int>("hotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("hotelId"));

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<string>("hotelname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("hotelId");

                    b.ToTable("Booknows");
                });
#pragma warning restore 612, 618
        }
    }
}
