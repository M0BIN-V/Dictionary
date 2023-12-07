using Dictionary.App.Models;

namespace Dictionary.App.Data;

internal static class DbRepository
{
    static readonly List<Word> _words =
    [
        new Word
        {
            PersianMeaning = "سلام",
            EnglishMeaning = "hello"
        },
        new Word
        {
            PersianMeaning = "بله",
            EnglishMeaning = "yes"
        },
        new Word
        {
            PersianMeaning = "خیر",
            EnglishMeaning = "no"
        },
        new Word
        {
            PersianMeaning = "آّب",
            EnglishMeaning = "whater"
        },
    ];

    public static IEnumerable<Word> Getall()
    {
        return _words;
    }

    public static void Add(Word word)
    {
        if (GetByPersianMeaning(word.PersianMeaning) is null &&
            GetByEnglishMeaning(word.EnglishMeaning) is null)
        {
            _words.Add(word);
        }
        else
        {
            throw new Exception("word exists !");
        }
    }

    public static void Delete(Word word)
    {
        var dbWord = GetByPersianMeaning(word.PersianMeaning);
        if (dbWord is not null)
        {
            _words.Remove(dbWord);
        }
        else if ((dbWord = GetByEnglishMeaning(word.EnglishMeaning)) is not null)
        {
            _words.Remove(dbWord);
        }
        else
        {
            throw new Exception("word not found !");
        }
    }

    public static Word? Get(string word)
    {
        return GetByPersianMeaning(word) ?? GetByEnglishMeaning(word);
    }

    public static Word? GetByPersianMeaning(string persianMeaning)
    {
        return _words.Find(w => w.PersianMeaning == persianMeaning);
    }

    public static Word? GetByEnglishMeaning(string englishMeaning)
    {
        return _words.Find(w => w.EnglishMeaning.ToLower() == englishMeaning.ToLower());
    }

    public static void Update(Word word)
    {
        var dbWord = GetByPersianMeaning(word.PersianMeaning);

        if (dbWord is not null)
        {
            dbWord.EnglishMeaning = word.EnglishMeaning;
            return;
        }

        dbWord = GetByEnglishMeaning(word.EnglishMeaning);

        if (dbWord is not null)
        {
            dbWord.PersianMeaning = word.PersianMeaning;
        }
        else
        {
            throw new Exception("word not found !");
        }
    }
}
