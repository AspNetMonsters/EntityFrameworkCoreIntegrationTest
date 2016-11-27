using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EntityFrameworkIntegrationTesting.Models;

namespace EntityFrameworkIntegrationTesting.Migrations
{
    [DbContext(typeof(MonsterContext))]
    partial class MonsterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameworkIntegrationTesting.Models.Monster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Colour");

                    b.Property<bool>("IsScary");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Monsters");
                });
        }
    }
}
