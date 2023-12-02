﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YemekKalori.DAL.Context;

#nullable disable

namespace YemekKalori.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231202130720_InitPics")]
    partial class InitPics
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("YemekKalori.Domain.Entities.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Calorie")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CarbRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FatRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FoodPic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProteinRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Foods", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calorie = 155m,
                            CarbRate = 1.1m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5153),
                            FatRate = 10.6m,
                            FoodPic = "Images/HaşlanmışYumurta.jpg",
                            Name = "Haşlanmış Yumurta",
                            ProteinRate = 12.6m,
                            Status = 1,
                            Type = 5
                        },
                        new
                        {
                            Id = 2,
                            Calorie = 264m,
                            CarbRate = 1.4m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5157),
                            FatRate = 21m,
                            FoodPic = "Images/BeyazPeynir.jpg",
                            Name = "Peynir",
                            ProteinRate = 18m,
                            Status = 1,
                            Type = 4
                        },
                        new
                        {
                            Id = 3,
                            Calorie = 115m,
                            CarbRate = 6m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5159),
                            FatRate = 11m,
                            FoodPic = "Images/siya-zeytin.jpeg",
                            Name = "Siyah Zeytin",
                            ProteinRate = 0.8m,
                            Status = 1,
                            Type = 2
                        },
                        new
                        {
                            Id = 4,
                            Calorie = 145m,
                            CarbRate = 3.8m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5161),
                            FatRate = 15.3m,
                            FoodPic = "Images/YesilZeytin.png",
                            Name = "Yeşil Zeytin",
                            ProteinRate = 1m,
                            Status = 1,
                            Type = 2
                        },
                        new
                        {
                            Id = 5,
                            Calorie = 196m,
                            CarbRate = 1.1m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5163),
                            FatRate = 15m,
                            FoodPic = "Images/SahandaYumurta.png",
                            Name = "Sahanda Yumurta",
                            ProteinRate = 14m,
                            Status = 1,
                            Type = 5
                        },
                        new
                        {
                            Id = 6,
                            Calorie = 106m,
                            CarbRate = 10m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5164),
                            FatRate = 4.9m,
                            FoodPic = "Images/Menemen.jpg",
                            Name = "Menemen",
                            ProteinRate = 6.4m,
                            Status = 1,
                            Type = 5
                        },
                        new
                        {
                            Id = 7,
                            Calorie = 266m,
                            CarbRate = 67m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5166),
                            FatRate = 0.2m,
                            FoodPic = "Images/Reçel.jpg",
                            Name = "Reçel",
                            ProteinRate = 0.3m,
                            Status = 1,
                            Type = 1
                        },
                        new
                        {
                            Id = 8,
                            Calorie = 304m,
                            CarbRate = 82m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5167),
                            FatRate = 0m,
                            FoodPic = "Images/bal.png",
                            Name = "Bal",
                            ProteinRate = 0.3m,
                            Status = 1,
                            Type = 8
                        },
                        new
                        {
                            Id = 9,
                            Calorie = 336m,
                            CarbRate = 1.4m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5168),
                            FatRate = 30m,
                            FoodPic = "Images/salam.png",
                            Name = "Salam",
                            ProteinRate = 13m,
                            Status = 1,
                            Type = 3
                        },
                        new
                        {
                            Id = 10,
                            Calorie = 1m,
                            CarbRate = 0.3m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5171),
                            FatRate = 0m,
                            FoodPic = "Images/Çay.png",
                            Name = "Çay",
                            ProteinRate = 0m,
                            Status = 1,
                            Type = 9
                        },
                        new
                        {
                            Id = 11,
                            Calorie = 1m,
                            CarbRate = 0m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5172),
                            FatRate = 0m,
                            FoodPic = "Images/YesilCay.png",
                            Name = "Yeşil Çay",
                            ProteinRate = 0m,
                            Status = 1,
                            Type = 9
                        },
                        new
                        {
                            Id = 12,
                            Calorie = 45m,
                            CarbRate = 10.4m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5173),
                            FatRate = 0.2m,
                            FoodPic = "Images/Portakal-suyu.jpg",
                            Name = "Portakal Suyu",
                            ProteinRate = 0.7m,
                            Status = 1,
                            Type = 10
                        },
                        new
                        {
                            Id = 13,
                            Calorie = 42m,
                            CarbRate = 5m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5175),
                            FatRate = 1m,
                            FoodPic = "Images/Süt.jpg",
                            Name = "Süt",
                            ProteinRate = 3.4m,
                            Status = 1,
                            Type = 4
                        },
                        new
                        {
                            Id = 14,
                            Calorie = 66m,
                            CarbRate = 9.2m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5177),
                            FatRate = 2.2m,
                            FoodPic = "Images/MercimekCorbası.png",
                            Name = "Mercimek Çorbası",
                            ProteinRate = 4.1m,
                            Status = 1,
                            Type = 2
                        },
                        new
                        {
                            Id = 15,
                            Calorie = 39m,
                            CarbRate = 3.9m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5178),
                            FatRate = 1.5m,
                            FoodPic = "Images/Tavuk Çorbası.png",
                            Name = "Tavuk Çorbası",
                            ProteinRate = 2.9m,
                            Status = 1,
                            Type = 3
                        },
                        new
                        {
                            Id = 16,
                            Calorie = 32m,
                            CarbRate = 4.3m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5179),
                            FatRate = 1.6m,
                            FoodPic = "Images/domatesÇorbası.png",
                            Name = "Domates Çorbası",
                            ProteinRate = 1.2m,
                            Status = 1,
                            Type = 2
                        },
                        new
                        {
                            Id = 17,
                            Calorie = 40m,
                            CarbRate = 5.3m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5181),
                            FatRate = 1.5m,
                            FoodPic = "Images/SebzeÇorbası.jpg",
                            Name = "Sebze Çorbası",
                            ProteinRate = 1.4m,
                            Status = 1,
                            Type = 2
                        },
                        new
                        {
                            Id = 18,
                            Calorie = 130m,
                            CarbRate = 28.2m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5183),
                            FatRate = 0.3m,
                            FoodPic = "Images/PirinçPilavı.jpg",
                            Name = "Pirinç Pilavı",
                            ProteinRate = 2.7m,
                            Status = 1,
                            Type = 6
                        },
                        new
                        {
                            Id = 19,
                            Calorie = 83m,
                            CarbRate = 18.6m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5185),
                            FatRate = 0.2m,
                            FoodPic = "Images/BulgurPilavı.jpg",
                            Name = "Bulgur Pilavı",
                            ProteinRate = 3.1m,
                            Status = 1,
                            Type = 6
                        },
                        new
                        {
                            Id = 20,
                            Calorie = 131m,
                            CarbRate = 25m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5186),
                            FatRate = 1.1m,
                            FoodPic = "Images/Makarna.jpg",
                            Name = "Makarna",
                            ProteinRate = 5m,
                            Status = 1,
                            Type = 7
                        },
                        new
                        {
                            Id = 21,
                            Calorie = 180m,
                            CarbRate = 2m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5187),
                            FatRate = 8m,
                            FoodPic = "Images/Kebap.jpg",
                            Name = "Kebap",
                            ProteinRate = 25m,
                            Status = 1,
                            Type = 3
                        },
                        new
                        {
                            Id = 22,
                            Calorie = 225m,
                            CarbRate = 2.2m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5189),
                            FatRate = 12m,
                            FoodPic = "Images/Döner.jpg",
                            Name = "Döner",
                            ProteinRate = 26m,
                            Status = 1,
                            Type = 3
                        },
                        new
                        {
                            Id = 23,
                            Calorie = 333m,
                            CarbRate = 31.8m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5190),
                            FatRate = 17.8m,
                            FoodPic = "Images/Falafel.jpg",
                            Name = "Falafel",
                            ProteinRate = 13.3m,
                            Status = 1,
                            Type = 2
                        },
                        new
                        {
                            Id = 24,
                            Calorie = 254m,
                            CarbRate = 30m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5191),
                            FatRate = 10m,
                            FoodPic = "Images/Hamburger.png",
                            Name = "Hamburger",
                            ProteinRate = 12m,
                            Status = 1,
                            Type = 3
                        },
                        new
                        {
                            Id = 25,
                            Calorie = 20m,
                            CarbRate = 4m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5194),
                            FatRate = 0.2m,
                            FoodPic = "Images/MevsimSalata.png",
                            Name = "Mevsim Salata",
                            ProteinRate = 1m,
                            Status = 1,
                            Type = 2
                        },
                        new
                        {
                            Id = 26,
                            Calorie = 23m,
                            CarbRate = 4.3m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5195),
                            FatRate = 0.4m,
                            FoodPic = "Images/coban_salatasi.jpg",
                            Name = "Çoban Salata",
                            ProteinRate = 1.1m,
                            Status = 1,
                            Type = 2
                        },
                        new
                        {
                            Id = 27,
                            Calorie = 265m,
                            CarbRate = 49m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5196),
                            FatRate = 3.2m,
                            FoodPic = "Images/beyaz_ekmek.jpg",
                            Name = "Beyaz Ekmek",
                            ProteinRate = 9m,
                            Status = 1,
                            Type = 7
                        },
                        new
                        {
                            Id = 28,
                            Calorie = 247m,
                            CarbRate = 41m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5198),
                            FatRate = 4.2m,
                            FoodPic = "Images/kepek_ekmegi.jpg",
                            Name = "Kepekli Ekmek",
                            ProteinRate = 13m,
                            Status = 1,
                            Type = 7
                        },
                        new
                        {
                            Id = 29,
                            Calorie = 259m,
                            CarbRate = 48.3m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5199),
                            FatRate = 3.3m,
                            FoodPic = "Images/cavdar_ekmegi.jpg",
                            Name = "Çavdar Ekmeği",
                            ProteinRate = 8.5m,
                            Status = 1,
                            Type = 7
                        },
                        new
                        {
                            Id = 30,
                            Calorie = 247m,
                            CarbRate = 43.4m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5201),
                            FatRate = 4.4m,
                            FoodPic = "Images/tam_tahilli_ekmek.jpg",
                            Name = "Tam Tahıllı Ekmek",
                            ProteinRate = 13m,
                            Status = 1,
                            Type = 7
                        },
                        new
                        {
                            Id = 31,
                            Calorie = 0.5m,
                            CarbRate = 0m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5202),
                            FatRate = 0m,
                            FoodPic = "Images/light_kola.jpg",
                            Name = "Light Cola",
                            ProteinRate = 0m,
                            Status = 1,
                            Type = 11
                        },
                        new
                        {
                            Id = 32,
                            Calorie = 48m,
                            CarbRate = 12m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5203),
                            FatRate = 0m,
                            FoodPic = "Images/fanta.jpg",
                            Name = "Fanta",
                            ProteinRate = 0m,
                            Status = 1,
                            Type = 11
                        },
                        new
                        {
                            Id = 33,
                            Calorie = 30m,
                            CarbRate = 7.5m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5207),
                            FatRate = 0m,
                            FoodPic = "Images/icetea.jpg",
                            Name = "Ice Tea",
                            ProteinRate = 0m,
                            Status = 1,
                            Type = 11
                        },
                        new
                        {
                            Id = 34,
                            Calorie = 37m,
                            CarbRate = 3.5m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5208),
                            FatRate = 2m,
                            FoodPic = "Images/ayran.jpg",
                            Name = "Ayran",
                            ProteinRate = 1.7m,
                            Status = 1,
                            Type = 4
                        },
                        new
                        {
                            Id = 35,
                            Calorie = 299m,
                            CarbRate = 79.2m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5209),
                            FatRate = 0.5m,
                            FoodPic = "kuru_uzum.jpg",
                            Name = "Kuru Üzüm",
                            ProteinRate = 3.1m,
                            Status = 1,
                            Type = 1
                        },
                        new
                        {
                            Id = 36,
                            Calorie = 241m,
                            CarbRate = 62.6m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5211),
                            FatRate = 0.5m,
                            FoodPic = "Images/kuru_kayisi.jpg",
                            Name = "Kuru Kayısı",
                            ProteinRate = 3.4m,
                            Status = 1,
                            Type = 1
                        },
                        new
                        {
                            Id = 37,
                            Calorie = 654m,
                            CarbRate = 13.7m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5212),
                            FatRate = 65.2m,
                            FoodPic = "Images/ceviz.jpg",
                            Name = "Ceviz",
                            ProteinRate = 15.2m,
                            Status = 1,
                            Type = 12
                        },
                        new
                        {
                            Id = 38,
                            Calorie = 628m,
                            CarbRate = 16.7m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5213),
                            FatRate = 60.8m,
                            FoodPic = "Images/findik.jpg",
                            Name = "Fındık",
                            ProteinRate = 15m,
                            Status = 1,
                            Type = 12
                        },
                        new
                        {
                            Id = 39,
                            Calorie = 567m,
                            CarbRate = 16.1m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5215),
                            FatRate = 49.2m,
                            FoodPic = "Images/fistik.jpg",
                            Name = "Fıstık",
                            ProteinRate = 25.8m,
                            Status = 1,
                            Type = 12
                        },
                        new
                        {
                            Id = 40,
                            Calorie = 52m,
                            CarbRate = 13.8m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5216),
                            FatRate = 0.2m,
                            FoodPic = "yesil_elma.jpg",
                            Name = "Yeşil Elma",
                            ProteinRate = 0.3m,
                            Status = 1,
                            Type = 1
                        },
                        new
                        {
                            Id = 41,
                            Calorie = 546m,
                            CarbRate = 45m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5245),
                            FatRate = 31m,
                            FoodPic = "bitter_cikolata.jpg",
                            Name = "Bitter Çikolata",
                            ProteinRate = 5m,
                            Status = 1,
                            Type = 13
                        },
                        new
                        {
                            Id = 42,
                            Calorie = 2m,
                            CarbRate = 0m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5247),
                            FatRate = 0m,
                            FoodPic = "Images/turk_kahve.jpg",
                            Name = "Türk Kahvesi",
                            ProteinRate = 0.1m,
                            Status = 1,
                            Type = 14
                        },
                        new
                        {
                            Id = 43,
                            Calorie = 1m,
                            CarbRate = 0m,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(5248),
                            FatRate = 0m,
                            FoodPic = "Images/filtre_kahve.jpg",
                            Name = "Filtre Kahve",
                            ProteinRate = 0.1m,
                            Status = 1,
                            Type = 14
                        });
                });

            modelBuilder.Entity("YemekKalori.Domain.Entities.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("MealCalorie")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("MealTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Meals", (string)null);
                });

            modelBuilder.Entity("YemekKalori.Domain.Entities.MealFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Calorie")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CarbRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FatRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<int?>("MealId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Portion")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProteinRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("MealId");

                    b.ToTable("MealFood", (string)null);
                });

            modelBuilder.Entity("YemekKalori.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal?>("BMI")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("decimal(18,2)")
                        .HasComputedColumnSql("CAST([Weight] / POWER([Height], 2) AS DECIMAL(18,2))", true);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Diet")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Goal")
                        .HasColumnType("int");

                    b.Property<decimal?>("HedefKalori")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 12, 2, 16, 7, 19, 538, DateTimeKind.Local).AddTicks(4405),
                            FirstName = "Admin",
                            Height = 0m,
                            LastName = "Admin",
                            Password = "a400467bedede01a08c86c6b11ce7b6d97fe6e702df76c6b5364ce6a04d86d0b",
                            Salt = "OLXx4jI5mjJQQem+RBVrGmkwrKx/TljK3xYothYCcMY=",
                            Status = 1,
                            Type = 1,
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("YemekKalori.Domain.Entities.Meal", b =>
                {
                    b.HasOne("YemekKalori.Domain.Entities.User", "User")
                        .WithMany("UserMeals")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YemekKalori.Domain.Entities.MealFood", b =>
                {
                    b.HasOne("YemekKalori.Domain.Entities.Food", "Food")
                        .WithMany("MealFoods")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YemekKalori.Domain.Entities.Meal", "Meal")
                        .WithMany("MealFoods")
                        .HasForeignKey("MealId");

                    b.Navigation("Food");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("YemekKalori.Domain.Entities.Food", b =>
                {
                    b.Navigation("MealFoods");
                });

            modelBuilder.Entity("YemekKalori.Domain.Entities.Meal", b =>
                {
                    b.Navigation("MealFoods");
                });

            modelBuilder.Entity("YemekKalori.Domain.Entities.User", b =>
                {
                    b.Navigation("UserMeals");
                });
#pragma warning restore 612, 618
        }
    }
}
