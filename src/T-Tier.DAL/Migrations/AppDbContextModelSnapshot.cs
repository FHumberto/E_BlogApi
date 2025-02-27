﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using T_Tier.DAL.Context;

#nullable disable

namespace T_Tier.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.ToTable("AspNetRoles", "Identity");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Default",
                            NormalizedName = "DEFAULT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", "Identity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "nickname",
                            ClaimValue = "adminuser",
                            UserId = "a1b2c3d4-e5f6-7890-abcd-1234567890ab"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "email",
                            ClaimValue = "admin@example.com",
                            UserId = "a1b2c3d4-e5f6-7890-abcd-1234567890ab"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "nickname",
                            ClaimValue = "guestuser",
                            UserId = "b2c3d4e5-f6a7-890b-cdef-2345678901bc"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "email",
                            ClaimValue = "guest@example.com",
                            UserId = "b2c3d4e5-f6a7-890b-cdef-2345678901bc"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "nickname",
                            ClaimValue = "default",
                            UserId = "c3d4e5f6-a7b8-90cd-efgh-3456789012cd"
                        },
                        new
                        {
                            Id = 6,
                            ClaimType = "email",
                            ClaimValue = "default@example.com",
                            UserId = "c3d4e5f6-a7b8-90cd-efgh-3456789012cd"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", "Identity");

                    b.HasData(
                        new
                        {
                            UserId = "a1b2c3d4-e5f6-7890-abcd-1234567890ab",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "b2c3d4e5-f6a7-890b-cdef-2345678901bc",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "c3d4e5f6-a7b8-90cd-efgh-3456789012cd",
                            RoleId = "2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", "Identity");
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTag", "blog");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            TagId = 1
                        },
                        new
                        {
                            PostId = 1,
                            TagId = 2
                        },
                        new
                        {
                            PostId = 2,
                            TagId = 2
                        },
                        new
                        {
                            PostId = 2,
                            TagId = 3
                        },
                        new
                        {
                            PostId = 3,
                            TagId = 1
                        },
                        new
                        {
                            PostId = 3,
                            TagId = 3
                        });
                });

            modelBuilder.Entity("T_Tier.DAL.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments", "blog");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "Ótimo post, admin!",
                            IsDeleted = false,
                            PostId = 1,
                            UserId = "b2c3d4e5-f6a7-890b-cdef-2345678901bc"
                        },
                        new
                        {
                            Id = 2,
                            Body = "Interessante ponto de vista!",
                            IsDeleted = false,
                            PostId = 2,
                            UserId = "c3d4e5f6-a7b8-90cd-efgh-3456789012cd"
                        },
                        new
                        {
                            Id = 3,
                            Body = "Parabéns pelo post!",
                            IsDeleted = false,
                            PostId = 3,
                            UserId = "a1b2c3d4-e5f6-7890-abcd-1234567890ab"
                        });
                });

            modelBuilder.Entity("T_Tier.DAL.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Posts", "blog");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "Este é um post do administrador.",
                            IsDeleted = false,
                            Title = "Admin's First Post",
                            UserId = "a1b2c3d4-e5f6-7890-abcd-1234567890ab"
                        },
                        new
                        {
                            Id = 2,
                            Body = "Este é um post do convidado.",
                            IsDeleted = false,
                            Title = "Guest's First Post",
                            UserId = "b2c3d4e5-f6a7-890b-cdef-2345678901bc"
                        },
                        new
                        {
                            Id = 3,
                            Body = "Este é um post do usuário padrão.",
                            IsDeleted = false,
                            Title = "Default's First Post",
                            UserId = "c3d4e5f6-a7b8-90cd-efgh-3456789012cd"
                        });
                });

            modelBuilder.Entity("T_Tier.DAL.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Tags", "blog");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tecnologia"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Educação"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Saúde"
                        });
                });

            modelBuilder.Entity("T_Tier.DAL.Entities.User", b =>
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
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

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", "Identity");

                    b.HasData(
                        new
                        {
                            Id = "a1b2c3d4-e5f6-7890-abcd-1234567890ab",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "abcdef1234567890",
                            Email = "admin@example.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            IsDeleted = false,
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMINUSER",
                            PasswordHash = "AQAAAAIAAYagAAAAEFL1NcDnXQQmlE9E+oiCQRABamOOBcwBdvPBzNNLDB+8Qv6IGbmvag0qsLxdswDDSw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1234567890abcdef",
                            TwoFactorEnabled = false,
                            UserName = "adminuser"
                        },
                        new
                        {
                            Id = "b2c3d4e5-f6a7-890b-cdef-2345678901bc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1234567890abcdef",
                            Email = "guest@example.com",
                            EmailConfirmed = false,
                            FirstName = "Guest",
                            IsDeleted = false,
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "GUEST@EXAMPLE.COM",
                            NormalizedUserName = "GUESTUSER",
                            PasswordHash = "AQAAAAIAAYagAAAAEJwHp5n8U4kmadRHRZ8MO0jjj7YHkU0MgrCEsZzotYy2zf9YPIaNAd7IrqKXJv/ZRQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "abcdef1234567890",
                            TwoFactorEnabled = false,
                            UserName = "guestuser"
                        },
                        new
                        {
                            Id = "c3d4e5f6-a7b8-90cd-efgh-3456789012cd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0987654321fedcba",
                            Email = "default@example.com",
                            EmailConfirmed = false,
                            FirstName = "Default",
                            IsDeleted = false,
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "DEFAULT@EXAMPLE.COM",
                            NormalizedUserName = "DEFAULT",
                            PasswordHash = "AQAAAAIAAYagAAAAELCoiOQvm1OPWvY4aORXf/esrsCcwzFERM55w5Bb1WSvMUnKhKOQuDhsIrBdpQqseA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fedcba0987654321",
                            TwoFactorEnabled = false,
                            UserName = "default"
                        });
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
                    b.HasOne("T_Tier.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("T_Tier.DAL.Entities.User", null)
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

                    b.HasOne("T_Tier.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("T_Tier.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.HasOne("T_Tier.DAL.Entities.Post", null)
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("T_Tier.DAL.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("T_Tier.DAL.Entities.Comment", b =>
                {
                    b.HasOne("T_Tier.DAL.Entities.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("T_Tier.DAL.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("T_Tier.DAL.Entities.Post", b =>
                {
                    b.HasOne("T_Tier.DAL.Entities.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("User");
                });

            modelBuilder.Entity("T_Tier.DAL.Entities.Post", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("T_Tier.DAL.Entities.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
