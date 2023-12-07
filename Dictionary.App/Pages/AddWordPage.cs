using Dictionary.App.Data;
using Dictionary.App.Models;
using Dictionary.App.Tools;

namespace Dictionary.App.Pages;

internal class AddWordPage : IPage
{
    public string Title => "Add word";

    public void Show()
    {
        Console.Clear();
        Console.Write("English : ");
        var englishWord = Console.ReadLine();

        Console.Write("Persian : ");
        var persianWord = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(englishWord))
        {
            ConsoleTools.WriteError("English word is empty !");
        }
        else if (string.IsNullOrWhiteSpace(persianWord))
        {
            ConsoleTools.WriteError("Persian word is empty !");
        }
        else
        {
            var word = new Word
            {
                EnglishMeaning = englishWord,
                PersianMeaning = persianWord
            };

            try
            {
                DbRepository.Add(word);
                Console.Clear();
                ConsoleTools.WriteSuccess("Added");
            }
            catch
            {
                ConsoleTools.WriteError("this word exists !");
            }
        }
    }
}
