using System.ComponentModel.DataAnnotations;

namespace RecipeApp.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title field is required.")]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Title { get; set; } = string.Empty;

        [StringLength(maximumLength: 1000)]
        public string? Description { get; set; }

        [StringLength(maximumLength: 4000)]
        public string? Directions { get; set; }
        
        [StringLength(maximumLength: 2000)]
        public string? Modifications { get; set; }

        public int? CookTime { get; set; }

        public int? PrepTime { get; set; }
	
        public string? Yield { get; set; }

        public byte[]? Picture { get; set; }

        public List<Ingredient>? IngredientList { get; set; }

    }
}
