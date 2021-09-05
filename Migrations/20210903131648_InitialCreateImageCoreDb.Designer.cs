﻿// <auto-generated />
using System;
using BlazorTestProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorTestProject.Migrations
{
    [DbContext(typeof(BlazorContext))]
    [Migration("20210903131648_InitialCreateImageCoreDb")]
    partial class InitialCreateImageCoreDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("BlazorTestProject.Entities.CheckList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CheckListName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CheckLists");
                });

            modelBuilder.Entity("BlazorTestProject.Entities.Entry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CheckListId")
                        .HasColumnType("TEXT");

                    b.Property<string>("EntryText")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDone")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CheckListId");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("BlazorTestProject.Entities.Entry", b =>
                {
                    b.HasOne("BlazorTestProject.Entities.CheckList", "CheckList")
                        .WithMany("Entries")
                        .HasForeignKey("CheckListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CheckList");
                });

            modelBuilder.Entity("BlazorTestProject.Entities.CheckList", b =>
                {
                    b.Navigation("Entries");
                });
#pragma warning restore 612, 618
        }
    }
}