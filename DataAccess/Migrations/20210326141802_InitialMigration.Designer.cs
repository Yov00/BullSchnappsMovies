﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210326141802_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Domain.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Adult")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Backdrop_path")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Original_language")
                        .HasColumnType("TEXT");

                    b.Property<string>("Original_title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Overview")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Popularity")
                        .HasColumnType("TEXT");

                    b.Property<string>("Poster_path")
                        .HasColumnType("TEXT");

                    b.Property<string>("Release_date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Video")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Vote_avarage")
                        .HasColumnType("REAL");

                    b.Property<int>("Vote_count")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
