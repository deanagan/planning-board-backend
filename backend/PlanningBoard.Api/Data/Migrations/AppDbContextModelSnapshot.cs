﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlanningBoard.Api.Data.Contexts;

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlanningBoard.Api.Data.Models.Epic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Epics");
                });

            modelBuilder.Entity("PlanningBoard.Api.Data.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A scrum master has more administration rights.",
                            Name = "Scrum Master"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A developer can do basic operations.",
                            Name = "Developer"
                        });
                });

            modelBuilder.Entity("PlanningBoard.Api.Data.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("PlanningBoard.Api.Data.Models.Story", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EpicId")
                        .HasColumnType("int");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EpicId");

                    b.HasIndex("StateId");

                    b.HasIndex("UserId");

                    b.ToTable("Stories");
                });

            modelBuilder.Entity("PlanningBoard.Api.Data.Models.StoryDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StoryId")
                        .HasColumnType("int");

                    b.Property<bool>("isDone")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("StoryId");

                    b.ToTable("StoryDetails");
                });

            modelBuilder.Entity("PlanningBoard.Api.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "jack.black@planningboard.io",
                            Hash = "123456",
                            Name = "Jack Black",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "john.smith@planningboard.io",
                            Hash = "12345678",
                            Name = "John Smith",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 3,
                            Email = "jane.doe@planningboard.io",
                            Hash = "988767",
                            Name = "Jane Doe",
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("PlanningBoard.Api.Data.Models.Story", b =>
                {
                    b.HasOne("PlanningBoard.Api.Data.Models.Epic", "Epic")
                        .WithMany("Stories")
                        .HasForeignKey("EpicId");

                    b.HasOne("PlanningBoard.Api.Data.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId");

                    b.HasOne("PlanningBoard.Api.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Epic");

                    b.Navigation("State");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PlanningBoard.Api.Data.Models.StoryDetail", b =>
                {
                    b.HasOne("PlanningBoard.Api.Data.Models.Story", "Story")
                        .WithMany("StoryDetails")
                        .HasForeignKey("StoryId");

                    b.Navigation("Story");
                });

            modelBuilder.Entity("PlanningBoard.Api.Data.Models.User", b =>
                {
                    b.HasOne("PlanningBoard.Api.Data.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PlanningBoard.Api.Data.Models.Epic", b =>
                {
                    b.Navigation("Stories");
                });

            modelBuilder.Entity("PlanningBoard.Api.Data.Models.Story", b =>
                {
                    b.Navigation("StoryDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
