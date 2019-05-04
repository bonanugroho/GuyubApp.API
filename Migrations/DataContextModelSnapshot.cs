﻿// <auto-generated />
using GuyubApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GuyubApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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