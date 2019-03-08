﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vulnerabilites.Data.Context;

namespace Vulnerabilities.Data.Migrations.MPCMissingPatchDb
{
    [DbContext(typeof(MPCMissingPatchDbContext))]
    partial class MPCMissingPatchDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vulnerabilities.Data.Models.Server", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DowntimeContact")
                        .HasColumnName("Downtime contact")
                        .HasMaxLength(70);

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnName("IP")
                        .HasMaxLength(50);

                    b.Property<DateTime>("LastDetected")
                        .HasColumnName("Last detected date");

                    b.Property<string>("Notes");

                    b.Property<string>("OSversion")
                        .HasColumnName("OS Version")
                        .HasMaxLength(70);

                    b.Property<string>("Port");

                    b.Property<string>("SystemName")
                        .IsRequired()
                        .HasColumnName("System name")
                        .HasMaxLength(100);

                    b.Property<string>("SystemStatus")
                        .IsRequired()
                        .HasColumnName("System status")
                        .HasMaxLength(50);

                    b.Property<string>("SystemType")
                        .IsRequired()
                        .HasColumnName("System type")
                        .HasMaxLength(50);

                    b.Property<string>("TechnicalOwner")
                        .HasColumnName("Technical owner")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Servers");
                });

            modelBuilder.Entity("Vulnerabilities.Data.Models.ServerVulnerability", b =>
                {
                    b.Property<int>("ServerId");

                    b.Property<int>("VulnerabilityId");

                    b.HasKey("ServerId", "VulnerabilityId");

                    b.HasIndex("VulnerabilityId");

                    b.ToTable("ServerVulnerability");
                });

            modelBuilder.Entity("Vulnerabilities.Data.Models.Vulnerability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CVE");

                    b.Property<DateTime>("LastDetected")
                        .HasColumnName("Last detected date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Notes");

                    b.Property<string>("QID");

                    b.Property<string>("Severity")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Solution");

                    b.HasKey("Id");

                    b.ToTable("Vulnerabilities");
                });

            modelBuilder.Entity("Vulnerabilities.Data.Models.ServerVulnerability", b =>
                {
                    b.HasOne("Vulnerabilities.Data.Models.Server", "Server")
                        .WithMany("Vulnerabilities")
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Vulnerabilities.Data.Models.Vulnerability", "Vulnerability")
                        .WithMany("Servers")
                        .HasForeignKey("VulnerabilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
