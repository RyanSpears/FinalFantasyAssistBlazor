namespace FinalFantasyAssistBlazor.Shared.Entities;

public class Book
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public string Title { get; set; }
    
    public string Number { get; set; }
    
    public override bool Equals(object obj)
    {
        return obj is Book book && Id == book.Id;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }
}