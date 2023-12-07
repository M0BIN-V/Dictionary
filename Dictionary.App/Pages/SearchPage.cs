using Dictionary.App.Data;
using Dictionary.App.Tools;

namespace Dictionary.App.Pages
{
    internal class SearchPage : IPage
    {
        public string Title => "Search";

        public void Show()
        {
            Console.Clear();

            Console.Write("Enter word : ");
            var input = Console.ReadLine() ?? "";

            var result = DbRepository.GetByEnglishMeaning(input) ??
                         DbRepository.GetByPersianMeaning(input);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;

            if (result is null)
            {
                ConsoleTools.WriteError("Word not found !");
            }
            else
            {
                Console.WriteLine($"English : {result.EnglishMeaning}");
                Console.WriteLine($"Persian : {result.PersianMeaning}");

                Console.WriteLine("====================================");
                Console.ResetColor();
                Console.WriteLine("Press 'ENTER' to return to the menu");
                Console.ReadLine();
            }
        }
    }
}
