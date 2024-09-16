namespace SpaceInFiles.Helpers;

/// <summary>
/// Static class for space count calculation.
/// </summary>
public static class SpaceCounter
{
    /// <summary>
    /// Method return count of some symbol in file.  
    /// </summary>
    /// <param name="filePath">Path to file.</param>
    /// <param name="symbol">Symbol to count (space by default).</param>
    /// <returns><see cref="Task"/>Number of symbol occurrences</returns>
    public static async Task<FileSymbolCountResponse> Count(string filePath, char symbol = ' ')
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("{0} not found", filePath);
        }

        var content = await File.ReadAllTextAsync(filePath);
        var count = content.Count(x => x == symbol);
        return new FileSymbolCountResponse(filePath: filePath, symbolCount: count);
    }
}
