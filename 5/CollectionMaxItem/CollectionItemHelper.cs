using System.Collections;

namespace CollectionMaxItem;

public static class CollectionItemHelper
{
    /// <summary>
    /// Return max collection element. If collection has elements with same value last of this element will be returned.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="collection">Collection of T items.</param>
    /// <param name="convertToNumber">Delegate function to convert item to float.</param>
    /// <returns>max element</returns>
    /// <exception cref="Exception">Possible when collection is empty.</exception>
    public static T GetMax<T>(this IEnumerable collection, Func<T, float> convertToNumber) where T : class
    {
        T? maxItem = null;
        float currentMax = float.MinValue;
        foreach (T item in collection)
            if(currentMax <= convertToNumber(item))
            {
                currentMax = convertToNumber(item);
                maxItem = item;
            }
        if (maxItem is null) throw new Exception("Cannot find max element.");
        return maxItem;
    }

}
