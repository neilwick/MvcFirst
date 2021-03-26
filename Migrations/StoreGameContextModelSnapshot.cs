﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcFirst.Models;

namespace MvcFirst.Migrations
{
    [DbContext(typeof(StoreGameContext))]
    partial class StoreGameContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("MvcFirst.Models.Game", b =>
                {
                    b.Property<int>("GameID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("PublisherEmail")
                        .HasColumnType("TEXT");

                    b.Property<uint>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecretInformation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasMaxLength(24)
                        .HasColumnType("TEXT");

                    b.HasKey("GameID");

                    b.ToTable("Game");
                });
#pragma warning restore 612, 618
        }
    }
}