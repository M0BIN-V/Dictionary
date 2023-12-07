namespace Dictionary.App.Pages;

internal class EditWordPage : IPage
{
    public string Title => "Edit word";

    public void Show()
    {
        Console.Clear();
        Console.WriteLine("edit");
    }
}
