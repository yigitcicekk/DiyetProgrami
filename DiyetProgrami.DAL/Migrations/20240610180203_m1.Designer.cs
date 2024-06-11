﻿// <auto-generated />
using System;
using DiyetProgrami.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiyetProgrami.DAL.Migrations
{
    [DbContext(typeof(DiyetProgramiDbContext))]
    [Migration("20240610180203_m1")]
    partial class m1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DiyetProgrami.DAL.Entities.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("DiyetProgrami.DAL.Entities.DietPlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DieterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DietitianId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ExerciseLogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PlanName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DieterId");

                    b.HasIndex("DietitianId");

                    b.HasIndex("ExerciseLogId");

                    b.ToTable("DietPlans");
                });

            modelBuilder.Entity("DiyetProgrami.DAL.Entities.Dieter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DietitianId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("DietitianId");

                    b.HasIndex("UserId");

                    b.ToTable("Dieters");
                });

            modelBuilder.Entity("DiyetProgrami.DAL.Entities.Dietitian", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Dietitians");
                });

            modelBuilder.Entity("DiyetProgrami.DAL.Entities.ExerciseLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("CaloriesBurned")
                        .HasColumnType("real");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DietPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Duration")
                        .HasColumnType("real");

                    b.Property<string>("ExerciseType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ExerciseLogs");
                });

            modelBuilder.Entity("DiyetProgrami.DAL.Entities.MealLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Calories")
                        .HasColumnType("real");

                    b.Property<float>("Carbohydrates")
                        .HasColumnType("real");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DietPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Fat")
                        .HasColumnType("real");

                    b.Property<string>("MealType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("Protein")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("DietPlanId")
                        .IsUnique();

                    b.ToTable("MealLogs");
                });

            modelBuilder.Entity("DiyetProgrami.DAL.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("VerificationCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DiyetProgrami.DAL.Entities.Admin", b =>
                {
                    b.HasOne("DiyetProgrami.DAL.Entities.User", "User")
                        .WithMany("Admins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DiyetProgrami.DAL.Entities.DietPlan", b =>
                {
                    b.HasOne("DiyetProgrami.DAL.Entities.Dieter", "Dieter")
                        .WithMany("DietPlans")
                        .HasForeignKey("DieterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiyetProgrami.DAL.Entities.Dietitian", "Dietitian")
                        .WithMany("DietPlans")
                        .HasForeignKey("DietitianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiyetProgrami.DAL.Entities.ExerciseLog", "ExerciseLog")
                        .WithMany("DietPlan")
                        .HasForeignKey("ExerciseLogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dieter");

                    b.Navigation("Dietitian");

                    b.Navigation("ExerciseLog");
                });

            modelBuilder.Entity("DiyetProgrami.DAL.Entities.Dieter", b =>
                {
                    b.HasOne("DiyetProgrami.DAL.Entities.Dietitian", "Dietitian")
                        .WithMany("Dieters")
                        .HasForeignKey("DietitianId");

                    b.HasOne("DiyetProgrami.DAL.Entities.User", "User")
                        .WithMany("Dieters")
                        .HasForeignKey("UserId");

                    b.Navigation("Dietitian");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DiyetProgrami.DAL.Entities.Dietitian", b =>
                {
                    b.HasOne("DiyetProgrami.DAL.Entities.User", "User")
                        .WithMany("Dietitians")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DiyetProgrami.DAL.Entities.MealLog", b =>
                {
                    b.HasOne("DiyetProgrami.DAL.Entities.DietPlan", "DietPlan")
                        .WithOne("MealLog")
                        .HasForeignKey("DiyetProgrami.DAL.Entities.MealLog", "DietPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DietPlan");
                });

            modelBuilder.Entity("DiyetProgrami.DAL.Entities.DietPlan", b =>
                {
                    b.Navigation("MealLog")
                        .IsRequired();
                });

            modelBuilder.Entity("DiyetProgrami.DAL.Entities.Dieter", b =>
                {
                    b.Navigation("DietPlans");
                });

            modelBuilder.Entity("DiyetProgrami.DAL.Entities.Dietitian", b =>
                {
                    b.Navigation("DietPlans");

                    b.Navigation("Dieters");
                });

            modelBuilder.Entity("DiyetProgrami.DAL.Entities.ExerciseLog", b =>
                {
                    b.Navigation("DietPlan");
                });

            modelBuilder.Entity("DiyetProgrami.DAL.Entities.User", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("Dieters");

                    b.Navigation("Dietitians");
                });
#pragma warning restore 612, 618
        }
    }
}
