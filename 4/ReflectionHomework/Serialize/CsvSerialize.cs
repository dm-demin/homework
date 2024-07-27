using System.Reflection;

namespace ReflectionHomework.Serialize;

/// <summary>
/// Класс для сериализации объекта произвольного типа в строку в формате CSV
/// </summary>
public static class CsvSerializer
{
    /// <summary>
    /// Метод возвращает строковое представление объекта как перечисление значения полей.
    /// </summary>
    /// <typeparam name="T">Тип объекта.</typeparam>
    /// <param name="obj">Объект, который нужно сериализовать.</param>
    /// <param name="delimiter">Разделитель колонок в CSV, по умолчанию ";"</param>
    /// <returns>Строка со значениями свойств объектов.</returns>
    public static string Serialize(object obj, string delimiter = ";")
    {
        var result = string.Empty;
        var type = obj.GetType();

        foreach (var field in type.GetFields())
        {
            if (result.Length > 0)
            {
                result += delimiter;
            }

            result += field.GetValue(obj);
        }

        return result;
    }

    /// <summary>
    /// Метод десериализации строки CSV в объект типа T. Важен порядок полей в файле.
    /// </summary>
    /// <typeparam name="T">Тип объекта для сериализации.</typeparam>
    /// <param name="text">Строка для десериализации.</param>
    /// <param name="delimiter">Разделитель CSV, по умолчанию ";".</param>
    /// <returns>Объект типа T.</returns>
    public static T Deserialize<T>(string text, string delimiter = ";")
    {
        var type = typeof(T);
        var fields = type.GetFields();

        var result = Activator.CreateInstance(type);

        int i = 0;
        foreach (string param in text.Split(delimiter))
        {
            fields[i].SetValue(result, Convert.ChangeType(param, fields[i].FieldType, null));
            i++;
        }

        return (T)result;
    }

    /// <summary>
    /// Метод десериализации строки CSV в объект типа T.
    /// </summary>
    /// <typeparam name="T">Тип объекта для сериализации.</typeparam>
    /// <param name="text">Строка для десериализации.</param>
    /// <param name="header">Строка заголовка параметров.</param>
    /// <param name="delimiter">Разделитель CSV, по умолчанию ";".</param>
    /// <returns>Объект типа T.</returns>
    public static T Deserialize<T>(string text, string header, string delimiter = ";")
    {
        var type = typeof(T);
        FieldInfo[] fields = type.GetFields();

        var result = Activator.CreateInstance(type);

        int i = 0;
        var values = text.Split(delimiter);

        foreach (string param in header.Split(delimiter))
        {
            FieldInfo field = fields.Where(x => x.Name == param).First<FieldInfo>();
            field.SetValue(result, Convert.ChangeType(values[i], field.FieldType, null));
            i++;
        }

        return (T)result;
    }

    /// <summary>
    /// Метод получения заголовков для указанного типа объектов.
    /// </summary>
    /// <typeparam name="T">Тип объекта для сериализации</typeparam>
    /// <param name="separator">Разделитель, по умолчанию ";"</param>
    /// <returns>Строка заголовка</returns>
    public static string GetHeaders<T>(string separator = ";")
    {
        var result = string.Empty;
        var type = typeof(T);

        foreach (var field in type.GetFields())
        {
            if (result.Length > 0)
            {
                result += separator;
            }

            result += field.Name;
        }

        return result;
    }
}
