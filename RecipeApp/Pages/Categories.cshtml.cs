#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data;
using RecipeApp.Models;

namespace RecipeApp.Pages
{
    public class CategoriesModel : PageModel
    {
        private readonly RecipeApp.Data.ApplicationDbContext _context;

        public CategoriesModel(RecipeApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //Category = await _context.Categories.FirstOrDefaultAsync(m => m.Id == id);

            //if (Category == null)
            //{
            //    return NotFound();
            //}
            return Page();
        }

        public JsonResult OnGetReadCategories()
        {
            JsonResult result = new JsonResult(_context.Categories);
            return result;
        }
        
        public JsonResult OnGetSave(string idStr, string name)
        {
            if (idStr.Equals("NEW"))
            {
                Category category = new Category()
                {
                    Name = name
                };
                _context.Categories.Add(category);
            }
            else
            {
                int id;
                bool success = int.TryParse(idStr, out id);

                if (success)
                {
                    Category category = _context.Categories.FirstOrDefault(c => c.Id == id);
                    if (category != null)
                    {
                        category.Name = name;
                    }
                }
            }

            _context.SaveChanges();
            return new JsonResult(_context.Categories.FirstOrDefault(c => c.Name == name)?.Id);
        }

        public void OnGetDelete(string idStr)
        {
            int id;
            bool success = int.TryParse(idStr, out id);

            if (success)
            {
                Category category = _context.Categories.FirstOrDefault(c => c.Id == id);
                if (category != null)
                {
                    _context.Categories.Remove(category);
                    _context.SaveChanges();
                }
            }
        }
    }
}
