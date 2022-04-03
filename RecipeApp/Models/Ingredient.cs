using System.ComponentModel.DataAnnotations;

namespace RecipeApp.Models
{
    public class Ingredient
	{
		public int Id { get; set; }

		/// <summary>
		/// Name of the ingredient
		/// </summary>
		[Required(ErrorMessage = "Name field is required.")]
		[StringLength(maximumLength: 100, MinimumLength = 2)]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// The numerical value of the serving size of the ingredient
		/// </summary>
		[Required(ErrorMessage = "Serving size field is required.")]
		public double ServingSize { get; set; }

		/// <summary>
		/// The unit of measure for the serving size of the ingredient
		/// </summary>
		[Required(ErrorMessage = "Unit of measure field is required.")]
		public UnitOfMeasure? Units { get; set; }

		/// <summary>
		/// The number of calories per serving
		/// </summary>
		[Required(ErrorMessage = "Calories field is required.")]
		public double Calories { get; set; }

		/// <summary>
		/// The number of grams of total fat per serving
		/// </summary>
		[Required(ErrorMessage = "Total fat field is required.")]
		public double TotalFat { get; set; }

		/// <summary>
		/// The number of grams of saturated fat per serving
		/// </summary>
		[Required(ErrorMessage = "Saturated fat field is required.")]
		public double SaturatedFat { get; set; }

		/// <summary>
		/// The number of grams of trans fat per serving
		/// </summary>
		[Required(ErrorMessage = "Trans fat field is required.")]
		public double TransFat { get; set; }

		/// <summary>
		/// The number of milligrams of cholesterol per serving
		/// </summary>
		[Required(ErrorMessage = "Cholesterol field is required.")]
		public double Cholesterol { get; set; }

		/// <summary>
		/// The number of milligrams of sodium per serving
		/// </summary>
		[Required(ErrorMessage = "Sodium field is required.")]
		public double Sodium { get; set; }

		/// <summary>
		/// The number of grams of total carbs per serving
		/// </summary>
		[Required(ErrorMessage = "Total Carbohydrates field is required.")]
		public double TotalCarbs { get; set; }

		/// <summary>
		/// The number of grams of dietary fiber per serving
		/// </summary>
		[Required(ErrorMessage = "Dietary Fiber field is required.")]
		public double DietaryFiber { get; set; }

		/// <summary>
		/// The number of grams of total sugars per serving
		/// </summary>
		[Required(ErrorMessage = "Total sugars field is required.")]
		public double TotalSugars { get; set; }

		/// <summary>
		/// The number of grams of added sugars per serving
		/// </summary>
		[Required(ErrorMessage = "Added sugars field is required.")]
		public double AddedSugars { get; set; }

		/// <summary>
		/// The number of grams of protein per serving
		/// </summary>
		[Required(ErrorMessage = "Protein field is required.")]
		public double Protein { get; set; }

		/// <summary>
		/// The number of micrograms of vitamin D per serving
		/// </summary>
		[Required(ErrorMessage = "Vitamin D field is required.")]
		public double VitaminD { get; set; }

		/// <summary>
		/// The number of milligrams of calcium per serving
		/// </summary>
		[Required(ErrorMessage = "Calcium field is required.")]
		public double Calcium { get; set; }

		/// <summary>
		/// The number of milligrams of iron per serving
		/// </summary>
		[Required(ErrorMessage = "Iron field is required.")]
		public double Iron { get; set; }
		
		/// <summary>
		/// The number of milligrams of potassium per serving
		/// </summary>
		[Required(ErrorMessage = "Potassium field is required.")]
		public double Potassium { get; set; }
	}
}
