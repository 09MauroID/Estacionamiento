﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Presentacion.Persistencia;

#nullable disable

namespace Presentacion.Presentacion.Migracion
{
    [DbContext(typeof(PresentacionDbContext))]
    partial class PresentacionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.src.Administrador", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("Sistemaid")
                        .HasColumnType("char(36)");

                    b.Property<string>("contraseña")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.HasIndex("Sistemaid");

                    b.ToTable("Administrador");
                });

            modelBuilder.Entity("Dominio.src.Asistente", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("Administradorid")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("PortalAsistenteEstacionamientoid")
                        .HasColumnType("char(36)");

                    b.Property<string>("contrasenia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.HasIndex("Administradorid");

                    b.HasIndex("PortalAsistenteEstacionamientoid");

                    b.ToTable("Asistente");
                });

            modelBuilder.Entity("Dominio.src.Cliente", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ticketEntradaid")
                        .HasColumnType("char(36)");

                    b.HasKey("id");

                    b.HasIndex("ticketEntradaid");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Dominio.src.Estacionamiento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("plantanroPiso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("plantanroPiso");

                    b.ToTable("Estacionamiento");
                });

            modelBuilder.Entity("Dominio.src.Pago", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("montodePago")
                        .HasColumnType("int");

                    b.Property<string>("tipoPago")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.ToTable("Pago");
                });

            modelBuilder.Entity("Dominio.src.PanelElectrico", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.HasKey("id");

                    b.ToTable("PanelElectrico");
                });

            modelBuilder.Entity("Dominio.src.PanelEntrada", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ticketEntradaid")
                        .HasColumnType("char(36)");

                    b.Property<string>("ubicacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.HasIndex("ticketEntradaid");

                    b.ToTable("Panelentrada");
                });

            modelBuilder.Entity("Dominio.src.PanelEstacionamiento", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("espacioslibres")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("PanelEstacionamento");
                });

            modelBuilder.Entity("Dominio.src.PanelSalida", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("PagoTicket")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("TicketSalidaid")
                        .HasColumnType("char(36)");

                    b.HasKey("id");

                    b.HasIndex("TicketSalidaid");

                    b.ToTable("PanelSalida");
                });

            modelBuilder.Entity("Dominio.src.Planta", b =>
                {
                    b.Property<int>("nroPiso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<Guid?>("Administradorid")
                        .HasColumnType("char(36)");

                    b.Property<bool>("habilitado")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("nroPiso");

                    b.HasIndex("Administradorid");

                    b.ToTable("Planta");
                });

            modelBuilder.Entity("Dominio.src.PortalAsistenteEstacionamiento", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("sistemaid")
                        .HasColumnType("char(36)");

                    b.HasKey("id");

                    b.HasIndex("sistemaid");

                    b.ToTable("PortalAsistenteEstacionamiento");
                });

            modelBuilder.Entity("Dominio.src.PortalInformacionCliente", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("PagoTicket")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TicketSalida")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("ticketEntradaid")
                        .HasColumnType("char(36)");

                    b.HasKey("id");

                    b.HasIndex("ticketEntradaid");

                    b.ToTable("PortalInformacionCliente");
                });

            modelBuilder.Entity("Dominio.src.Sistema", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("EstacionamientoId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PanelElectricoid")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PortalInformacionClienteid")
                        .HasColumnType("char(36)");

                    b.HasKey("id");

                    b.HasIndex("EstacionamientoId");

                    b.HasIndex("PanelElectricoid");

                    b.HasIndex("PortalInformacionClienteid");

                    b.ToTable("Sistema");
                });

            modelBuilder.Entity("Dominio.src.Slot", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("Administradorid")
                        .HasColumnType("char(36)");

                    b.Property<int?>("PlantanroPiso")
                        .HasColumnType("int");

                    b.Property<int>("TipoSlot")
                        .HasColumnType("int");

                    b.Property<int>("tipoVehiculo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Administradorid");

                    b.HasIndex("PlantanroPiso");

                    b.ToTable("Slot");
                });

            modelBuilder.Entity("Dominio.src.TicketEntrada", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Monto")
                        .HasColumnType("int");

                    b.Property<Guid?>("Sistemaid")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("horarioIngreso")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("matricula")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("tipoVehiculo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.HasIndex("Sistemaid");

                    b.ToTable("TicketEntrada");
                });

            modelBuilder.Entity("Dominio.src.Usuario", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("Sistemaid")
                        .HasColumnType("char(36)");

                    b.Property<string>("contraseña")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.HasIndex("Sistemaid");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Dominio.src.Vehiculo", b =>
                {
                    b.Property<string>("matricula")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("tipoVehiculo")
                        .HasColumnType("int");

                    b.HasKey("matricula");

                    b.ToTable("Vehiculo");
                });

            modelBuilder.Entity("Dominio.src.Administrador", b =>
                {
                    b.HasOne("Dominio.src.Sistema", null)
                        .WithMany("Administradores")
                        .HasForeignKey("Sistemaid");
                });

            modelBuilder.Entity("Dominio.src.Asistente", b =>
                {
                    b.HasOne("Dominio.src.Administrador", null)
                        .WithMany("asistentes")
                        .HasForeignKey("Administradorid");

                    b.HasOne("Dominio.src.PortalAsistenteEstacionamiento", null)
                        .WithMany("Asistentes")
                        .HasForeignKey("PortalAsistenteEstacionamientoid");
                });

            modelBuilder.Entity("Dominio.src.Cliente", b =>
                {
                    b.HasOne("Dominio.src.TicketEntrada", "ticketEntrada")
                        .WithMany()
                        .HasForeignKey("ticketEntradaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ticketEntrada");
                });

            modelBuilder.Entity("Dominio.src.Estacionamiento", b =>
                {
                    b.HasOne("Dominio.src.Planta", "planta")
                        .WithMany()
                        .HasForeignKey("plantanroPiso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("planta");
                });

            modelBuilder.Entity("Dominio.src.PanelEntrada", b =>
                {
                    b.HasOne("Dominio.src.TicketEntrada", "ticketEntrada")
                        .WithMany()
                        .HasForeignKey("ticketEntradaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ticketEntrada");
                });

            modelBuilder.Entity("Dominio.src.PanelSalida", b =>
                {
                    b.HasOne("Dominio.src.TicketEntrada", "TicketSalida")
                        .WithMany()
                        .HasForeignKey("TicketSalidaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TicketSalida");
                });

            modelBuilder.Entity("Dominio.src.Planta", b =>
                {
                    b.HasOne("Dominio.src.Administrador", null)
                        .WithMany("plantas")
                        .HasForeignKey("Administradorid");
                });

            modelBuilder.Entity("Dominio.src.PortalAsistenteEstacionamiento", b =>
                {
                    b.HasOne("Dominio.src.Sistema", "sistema")
                        .WithMany()
                        .HasForeignKey("sistemaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sistema");
                });

            modelBuilder.Entity("Dominio.src.PortalInformacionCliente", b =>
                {
                    b.HasOne("Dominio.src.TicketEntrada", "ticketEntrada")
                        .WithMany()
                        .HasForeignKey("ticketEntradaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ticketEntrada");
                });

            modelBuilder.Entity("Dominio.src.Sistema", b =>
                {
                    b.HasOne("Dominio.src.Estacionamiento", "Estacionamiento")
                        .WithMany()
                        .HasForeignKey("EstacionamientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.src.PanelElectrico", "PanelElectrico")
                        .WithMany()
                        .HasForeignKey("PanelElectricoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.src.PortalInformacionCliente", "PortalInformacionCliente")
                        .WithMany()
                        .HasForeignKey("PortalInformacionClienteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estacionamiento");

                    b.Navigation("PanelElectrico");

                    b.Navigation("PortalInformacionCliente");
                });

            modelBuilder.Entity("Dominio.src.Slot", b =>
                {
                    b.HasOne("Dominio.src.Administrador", null)
                        .WithMany("slots")
                        .HasForeignKey("Administradorid");

                    b.HasOne("Dominio.src.Planta", null)
                        .WithMany("slots")
                        .HasForeignKey("PlantanroPiso");
                });

            modelBuilder.Entity("Dominio.src.TicketEntrada", b =>
                {
                    b.HasOne("Dominio.src.Sistema", null)
                        .WithMany("Tickets")
                        .HasForeignKey("Sistemaid");
                });

            modelBuilder.Entity("Dominio.src.Usuario", b =>
                {
                    b.HasOne("Dominio.src.Sistema", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("Sistemaid");
                });

            modelBuilder.Entity("Dominio.src.Administrador", b =>
                {
                    b.Navigation("asistentes");

                    b.Navigation("plantas");

                    b.Navigation("slots");
                });

            modelBuilder.Entity("Dominio.src.Planta", b =>
                {
                    b.Navigation("slots");
                });

            modelBuilder.Entity("Dominio.src.PortalAsistenteEstacionamiento", b =>
                {
                    b.Navigation("Asistentes");
                });

            modelBuilder.Entity("Dominio.src.Sistema", b =>
                {
                    b.Navigation("Administradores");

                    b.Navigation("Tickets");

                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
