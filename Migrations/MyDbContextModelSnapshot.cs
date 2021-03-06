// <auto-generated />
using System;
using ForOleksiyAspNet5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ForOleksiyAspNet5.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ForOleksiyAspNet5.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("EndGame")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("GamerDarkId")
                        .HasColumnType("int");

                    b.Property<int?>("GamerWhiteId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("StatrtGame")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("GamerDarkId");

                    b.HasIndex("GamerWhiteId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("ForOleksiyAspNet5.Models.Gamer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Birthday")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rang")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Gamers");
                });

            modelBuilder.Entity("ForOleksiyAspNet5.Models.Moves", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_sozdaniya");

                    b.Property<string>("Figure")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("figura");

                    b.Property<string>("From")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("s");

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("To")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("na");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Hody");
                });

            modelBuilder.Entity("ForOleksiyAspNet5.Models.Game", b =>
                {
                    b.HasOne("ForOleksiyAspNet5.Models.Gamer", "GamerDark")
                        .WithMany()
                        .HasForeignKey("GamerDarkId");

                    b.HasOne("ForOleksiyAspNet5.Models.Gamer", "GamerWhite")
                        .WithMany()
                        .HasForeignKey("GamerWhiteId");

                    b.Navigation("GamerDark");

                    b.Navigation("GamerWhite");
                });

            modelBuilder.Entity("ForOleksiyAspNet5.Models.Moves", b =>
                {
                    b.HasOne("ForOleksiyAspNet5.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");

                    b.Navigation("Game");
                });
#pragma warning restore 612, 618
        }
    }
}
