using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public CreateModel(ApplicationDBContext db)
        {
            _db = db;
        }

        //[BindProperty]
        public Book book { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(Book book)
        {
            if (ModelState.IsValid)
            {
                await _db.Book.AddAsync(book);
                await _db.SaveChangesAsync();
                return RedirectToPage("/BookList/Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
