namespace Dictionary.App.Tools;

internal static class ConsoleTools
{
    public static void WriteError(string text)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(text);
        Console.ResetColor();
        End();
    }

    public static void WriteSuccess(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(text);
        Console.ResetColor();
        End();
    }

    private static void End()
    {
        Console.WriteLine("===================================");
        Console.Write("Press 'ENTER' to return to the menu");
        Console.ReadLine();
    }
}
