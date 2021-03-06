﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuarterControl.Models.DB;

namespace QuarterControl.Migrations
{
    [DbContext(typeof(QuarterControlDBContext))]
    partial class QuarterControlDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuarterControl.Models.AngusInspect", b =>
                {
                    b.Property<int>("AngusInspectId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GarronID");

                    b.Property<bool>("MarmoreoApto");

                    b.Property<DateTime>("Updated");

                    b.HasKey("AngusInspectId");

                    b.ToTable("AngusInspect");
                });
#pragma warning restore 612, 618
        }
    }
}
