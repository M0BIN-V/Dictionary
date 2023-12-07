using Dictionary.Data.Entities;

namespace Dictionary.Data.Repository;

internal class Repository
{
    static readonly List<WordDto> _words = [];

    public void Add(WordDto word)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public bool Exists(WordDto word)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<WordDto> GetAll()
    {
        throw new NotImplementedException();
    }

    public WordDto? GetByEnglishMeaning(string EnglishWord)
    {
        throw new NotImplementedException();
    }

    public WordDto? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public WordDto? GetByPersianMeaning(string persianWord)
    {
        throw new NotImplementedException();
    }

    public void SaveChanges()
    {
        throw new NotImplementedException();
    }

    public void Update(WordDto word)
    {
        throw new NotImplementedException();
    }
}
