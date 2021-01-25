﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolPlanner.Data;

namespace SchoolPlanner2.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20210125194640_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SchoolPlanner.Models.Exam", b =>
                {
                    b.Property<int>("ExamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Room")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("ExamID");

                    b.HasIndex("SubjectID");

                    b.ToTable("Exam");
                });

            modelBuilder.Entity("SchoolPlanner.Models.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Day")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("SubjectID");

                    b.HasIndex("TeacherID");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("SchoolPlanner.Models.Task", b =>
                {
                    b.Property<int>("TaskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeOfTask")
                        .HasColumnType("int");

                    b.HasKey("TaskID");

                    b.HasIndex("SubjectID");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("SchoolPlanner.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherID");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("SchoolPlanner.Models.Exam", b =>
                {
                    b.HasOne("SchoolPlanner.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolPlanner.Models.Subject", b =>
                {
                    b.HasOne("SchoolPlanner.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolPlanner.Models.Task", b =>
                {
                    b.HasOne("SchoolPlanner.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
