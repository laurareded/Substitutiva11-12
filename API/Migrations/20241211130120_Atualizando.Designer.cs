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
    [Migration("20241211130120_Atualizando")]
    partial class Atualizando
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

                    b.Property<string>("AlunoId1")
                        .HasColumnType("TEXT");

                    b.Property<string>("AlunoId2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Peso")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ImcId");

                    b.HasIndex("AlunoId1");

                    b.HasIndex("AlunoId2");

                    b.ToTable("Imcs");
                });

            modelBuilder.Entity("API.models.Imc", b =>
                {
                    b.HasOne("API.models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId1");

                    b.HasOne("API.models.Aluno", "AlunoId")
                        .WithMany()
                        .HasForeignKey("AlunoId2");

                    b.Navigation("Aluno");

                    b.Navigation("AlunoId");
                });
#pragma warning restore 612, 618
        }
    }
}
