﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vrote_Diana.Data;

#nullable disable

namespace Vrote_Diana.Migrations
{
    [DbContext(typeof(Vrote_DianaContext))]
    partial class Vrote_DianaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Vrote_Diana.Models.Buyer", b =>
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MemberID")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MemberID");

                    b.ToTable("Buyer");
                });

            modelBuilder.Entity("Vrote_Diana.Models.ContactInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("ContactAdress")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ContactInfo");
                });

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

                    b.Property<int?>("MemberID")
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

                    b.HasIndex("MemberID");

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

            modelBuilder.Entity("Vrote_Diana.Models.Member", b =>
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

                    b.ToTable("Member");
                });

            modelBuilder.Entity("Vrote_Diana.Models.Vanzare", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("BuyerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataVanzare")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HomeID")
                        .HasColumnType("int");

                    b.Property<int?>("MemberID")
                        .HasColumnType("int");

                    b.Property<int?>("PretVanzare")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BuyerID");

                    b.HasIndex("HomeID")
                        .IsUnique()
                        .HasFilter("[HomeID] IS NOT NULL");

                    b.HasIndex("MemberID");

                    b.ToTable("Vanzare");
                });

            modelBuilder.Entity("Vrote_Diana.Models.Buyer", b =>
                {
                    b.HasOne("Vrote_Diana.Models.Member", "Member")
                        .WithMany("Buyers")
                        .HasForeignKey("MemberID");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Vrote_Diana.Models.Home", b =>
                {
                    b.HasOne("Vrote_Diana.Models.Location", "Location")
                        .WithMany("Homes")
                        .HasForeignKey("LocationID");

                    b.HasOne("Vrote_Diana.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID");

                    b.Navigation("Location");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Vrote_Diana.Models.Vanzare", b =>
                {
                    b.HasOne("Vrote_Diana.Models.Buyer", "Buyer")
                        .WithMany("Vanzari")
                        .HasForeignKey("BuyerID");

                    b.HasOne("Vrote_Diana.Models.Home", "Home")
                        .WithOne("Vanzare")
                        .HasForeignKey("Vrote_Diana.Models.Vanzare", "HomeID");

                    b.HasOne("Vrote_Diana.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID");

                    b.Navigation("Buyer");

                    b.Navigation("Home");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Vrote_Diana.Models.Buyer", b =>
                {
                    b.Navigation("Vanzari");
                });

            modelBuilder.Entity("Vrote_Diana.Models.Home", b =>
                {
                    b.Navigation("Vanzare");
                });

            modelBuilder.Entity("Vrote_Diana.Models.Location", b =>
                {
                    b.Navigation("Homes");
                });

            modelBuilder.Entity("Vrote_Diana.Models.Member", b =>
                {
                    b.Navigation("Buyers");
                });
#pragma warning restore 612, 618
        }
    }
}
