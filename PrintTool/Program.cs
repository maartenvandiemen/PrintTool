// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Print: {Splitter.Split(args)}");

internal static class Splitter
{
    internal static string Split(string[] args) => string.Join(", ", args);
}
