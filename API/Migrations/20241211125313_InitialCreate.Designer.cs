﻿// <auto-generated />
using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20241211125313_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("API.models.Aluno", b =>
                {
                    b.Property<string>("AlunoId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.HasKey("AlunoId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("API.models.Imc", b =>
                {
                    b.Property<string>("ImcId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Altura")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AlunoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Peso")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ImcId");

                    b.HasIndex("AlunoId");

                    b.ToTable("Imcs");
                });

            modelBuilder.Entity("API.models.Imc", b =>
                {
                    b.HasOne("API.models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId");

                    b.Navigation("Aluno");
                });
#pragma warning restore 612, 618
        }
    }
}