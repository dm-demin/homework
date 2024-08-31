using Homework5;
using Homework5.Helpers;

MaxItemExample.Run();

FileSearchExample fileSearcher = new(new FileSearcher(), "..\\..\\..\\Data\\SearchDir", "*.txt");
fileSearcher.Run();

FileSearchWithCancellationExample firstFileSearcher = new(new FileSearcherWithCancellation(), "..\\..\\..\\Data\\SearchDir", "*.txt");
firstFileSearcher.Run();

