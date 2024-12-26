﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api_on_off.src.routes.raffleNumbers.context;

#nullable disable

namespace api_on_off.Migrations
{
    [DbContext(typeof(RaffleNumbersContext))]
    [Migration("20241226042616_AddCreatedAtToRaffleNumber")]
    partial class AddCreatedAtToRaffleNumber
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("api_on_off.src.routes.raffleNumbers.model.RaffleNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("RaffleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("Number");

                    b.HasIndex("RaffleId");

                    b.HasIndex("UserId");

                    b.ToTable("RaffleNumbers");
                });

            modelBuilder.Entity("api_on_off.src.shared.models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("api_on_off.src.shared.models.Raffle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Raffle");
                });

            modelBuilder.Entity("api_on_off.src.shared.models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("api_on_off.src.routes.raffleNumbers.model.RaffleNumber", b =>
                {
                    b.HasOne("api_on_off.src.shared.models.Client", "Client")
                        .WithMany("RaffleNumbers")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_on_off.src.shared.models.Raffle", "Raffle")
                        .WithMany("RaffleNumbers")
                        .HasForeignKey("RaffleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_on_off.src.shared.models.User", "User")
                        .WithMany("RaffleNumbers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Raffle");

                    b.Navigation("User");
                });

            modelBuilder.Entity("api_on_off.src.shared.models.Client", b =>
                {
                    b.Navigation("RaffleNumbers");
                });

            modelBuilder.Entity("api_on_off.src.shared.models.Raffle", b =>
                {
                    b.Navigation("RaffleNumbers");
                });

            modelBuilder.Entity("api_on_off.src.shared.models.User", b =>
                {
                    b.Navigation("RaffleNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}