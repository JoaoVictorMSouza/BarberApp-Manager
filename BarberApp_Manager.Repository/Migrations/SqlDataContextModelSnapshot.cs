﻿// <auto-generated />
using System;
using BarberApp_Manager.Repository.SqlConfigurations.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BarberApp_Manager.Repository.Migrations
{
    [DbContext(typeof(SqlDataContext))]
    partial class SqlDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BarberApp_Manager.Entity.Cabeleireiro.CabeleireiroEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DS_CPF");

                    b.Property<DateTime?>("DhAlteracao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DH_ALTERACAO");

                    b.Property<DateTime?>("DhInclusao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DH_INCLUSAO");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DS_EMAIL");

                    b.Property<bool>("IsAceitandoServico")
                        .HasColumnType("bit")
                        .HasColumnName("TG_ACEITANDO_SERVICO");

                    b.Property<bool>("IsInativo")
                        .HasColumnType("bit")
                        .HasColumnName("TG_INATIVO");

                    b.Property<DateTime?>("LimiteServicoFim")
                        .HasColumnType("datetime2")
                        .HasColumnName("DH_LIMITE_SERVICO_FIM");

                    b.Property<DateTime?>("LimiteServicoInicio")
                        .HasColumnType("datetime2")
                        .HasColumnName("DH_LIMITE_SERVICO_INICIO");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DS_LOGIN");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DS_NOME");

                    b.Property<string>("Permisao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DS_PERMISAO");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DS_SENHA");

                    b.HasKey("Id");

                    b.ToTable("TB_CABELEIREIRO", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}