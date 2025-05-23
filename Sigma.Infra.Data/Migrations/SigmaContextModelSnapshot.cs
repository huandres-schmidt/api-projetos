﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Sigma.Infra.Data.Context;

#nullable disable

namespace Sigma.Infra.Data.Migrations
{
    [DbContext(typeof(SigmaContext))]
    partial class SigmaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Sigma.Domain.Entities.Projeto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("datainicio");

                    b.Property<string>("Descricao")
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<decimal>("OrcamentoTotal")
                        .HasColumnType("numeric")
                        .HasColumnName("orcamentototal");

                    b.Property<DateTime>("PrevisaoTermino")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("previsaotermino");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<int>("classificacao")
                        .HasColumnType("integer")
                        .HasColumnName("classificacao");

                    b.HasKey("Id")
                        .HasName("pk_projetos");

                    b.ToTable("projetos");
                });
#pragma warning restore 612, 618
        }
    }
}
