using Homework5.Events;

namespace Homework5.Helpers;

public class FileSearcherWithCancellation : FileSearcher
{
    public override void Search(string directory, string filenamePattern)
    {
        foreach (var file in Directory.EnumerateFiles(directory, filenamePattern))
        {
            FileArgs args = RaiseFileFound(file);
            if(args.CancelSearch) { break; }
        }
    }

    private new FileArgs RaiseFileFound(string file)
    {
        FileArgs args = new(file);
        FileFound?.Invoke(this, args);
        return args;
    }

}
