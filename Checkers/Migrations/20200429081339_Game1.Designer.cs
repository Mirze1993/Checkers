﻿// <auto-generated />
using System;
using Checkers.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Checkers.Migrations
{
    [DbContext(typeof(AppContex))]
    [Migration("20200429081339_Game1")]
    partial class Game1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Checkers.DB.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("State");

                    b.Property<int?>("User1Id");

                    b.Property<int?>("User2Id");

                    b.HasKey("Id");

                    b.HasIndex("User1Id");

                    b.HasIndex("User2Id");

                    b.ToTable("games");
                });

            modelBuilder.Entity("Checkers.DB.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Checkers.DB.Game", b =>
                {
                    b.HasOne("Checkers.DB.User", "User1")
                        .WithMany()
                        .HasForeignKey("User1Id");

                    b.HasOne("Checkers.DB.User", "User2")
                        .WithMany()
                        .HasForeignKey("User2Id");
                });
#pragma warning restore 612, 618
        }
    }
}
