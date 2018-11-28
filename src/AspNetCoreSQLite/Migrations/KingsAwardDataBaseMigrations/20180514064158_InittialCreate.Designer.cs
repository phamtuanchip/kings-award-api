﻿// <auto-generated />
using AspNet5SQLite.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AspNetCoreSQLite.Migrations.KingsAwardDataBaseMigrations
{
    [DbContext(typeof(KingsAwardDataBase))]
    [Migration("20180514064158_InittialCreate")]
    partial class InittialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("AspNetCoreSQLite.Model.Activity", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<byte[]>("Data");

                    b.Property<DateTime>("Date");

                    b.Property<string>("DateTime");

                    b.Property<string>("Description");

                    b.Property<string>("ItemInerText");

                    b.Property<string>("ItemText");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name");

                    b.Property<string>("SubTitle");

                    b.Property<string>("Title");

                    b.HasKey("id");

                    b.ToTable("Activites");
                });

            modelBuilder.Entity("AspNetCoreSQLite.Model.Archive", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("ArchivePoints");

                    b.Property<DateTime>("Created");

                    b.Property<byte[]>("Data");

                    b.Property<DateTime>("Date");

                    b.Property<string>("DateTime");

                    b.Property<string>("Description");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name");

                    b.Property<long>("awardsId");

                    b.Property<long>("childrenId");

                    b.HasKey("id");

                    b.ToTable("Archives");
                });

            modelBuilder.Entity("AspNetCoreSQLite.Model.Award", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<byte[]>("Data");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<DateTime>("From");

                    b.Property<string>("Gift");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name");

                    b.Property<string>("SubTitle");

                    b.Property<int>("TargetPoint");

                    b.Property<string>("Title");

                    b.Property<DateTime>("To");

                    b.HasKey("id");

                    b.ToTable("Awards");
                });

            modelBuilder.Entity("AspNetCoreSQLite.Model.Child", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avatar");

                    b.Property<DateTime>("Created");

                    b.Property<string>("DOB");

                    b.Property<byte[]>("Data");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<short>("Gender");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name");

                    b.Property<string>("Nick");

                    b.Property<int>("Year");

                    b.HasKey("id");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("AspNetCoreSQLite.Model.Task", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<byte[]>("Data");

                    b.Property<DateTime>("Date");

                    b.Property<int>("DefaultPoint");

                    b.Property<string>("Description");

                    b.Property<int>("ManualPoint");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name");

                    b.HasKey("id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("AspNetCoreSQLite.Model.TaskDone", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("Archiveid");

                    b.Property<DateTime>("Created");

                    b.Property<byte[]>("Data");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name");

                    b.Property<int>("Point");

                    b.Property<long>("tasksId");

                    b.HasKey("id");

                    b.HasIndex("Archiveid");

                    b.ToTable("TasksDone");
                });

            modelBuilder.Entity("AspNetCoreSQLite.Model.TaskDone", b =>
                {
                    b.HasOne("AspNetCoreSQLite.Model.Archive")
                        .WithMany("TaskDone")
                        .HasForeignKey("Archiveid");
                });
#pragma warning restore 612, 618
        }
    }
}