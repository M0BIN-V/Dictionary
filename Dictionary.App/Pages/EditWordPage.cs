using Dictionary.App.Data;
using Dictionary.App.Tools;

namespace Dictionary.App.Pages;

internal class EditWordPage : IPage
{
    public string Title => "Edit word";

    public void Show()
    {
        Console.Clear();

        Console.Write("Word : ");
        var inputWord = Console.ReadLine() ?? "";

        var word = DbRepository.Get(inputWord);

        Console.Clear();

        if (word is not null)
        {
            Console.WriteLine($"Old English meaning : {word.EnglishMeaning}");
            Console.WriteLine($"Old Persian meaning : {word.PersianMeaning}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.Write("New English meaning : ");
            var english = Console.ReadLine();

            Console.Write("New Persian meaning : ");
            var persian = Console.ReadLine();

            if (string.IsNullOrEmpty(english))
            {
                ConsoleTools.WriteError("English meaning is empty !");
            }
            else if (string.IsNullOrEmpty(persian))
            {
                ConsoleTools.WriteError("Persian meaning is empty !");
            }
            else
            {
                word.EnglishMeaning = english;
                word.PersianMeaning = persian;

                DbRepository.Update(word);
                Console.Clear();
                ConsoleTools.WriteSuccess("Edited ");
            }
        }
        else
        {
            ConsoleTools.WriteError("Word not found !");
        }
    }
}
