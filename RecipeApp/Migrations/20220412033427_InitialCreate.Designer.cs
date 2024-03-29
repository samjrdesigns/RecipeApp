﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeApp.Data;

#nullable disable

namespace RecipeApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220412033427_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("IngredientRecipe", b =>
                {
                    b.Property<int>("IngredientsId")
                        .HasColumnType("int");

                    b.Property<int>("RecipesId")
                        .HasColumnType("int");

                    b.HasKey("IngredientsId", "RecipesId");

                    b.HasIndex("RecipesId");

                    b.ToTable("IngredientRecipe");
                });

            modelBuilder.Entity("RecipeApp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("RecipeApp.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("AddedSugars")
                        .HasColumnType("double");

                    b.Property<double>("Calcium")
                        .HasColumnType("double");

                    b.Property<double>("Calories")
                        .HasColumnType("double");

                    b.Property<double>("Cholesterol")
                        .HasColumnType("double");

                    b.Property<double>("DietaryFiber")
                        .HasColumnType("double");

                    b.Property<double>("Iron")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<double>("Potassium")
                        .HasColumnType("double");

                    b.Property<double>("Protein")
                        .HasColumnType("double");

                    b.Property<double>("SaturatedFat")
                        .HasColumnType("double");

                    b.Property<double>("ServingSize")
                        .HasColumnType("double");

                    b.Property<double>("Sodium")
                        .HasColumnType("double");

                    b.Property<double>("TotalCarbs")
                        .HasColumnType("double");

                    b.Property<double>("TotalFat")
                        .HasColumnType("double");

                    b.Property<double>("TotalSugars")
                        .HasColumnType("double");

                    b.Property<double>("TransFat")
                        .HasColumnType("double");

                    b.Property<int>("UnitsId")
                        .HasColumnType("int");

                    b.Property<double>("VitaminD")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("UnitsId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("RecipeApp.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("CookTime")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Directions")
                        .HasMaxLength(4000)
                        .HasColumnType("varchar(4000)");

                    b.Property<string>("Notes")
                        .HasMaxLength(4000)
                        .HasColumnType("varchar(4000)");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("longblob");

                    b.Property<int?>("PrepTime")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Yield")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("RecipeApp.Models.UnitOfMeasure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Conversion")
                        .HasColumnType("double");

                    b.Property<bool>("IsDryMeasure")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("IngredientRecipe", b =>
                {
                    b.HasOne("RecipeApp.Models.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeApp.Models.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecipeApp.Models.Ingredient", b =>
                {
                    b.HasOne("RecipeApp.Models.UnitOfMeasure", "Units")
                        .WithMany()
                        .HasForeignKey("UnitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Units");
                });

            modelBuilder.Entity("RecipeApp.Models.Recipe", b =>
                {
                    b.HasOne("RecipeApp.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
