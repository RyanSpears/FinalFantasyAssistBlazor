using FinalFantasyAssistBlazor.API.Models;
using FinalFantasyAssistBlazor.Shared;
using FinalFantasyAssistBlazor.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Supabase;

namespace FinalFantasyAssistBlazor.API.Controllers;

[ApiController]
[Route("[controller]")]
public class MonstersController : ControllerBase
{
    private readonly Client _db;

    public MonstersController(Client Db)
    {
        _db = Db;
        Db.InitializeAsync().Wait();
    }
    
    [HttpGet(Name = "GetMonsters")]
    public async Task<IEnumerable<Monster>> Get()
    {

        var response = await _db.From<MonsterModel>().Get();

        var monsters = response.Models.Select(b => new Monster
        {
            Id = b.Id,
            CreatedAt = b.CreatedAt,
            Name = b.Name,
            Skill = b.Skill,
            Stamina = b.Stamina,
            BookId = b.BookId
        });

        return monsters.ToList();
    }
}
