#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BuiXuanToan.Model;

namespace BuiXuanToan.Pages_comment
{
    public class IndexModel : PageModel
    {
        private readonly CategoryContext _context;

        public IndexModel(CategoryContext context)
        {
            _context = context;
        }

        public IList<comment> comment { get;set; }

        public async Task OnGetAsync()
        {
            comment = await _context.comment.ToListAsync();
        }
    }
}
