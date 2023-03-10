// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentAdminPortalAngular.DataModels;

#nullable disable

namespace StudentAdminPortalAngular.Migrations
{
    [DbContext(typeof(StudentAdminContext))]
    [Migration("20221214114104_Sample")]
    partial class Sample
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentAdminPortalAngular.DataModels.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhysicalAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("addresse");
                });

            modelBuilder.Entity("StudentAdminPortalAngular.DataModels.Gender", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descreption")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("gender");
                });

            modelBuilder.Entity("StudentAdminPortalAngular.DataModels.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBearth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GenderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("student");
                });

            modelBuilder.Entity("StudentAdminPortalAngular.DataModels.Address", b =>
                {
                    b.HasOne("StudentAdminPortalAngular.DataModels.Student", null)
                        .WithOne("Address")
                        .HasForeignKey("StudentAdminPortalAngular.DataModels.Address", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentAdminPortalAngular.DataModels.Student", b =>
                {
                    b.HasOne("StudentAdminPortalAngular.DataModels.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("StudentAdminPortalAngular.DataModels.Student", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
