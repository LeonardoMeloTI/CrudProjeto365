﻿// <auto-generated />
using System;
using CrudProjeto365.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudProjeto365.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211221011235_Banco3")]
    partial class Banco3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrudProjeto365.Models.Cliente", b =>
                {
                    b.Property<int>("Cliente_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cliente_id");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("CrudProjeto365.Models.Contato", b =>
                {
                    b.Property<int>("Contato_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mensagem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Contato_id");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("CrudProjeto365.Models.Passagem", b =>
                {
                    b.Property<int>("Passagem_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Classe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cliente_id")
                        .HasColumnType("int");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Horario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poltrona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preço")
                        .HasColumnType("float");

                    b.HasKey("Passagem_id");

                    b.HasIndex("Cliente_id");

                    b.ToTable("passagem");
                });

            modelBuilder.Entity("CrudProjeto365.Models.Passagem", b =>
                {
                    b.HasOne("CrudProjeto365.Models.Cliente", "Cliente")
                        .WithMany("Id_passagem")
                        .HasForeignKey("Cliente_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("CrudProjeto365.Models.Cliente", b =>
                {
                    b.Navigation("Id_passagem");
                });
#pragma warning restore 612, 618
        }
    }
}