using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BasketballChallenge.Data;
using BasketballChallenge.Data.Models;

namespace BasketballChallenge.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly BasketballChallenge.Data.ApplicationDbContext _context;

        public IndexModel(BasketballChallenge.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
