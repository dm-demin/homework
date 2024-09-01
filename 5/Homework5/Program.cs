using Homework5;
using Homework5.Helpers;

MaxItemExample.Run();

var fileSearcher = new FileSearchExample (new FileSearcher(), "..\\..\\..\\Data\\SearchDir", "*.txt");
fileSearcher.Run();

var firstFileSearcher = new FileSearchWithCancellationExample(new FileSearcherWithCancellation(), "..\\..\\..\\Data\\SearchDir", "*.*");
firstFileSearcher.Run();
