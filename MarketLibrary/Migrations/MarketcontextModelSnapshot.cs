﻿// <auto-generated />
using System;
using MarketLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MarketLibrary.Migrations
{
    [DbContext(typeof(Marketcontext))]
    partial class MarketcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MarketLibrary.MarketModels.Market", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("code")
                        .HasColumnType("int");

                    b.Property<int>("salary")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("SuperMarket");
                });

            modelBuilder.Entity("MarketLibrary.MarketModels.dropdown", b =>
                {
                    b.Property<int>("Departmentid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MarketID")
                        .HasColumnType("int");

                    b.HasKey("Departmentid");

                    b.HasIndex("MarketID");

                    b.ToTable("Dropdowns");
                });

            modelBuilder.Entity("MarketLibrary.MarketModels.dropdown", b =>
                {
                    b.HasOne("MarketLibrary.MarketModels.Market", null)
                        .WithMany("type")
                        .HasForeignKey("MarketID");
                });

            modelBuilder.Entity("MarketLibrary.MarketModels.Market", b =>
                {
                    b.Navigation("type");
                });
#pragma warning restore 612, 618
        }
    }
}
