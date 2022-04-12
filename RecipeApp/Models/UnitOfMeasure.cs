namespace RecipeApp.Models
{
    public class UnitOfMeasure
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Abbreviation { get; set; } = string.Empty;

        /// <summary>
        /// True if this unit of measure is for dry ingredients; false if meant for liquid ingredients
        /// </summary>
        public bool IsDryMeasure { get; set; }

        /// <summary>
        /// This is the conversion constant. It represents the number of milliliters (liquid measure)
        /// or grams (dry measure) contained in 1 unit of this type.
        /// </summary>
        public double Conversion { get; set; }
    }
}
