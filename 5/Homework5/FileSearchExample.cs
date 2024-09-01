using Homework5.Events;
using Homework5.Helpers;

namespace Homework5;

public class FileSearchExample
{
    protected FileSearcher _fileSearcher;
    private readonly string _pattern;
    private readonly string _directory;

    public FileSearchExample(FileSearcher searcher, string directory, string pattern)
    {
        _directory = directory;
        _pattern = pattern;
        _fileSearcher = searcher;
        
    }

    public void Run()
    {
        ConfigureFileSearcher();
        _fileSearcher.Search(_directory, _pattern);
    }

    protected EventHandler<FileArgs> onFileFound = (sender, eventArgs) =>
        Console.WriteLine("Found file " + eventArgs.FoundFileName);

    protected virtual void ConfigureFileSearcher()
    {
        _fileSearcher.FileFound += onFileFound;
    }
}
