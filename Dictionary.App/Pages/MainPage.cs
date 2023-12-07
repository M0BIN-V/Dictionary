using Dictionary.App.Components;

namespace Dictionary.App.Pages;

internal class MainPage : IPage
{
    public string Title => "Main";

    public void Show()
    {
        var menu = new Menu
        {
            Pages =
            [
                new SearchPage(),
                new AddWordPage(),
                new EditWordPage(),
                new RemoveWordPage()
            ]
        };

        menu.Show();
    }
}
