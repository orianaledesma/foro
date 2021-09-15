﻿// <auto-generated />
using System;
using Foro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Foro.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Foro.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Foro.Models.Entrada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<int>("MiembroId")
                        .HasColumnType("int");

                    b.Property<bool>("Privada")
                        .HasColumnType("bit");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("MiembroId");

                    b.ToTable("Entrada");
                });

            modelBuilder.Entity("Foro.Models.EntradaMiembro", b =>
                {
                    b.Property<int>("EntradaId")
                        .HasColumnType("int");

                    b.Property<int>("MiembroId")
                        .HasColumnType("int");

                    b.HasKey("EntradaId", "MiembroId");

                    b.HasIndex("MiembroId");

                    b.ToTable("EntradasMiembros");
                });

            modelBuilder.Entity("Foro.Models.Pregunta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activa")
                        .HasColumnType("bit");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("EntradaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("MiembroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EntradaId");

                    b.HasIndex("MiembroId");

                    b.ToTable("Pregunta");
                });

            modelBuilder.Entity("Foro.Models.Reaccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<bool>("MeGusta")
                        .HasColumnType("bit");

                    b.Property<int>("MiembroId")
                        .HasColumnType("int");

                    b.Property<int>("RespuestaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MiembroId");

                    b.HasIndex("RespuestaId");

                    b.ToTable("Reaccion");
                });

            modelBuilder.Entity("Foro.Models.Respuesta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("MiembroId")
                        .HasColumnType("int");

                    b.Property<int>("PreguntaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MiembroId");

                    b.HasIndex("PreguntaId");

                    b.ToTable("Respuesta");
                });

            modelBuilder.Entity("Foro.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Usuario");
                });

            modelBuilder.Entity("Foro.Models.Miembro", b =>
                {
                    b.HasBaseType("Foro.Models.Usuario");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Miembro");
                });

            modelBuilder.Entity("Foro.Models.Entrada", b =>
                {
                    b.HasOne("Foro.Models.Categoria", "Categoria")
                        .WithMany("Entradas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Foro.Models.Miembro", "Miembro")
                        .WithMany("Entradas")
                        .HasForeignKey("MiembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Foro.Models.EntradaMiembro", b =>
                {
                    b.HasOne("Foro.Models.Entrada", "Entrada")
                        .WithMany("MiembroHabilitados")
                        .HasForeignKey("EntradaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Foro.Models.Miembro", "Miembro")
                        .WithMany("EntradasHabilitados")
                        .HasForeignKey("MiembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Foro.Models.Pregunta", b =>
                {
                    b.HasOne("Foro.Models.Entrada", "Entrada")
                        .WithMany("Preguntas")
                        .HasForeignKey("EntradaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Foro.Models.Miembro", null)
                        .WithMany("Preguntas")
                        .HasForeignKey("MiembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Foro.Models.Reaccion", b =>
                {
                    b.HasOne("Foro.Models.Miembro", "Miembro")
                        .WithMany("PreguntasYRespuestasQueMeGustan")
                        .HasForeignKey("MiembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Foro.Models.Respuesta", "Respuesta")
                        .WithMany("Reacciones")
                        .HasForeignKey("RespuestaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Foro.Models.Respuesta", b =>
                {
                    b.HasOne("Foro.Models.Miembro", "Miembro")
                        .WithMany("Respuestas")
                        .HasForeignKey("MiembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Foro.Models.Pregunta", "Pregunta")
                        .WithMany("Respuestas")
                        .HasForeignKey("PreguntaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
