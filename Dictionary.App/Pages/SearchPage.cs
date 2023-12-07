using Dictionary.App.Data;

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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("word not found !");
            }
            else
            {
                Console.WriteLine($"English : {result.EnglishMeaning}");
                Console.WriteLine($"Persian : {result.PersianMeaning}");
            }
            Console.WriteLine("===================");
            Console.ResetColor();
            Console.WriteLine("Press 'ENTER' to return to the menu");
            Console.ReadLine();
        }
    }
}
