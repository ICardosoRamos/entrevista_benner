﻿// <auto-generated />
using System;
using Estacionamento.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Estacionamento.API.Migrations
{
    [DbContext(typeof(AplicationDBContext))]
    [Migration("20240709151527_InitMigration")]
    partial class InitMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Estacionamento.API.Data.Estacionamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<TimeSpan?>("Duracao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("HorarioChegada")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("HorarioSaida")
                        .HasColumnType("TEXT");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("PrecoHora")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan?>("TempoCobrado")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("ValorAPagar")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Estacionamento");
                });

            modelBuilder.Entity("Estacionamento.API.Data.Preco", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("PrecoPorHora")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Preco");
                });
#pragma warning restore 612, 618
        }
    }
}