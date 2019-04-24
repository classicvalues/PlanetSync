﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlanetSync_Server.Data;

namespace PlanetSync_Server.Migrations
{
    [DbContext(typeof(PsContext))]
    [Migration("20190424044202_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("PlanetSync_Server.Data.Models.Mod", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsApproved");

                    b.Property<string>("ModDescription")
                        .IsRequired();

                    b.Property<string>("ModId")
                        .IsRequired();

                    b.Property<ulong>("OwnerId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Mods");
                });

            modelBuilder.Entity("PlanetSync_Server.Data.Models.ModFile", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<ulong>("OwnerId");

                    b.Property<string>("Path")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("ModFile");
                });

            modelBuilder.Entity("PlanetSync_Server.Data.Models.User", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CanAddMods");

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PlanetSync_Server.Data.Models.Mod", b =>
                {
                    b.HasOne("PlanetSync_Server.Data.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PlanetSync_Server.Data.Models.ModFile", b =>
                {
                    b.HasOne("PlanetSync_Server.Data.Models.Mod", "Owner")
                        .WithMany("FileList")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
