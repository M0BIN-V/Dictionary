using Dictionary.App.Data;
using Dictionary.App.Tools;

namespace Dictionary.App.Pages;

internal class RemoveWordPage : IPage
{
    public string Title => "Remove word";

    public void Show()
    {
        Console.Clear();

        Console.Write("Word : ");
        var inputWord = Console.ReadLine() ?? "";

        var word = DbRepository.GetByPersianMeaning(inputWord) ??
                   DbRepository.GetByEnglishMeaning(inputWord);

        if (word is not null)
        {
            DbRepository.Delete(word);
            Console.Clear();
            ConsoleTools.WriteSuccess("Removed");
        }
        else
        {
            ConsoleTools.WriteError("Word not found !");
        }
    }
}
