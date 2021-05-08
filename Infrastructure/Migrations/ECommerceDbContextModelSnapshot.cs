﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ECommerceDbContext))]
    partial class ECommerceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Coffee"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tea"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Milk"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sweeteners"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Coffee Machines"
                        });
                });

            modelBuilder.Entity("Domain.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("date");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Domain.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("date");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 5,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://i.ibb.co/6bgccSg/212.jpg",
                            Price = 200,
                            Title = "First Product"
                        },
                        new
                        {
                            Id = 2,
                            Amount = 6,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://i.ibb.co/KyQwzHG/21133206.jpg",
                            Price = 210,
                            Title = "Second Product"
                        },
                        new
                        {
                            Id = 3,
                            Amount = 6,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://i.ibb.co/kmctC6G/21256508.jpg",
                            Price = 220,
                            Title = "Third Product"
                        },
                        new
                        {
                            Id = 4,
                            Amount = 6,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://i.ibb.co/KNFCs43/cosmetic-40.jpg",
                            Price = 220,
                            Title = "Fourth Product"
                        },
                        new
                        {
                            Id = 5,
                            Amount = 6,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://i.ibb.co/r6N7p8M/jar-03.jpg",
                            Price = 220,
                            Title = "Fifth Product"
                        },
                        new
                        {
                            Id = 6,
                            Amount = 6,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://i.ibb.co/X2gYjMN/jar-13.jpg",
                            Price = 220,
                            Title = "Sixth Product"
                        },
                        new
                        {
                            Id = 7,
                            Amount = 6,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://i.ibb.co/hcRbLBg/jar-24.jpg",
                            Price = 220,
                            Title = "Seventh Product"
                        },
                        new
                        {
                            Id = 8,
                            Amount = 6,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://i.ibb.co/mCMyJHD/jar-25.jpg",
                            Price = 220,
                            Title = "Eigth Product"
                        },
                        new
                        {
                            Id = 9,
                            Amount = 6,
                            CategoryId = 5,
                            CreatedAt = new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://i.ibb.co/qJVPFxJ/jar-36.jpg",
                            Price = 220,
                            Title = "Nineth Product"
                        });
                });

            modelBuilder.Entity("Domain.OrderItem", b =>
                {
                    b.HasOne("Domain.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Domain.Product", b =>
                {
                    b.HasOne("Domain.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Domain.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Domain.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
