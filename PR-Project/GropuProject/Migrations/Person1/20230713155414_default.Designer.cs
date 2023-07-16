﻿// <auto-generated />
using GropuProject.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GropuProject.Migrations.Person1
{
    [DbContext(typeof(Person1Context))]
    [Migration("20230713155414_default")]
    partial class @default
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("GropuProject.Views.Person1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProPrice")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProQuantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SalesTax")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
