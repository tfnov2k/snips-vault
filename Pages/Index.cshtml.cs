using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using snipsvault.Data;
using snipsvault.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace snipsvault.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
            Snippets = new List<Snippet>();
        }

        public List<Snippet> Snippets { get; set; }

        public async Task OnGetAsync()
        {
            Snippets = await _context.Snippets.ToListAsync();
        }
    }
}
