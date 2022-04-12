using System.ComponentModel.DataAnnotations;

namespace RecipeApp.Models
{
    public class Category
    {
        public int Id { get; set; }

        /// <summary>
        /// Category name
        /// </summary>
        [Required(ErrorMessage = "Title field is required.")]
        [StringLength(maximumLength: 50, MinimumLength = 2)]
        public string Name { get; set; }
    }
}
