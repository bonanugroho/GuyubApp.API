﻿// <auto-generated />
using System;
using GuyubApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GuyubApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190504115229_AddedPengeluaranEntity")]
    partial class AddedPengeluaranEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("GuyubApp.API.Models.Blok", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nama");

                    b.Property<string>("NamaJalan");

                    b.Property<int>("RtId");

                    b.HasKey("Id");

                    b.HasIndex("RtId");

                    b.ToTable("Bloks");
                });

            modelBuilder.Entity("GuyubApp.API.Models.IuranNonWajib", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Bulan");

                    b.Property<string>("Deskripsi");

                    b.Property<int>("IuranBayar");

                    b.Property<int>("RumahId");

                    b.Property<int>("Tahun");

                    b.Property<DateTime>("TanggalTransaksi");

                    b.HasKey("Id");

                    b.HasIndex("RumahId");

                    b.ToTable("IuranNonWajibs");
                });

            modelBuilder.Entity("GuyubApp.API.Models.IuranWajib", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Bulan");

                    b.Property<int>("IPLAktual");

                    b.Property<int>("IPLBayar");

                    b.Property<int>("IPLSesuaiAturan");

                    b.Property<string>("Nama");

                    b.Property<int>("RumahId");

                    b.Property<int>("Tahun");

                    b.Property<DateTime>("TanggalTransaksi");

                    b.HasKey("Id");

                    b.HasIndex("RumahId");

                    b.ToTable("IuranWajibs");
                });

            modelBuilder.Entity("GuyubApp.API.Models.Pengeluaran", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Bulan");

                    b.Property<string>("Deskripsi");

                    b.Property<int>("RpBayar");

                    b.Property<int>("RtId");

                    b.Property<int>("Tahun");

                    b.Property<DateTime>("TanggalTransaksi");

                    b.Property<string>("Tipe");

                    b.HasKey("Id");

                    b.HasIndex("RtId");

                    b.ToTable("Pengeluarans");
                });

            modelBuilder.Entity("GuyubApp.API.Models.RT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nama");

                    b.Property<int>("RwId");

                    b.HasKey("Id");

                    b.HasIndex("RwId");

                    b.ToTable("RTs");
                });

            modelBuilder.Entity("GuyubApp.API.Models.RW", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Kecamatan");

                    b.Property<string>("Kelurahan");

                    b.Property<string>("Keterangan");

                    b.Property<string>("Kota");

                    b.Property<string>("Nama");

                    b.Property<string>("Provinsi");

                    b.HasKey("Id");

                    b.ToTable("RWs");
                });

            modelBuilder.Entity("GuyubApp.API.Models.Rumah", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlokId");

                    b.Property<int>("Dihuni");

                    b.Property<int>("IPLAktual");

                    b.Property<int>("IPLSesuaiAturan");

                    b.Property<string>("NamaKKWarga");

                    b.Property<string>("NoRumah");

                    b.HasKey("Id");

                    b.HasIndex("BlokId");

                    b.ToTable("Rumahs");
                });

            modelBuilder.Entity("GuyubApp.API.Models.Blok", b =>
                {
                    b.HasOne("GuyubApp.API.Models.RT", "RT")
                        .WithMany()
                        .HasForeignKey("RtId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GuyubApp.API.Models.IuranNonWajib", b =>
                {
                    b.HasOne("GuyubApp.API.Models.Rumah", "Rumah")
                        .WithMany()
                        .HasForeignKey("RumahId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GuyubApp.API.Models.IuranWajib", b =>
                {
                    b.HasOne("GuyubApp.API.Models.Rumah", "Rumah")
                        .WithMany()
                        .HasForeignKey("RumahId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GuyubApp.API.Models.Pengeluaran", b =>
                {
                    b.HasOne("GuyubApp.API.Models.RT", "RT")
                        .WithMany()
                        .HasForeignKey("RtId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GuyubApp.API.Models.RT", b =>
                {
                    b.HasOne("GuyubApp.API.Models.RW", "RW")
                        .WithMany()
                        .HasForeignKey("RwId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GuyubApp.API.Models.Rumah", b =>
                {
                    b.HasOne("GuyubApp.API.Models.Blok", "Blok")
                        .WithMany()
                        .HasForeignKey("BlokId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
