﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WinformsMicrosoft;

#nullable disable

namespace WinformsMicrosoft.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231227201209_addedPains")]
    partial class addedPains
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WinformsMicrosoft.Domain.Complaints", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ComplaintName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("complaintname");

                    b.Property<int>("IllnessCategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("illnesscategoryid");

                    b.HasKey("Id");

                    b.HasIndex("IllnessCategoryId");

                    b.ToTable("complaints");
                });

            modelBuilder.Entity("WinformsMicrosoft.Domain.IllnessCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("categoryname");

                    b.HasKey("Id");

                    b.ToTable("illnesscategory");
                });

            modelBuilder.Entity("WinformsMicrosoft.Domain.Pains", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id`");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("TypeOfPain")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("typeofpain");

                    b.HasKey("Id");

                    b.ToTable("pains");
                });

            modelBuilder.Entity("WinformsMicrosoft.Domain.Complaints", b =>
                {
                    b.HasOne("WinformsMicrosoft.Domain.IllnessCategory", "illnessCategory")
                        .WithMany("Complaints")
                        .HasForeignKey("IllnessCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("illnessCategory");
                });

            modelBuilder.Entity("WinformsMicrosoft.Domain.IllnessCategory", b =>
                {
                    b.Navigation("Complaints");
                });
#pragma warning restore 612, 618
        }
    }
}
