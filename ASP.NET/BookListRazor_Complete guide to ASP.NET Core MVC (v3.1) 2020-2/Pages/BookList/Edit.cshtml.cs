using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public EditModel(ApplicationDBContext db)
        {
            _db = db;
        }

        public Book book { get; set; }

        public async Task OnGet(int id)
        {
            book = await _db.Book.FindAsync(id);
            //return Page(book);
        }

        public async Task<IActionResult> Onpost(Book book)
        {
            if (ModelState.IsValid)
            {
                var BookFromDataBase = await _db.Book.FindAsync(book.Id);
                BookFromDataBase.Name = book.Name;
                BookFromDataBase.Author = book.Author;
                BookFromDataBase.ISBN = book.ISBN;

                await _db.SaveChangesAsync();

                return RedirectToPage("/BookList/Index");
            }
            else
            {
                return RedirectToPage();
            }

        }
    }
}
