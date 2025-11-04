using E_commerce_Temp.Data;
using E_commerce_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_commerce_Temp.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public Category Category { get; set; }

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet(int? id)
        {
            if (id == null || id == 0)
            {
                RedirectToPage("Index");
            }
            Category = _context.Categories.Find(id);
        }
        public IActionResult OnPost(int? id)
        {
            if (id == null || id == 0)
            {
                return RedirectToPage("Index");
            }
            Category = _context.Categories.Find(id);
            if (Category != null)
            {
                _context.Categories.Remove(Category);
                _context.SaveChanges();
                TempData["success"] = "Category deleted successfully!";
            }
            return RedirectToPage("Index");
        }
    }
}
