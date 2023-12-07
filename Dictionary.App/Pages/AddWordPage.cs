namespace Dictionary.App.Pages;

internal class AddWordPage : IPage
{
    public string Title => "Add word";

    public void Show()
    {
        Console.Clear();
        Console.WriteLine("add word");
    }
}
