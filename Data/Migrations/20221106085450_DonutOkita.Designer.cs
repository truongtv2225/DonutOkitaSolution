﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(DonutOkitaContext))]
    [Migration("20221106085450_DonutOkita")]
    partial class DonutOkita
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Data.DomainClass.ChiTietSp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(NEWID())");

                    b.Property<string>("Anh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("GiaBan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DECIMAL(20,0)")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("GiaNhap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DECIMAL(20,0)")
                        .HasDefaultValue(0m);

                    b.Property<Guid?>("IdDongSp")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdMauSac")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdNsx")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSp")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NamBh")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdDongSp");

                    b.HasIndex("IdMauSac");

                    b.HasIndex("IdNsx");

                    b.HasIndex("IdSp");

                    b.ToTable("ChiTietSp", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("145ba541-041b-43fe-be1e-4cc3833789ac"),
                            Anh = "https://cdn.tgdd.vn/Products/Images/42/247364/samsung-galaxy-m53-nau-thumb-600x600.jpg",
                            GiaBan = 200000m,
                            GiaNhap = 900000m,
                            IdDongSp = new Guid("b29ceea6-16a5-4171-9486-621650b569a1"),
                            IdMauSac = new Guid("b29ceea6-16a5-4171-9486-621650b569a2"),
                            IdNsx = new Guid("b29ceea6-16a5-4171-9486-621650b569a3"),
                            IdSp = new Guid("b29ceea6-16a5-4171-9486-621650b569a4"),
                            MoTa = "",
                            NamBh = 2002,
                            SoLuongTon = 50
                        },
                        new
                        {
                            Id = new Guid("8673efa6-de82-4ba0-9b3a-6ee7b18b52c7"),
                            Anh = "https://cdn.tgdd.vn/Products/Images/42/230529/TimerThumb/iphone-13-pro-max-(18).jpg",
                            GiaBan = 200000m,
                            GiaNhap = 900000m,
                            IdDongSp = new Guid("b29ceea6-16a5-4171-9486-621650b569a1"),
                            IdMauSac = new Guid("b29ceea6-16a5-4171-9486-621650b569a8"),
                            IdNsx = new Guid("b29ceea6-16a5-4171-9486-621650b569a3"),
                            IdSp = new Guid("b29ceea6-16a5-4171-9486-621650b569a4"),
                            MoTa = "",
                            NamBh = 2002,
                            SoLuongTon = 50
                        },
                        new
                        {
                            Id = new Guid("3b3339ff-977c-43bf-89ac-1adab4249a47"),
                            Anh = "https://cdn.tgdd.vn/Products/Images/42/251703/oppo-a95-4g-bac-2-600x600.jpg",
                            GiaBan = 200000m,
                            GiaNhap = 900000m,
                            IdDongSp = new Guid("b29ceea6-16a5-4171-9486-621650b569a1"),
                            IdMauSac = new Guid("b29ceea6-16a5-4171-9486-621650b569a9"),
                            IdNsx = new Guid("b29ceea6-16a5-4171-9486-621650b569a3"),
                            IdSp = new Guid("b29ceea6-16a5-4171-9486-621650b569a4"),
                            MoTa = "",
                            NamBh = 2002,
                            SoLuongTon = 50
                        },
                        new
                        {
                            Id = new Guid("f1bd014f-87c6-4f78-af7a-229470672145"),
                            Anh = "https://cdn.tgdd.vn/Products/Images/42/253402/realme-c21-y-blue-600x600.jpg",
                            GiaBan = 200000m,
                            GiaNhap = 900000m,
                            IdDongSp = new Guid("b29ceea6-16a5-4171-9486-621650b569a1"),
                            IdMauSac = new Guid("b29ceea6-16a5-4171-9486-621650b569a9"),
                            IdNsx = new Guid("b29ceea6-16a5-4171-9486-621650b569a3"),
                            IdSp = new Guid("b29ceea6-16a5-4171-9486-621650b569a4"),
                            MoTa = "",
                            NamBh = 2002,
                            SoLuongTon = 50
                        },
                        new
                        {
                            Id = new Guid("cd001834-cc8a-49bb-bd60-1e988b938ccb"),
                            Anh = "https://cdn.tgdd.vn/Products/Images/42/247364/samsung-galaxy-m53-nau-thumb-600x600.jpg",
                            GiaBan = 200000m,
                            GiaNhap = 900000m,
                            IdDongSp = new Guid("b29ceea6-16a5-4171-9486-621650b569a1"),
                            IdMauSac = new Guid("b29ceea6-16a5-4171-9486-621650b569a5"),
                            IdNsx = new Guid("b29ceea6-16a5-4171-9486-621650b569a3"),
                            IdSp = new Guid("b29ceea6-16a5-4171-9486-621650b569a4"),
                            MoTa = "",
                            NamBh = 2002,
                            SoLuongTon = 50
                        },
                        new
                        {
                            Id = new Guid("e1acf252-4aec-4e20-a1bf-1ab75a7ce9f0"),
                            Anh = "https://cdn.tgdd.vn/Products/Images/42/247364/samsung-galaxy-m53-nau-thumb-600x600.jpg",
                            GiaBan = 200000m,
                            GiaNhap = 900000m,
                            IdDongSp = new Guid("b29ceea6-16a5-4171-9486-621650b569a1"),
                            IdMauSac = new Guid("b29ceea6-16a5-4171-9486-621650b569a6"),
                            IdNsx = new Guid("b29ceea6-16a5-4171-9486-621650b569a3"),
                            IdSp = new Guid("b29ceea6-16a5-4171-9486-621650b569a4"),
                            MoTa = "",
                            NamBh = 2002,
                            SoLuongTon = 50
                        });
                });

            modelBuilder.Entity("Data.DomainClass.ChucVu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(NEWID())");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("ChucVu", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b29ceea6-16a5-4171-9486-621650b569a7"),
                            Ma = "NV1",
                            Ten = "Trần Nam"
                        });
                });

            modelBuilder.Entity("Data.DomainClass.CuaHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(NEWID())");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ma")
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("QuocGia")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ThanhPho")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("CuaHang", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b29ceea6-16a5-4171-9486-621650b569a8"),
                            Ma = "CH1",
                            Ten = "Minky Store"
                        });
                });

            modelBuilder.Entity("Data.DomainClass.DongSp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(NEWID())");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("DongSp", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b29ceea6-16a5-4171-9486-621650b569a1"),
                            Ma = "DSP1",
                            Ten = "Iphone"
                        });
                });

            modelBuilder.Entity("Data.DomainClass.GioHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(NEWID())");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("IdKh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdNv")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("DATE");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("DATE");

                    b.Property<string>("Sdt")
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("TenNguoiNhan")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TinhTrang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("IdKh");

                    b.HasIndex("IdNv");

                    b.ToTable("GioHang", (string)null);
                });

            modelBuilder.Entity("Data.DomainClass.GioHangChiTiet", b =>
                {
                    b.Property<Guid>("IdGioHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdChiTietSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DECIMAL(20,0)")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("DonGiaKhiGiam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DECIMAL(20,0)")
                        .HasDefaultValue(0m);

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IdGioHang", "IdChiTietSp");

                    b.HasIndex("IdChiTietSp");

                    b.ToTable("GioHangChiTiet", (string)null);
                });

            modelBuilder.Entity("Data.DomainClass.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(NEWID())");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("IdKh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdNv")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<DateTime?>("NgayNhan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayShip")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("TenNguoiNhan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TinhTrang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("IdKh");

                    b.HasIndex("IdNv");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("Data.DomainClass.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdChiTietSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DECIMAL(20,0)")
                        .HasDefaultValue(0m);

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IdHoaDon", "IdChiTietSp");

                    b.HasIndex("IdChiTietSp");

                    b.ToTable("HoaDonChiTiet", (string)null);
                });

            modelBuilder.Entity("Data.DomainClass.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(NEWID())");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ho")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Ma")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("MatKhau")
                        .HasColumnType("VARCHAR(MAX)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("DATE");

                    b.Property<string>("QuocGia")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sdt")
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("Ten")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TenDem")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ThanhPho")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("KhachHang", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("fdb189b3-75f3-4636-9845-39166bb052c2"),
                            Ma = "KH1",
                            NgaySinh = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Ten = "Ánh"
                        });
                });

            modelBuilder.Entity("Data.DomainClass.MauSac", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(NEWID())");

                    b.Property<string>("Ma")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Ten")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("MauSac", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b29ceea6-16a5-4171-9486-621650b569a2"),
                            Ma = "MS1",
                            Ten = "Đỏ"
                        },
                        new
                        {
                            Id = new Guid("b29ceea6-16a5-4171-9486-621650b569a8"),
                            Ma = "MS1",
                            Ten = "Vàng"
                        },
                        new
                        {
                            Id = new Guid("b29ceea6-16a5-4171-9486-621650b569a9"),
                            Ma = "MS1",
                            Ten = "Tím"
                        },
                        new
                        {
                            Id = new Guid("b29ceea6-16a5-4171-9486-621650b569a5"),
                            Ma = "MS1",
                            Ten = "Trắng"
                        },
                        new
                        {
                            Id = new Guid("b29ceea6-16a5-4171-9486-621650b569a6"),
                            Ma = "MS1",
                            Ten = "Đen"
                        });
                });

            modelBuilder.Entity("Data.DomainClass.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(NEWID())");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ho")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<Guid?>("IdCh")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdCv")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdGuiBc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("MatKhau")
                        .HasColumnType("VARCHAR(MAX)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("DATE");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TenDem")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("IdCh");

                    b.HasIndex("IdCv");

                    b.HasIndex("IdGuiBc");

                    b.ToTable("NhanVien", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8850d2ff-77d5-476e-9123-f1a8864babe2"),
                            DiaChi = "Hà Nội",
                            GioiTinh = "Nam",
                            Ho = "Nguyễn",
                            IdCh = new Guid("b29ceea6-16a5-4171-9486-621650b569a8"),
                            IdCv = new Guid("b29ceea6-16a5-4171-9486-621650b569a7"),
                            Ma = "NV1",
                            MatKhau = "1234",
                            NgaySinh = new DateTime(2022, 11, 6, 15, 54, 49, 711, DateTimeKind.Local).AddTicks(9266),
                            Sdt = "1234",
                            Ten = "Đăng",
                            TenDem = "Viết Hải",
                            TrangThai = 0
                        });
                });

            modelBuilder.Entity("Data.DomainClass.Nsx", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(NEWID())");

                    b.Property<string>("Ma")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Ten")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Nsx", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b29ceea6-16a5-4171-9486-621650b569a3"),
                            Ma = "DSP1",
                            Ten = "Apple"
                        });
                });

            modelBuilder.Entity("Data.DomainClass.SanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(NEWID())");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("SanPham", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b29ceea6-16a5-4171-9486-621650b569a4"),
                            Ma = "SP1",
                            Ten = "Iphone 13 Promax"
                        });
                });

            modelBuilder.Entity("Data.DomainClass.ChiTietSp", b =>
                {
                    b.HasOne("Data.DomainClass.DongSp", "DongSp")
                        .WithMany("ChiTietSps")
                        .HasForeignKey("IdDongSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.DomainClass.MauSac", "MauSac")
                        .WithMany("ChiTietSps")
                        .HasForeignKey("IdMauSac")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.DomainClass.Nsx", "Nsx")
                        .WithMany("ChiTietSps")
                        .HasForeignKey("IdNsx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.DomainClass.SanPham", "SanPham")
                        .WithMany("ChiTietSps")
                        .HasForeignKey("IdSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DongSp");

                    b.Navigation("MauSac");

                    b.Navigation("Nsx");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("Data.DomainClass.GioHang", b =>
                {
                    b.HasOne("Data.DomainClass.KhachHang", "KhachHang")
                        .WithMany("GioHangs")
                        .HasForeignKey("IdKh");

                    b.HasOne("Data.DomainClass.NhanVien", "NhanVien")
                        .WithMany("GioHangs")
                        .HasForeignKey("IdNv");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("Data.DomainClass.GioHangChiTiet", b =>
                {
                    b.HasOne("Data.DomainClass.ChiTietSp", "ChiTietSp")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("IdChiTietSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.DomainClass.GioHang", "GioHang")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("IdGioHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChiTietSp");

                    b.Navigation("GioHang");
                });

            modelBuilder.Entity("Data.DomainClass.HoaDon", b =>
                {
                    b.HasOne("Data.DomainClass.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdKh");

                    b.HasOne("Data.DomainClass.NhanVien", "NhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdNv");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("Data.DomainClass.HoaDonChiTiet", b =>
                {
                    b.HasOne("Data.DomainClass.ChiTietSp", "ChiTietSp")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdChiTietSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.DomainClass.HoaDon", "HoaDon")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChiTietSp");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("Data.DomainClass.NhanVien", b =>
                {
                    b.HasOne("Data.DomainClass.CuaHang", "CuaHang")
                        .WithMany("NhanViens")
                        .HasForeignKey("IdCh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.DomainClass.ChucVu", "ChucVu")
                        .WithMany("NhanViens")
                        .HasForeignKey("IdCv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.DomainClass.NhanVien", "Nhan_Vien")
                        .WithMany("NhanViens")
                        .HasForeignKey("IdGuiBc");

                    b.Navigation("ChucVu");

                    b.Navigation("CuaHang");

                    b.Navigation("Nhan_Vien");
                });

            modelBuilder.Entity("Data.DomainClass.ChiTietSp", b =>
                {
                    b.Navigation("GioHangChiTiets");

                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("Data.DomainClass.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("Data.DomainClass.CuaHang", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("Data.DomainClass.DongSp", b =>
                {
                    b.Navigation("ChiTietSps");
                });

            modelBuilder.Entity("Data.DomainClass.GioHang", b =>
                {
                    b.Navigation("GioHangChiTiets");
                });

            modelBuilder.Entity("Data.DomainClass.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("Data.DomainClass.KhachHang", b =>
                {
                    b.Navigation("GioHangs");

                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("Data.DomainClass.MauSac", b =>
                {
                    b.Navigation("ChiTietSps");
                });

            modelBuilder.Entity("Data.DomainClass.NhanVien", b =>
                {
                    b.Navigation("GioHangs");

                    b.Navigation("HoaDons");

                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("Data.DomainClass.Nsx", b =>
                {
                    b.Navigation("ChiTietSps");
                });

            modelBuilder.Entity("Data.DomainClass.SanPham", b =>
                {
                    b.Navigation("ChiTietSps");
                });
#pragma warning restore 612, 618
        }
    }
}