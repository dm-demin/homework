using Homework5.Events;
using Homework5.Helpers;

namespace Homework5;

public class FileSearchWithCancellationExample : FileSearchExample
{
    /// <summary>
    /// Print found by mask filenames. Cancel processing when *.json found. 
    /// </summary>
    /// <param name="searcher">Searcher helper.</param>
    /// <param name="directory">Path to directory to search.</param>
    /// <param name="pattern">Filename pattern to search.</param>
    public FileSearchWithCancellationExample(FileSearcher searcher, string directory, string pattern) : base(searcher, directory, pattern)
    {
    }

    protected EventHandler<FileArgs> _onJsonFileFound = (sender, eventArgs) =>
    {
        Console.WriteLine("Found file " + eventArgs.FoundFileName);
        if(eventArgs.FoundFileName.EndsWith(".json"))
        {
            eventArgs.CancelSearch = true;
            Console.WriteLine("Json found. Process cancelled.");
        }
    };

    protected override void ConfigureFileSearcher()
    {
        _fileSearcher.FileFound += _onJsonFileFound;
    }
}
