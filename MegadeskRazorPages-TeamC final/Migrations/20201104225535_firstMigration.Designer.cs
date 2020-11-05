﻿// <auto-generated />
using System;
using MegadeskRazorPages.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MegadeskRazorPages.Migrations
{
    [DbContext(typeof(MegadeskRazorPagesContext))]
    [Migration("20201104225535_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MegadeskRazorPages.Models.Desk", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Depth");

                    b.Property<int>("Drawers");

                    b.Property<string>("Material");

                    b.Property<int>("Width");

                    b.HasKey("ID");

                    b.ToTable("Desk");
                });

            modelBuilder.Entity("MegadeskRazorPages.Models.DeskQuote", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BaseDeskPrice");

                    b.Property<string>("Date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("RushDays");

                    b.Property<int>("TotalPrice");

                    b.Property<int?>("deskID");

                    b.HasKey("ID");

                    b.HasIndex("deskID");

                    b.ToTable("DeskQuote");
                });

            modelBuilder.Entity("MegadeskRazorPages.Models.DeskQuote", b =>
                {
                    b.HasOne("MegadeskRazorPages.Models.Desk", "desk")
                        .WithMany()
                        .HasForeignKey("deskID");
                });
#pragma warning restore 612, 618
        }
    }
}
