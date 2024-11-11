﻿// <auto-generated />
using System;
using Data_Tutor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data_Tutor.Migrations
{
    [DbContext(typeof(TutorDbContext))]
    [Migration("20241111145932_hehe2")]
    partial class hehe2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data_Tutor.Models.GHCT", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GioHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("SanPhamId")
                        .HasColumnType("int");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GioHangId");

                    b.HasIndex("SanPhamId");

                    b.ToTable("GHCTs");
                });

            modelBuilder.Entity("Data_Tutor.Models.GioHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("GioHangs");
                });

            modelBuilder.Entity("Data_Tutor.Models.HDCT", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("HoaDonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("SanPhamId")
                        .HasColumnType("int");

                    b.Property<decimal?>("TotalMoney")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("HoaDonId");

                    b.HasIndex("SanPhamId");

                    b.ToTable("HDCTs");
                });

            modelBuilder.Entity("Data_Tutor.Models.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("SoldDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("TotalMoney")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("Data_Tutor.Models.SanPham", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SanPhams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Khoai "
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sắn "
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ngô "
                        });
                });

            modelBuilder.Entity("Data_Tutor.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Data_Tutor.Models.GHCT", b =>
                {
                    b.HasOne("Data_Tutor.Models.GioHang", "GioHang")
                        .WithMany("GHCTs")
                        .HasForeignKey("GioHangId");

                    b.HasOne("Data_Tutor.Models.SanPham", "SanPham")
                        .WithMany("GHCTs")
                        .HasForeignKey("SanPhamId");

                    b.Navigation("GioHang");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("Data_Tutor.Models.GioHang", b =>
                {
                    b.HasOne("Data_Tutor.Models.User", "User")
                        .WithOne("GioHang")
                        .HasForeignKey("Data_Tutor.Models.GioHang", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data_Tutor.Models.HDCT", b =>
                {
                    b.HasOne("Data_Tutor.Models.HoaDon", "HoaDon")
                        .WithMany("HDCTs")
                        .HasForeignKey("HoaDonId");

                    b.HasOne("Data_Tutor.Models.SanPham", "SanPham")
                        .WithMany("HDCTs")
                        .HasForeignKey("SanPhamId");

                    b.Navigation("HoaDon");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("Data_Tutor.Models.HoaDon", b =>
                {
                    b.HasOne("Data_Tutor.Models.User", "User")
                        .WithMany("HoaDons")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data_Tutor.Models.GioHang", b =>
                {
                    b.Navigation("GHCTs");
                });

            modelBuilder.Entity("Data_Tutor.Models.HoaDon", b =>
                {
                    b.Navigation("HDCTs");
                });

            modelBuilder.Entity("Data_Tutor.Models.SanPham", b =>
                {
                    b.Navigation("GHCTs");

                    b.Navigation("HDCTs");
                });

            modelBuilder.Entity("Data_Tutor.Models.User", b =>
                {
                    b.Navigation("GioHang");

                    b.Navigation("HoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
