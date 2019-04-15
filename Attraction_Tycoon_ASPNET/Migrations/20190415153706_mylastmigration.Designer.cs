﻿// <auto-generated />
using System;
using Attraction_Tycoon_ASPNET.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Attraction_Tycoon_ASPNET.Migrations
{
    [DbContext(typeof(Attraction_Tycoon_ASPNETContext))]
    [Migration("20190415153706_mylastmigration")]
    partial class mylastmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Attraction_Tycoon_ASPNET.Models.Carousel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Searchid");

                    b.Property<int>("capacity");

                    b.Property<int>("duration");

                    b.Property<bool>("is_open");

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<string>("state");

                    b.Property<string>("type")
                        .IsRequired();

                    b.Property<int>("waiting_time");

                    b.Property<int>("zone");

                    b.Property<string>("zoneName");

                    b.HasKey("id");

                    b.HasIndex("Searchid");

                    b.ToTable("Carousel");
                });

            modelBuilder.Entity("Attraction_Tycoon_ASPNET.Models.Search", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("id");

                    b.ToTable("Search");
                });

            modelBuilder.Entity("Attraction_Tycoon_ASPNET.Models.Shop", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Searchid");

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<string>("type")
                        .IsRequired();

                    b.Property<int>("zone");

                    b.Property<string>("zoneName");

                    b.HasKey("id");

                    b.HasIndex("Searchid");

                    b.ToTable("Shop");
                });

            modelBuilder.Entity("Attraction_Tycoon_ASPNET.Models.Staff", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Searchid");

                    b.Property<int>("hours");

                    b.Property<int>("id_user");

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<double>("salary");

                    b.Property<int?>("shopid");

                    b.Property<string>("status");

                    b.Property<string>("type")
                        .IsRequired();

                    b.HasKey("id");

                    b.HasIndex("Searchid");

                    b.HasIndex("shopid");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("Attraction_Tycoon_ASPNET.Models.Zone", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Zone");
                });

            modelBuilder.Entity("Attraction_Tycoon_ASPNET.Models.Carousel", b =>
                {
                    b.HasOne("Attraction_Tycoon_ASPNET.Models.Search")
                        .WithMany("carousels")
                        .HasForeignKey("Searchid");
                });

            modelBuilder.Entity("Attraction_Tycoon_ASPNET.Models.Shop", b =>
                {
                    b.HasOne("Attraction_Tycoon_ASPNET.Models.Search")
                        .WithMany("shops")
                        .HasForeignKey("Searchid");
                });

            modelBuilder.Entity("Attraction_Tycoon_ASPNET.Models.Staff", b =>
                {
                    b.HasOne("Attraction_Tycoon_ASPNET.Models.Search")
                        .WithMany("staffs")
                        .HasForeignKey("Searchid");

                    b.HasOne("Attraction_Tycoon_ASPNET.Models.Shop", "shop")
                        .WithMany("staffs")
                        .HasForeignKey("shopid");
                });
#pragma warning restore 612, 618
        }
    }
}
