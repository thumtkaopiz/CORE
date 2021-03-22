﻿// <auto-generated />
using System;
using DATA.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DATA.Migrations
{
    [DbContext(typeof(BaseContext))]
    [Migration("20210322083853_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DATA.Entities.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<int?>("PublisherID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("PublisherID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("DATA.Entities.Publisher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("DATA.Entities.Book", b =>
                {
                    b.HasOne("DATA.Entities.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherID");
                });
#pragma warning restore 612, 618
        }
    }
}
