﻿// <auto-generated />
using ClassBoots.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClassBoots.Migrations.Model
{
    [DbContext(typeof(ModelContext))]
    [Migration("20180907164731_ModelSchem")]
    partial class ModelSchem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClassBoots.Models.Institution", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress");

                    b.Property<string>("GeoLocation");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Institution");
                });

            modelBuilder.Entity("ClassBoots.Models.Lecture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<int>("LecturerID");

                    b.Property<int>("SubjectID");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Lecture");
                });

            modelBuilder.Entity("ClassBoots.Models.School", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InstitutionID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("School");
                });

            modelBuilder.Entity("ClassBoots.Models.Subject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("SchoolID");

                    b.HasKey("ID");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("ClassBoots.Models.Video", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LectureID");

                    b.Property<int>("Position");

                    b.Property<string>("Refference");

                    b.Property<int>("Views");

                    b.HasKey("ID");

                    b.ToTable("Video");
                });
#pragma warning restore 612, 618
        }
    }
}
