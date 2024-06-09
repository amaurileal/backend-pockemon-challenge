﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend_pokemon_challenge.infrastructure.Persistence;

#nullable disable

namespace backend_pokemon_challenge.infrastructure.Migrations
{
    [DbContext(typeof(PokemonChallengeDdContext))]
    partial class PokemonChallengeDdContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("backend_pokemon_challenge.domain.Entities.CapturedPokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PokemonId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PokemonMasterId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PokemonMasterId");

                    b.ToTable("CapturedPokemons");
                });

            modelBuilder.Entity("backend_pokemon_challenge.domain.Entities.PokemonMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PokemonMasters");
                });

            modelBuilder.Entity("backend_pokemon_challenge.domain.Entities.CapturedPokemon", b =>
                {
                    b.HasOne("backend_pokemon_challenge.domain.Entities.PokemonMaster", "PokemonMaster")
                        .WithMany()
                        .HasForeignKey("PokemonMasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PokemonMaster");
                });
#pragma warning restore 612, 618
        }
    }
}