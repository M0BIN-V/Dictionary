namespace Dictionary.App.Pages;

internal interface IPage
{
    public string Title { get; }
    public void Show();
}
