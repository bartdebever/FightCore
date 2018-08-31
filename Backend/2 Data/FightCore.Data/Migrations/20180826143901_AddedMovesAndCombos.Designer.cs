﻿// <auto-generated />
using System;
using FightCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FightCore.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180826143901_AddedMovesAndCombos")]
    partial class AddedMovesAndCombos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FightCore.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("FightCore.Models.Characters.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ComboId");

                    b.Property<string>("Description");

                    b.Property<int?>("GameId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ComboId");

                    b.HasIndex("GameId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("FightCore.Models.Characters.Combo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CharacterId");

                    b.Property<double>("MaximumDamage");

                    b.Property<double>("MinimumDamage");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Combos");
                });

            modelBuilder.Entity("FightCore.Models.Characters.Move", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CharacterId");

                    b.Property<int?>("ComboId");

                    b.Property<int?>("InputId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("ComboId");

                    b.HasIndex("InputId");

                    b.ToTable("Moves");
                });

            modelBuilder.Entity("FightCore.Models.Characters.Technique", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CharacterId");

                    b.Property<string>("Description");

                    b.Property<int?>("GameId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("GameId");

                    b.ToTable("Techniques");
                });

            modelBuilder.Entity("FightCore.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abbreviation");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("FightCore.Models.Shared.ControllerInput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KeyCode");

                    b.Property<int?>("TechniqueId");

                    b.Property<string>("TextDescription");

                    b.HasKey("Id");

                    b.HasIndex("TechniqueId");

                    b.ToTable("ControllerInputs");
                });

            modelBuilder.Entity("FightCore.Models.Shared.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CharacterId");

                    b.Property<string>("Description");

                    b.Property<int?>("GameId");

                    b.Property<int>("MediaType");

                    b.Property<int?>("MoveId");

                    b.Property<string>("Source");

                    b.Property<string>("SourceUrl");

                    b.Property<int?>("TechniqueId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("GameId");

                    b.HasIndex("MoveId");

                    b.HasIndex("TechniqueId");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FightCore.Models.Characters.Character", b =>
                {
                    b.HasOne("FightCore.Models.Characters.Combo")
                        .WithMany("WorksOn")
                        .HasForeignKey("ComboId");

                    b.HasOne("FightCore.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("FightCore.Models.Characters.Combo", b =>
                {
                    b.HasOne("FightCore.Models.Characters.Character", "Character")
                        .WithMany("Combos")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("FightCore.Models.Characters.Move", b =>
                {
                    b.HasOne("FightCore.Models.Characters.Character", "Character")
                        .WithMany("Moves")
                        .HasForeignKey("CharacterId");

                    b.HasOne("FightCore.Models.Characters.Combo")
                        .WithMany("Moves")
                        .HasForeignKey("ComboId");

                    b.HasOne("FightCore.Models.Shared.ControllerInput", "Input")
                        .WithMany()
                        .HasForeignKey("InputId");
                });

            modelBuilder.Entity("FightCore.Models.Characters.Technique", b =>
                {
                    b.HasOne("FightCore.Models.Characters.Character")
                        .WithMany("Techniques")
                        .HasForeignKey("CharacterId");

                    b.HasOne("FightCore.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("FightCore.Models.Shared.ControllerInput", b =>
                {
                    b.HasOne("FightCore.Models.Characters.Technique")
                        .WithMany("ControllerInputs")
                        .HasForeignKey("TechniqueId");
                });

            modelBuilder.Entity("FightCore.Models.Shared.Media", b =>
                {
                    b.HasOne("FightCore.Models.Characters.Character")
                        .WithMany("Media")
                        .HasForeignKey("CharacterId");

                    b.HasOne("FightCore.Models.Game")
                        .WithMany("Media")
                        .HasForeignKey("GameId");

                    b.HasOne("FightCore.Models.Characters.Move")
                        .WithMany("Media")
                        .HasForeignKey("MoveId");

                    b.HasOne("FightCore.Models.Characters.Technique")
                        .WithMany("Media")
                        .HasForeignKey("TechniqueId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("FightCore.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("FightCore.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FightCore.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("FightCore.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}