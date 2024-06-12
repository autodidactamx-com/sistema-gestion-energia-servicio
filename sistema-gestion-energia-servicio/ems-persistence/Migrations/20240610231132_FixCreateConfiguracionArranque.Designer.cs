﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ems_persistencia;

#nullable disable

namespace ems_persistencia.Migrations
{
    [DbContext(typeof(EmsLiteDbContext))]
    [Migration("20240610231132_FixCreateConfiguracionArranque")]
    partial class FixCreateConfiguracionArranque
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-preview.4.24267.1");

            modelBuilder.Entity("ems_persistencia.ConfiguracionArranque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CapacidadBateríaSegura")
                        .HasColumnType("REAL");

                    b.Property<double>("CapacidadBaterías")
                        .HasColumnType("REAL");

                    b.Property<double>("DemandaContratada")
                        .HasColumnType("REAL");

                    b.Property<double>("LimiteDemanda")
                        .HasColumnType("REAL");

                    b.Property<double>("PorcentajeCargaSegura")
                        .HasColumnType("REAL");

                    b.Property<double>("PorcentajeRespaldoEnergía")
                        .HasColumnType("REAL");

                    b.Property<double>("PotenciaBaterías")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("ConfiguracionArranque");
                });

            modelBuilder.Entity("ems_persistencia.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("People");
                });
#pragma warning restore 612, 618
        }
    }
}
