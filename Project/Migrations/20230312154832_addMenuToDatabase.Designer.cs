﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Data;

#nullable disable

namespace Project.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230312154832_addMenuToDatabase")]
    partial class addMenuToDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project.Models.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuId"));

                    b.Property<int>("MenuHide")
                        .HasColumnType("int");

                    b.Property<string>("MenuLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuMeta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MenuOrder")
                        .HasColumnType("int");

                    b.HasKey("MenuId");

                    b.ToTable("Menu");
                });
#pragma warning restore 612, 618
        }
    }
}
