using Dictionary.App.Pages;

namespace Dictionary.App.Components;

internal class Menu
{
    public required List<IPage> Pages { get; set; } = [];

    public void Show()
    {
        int selectedPageIndex = 1;

        while (true)
        {
            Console.Clear();
            for (int i = 1; i <= Pages.Count; i++)
            {
                var page = Pages[i - 1];

                Console.Write("[");

                if (i == selectedPageIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("#");
                }
                else
                {
                    Console.Write(" ");
                }

                Console.ResetColor();

                Console.WriteLine($"] {page.Title}");
            }

            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.DownArrow)
            {
                if (selectedPageIndex < Pages.Count)
                    selectedPageIndex++;
            }
            else if (key.Key == ConsoleKey.UpArrow)
            {
                if (selectedPageIndex > 1)
                    selectedPageIndex--;
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                Pages[selectedPageIndex - 1].Show();
            }
        }
    }
}
