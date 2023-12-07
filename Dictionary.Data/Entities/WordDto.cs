namespace Dictionary.Data.Entities;

public class WordDto
{
    public int Id { get; set; }

    public required string PersianMeaning { get; set; }

    public required string EnglishMeaning { get; set; }
}