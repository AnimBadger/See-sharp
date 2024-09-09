using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using See_sharp.Data;
using See_sharp.Models;

namespace See_sharp.Controllers;

[Route("API/[controller]")]
[ApiController]
public class ArticleController : ControllerBase
{
    private readonly ApiDbContext _context;
    
    public ArticleController(ApiDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Article>>> GetArticles()
    {
        return await _context.Articles.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Article>> GetAnArticle(int id)
    {
        var article = await _context.Articles.FindAsync(id);

        if (article == null)
        {
            return NotFound();
        }
        return article;
    }

}
