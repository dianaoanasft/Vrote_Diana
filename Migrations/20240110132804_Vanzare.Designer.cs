﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vrote_Diana.Data;

#nullable disable

namespace Vrote_Diana.Migrations
{
    [DbContext(typeof(Vrote_DianaContext))]
    [Migration("20240110132804_Vanzare")]
    partial class Vanzare
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Vrote_Diana.Models.Home", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("AvailabeDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocationID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VanzareID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("LocationID");

                    b.ToTable("Home");
                });

            modelBuilder.Entity("Vrote_Diana.Models.HomeType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Assigned")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("HomeType");
                });

            modelBuilder.Entity("Vrote_Diana.Models.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Vrote_Diana.Models.PossibleBuyer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adress")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PossibleBuyer");
                });

            modelBuilder.Entity("Vrote_Diana.Models.Vanzare", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DataVanzare")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HomeID")
                        .HasColumnType("int");

                    b.Property<int?>("PossibleBuyerID")
                        .HasColumnType("int");

                    b.Property<int?>("PretVanzare")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("HomeID")
                        .IsUnique()
                        .HasFilter("[HomeID] IS NOT NULL");

                    b.HasIndex("PossibleBuyerID");

                    b.ToTable("Vanzare");
                });

            modelBuilder.Entity("Vrote_Diana.Models.Home", b =>
                {
                    b.HasOne("Vrote_Diana.Models.Location", "Location")
                        .WithMany("Homes")
                        .HasForeignKey("LocationID");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Vrote_Diana.Models.Vanzare", b =>
                {
                    b.HasOne("Vrote_Diana.Models.Home", "Home")
                        .WithOne("Vanzare")
                        .HasForeignKey("Vrote_Diana.Models.Vanzare", "HomeID");

                    b.HasOne("Vrote_Diana.Models.PossibleBuyer", "PossibleBuyer")
                        .WithMany()
                        .HasForeignKey("PossibleBuyerID");

                    b.Navigation("Home");

                    b.Navigation("PossibleBuyer");
                });

            modelBuilder.Entity("Vrote_Diana.Models.Home", b =>
                {
                    b.Navigation("Vanzare");
                });

            modelBuilder.Entity("Vrote_Diana.Models.Location", b =>
                {
                    b.Navigation("Homes");
                });
#pragma warning restore 612, 618
        }
    }
}
