## 1. Написать обобщённую функцию расширения, находящую и возвращающую максимальный элемент коллекции.

Функция должна принимать на вход делегат, преобразующий входной тип в число для возможности поиска максимального значения.
public static T GetMax(this IEnumerable collection, Func<T, float> convertToNumber) where T : class;

Функция расширения реализована в файле [CollectionItemHelper.cs](..\CollectionMaxItem\CollectionItemHelper.cs)
Делегат преобразования к типу float в файле [SomeTypeToFloat.cs](Helpers\SomeTypeToFloat.cs)
Тип описан в [SomeType.cs](Models\SomeType.cs)

## 2. Написать класс, обходящий каталог файлов и выдающий событие при нахождении каждого файла;
Класс описан в [FileSearcher.cs](Helpers\FileSearcher.cs)

## 3. Оформить событие и его аргументы с использованием .NET соглашений:
public event EventHandler FileFound; FileArgs – будет содержать имя файла и наследоваться от EventArgs

## 4. Добавить возможность отмены дальнейшего поиска из обработчика;
Для этого расширен класс FileSearcher из п.2 - [FileSearcherWithCancellation.cs](Helpers\FileSearcherWithCancellation.cs)

## 5. Вывести в консоль сообщения, возникающие при срабатывании событий и результат поиска максимального элемента.
Файлы с примерами вызовов:
 - [FileSearchExample.cs](FileSearchExample.cs)
 - [FileSearchWithCancellationExample.cs](FileSearchWithCancellationExample.cs)
 - [MaxItemExample.cs](MaxItemExample.cs)


## Использованные материалы:
https://learn.microsoft.com/en-us/dotnet/csharp/event-pattern