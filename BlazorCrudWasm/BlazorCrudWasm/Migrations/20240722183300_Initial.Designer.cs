﻿// <auto-generated />
using System;
using BlazorCrudWasm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorCrudWasm.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240722183300_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorCrudWasm.Shared.Entities.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VideoGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Publisher = "CD Project",
                            ReleaseYear = 2024,
                            Title = "CyberPunk 2077"
                        },
                        new
                        {
                            Id = 2,
                            Publisher = "From Software",
                            ReleaseYear = 2020,
                            Title = "Elden Ring"
                        },
                        new
                        {
                            Id = 3,
                            Publisher = "Nintendo",
                            ReleaseYear = 1998,
                            Title = "The lengend of Zelda: Ocarina of Time"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
