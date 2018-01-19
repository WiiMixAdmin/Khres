﻿// <auto-generated />
using Khres.Persistent;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Khres.Migrations
{
    [DbContext(typeof(KhresDbContext))]
    partial class KhresDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Khres.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("PositionId");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Khres.Models.EmployeeLeave", b =>
                {
                    b.Property<int>("LeaveId");

                    b.Property<int>("LeaveTypeId");

                    b.HasKey("LeaveId", "LeaveTypeId");

                    b.HasIndex("LeaveTypeId");

                    b.ToTable("EmployeeLeaves");
                });

            modelBuilder.Entity("Khres.Models.Leave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmployeeId");

                    b.Property<bool>("IsUrgent");

                    b.Property<DateTime>("LastUpdated");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Leaves");
                });

            modelBuilder.Entity("Khres.Models.LeaveType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("LeaveTypes");
                });

            modelBuilder.Entity("Khres.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Khres.Models.Employee", b =>
                {
                    b.HasOne("Khres.Models.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Khres.Models.EmployeeLeave", b =>
                {
                    b.HasOne("Khres.Models.Leave", "Leave")
                        .WithMany("EmployeeLeaves")
                        .HasForeignKey("LeaveId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Khres.Models.LeaveType", "Type")
                        .WithMany("EmployeeLeaves")
                        .HasForeignKey("LeaveTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Khres.Models.Leave", b =>
                {
                    b.HasOne("Khres.Models.Employee", "Employee")
                        .WithMany("Leaves")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("Khres.Models.LeaveDetail", "Detail", b1 =>
                        {
                            b1.Property<int>("LeaveId");

                            b1.Property<string>("Description");

                            b1.Property<float>("Duration");

                            b1.Property<DateTime>("EndDate");

                            b1.Property<DateTime>("StartDate");

                            b1.ToTable("Leaves");

                            b1.HasOne("Khres.Models.Leave")
                                .WithOne("Detail")
                                .HasForeignKey("Khres.Models.LeaveDetail", "LeaveId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
