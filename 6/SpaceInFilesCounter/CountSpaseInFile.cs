using System.Diagnostics;
using SpaceInFiles.Helpers;

namespace SpaceInFiles;

public static class CountSpaceInFiles
{
    /// <summary>
    /// Для первого задания - Прочитать 3 файла параллельно и вычислить количество пробелов в них.
    /// </summary>
    public static async Task CountThreeFiles()
    {
        var files = new List<string>([
            "..\\..\\..\\Data\\1(19).txt",
            "..\\..\\..\\Data\\2(26).txt",
            "..\\..\\..\\Data\\3(20).txt"
        ]);

        Console.WriteLine("Calculate count of space in 3 files:");
        await RunAsync(files);
        
    }

    /// <summary>
    /// Для второго задания - Написать функцию, принимающую в качестве аргумента путь к папке.
    /// Из этой папки параллельно прочитать все файлы и вычислить количество пробелов в них.
    /// </summary>
    public static async Task CountAllInDirectoryAsync(string path)
    {
        List<string> files  = Directory.EnumerateFiles(path, "*").ToList();

        Console.WriteLine("Calculate count of space all files in {0}:", Path.GetFullPath(path));
        await RunAsync(files);
    }

    private static async Task RunAsync(List<string> filePaths)
    {
        var stopwatch = Stopwatch.StartNew();

        var tasks = filePaths.Select(file => SymbolCounter.Count(file)).ToList();
        var resultTasks = await Task.WhenAll(tasks);

        stopwatch.Stop();

        foreach (var result in resultTasks)
        {
            Console.WriteLine("File {0} contains {1} symbols", result.name, result.count);
        }

        Console.WriteLine("Finished. Working time was {0} ms", stopwatch.ElapsedMilliseconds);
    }
}
