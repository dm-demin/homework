namespace Homework5.Events;

public class FileArgs : EventArgs
{
    public string FoundFileName { get; }
    public bool CancelSearch { get; set; }

    public FileArgs(string fileName) => FoundFileName = fileName;
}
