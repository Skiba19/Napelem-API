﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Napelem_API.Data;

#nullable disable

namespace Napelem_API.Migrations
{
    [DbContext(typeof(NapelemContext))]
    [Migration("20230531161457_db.create")]
    partial class dbcreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Napelem_API.Models.Component", b =>
                {
                    b.Property<int>("componentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("componentID"));

                    b.Property<int?>("max_quantity")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("price")
                        .HasColumnType("int");

                    b.Property<int?>("quantity")
                        .HasColumnType("int");

                    b.HasKey("componentID");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("Napelem_API.Models.Employee", b =>
                {
                    b.Property<int>("employeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("employeeID"));

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("employeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Napelem_API.Models.Log", b =>
                {
                    b.Property<int>("logID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("logID"));

                    b.Property<int>("projectID")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("timestamp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("logID");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("Napelem_API.Models.Project", b =>
                {
                    b.Property<int>("projectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("projectID"));

                    b.Property<int>("employeeID")
                        .HasColumnType("int");

                    b.Property<int>("estimated_Time")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("project_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("project_location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("project_orderer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("project_price")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("wage")
                        .HasColumnType("int");

                    b.HasKey("projectID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Napelem_API.Models.Reservation", b =>
                {
                    b.Property<int>("reservationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("reservationID"));

                    b.Property<int>("componentID")
                        .HasColumnType("int");

                    b.Property<int>("projectID")
                        .HasColumnType("int");

                    b.Property<int>("reservationQuantity")
                        .HasColumnType("int");

                    b.HasKey("reservationID");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Napelem_API.Models.Storage", b =>
                {
                    b.Property<int>("storageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("storageID"));

                    b.Property<int>("column")
                        .HasColumnType("int");

                    b.Property<int>("componentID")
                        .HasColumnType("int");

                    b.Property<int>("current_quantity")
                        .HasColumnType("int");

                    b.Property<int>("level")
                        .HasColumnType("int");

                    b.Property<int>("row")
                        .HasColumnType("int");

                    b.HasKey("storageID");

                    b.ToTable("Storages");
                });
#pragma warning restore 612, 618
        }
    }
}
