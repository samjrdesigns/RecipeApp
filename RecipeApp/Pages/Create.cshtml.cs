#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecipeApp.Data;
using RecipeApp.Models;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Advanced;
using SixLabors.ImageSharp.Processing;

namespace RecipeApp.Pages.Recipes
{
    public class CreateModel : PageModel
    {
        private readonly RecipeApp.Data.ApplicationDbContext _context;

        public CreateModel(RecipeApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            Recipe = new Recipe();
            Recipe.PictureUrl = string.Empty;
            //Recipe.Picture = System.IO.File.ReadAllBytes(@"/app/Resources/default-picture.jpg");
            //pictureData = System.IO.File.ReadAllBytes(@"/app/Resources/default-picture.jpg");
            return Page();
        }

        //public JsonResult OnGetReplace()
        //{
        //    return new JsonResult("this is a test");
        //}

        public async Task<JsonResult> OnGetPreview(string url)
        {
            byte[] picData = await GetPictureBytes(url);

            var base64String = Convert.ToBase64String(picData);
            //Recipe.Picture = pictureData;
            return new JsonResult(base64String);
            
        }

        [BindProperty]
        public Recipe Recipe { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            Recipe.Picture = await GetPictureBytes(Recipe.PictureUrl);

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Recipes.Add(Recipe);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private async static Task<byte[]> GetPictureBytes(string url)
        {
            if (url == null || url == string.Empty)
            {
                return System.IO.File.ReadAllBytes(@"/app/Resources/default-picture.jpg");
            }

            Uri uri = new Uri(url);
            using (var client = new HttpClient())
            {
                byte[] origBytes = await client.GetByteArrayAsync(uri);

                using (var outputStream = new MemoryStream())
                {
                    using (Image image = Image.Load(origBytes))
                    {
                        Rectangle cropRect;
                        if (image.Width > image.Height)
                        {
                            int x = (image.Width - image.Height) / 2;
                            cropRect = new Rectangle(x, 0, image.Height, image.Height);
                        }
                        else if (image.Height > image.Width)
                        {
                            int y = (image.Height - image.Width) / 2;
                            cropRect = new Rectangle(0, y, image.Width, image.Width);
                        }
                        else
                        {
                            cropRect = new Rectangle(0, 0, image.Width, image.Height);
                        }

                        image.Mutate(x => x.Crop(cropRect));
                        image.Mutate(x => x.Resize(400, 400));
                        image.SaveAsJpeg(outputStream);
                    }

                    return outputStream.ToArray();
                }
            }
        }
    }
}
