using Homework5.Models;
using Homework5.Helpers;
using CollectionMaxItem;

namespace Homework5;

public static class MaxItemExample
{
    public static void Run()
    {
        // Создадим коллекцию и найдем максимальный элемент:
        var someList = new List<SomeType>() {
            new(name: "one", weight: 1f),
            new(name: "two", weight: 2f),
            new(name: "two-and-half", weight: 2.5f),
            new(name: "one-and-half", weight: 1.5f)
        };

        var maxItem = CollectionItemHelper.GetMax<SomeType>(someList, SomeTypeToFloat.GetFloat);
        Console.WriteLine("Max items in collections is " + maxItem);
    }
}
