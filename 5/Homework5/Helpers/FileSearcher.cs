using Homework5.Events;

namespace Homework5.Helpers;

public class FileSearcher
{
    public EventHandler<FileArgs>? FileFound;

    public virtual void Search(string directory, string filenamePattern)
    {
        foreach (var file in Directory.EnumerateFiles(directory, filenamePattern))
        {
            RaiseFileFound(file);
        }
    }

    protected virtual void RaiseFileFound(string file) => 
        FileFound?.Invoke(this, new FileArgs(file));
}
