﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using demo1.Models;

namespace demo1.Migrations
{
    [DbContext(typeof(KSContext))]
    partial class KSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("demo1.Models.Record", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Add");

                    b.Property<DateTimeOffset>("Changetime");

                    b.Property<string>("Class1");

                    b.Property<string>("Class2");

                    b.Property<string>("Description");

                    b.Property<int>("Gov");

                    b.Property<string>("Level");

                    b.Property<string>("Name");

                    b.Property<string>("Opentime");

                    b.Property<int>("ParkinginfoPx");

                    b.Property<int>("ParkinginfoPy");

                    b.Property<string>("Picdescribe1");

                    b.Property<string>("Picture1");

                    b.Property<string>("Px");

                    b.Property<string>("Py");

                    b.Property<long>("RecordId");

                    b.Property<string>("Remarks");

                    b.Property<string>("Tel");

                    b.Property<int>("Ticketinfo");

                    b.Property<string>("Toldescribe");

                    b.Property<int>("Travellinginfo");

                    b.Property<string>("Website");

                    b.Property<string>("Zone");

                    b.HasKey("Id");

                    b.ToTable("ScenicSpots");
                });
#pragma warning restore 612, 618
        }
    }
}
