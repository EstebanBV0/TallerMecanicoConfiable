// <auto-generated />
using System;
using MecanicoConfiable.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MecanicoConfiable.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220918163402_RevNiveles1")]
    partial class RevNiveles1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MecanicoConfiable.App.Dominio.Auxiliar", b =>
                {
                    b.Property<int>("IdAuxiliar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAuxiliar"), 1L, 1);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAuxiliar");

                    b.ToTable("Auxiliares");
                });

            modelBuilder.Entity("MecanicoConfiable.App.Dominio.CambioRepuesto", b =>
                {
                    b.Property<int>("IdCambioRepuesto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCambioRepuesto"), 1L, 1);

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdRepuesto")
                        .HasColumnType("int");

                    b.Property<int>("IdVehiculo")
                        .HasColumnType("int");

                    b.HasKey("IdCambioRepuesto");

                    b.HasIndex("IdRepuesto");

                    b.HasIndex("IdVehiculo");

                    b.ToTable("CambioRepuestos");
                });

            modelBuilder.Entity("MecanicoConfiable.App.Dominio.Dueño", b =>
                {
                    b.Property<int>("IdDueño")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDueño"), 1L, 1);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDueño");

                    b.ToTable("Dueños");
                });

            modelBuilder.Entity("MecanicoConfiable.App.Dominio.Mecanico", b =>
                {
                    b.Property<int>("IdMecanico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMecanico"), 1L, 1);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("NivelEstudio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMecanico");

                    b.ToTable("Mecanicos");
                });

            modelBuilder.Entity("MecanicoConfiable.App.Dominio.Repuesto", b =>
                {
                    b.Property<int>("IdRepuesto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRepuesto"), 1L, 1);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("IdRepuesto");

                    b.ToTable("Repuestos");
                });

            modelBuilder.Entity("MecanicoConfiable.App.Dominio.RevisionNiveles", b =>
                {
                    b.Property<int>("IdNiveles")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdNiveles"), 1L, 1);

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdVehiculo")
                        .HasColumnType("int");

                    b.Property<int>("NivelAceite")
                        .HasColumnType("int");

                    b.Property<int>("NivelLiquidDireccion")
                        .HasColumnType("int");

                    b.Property<int>("NivelLiquidoFrenos")
                        .HasColumnType("int");

                    b.Property<int>("NivelRefrigerante")
                        .HasColumnType("int");

                    b.HasKey("IdNiveles");

                    b.HasIndex("IdVehiculo");

                    b.ToTable("RevisionNiveles");
                });

            modelBuilder.Entity("MecanicoConfiable.App.Dominio.Seguro", b =>
                {
                    b.Property<int>("IdSeguro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSeguro"), 1L, 1);

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicial")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdVehiculo")
                        .HasColumnType("int");

                    b.Property<string>("TipoSeguro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ValorSeguro")
                        .HasColumnType("int");

                    b.HasKey("IdSeguro");

                    b.HasIndex("IdVehiculo");

                    b.ToTable("Seguros");
                });

            modelBuilder.Entity("MecanicoConfiable.App.Dominio.Vehiculo", b =>
                {
                    b.Property<int>("IdVehiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVehiculo"), 1L, 1);

                    b.Property<string>("DescripcionAdicional")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdDueño")
                        .HasColumnType("int");

                    b.Property<int>("IdMecanico")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroPasajeros")
                        .HasColumnType("int");

                    b.Property<string>("PaisOrigen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdVehiculo");

                    b.HasIndex("IdDueño");

                    b.HasIndex("IdMecanico");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("MecanicoConfiable.App.Dominio.CambioRepuesto", b =>
                {
                    b.HasOne("MecanicoConfiable.App.Dominio.Repuesto", "Repuesto")
                        .WithMany()
                        .HasForeignKey("IdRepuesto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MecanicoConfiable.App.Dominio.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("IdVehiculo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Repuesto");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("MecanicoConfiable.App.Dominio.RevisionNiveles", b =>
                {
                    b.HasOne("MecanicoConfiable.App.Dominio.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("IdVehiculo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("MecanicoConfiable.App.Dominio.Seguro", b =>
                {
                    b.HasOne("MecanicoConfiable.App.Dominio.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("IdVehiculo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("MecanicoConfiable.App.Dominio.Vehiculo", b =>
                {
                    b.HasOne("MecanicoConfiable.App.Dominio.Dueño", "Dueño")
                        .WithMany()
                        .HasForeignKey("IdDueño")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MecanicoConfiable.App.Dominio.Mecanico", "Mecanico")
                        .WithMany()
                        .HasForeignKey("IdMecanico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dueño");

                    b.Navigation("Mecanico");
                });
#pragma warning restore 612, 618
        }
    }
}
