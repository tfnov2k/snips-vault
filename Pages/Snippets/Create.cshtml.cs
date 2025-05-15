using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using snipsvault.Data;
using snipsvault.Models;
using System.Threading.Tasks;

namespace snipsvault.Pages.Snippets
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public CreateModel(AppDbContext context)
        {
            _context = context;
            Snippet = new Snippet();  
        }

        [BindProperty]
        public Snippet Snippet { get; set; }

        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Snippets.Add(Snippet);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");  
        }
    }
}
