﻿// <auto-generated />
using System;
using EMS_App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EMS_App.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20240103174332_FirstMig")]
    partial class FirstMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EMS_App.Models.DeptMaster", b =>
                {
                    b.Property<int>("DeptCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptCode"), 1L, 1);

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptCode");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("EMS_App.Models.EmpProfile", b =>
                {
                    b.Property<int>("EmpCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpCode"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeptCode")
                        .HasColumnType("int");

                    b.Property<int?>("DeptMasterDeptCode")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.HasKey("EmpCode");

                    b.HasIndex("DeptMasterDeptCode");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("EMS_App.Models.EmpProfile", b =>
                {
                    b.HasOne("EMS_App.Models.DeptMaster", null)
                        .WithMany("EmpProfiles")
                        .HasForeignKey("DeptMasterDeptCode");
                });

            modelBuilder.Entity("EMS_App.Models.DeptMaster", b =>
                {
                    b.Navigation("EmpProfiles");
                });
#pragma warning restore 612, 618
        }
    }
}
