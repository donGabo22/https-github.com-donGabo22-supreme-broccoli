﻿// <auto-generated />
using System;
using FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220615165223_migracionOrden3")]
    partial class migracionOrden3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models.Empleados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido_Materno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Apellido_Paterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Horario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RFC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol_Asignado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models.Menuu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caracter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platillo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Menuu");
                });

            modelBuilder.Entity("FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models.MeseroOrden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Observacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PedidoNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platillo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("MeseroOrden");
                });

            modelBuilder.Entity("FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models.Orden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantidadBebida")
                        .HasColumnType("int");

                    b.Property<int>("CantidadPLatillo")
                        .HasColumnType("int");

                    b.Property<string>("ComentarioBebida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComentarioPlatillo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreBebida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombrePlatillo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroPedido")
                        .HasColumnType("int");

                    b.Property<double>("PrecioBebida")
                        .HasColumnType("float");

                    b.Property<double>("PrecioPlatillo")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Orden");
                });

            modelBuilder.Entity("FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models.Registradora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bebida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CantidadB")
                        .HasColumnType("float");

                    b.Property<double>("CantidadP")
                        .HasColumnType("float");

                    b.Property<string>("CaracteristicasB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CaracteristicasP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Devolucion")
                        .HasColumnType("float");

                    b.Property<double>("Efectivo")
                        .HasColumnType("float");

                    b.Property<DateTime>("Fecha_Venta")
                        .HasColumnType("datetime2");

                    b.Property<int>("Pedido")
                        .HasColumnType("int");

                    b.Property<string>("Platillo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PreciOP")
                        .HasColumnType("float");

                    b.Property<double>("PrecioB")
                        .HasColumnType("float");

                    b.Property<double>("TotalB")
                        .HasColumnType("float");

                    b.Property<double>("TotalF")
                        .HasColumnType("float");

                    b.Property<double>("TotalP")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Registradora");
                });

            modelBuilder.Entity("FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models.Registros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Registros");
                });
#pragma warning restore 612, 618
        }
    }
}