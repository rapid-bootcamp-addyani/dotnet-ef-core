﻿// <auto-generated />
using System;
using DotnetEfCore.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotnetEfCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230110035739_AddMailboxToDatabase")]
    partial class AddMailboxToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DotnetEfCore.DataContext.AbsensiEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("AbsentEndDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("clock_out");

                    b.Property<DateTime>("AbsentStartDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("clock_in");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("id_employee");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("location");

                    b.HasKey("Id");

                    b.ToTable("tbl_absensi");
                });

            modelBuilder.Entity("DotnetEfCore.DataContext.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CategoryCode")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("category_code");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.HasKey("Id");

                    b.ToTable("tbl_category");
                });

            modelBuilder.Entity("DotnetEfCore.DataContext.EmployeeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("address");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("employee_name");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint")
                        .HasColumnName("phone");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("position");

                    b.HasKey("Id");

                    b.ToTable("tbl_employee");
                });

            modelBuilder.Entity("DotnetEfCore.DataContext.InventoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("inventory_name");

                    b.Property<int>("OnLoan")
                        .HasColumnType("int")
                        .HasColumnName("onloan");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<int>("Ready")
                        .HasColumnType("int")
                        .HasColumnName("ready");

                    b.Property<string>("Specification")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("specification");

                    b.HasKey("Id");

                    b.ToTable("tbl_inventory");
                });

            modelBuilder.Entity("DotnetEfCore.DataContext.LoanInventoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("detail");

                    b.Property<string>("NameAdmin")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name_admin");

                    b.Property<int>("NameUser")
                        .HasColumnType("int")
                        .HasColumnName("name_user");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.ToTable("tbl_loan_inventory");
                });

            modelBuilder.Entity("DotnetEfCore.DataContext.MailboxEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Attachment")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("attachment");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("body");

                    b.Property<string>("CCRecipients")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cc_recipients");

                    b.Property<DateTime>("Scheduled")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("scheduled");

                    b.Property<bool>("StatusDone")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("status");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("subject");

                    b.Property<string>("ToRecipients")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("to_recipients");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("tbl_mailbox");
                });
#pragma warning restore 612, 618
        }
    }
}
