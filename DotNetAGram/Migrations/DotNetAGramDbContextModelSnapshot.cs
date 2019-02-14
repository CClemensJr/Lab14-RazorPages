﻿// <auto-generated />
using DotNetAGram.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetAGram.Migrations
{
    [DbContext(typeof(DotNetAGramDbContext))]
    partial class DotNetAGramDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotNetAGram.Models.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Gunner and Yuna playing in snow at the dog park for the first time.",
                            ImageURL = "https://placeimg.com/640/480/animals",
                            Title = "Dogs in the Snow"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Gunner and Yuna playing at the beach for the first time.",
                            ImageURL = "https://placeimg.com/640/480/animals",
                            Title = "Dogs at the Beach"
                        },
                        new
                        {
                            ID = 3,
                            Description = "Gunner and Yuna playing in a volcano for the first time.",
                            ImageURL = "https://placeimg.com/640/480/animals",
                            Title = "Dogs in the Volcano"
                        },
                        new
                        {
                            ID = 4,
                            Description = "Gunner and Yuna playing in the jungle for the first time.",
                            ImageURL = "https://placeimg.com/640/480/animals",
                            Title = "Dogs in the Jungle"
                        },
                        new
                        {
                            ID = 5,
                            Description = "Gunner and Yuna playing in the White House for the first time.",
                            ImageURL = "https://placeimg.com/640/480/animals",
                            Title = "Dogs in the Whitehouse"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
