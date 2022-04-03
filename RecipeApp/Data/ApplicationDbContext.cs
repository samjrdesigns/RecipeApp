using Microsoft.EntityFrameworkCore;
using RecipeApp.Models;

namespace RecipeApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {

        }

        public DbSet<Recipe>? Recipes { get; set; }
    }
}
