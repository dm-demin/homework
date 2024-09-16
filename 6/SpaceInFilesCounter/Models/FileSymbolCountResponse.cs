namespace SpaceInFiles;

public class FileSymbolCountResponse
{
    public string name { get; set; }
    public string path {get; set; }
    public int count { get; set; }

    public FileSymbolCountResponse(string filePath, int symbolCount)
    {
        path = filePath;
        name = Path.GetFileName(filePath);
        count = symbolCount;
    }
}
