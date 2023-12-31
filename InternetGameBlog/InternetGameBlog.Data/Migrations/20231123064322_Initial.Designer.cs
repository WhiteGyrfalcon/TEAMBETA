﻿// <auto-generated />
using System;
using InternetGameBlog.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InternetGameBlog.Data.Migrations
{
    [DbContext(typeof(GameBlogDbContext))]
    [Migration("20231123064322_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("InternetGameBlog.Data.Models.Comment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("GameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("InternetGameBlog.Data.Models.Game", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorCompany")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<int>("LikeCnt")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = "523c6221-c7ec-4156-973c-ef365392be01",
                            CreatedOn = new DateTime(2023, 11, 23, 8, 43, 22, 218, DateTimeKind.Local).AddTicks(3433),
                            CreatorCompany = "GameCreating",
                            Genre = 1,
                            LikeCnt = 20,
                            Name = "Minecraft"
                        });
                });

            modelBuilder.Entity("InternetGameBlog.Data.Models.GamePlatform", b =>
                {
                    b.Property<string>("GameId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PlatformId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "PlatformId");

                    b.HasIndex("PlatformId");

                    b.ToTable("GamePlatforms");

                    b.HasData(
                        new
                        {
                            GameId = "523c6221-c7ec-4156-973c-ef365392be01",
                            PlatformId = 1
                        },
                        new
                        {
                            GameId = "523c6221-c7ec-4156-973c-ef365392be01",
                            PlatformId = 2
                        },
                        new
                        {
                            GameId = "523c6221-c7ec-4156-973c-ef365392be01",
                            PlatformId = 3
                        });
                });

            modelBuilder.Entity("InternetGameBlog.Data.Models.Image", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("InternetGameBlog.Data.Models.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Platforms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "PC"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Playstation"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Xbox"
                        });
                });

            modelBuilder.Entity("InternetGameBlog.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePicUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "605e03f7-dfb6-4fdb-9f36-481520c6b714",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f1fcc17d-9e10-40cd-8d2e-0a955fdc7d20",
                            Email = "ivan123@abv.bg",
                            EmailConfirmed = false,
                            FirstName = "Ivan",
                            LastName = "Ivanov",
                            LockoutEnabled = false,
                            NormalizedEmail = "IVAN123@ABV.BG",
                            NormalizedUserName = "VANKATA",
                            PasswordHash = "AQAAAAEAACcQAAAAEFn3bZbqtmDfKJhACVq7JRm2Yb+5YQV5F47QEg+8IpZman6LO1NZVjpv/lBAkso04A==",
                            PhoneNumberConfirmed = false,
                            ProfilePicUrl = "https://res.cloudinary.com/ddriqreo7/image/upload/v1700115971/schoolProjectImages/4127_zv0rup.jpg",
                            SecurityStamp = "884e3986-3c36-48c4-a04a-ab84067e1d5d",
                            TwoFactorEnabled = false,
                            UserName = "vankata"
                        },
                        new
                        {
                            Id = "16592260-d4ab-4d15-a34c-8aa894c70025",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "827c16e8-627e-447c-a139-5f573fbe4230",
                            Email = "peter@abv.bg",
                            EmailConfirmed = false,
                            FirstName = "Peter",
                            LastName = "Dimitrov",
                            LockoutEnabled = false,
                            NormalizedEmail = "PETER@ABV.BG",
                            NormalizedUserName = "PETER",
                            PasswordHash = "AQAAAAEAACcQAAAAEM/X6IwGmx5QskQIZZeVXje/L+rYGcLVdGfg+bHylT1QLy+rmE7TGdF0EYiTFJsu6g==",
                            PhoneNumberConfirmed = false,
                            ProfilePicUrl = "https://res.cloudinary.com/ddriqreo7/image/upload/v1700116926/schoolProjectImages/5585_lafw0h.jpg",
                            SecurityStamp = "142b6e73-0d6f-41dc-b02e-ffcb01729b8b",
                            TwoFactorEnabled = false,
                            UserName = "peter"
                        },
                        new
                        {
                            Id = "111c3195-4e75-4ea9-9f4c-7c69f3fb34c6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "44d80cdf-ce76-4daa-b17d-5b42f88ecf82",
                            Email = "gosho@abv.bg",
                            EmailConfirmed = false,
                            FirstName = "Georgi",
                            LastName = "Petrov",
                            LockoutEnabled = false,
                            NormalizedEmail = "GOSHO@ABV.BG",
                            NormalizedUserName = "GOSHO",
                            PasswordHash = "AQAAAAEAACcQAAAAEEp4DP1jcIvt7eDH+z4SboPmYyqez7fEnn2krSMvp6daPgEWlAksOfG7/A1BDyiogA==",
                            PhoneNumberConfirmed = false,
                            ProfilePicUrl = "https://res.cloudinary.com/ddriqreo7/image/upload/v1700118672/schoolProjectImages/2150771129_hrcjdi.jpg",
                            SecurityStamp = "772dccf8-1f86-4976-8761-a4f2cc3e3754",
                            TwoFactorEnabled = false,
                            UserName = "gosho"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("InternetGameBlog.Data.Models.Comment", b =>
                {
                    b.HasOne("InternetGameBlog.Data.Models.Game", "Game")
                        .WithMany("Comments")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InternetGameBlog.Data.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("InternetGameBlog.Data.Models.Game", b =>
                {
                    b.HasOne("InternetGameBlog.Data.Models.User", null)
                        .WithMany("FavouriteGames")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("InternetGameBlog.Data.Models.GamePlatform", b =>
                {
                    b.HasOne("InternetGameBlog.Data.Models.Game", "Game")
                        .WithMany("Platform")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InternetGameBlog.Data.Models.Platform", "Platform")
                        .WithMany("Games")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("InternetGameBlog.Data.Models.Image", b =>
                {
                    b.HasOne("InternetGameBlog.Data.Models.Game", "Game")
                        .WithMany("Images")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("InternetGameBlog.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("InternetGameBlog.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InternetGameBlog.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("InternetGameBlog.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InternetGameBlog.Data.Models.Game", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Images");

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("InternetGameBlog.Data.Models.Platform", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("InternetGameBlog.Data.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("FavouriteGames");
                });
#pragma warning restore 612, 618
        }
    }
}
