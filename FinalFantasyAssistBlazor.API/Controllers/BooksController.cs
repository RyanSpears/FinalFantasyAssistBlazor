using FinalFantasyAssistBlazor.API.Models;
using FinalFantasyAssistBlazor.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Supabase;

namespace FinalFantasyAssistBlazor.API.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly Client _db;

    public BooksController(Client db)
    {
        _db = db;
        db.InitializeAsync().Wait();
    }
    
    [HttpGet(Name = "GetBooks")]
    public async Task<IEnumerable<Book>> Get()
    {

        var response = await _db.From<BookModel>().Get();

        var books = response.Models.Select(b => new Book
        {
            Id = b.Id,
            CreatedAt = b.CreatedAt,
            Title = b.Title,
            Number = b.Number
        });

        return books.ToList();
    }
}