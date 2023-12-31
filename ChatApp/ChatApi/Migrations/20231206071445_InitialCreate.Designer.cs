﻿// <auto-generated />
using System;
using ChatRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChatApi.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20231206071445_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("ChatEntities.Chats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Chats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Message = "Hello Wolrd!!",
                            SendDate = new DateTime(2023, 12, 6, 10, 14, 45, 30, DateTimeKind.Local).AddTicks(6920),
                            UserName = "MOHAMMED"
                        },
                        new
                        {
                            Id = 2,
                            Message = "Hi Wolrd!!",
                            SendDate = new DateTime(2023, 12, 6, 10, 14, 45, 30, DateTimeKind.Local).AddTicks(6934),
                            UserName = "Manger"
                        },
                        new
                        {
                            Id = 3,
                            Message = "Hello There!!",
                            SendDate = new DateTime(2023, 12, 6, 10, 14, 45, 30, DateTimeKind.Local).AddTicks(6934),
                            UserName = "Fakid"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
