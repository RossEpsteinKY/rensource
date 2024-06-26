using Microsoft.AspNetCore.Mvc;
using System;

using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FaireController
    {
        private readonly AppDbContext _context;

        public FaireController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/getCreatedCharacters")]
        public async Task<ActionResult<IEnumerable<FaireDataModel>>> GetAllFaires()
        {
            return await _context.faires.Where(p => p.isDeleted == false).ToListAsync();
        }

    }
}
