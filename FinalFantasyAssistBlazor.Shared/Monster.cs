namespace FinalFantasyAssistBlazor.Shared.Entities;

public class Monster
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public string Name { get; set; }

    public int Skill { get; set; }

    public int Stamina { get; set; }

    public int BookId { get; set; }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }
}