using Postgrest.Attributes;
using Postgrest.Models;

namespace FinalFantasyAssistBlazor.API.Models;

[Table("books")]
public class BookModel : BaseModel
{
    [PrimaryKey]
    public int Id { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("title")]
    public string Title { get; set; }
    
    [Column("number")]
    public string Number { get; set; }
    
    public override bool Equals(object obj)
    {
        return obj is BookModel book && Id == book.Id;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }
}