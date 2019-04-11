﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nbic.References.EFCore;

namespace Nbic.References.EFCore.Migrations.SqliteMigrations
{
    [DbContext(typeof(SqliteReferencesDbContext))]
    [Migration("20190324220324_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("Nbic.References.Public.Models.Reference", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnName("Id");

                    b.Property<int?>("ApplicationId")
                        .HasColumnName("ApplicationId");

                    b.Property<string>("Author")
                        .IsUnicode(false);

                    b.Property<string>("Bibliography")
                        .IsUnicode(false);

                    b.Property<DateTime>("EditDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Firstname")
                        .IsUnicode(false);

                    b.Property<int?>("UserId")
                        .HasColumnName("UserId");

                    b.Property<string>("ImportXml")
                        .HasColumnName("ImportXML")
                        .HasColumnType("xml");

                    b.Property<string>("Journal")
                        .IsUnicode(false);

                    b.Property<string>("Keywords")
                        .IsUnicode(false);

                    b.Property<string>("Lastname")
                        .IsUnicode(false);

                    b.Property<string>("Middlename")
                        .IsUnicode(false);

                    b.Property<string>("Pages")
                        .IsUnicode(false);

                    b.Property<string>("Summary")
                        .IsUnicode(false);

                    b.Property<string>("Title")
                        .IsUnicode(false);

                    b.Property<string>("Url")
                        .HasColumnName("Url")
                        .IsUnicode(false);

                    b.Property<string>("Volume")
                        .IsUnicode(false);

                    b.Property<string>("Year")
                        .IsUnicode(false);

                    b.HasKey("Id")
                        .HasName("PK_Id");

                    b.HasIndex("UserId", "ApplicationId")
                        .HasName("IX_UserId_ApplicationId");

                    b.ToTable("Reference");
                });

            modelBuilder.Entity("Nbic.References.Public.Models.ReferenceUsage", b =>
                {
                    b.Property<Guid>("ReferenceId")
                        .HasColumnName("ReferenceId");

                    b.Property<int>("ApplicationId")
                        .HasColumnName("ApplicationId");

                    b.Property<int>("UserId")
                        .HasColumnName("UserId");

                    b.HasKey("ReferenceId", "ApplicationId", "UserId");

                    b.ToTable("ReferenceUsage");
                });

            modelBuilder.Entity("Nbic.References.Public.Models.ReferenceUsage", b =>
                {
                    b.HasOne("Nbic.References.Public.Models.Reference", "Reference")
                        .WithMany("ReferenceUsage")
                        .HasForeignKey("ReferenceId")
                        .HasConstraintName("FK_ReferenceUsage_Reference");
                });
#pragma warning restore 612, 618
        }
    }
}