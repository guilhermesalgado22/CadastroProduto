﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tarefa02.Data;

#nullable disable

namespace Tarefa02.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230822195651_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("Tarefa02.API.Model.Produto", b =>
                {
                    b.Property<int?>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Preco")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
