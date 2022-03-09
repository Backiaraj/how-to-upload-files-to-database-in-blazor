﻿// <auto-generated />
using System;
using Blazor_server_app_5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blazor_server_app_5.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220308123309_Createimgsave")]
    partial class Createimgsave
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blazor_server_app_5.Data.ImgClass", b =>
                {
                    b.Property<int>("Imgid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Img")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Imgname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Imgid");

                    b.ToTable("Saveimg");
                });
#pragma warning restore 612, 618
        }
    }
}