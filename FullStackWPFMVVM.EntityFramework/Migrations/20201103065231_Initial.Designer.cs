﻿// <auto-generated />
using System;
using FullStackWPFMVVM.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FullStackWPFMVVM.EntityFramework.Migrations
{
    [DbContext(typeof(FullStackWPFMVVMDBContext))]
    [Migration("20201103065231_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FullStackWPFMVVM.Domain.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountHolderId")
                        .HasColumnType("int");

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AccountHolderId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("FullStackWPFMVVM.Domain.Models.AssetTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPurchase")
                        .HasColumnType("bit");

                    b.Property<int>("Shares")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("AssetTransactions");
                });

            modelBuilder.Entity("FullStackWPFMVVM.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FullStackWPFMVVM.Domain.Models.Account", b =>
                {
                    b.HasOne("FullStackWPFMVVM.Domain.Models.User", "AccountHolder")
                        .WithMany()
                        .HasForeignKey("AccountHolderId");
                });

            modelBuilder.Entity("FullStackWPFMVVM.Domain.Models.AssetTransaction", b =>
                {
                    b.HasOne("FullStackWPFMVVM.Domain.Models.Account", "Account")
                        .WithMany("AssetTransactions")
                        .HasForeignKey("AccountId");

                    b.OwnsOne("FullStackWPFMVVM.Domain.Models.Stock", "Stock", b1 =>
                        {
                            b1.Property<int>("AssetTransactionId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<double>("PricePerShare")
                                .HasColumnType("float");

                            b1.Property<string>("Symbol")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("AssetTransactionId");

                            b1.ToTable("AssetTransactions");

                            b1.WithOwner()
                                .HasForeignKey("AssetTransactionId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
