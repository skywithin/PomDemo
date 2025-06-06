﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PomDemo.Data;

#nullable disable

namespace PomDemo.Migrations
{
    [DbContext(typeof(ServersDbContext))]
    partial class ServerManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PomDemo.Models.Server", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Servers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Toronto",
                            IsOnline = true,
                            Name = "Server1"
                        },
                        new
                        {
                            Id = 2,
                            City = "Toronto",
                            IsOnline = true,
                            Name = "Server2"
                        },
                        new
                        {
                            Id = 3,
                            City = "Toronto",
                            IsOnline = false,
                            Name = "Server3"
                        },
                        new
                        {
                            Id = 4,
                            City = "Toronto",
                            IsOnline = false,
                            Name = "Server4"
                        },
                        new
                        {
                            Id = 5,
                            City = "Montreal",
                            IsOnline = false,
                            Name = "Server5"
                        },
                        new
                        {
                            Id = 6,
                            City = "Montreal",
                            IsOnline = false,
                            Name = "Server6"
                        },
                        new
                        {
                            Id = 7,
                            City = "Montreal",
                            IsOnline = true,
                            Name = "Server7"
                        },
                        new
                        {
                            Id = 8,
                            City = "Ottawa",
                            IsOnline = false,
                            Name = "Server8"
                        },
                        new
                        {
                            Id = 9,
                            City = "Ottawa",
                            IsOnline = true,
                            Name = "Server9"
                        },
                        new
                        {
                            Id = 10,
                            City = "Calgary",
                            IsOnline = false,
                            Name = "Server10"
                        },
                        new
                        {
                            Id = 11,
                            City = "Calgary",
                            IsOnline = false,
                            Name = "Server11"
                        },
                        new
                        {
                            Id = 12,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server12"
                        },
                        new
                        {
                            Id = 13,
                            City = "Halifax",
                            IsOnline = false,
                            Name = "Server13"
                        },
                        new
                        {
                            Id = 14,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server14"
                        },
                        new
                        {
                            Id = 15,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server15"
                        },
                        new
                        {
                            Id = 16,
                            City = "Halifax",
                            IsOnline = false,
                            Name = "Server16"
                        },
                        new
                        {
                            Id = 17,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server17"
                        },
                        new
                        {
                            Id = 18,
                            City = "Halifax",
                            IsOnline = false,
                            Name = "Server18"
                        },
                        new
                        {
                            Id = 19,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server19"
                        },
                        new
                        {
                            Id = 20,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server20"
                        },
                        new
                        {
                            Id = 21,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server21"
                        },
                        new
                        {
                            Id = 22,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server22"
                        },
                        new
                        {
                            Id = 23,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server23"
                        },
                        new
                        {
                            Id = 24,
                            City = "Halifax",
                            IsOnline = false,
                            Name = "Server24"
                        },
                        new
                        {
                            Id = 25,
                            City = "Halifax",
                            IsOnline = false,
                            Name = "Server25"
                        },
                        new
                        {
                            Id = 26,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server26"
                        },
                        new
                        {
                            Id = 27,
                            City = "Halifax",
                            IsOnline = false,
                            Name = "Server27"
                        },
                        new
                        {
                            Id = 28,
                            City = "Halifax",
                            IsOnline = false,
                            Name = "Server28"
                        },
                        new
                        {
                            Id = 29,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server29"
                        },
                        new
                        {
                            Id = 30,
                            City = "Halifax",
                            IsOnline = false,
                            Name = "Server30"
                        },
                        new
                        {
                            Id = 31,
                            City = "Halifax",
                            IsOnline = false,
                            Name = "Server31"
                        },
                        new
                        {
                            Id = 32,
                            City = "Halifax",
                            IsOnline = false,
                            Name = "Server32"
                        },
                        new
                        {
                            Id = 33,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server33"
                        },
                        new
                        {
                            Id = 34,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server34"
                        },
                        new
                        {
                            Id = 35,
                            City = "Halifax",
                            IsOnline = false,
                            Name = "Server35"
                        },
                        new
                        {
                            Id = 36,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server36"
                        },
                        new
                        {
                            Id = 37,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server37"
                        },
                        new
                        {
                            Id = 38,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server38"
                        },
                        new
                        {
                            Id = 39,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server39"
                        },
                        new
                        {
                            Id = 40,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server40"
                        },
                        new
                        {
                            Id = 41,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server41"
                        },
                        new
                        {
                            Id = 42,
                            City = "Halifax",
                            IsOnline = false,
                            Name = "Server42"
                        },
                        new
                        {
                            Id = 43,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server43"
                        },
                        new
                        {
                            Id = 44,
                            City = "Halifax",
                            IsOnline = false,
                            Name = "Server44"
                        },
                        new
                        {
                            Id = 45,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server45"
                        },
                        new
                        {
                            Id = 46,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server46"
                        },
                        new
                        {
                            Id = 47,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server47"
                        },
                        new
                        {
                            Id = 48,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server48"
                        },
                        new
                        {
                            Id = 49,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server49"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
