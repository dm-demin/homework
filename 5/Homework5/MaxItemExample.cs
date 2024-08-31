using Homework5.Models;
using Homework5.Helpers;
using CollectionMaxItem;

namespace Homework5;

public static class MaxItemExample
{
    public static void Run()
    {
        // Создадим коллекцию и найдем максимальный элемент:
        List<SomeType> SomeList = new () {
            new SomeType(name: "one", weight: 1f),
            new SomeType(name: "two", weight: 2f),
            new SomeType(name: "two-and-half", weight: 2.5f),
            new SomeType(name: "one-and-half", weight: 1.5f)
        };

        SomeType maxItem = CollectionItemHelper.GetMax<SomeType>(SomeList, SomeTypeToFloat.GetFloat);
        Console.WriteLine("Max items in collections is " + maxItem);
    }
}
