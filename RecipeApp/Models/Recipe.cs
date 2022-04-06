﻿using System.ComponentModel.DataAnnotations;

namespace RecipeApp.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        /// <summary>
        /// Recipe title/name
        /// </summary>
        [Required(ErrorMessage = "Title field is required.")]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Recipe description
        /// </summary>
        [StringLength(maximumLength: 1000)]
        public string? Description { get; set; }

        /// <summary>
        /// Directions to make this recipe
        /// </summary>
        [StringLength(maximumLength: 4000)]
        public string? Directions { get; set; }
        
        /// <summary>
        /// Additional notes, including modifications, for this recipe
        /// </summary>
        [StringLength(maximumLength: 4000)]
        public string? Notes { get; set; }

        /// <summary>
        /// Time, in minutes, to cook/bake this recipe
        /// </summary>
        public int? CookTime { get; set; }

        /// <summary>
        /// Time, in minutes, necessary to prepare to cook/bake this recipe
        /// </summary>
        public int? PrepTime { get; set; }
	
        /// <summary>
        /// Number of servings and/or amount this recipe produces
        /// </summary>
        public string? Yield { get; set; }

        /// <summary>
        /// Profile picture for this recipe
        /// </summary>
        public byte[]? Picture { get; set; }

        /// <summary>
        /// Collection of ingredients used by this recipe
        /// </summary>
        public ICollection<Ingredient>? Ingredients { get; set; }

    }
}