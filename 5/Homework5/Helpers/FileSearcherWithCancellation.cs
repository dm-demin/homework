using Homework5.Events;

namespace Homework5.Helpers;

public class FileSearcherWithCancellation : FileSearcher
{
    public override void Search(string directory, string filenamePattern)
    {
        foreach (var file in Directory.EnumerateFiles(directory, filenamePattern).Select(Path.GetFileName))
        {
            var args = RaiseFileFound(file);
            if(args.CancelSearch)
            {
                break;
            }
        }
    }

    private new FileArgs RaiseFileFound(string file)
    {
        var args = new FileArgs(file);
        FileFound?.Invoke(this, args);
        return args;
    }
}
