﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WeWaiter.DataBase;

namespace WeWaiter.DataBase
{
    [DbContext(typeof(WeWaiterContext))]
    [Migration("20180902153935_AddCatalog")]
    partial class AddCatalog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("WeWaiter.DataBase.BuyItem", b =>
                {
                    b.Property<string>("BuyItemID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("GoodsID");

                    b.Property<string>("OrderID");

                    b.Property<int>("Total");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("BuyItemID");

                    b.ToTable("BuyItem");
                });

            modelBuilder.Entity("WeWaiter.DataBase.Catalog", b =>
                {
                    b.Property<string>("CatalogID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CatalogName");

                    b.Property<bool>("Deleted");

                    b.Property<int>("OrderBy");

                    b.Property<string>("SellerID");

                    b.HasKey("CatalogID");

                    b.ToTable("Catalog");
                });

            modelBuilder.Entity("WeWaiter.DataBase.Goods", b =>
                {
                    b.Property<string>("GoodsID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BarCode");

                    b.Property<string>("CatalogID");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description");

                    b.Property<string>("Icon");

                    b.Property<string>("Image");

                    b.Property<decimal>("MinSellingPrice");

                    b.Property<string>("Name");

                    b.Property<decimal>("PurchasePrice");

                    b.Property<int>("Rating");

                    b.Property<string>("Seller");

                    b.Property<decimal>("SellingPrice");

                    b.Property<int>("Stock");

                    b.Property<bool>("Visible");

                    b.HasKey("GoodsID");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("WeWaiter.DataBase.Order", b =>
                {
                    b.Property<string>("OrderID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("ActPay");

                    b.Property<DateTime>("Create");

                    b.Property<int>("OrderIndex");

                    b.Property<int>("OrderStatus");

                    b.Property<string>("PayOrderID");

                    b.Property<string>("PayType");

                    b.Property<decimal>("Payable");

                    b.Property<string>("SellerID");

                    b.Property<decimal>("TotalPrice");

                    b.Property<string>("UserID");

                    b.HasKey("OrderID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("WeWaiter.DataBase.Printer", b =>
                {
                    b.Property<string>("PrinterID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApiURL");

                    b.Property<string>("Desc");

                    b.Property<string>("Name");

                    b.Property<string>("PrinterType");

                    b.HasKey("PrinterID");

                    b.ToTable("Printer");
                });

            modelBuilder.Entity("WeWaiter.DataBase.Seat", b =>
                {
                    b.Property<string>("SeatId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Seats");

                    b.Property<string>("Seller");

                    b.Property<bool>("Sit");

                    b.HasKey("SeatId");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("WeWaiter.DataBase.Seller", b =>
                {
                    b.Property<string>("SellerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avatar");

                    b.Property<string>("Bulletin");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description");

                    b.Property<int>("FoodScore");

                    b.Property<float>("MinPrice");

                    b.Property<string>("Name");

                    b.Property<string[]>("Pics");

                    b.Property<string>("PrintID");

                    b.Property<int>("RankRate");

                    b.Property<int>("RatingCount");

                    b.Property<int>("Score");

                    b.Property<int>("SellCount");

                    b.Property<int>("ServiceScore");

                    b.Property<int>("TableNumber");

                    b.HasKey("SellerID");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("WeWaiter.DataBase.SellerInfo", b =>
                {
                    b.Property<string>("SellerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("LogoURL");

                    b.Property<string>("MapURL");

                    b.Property<string>("OwnerIDNumber");

                    b.Property<string>("OwnerName");

                    b.Property<string>("OwnerPhone");

                    b.Property<string>("OwnerWeixinID");

                    b.HasKey("SellerID");

                    b.ToTable("SellerInfo");
                });

            modelBuilder.Entity("WeWaiter.DataBase.User", b =>
                {
                    b.Property<string>("WeixinID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("JoinIn");

                    b.Property<DateTime>("LastActive");

                    b.Property<string>("NickName");

                    b.Property<string>("Phone");

                    b.HasKey("WeixinID");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
