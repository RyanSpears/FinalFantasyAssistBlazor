using Postgrest.Attributes;
using Postgrest.Models;

namespace FinalFantasyAssistBlazor.API.Models;

[Table("monsters")]
public class MonsterModel : BaseModel
{
    [PrimaryKey]
    public int Id { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("skill")]
    public int Skill { get; set; }

    [Column("stamina")]
    public int Stamina { get; set; }

    [Column("book_id")]
    public int BookId { get; set; }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }
}