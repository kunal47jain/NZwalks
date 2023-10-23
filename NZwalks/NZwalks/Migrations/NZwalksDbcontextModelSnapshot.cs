﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NZwalks.Data;

#nullable disable

namespace NZwalks.Migrations
{
    [DbContext(typeof(NZwalksDbcontext))]
    partial class NZwalksDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NZwalks.Model.Domains.Regions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Area")
                        .HasColumnType("float");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Lat")
                        .HasColumnType("float");

                    b.Property<double>("Long")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Population")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("NZwalks.Model.Domains.Walk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Regionid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RegionsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("length")
                        .HasColumnType("float");

                    b.Property<Guid>("walkdifficultyId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RegionsId");

                    b.HasIndex("walkdifficultyId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("NZwalks.Model.Domains.Walkdifficulty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("length")
                        .HasColumnType("float");

                    b.Property<Guid>("walkdifficultyId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Walkdifficultie");
                });

            modelBuilder.Entity("NZwalks.Model.Domains.Walk", b =>
                {
                    b.HasOne("NZwalks.Model.Domains.Regions", "Regions")
                        .WithMany("Walks")
                        .HasForeignKey("RegionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NZwalks.Model.Domains.Walkdifficulty", "Walkdifficulty")
                        .WithMany()
                        .HasForeignKey("walkdifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Regions");

                    b.Navigation("Walkdifficulty");
                });

            modelBuilder.Entity("NZwalks.Model.Domains.Regions", b =>
                {
                    b.Navigation("Walks");
                });
#pragma warning restore 612, 618
        }
    }
}
