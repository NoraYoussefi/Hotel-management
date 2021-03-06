// <auto-generated />
using System;
using Hotel_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hotel_Project.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20220612123844_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Hotel_Project.Data.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CodePostal")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Hotel_Project.Data.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryPrice")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Hotel_Project.Data.Classement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Rate")
                        .HasColumnType("integer");

                    b.Property<int>("coef")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Classements");
                });

            modelBuilder.Entity("Hotel_Project.Data.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CIN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CodePostal")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Tel")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Hotel_Project.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("integer");

                    b.Property<int>("CassementId")
                        .HasColumnType("integer");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumTel")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("CassementId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("Hotel_Project.Data.Prestation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Prestations");
                });

            modelBuilder.Entity("Hotel_Project.Data.PrestationReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateFacture")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Payed")
                        .HasColumnType("boolean");

                    b.Property<int>("PrestationId")
                        .HasColumnType("integer");

                    b.Property<int>("ReservationId")
                        .HasColumnType("integer");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("PrestationId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Factures");
                });

            modelBuilder.Entity("Hotel_Project.Data.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RoomId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<float>("arrhes")
                        .HasColumnType("real");

                    b.Property<DateTime>("datePayeArrhes")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("RoomId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Hotel_Project.Data.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("HotelId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsReserved")
                        .HasColumnType("boolean");

                    b.Property<string>("Num")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RoomTel")
                        .HasColumnType("integer");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("HotelId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Hotel_Project.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CIN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CodePostal")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<int>("Tel")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PrestationReservation", b =>
                {
                    b.Property<int>("PrestationsId")
                        .HasColumnType("integer");

                    b.Property<int>("ReservationsId")
                        .HasColumnType("integer");

                    b.HasKey("PrestationsId", "ReservationsId");

                    b.HasIndex("ReservationsId");

                    b.ToTable("PrestationReservation");
                });

            modelBuilder.Entity("Hotel_Project.Data.Hotel", b =>
                {
                    b.HasOne("Hotel_Project.Data.Address", "Address")
                        .WithOne("Hotel")
                        .HasForeignKey("Hotel_Project.Data.Hotel", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_Project.Data.Classement", "Cassement")
                        .WithMany("hotels")
                        .HasForeignKey("CassementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Cassement");
                });

            modelBuilder.Entity("Hotel_Project.Data.PrestationReservation", b =>
                {
                    b.HasOne("Hotel_Project.Data.Prestation", "Prestation")
                        .WithMany()
                        .HasForeignKey("PrestationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_Project.Data.Reservation", "Reservation")
                        .WithMany()
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prestation");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Hotel_Project.Data.Reservation", b =>
                {
                    b.HasOne("Hotel_Project.Data.Client", "Client")
                        .WithMany("Reservations")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_Project.Data.Room", "Room")
                        .WithMany("Reservations")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_Project.Data.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Room");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hotel_Project.Data.Room", b =>
                {
                    b.HasOne("Hotel_Project.Data.Category", "Category")
                        .WithMany("Rooms")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_Project.Data.Hotel", "Hotel")
                        .WithMany("Room")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("PrestationReservation", b =>
                {
                    b.HasOne("Hotel_Project.Data.Prestation", null)
                        .WithMany()
                        .HasForeignKey("PrestationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_Project.Data.Reservation", null)
                        .WithMany()
                        .HasForeignKey("ReservationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hotel_Project.Data.Address", b =>
                {
                    b.Navigation("Hotel")
                        .IsRequired();
                });

            modelBuilder.Entity("Hotel_Project.Data.Category", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Hotel_Project.Data.Classement", b =>
                {
                    b.Navigation("hotels");
                });

            modelBuilder.Entity("Hotel_Project.Data.Client", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Hotel_Project.Data.Hotel", b =>
                {
                    b.Navigation("Room");
                });

            modelBuilder.Entity("Hotel_Project.Data.Room", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Hotel_Project.Data.User", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
