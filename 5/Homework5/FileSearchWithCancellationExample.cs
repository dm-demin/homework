using Homework5.Events;
using Homework5.Helpers;

namespace Homework5;

public class FileSearchWithCancellationExample : FileSearchExample
{
    public FileSearchWithCancellationExample(FileSearcher searcher, string directory, string pattern) : base(searcher, directory, pattern)
    {
    }

    protected new EventHandler<FileArgs> onFileFound = (sender, eventArgs) =>
    {
        Console.WriteLine("Found file {name}" + eventArgs.FoundFileName + ". Stop searching");
        eventArgs.CancelSearch = true;
    };

    protected override void ConfigureFileSearcher()
    {
        _fileSearcher.FileFound += onFileFound;
    }

}
