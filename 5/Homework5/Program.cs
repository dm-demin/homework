using Homework5;
using Homework5.Helpers;

MaxItemExample.Run();

// вывожу все файлы txt
var fileSearcher = new FileSearchExample (new FileSearcher(), "..\\..\\..\\Data\\SearchDir", "*.txt");
fileSearcher.Run();

// вывожу все файлы пока не найден json
var firstFileSearcher = new FileSearchWithCancellationExample(new FileSearcherWithCancellation(), "..\\..\\..\\Data\\SearchDir", "*.*");
firstFileSearcher.Run();
