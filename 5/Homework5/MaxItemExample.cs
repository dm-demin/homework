using CollectionMaxItem;

namespace Homework5;

public static class MaxItemExample
{
    public static void Run()
    {
        // Создадим коллекцию и найдем максимальный элемент:
        var someList = new List<string>() {
            "1,5",
            "1",
            "2,5",
            "1"
        };

        var maxItem = someList.GetMax<string>(str=>float.Parse(str));
        Console.WriteLine("Max items in collections is " + maxItem);
    }
}
