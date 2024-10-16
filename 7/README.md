# Домашняя работа 7 - Многопоточный проект

## Цель
Применение разных способов распараллеливания задач и оценка оптимального способа реализации.

## Описание
1. Напишите вычисление суммы элементов массива интов:
  - Обычное
  - Параллельное (для реализации использовать Thread, например List)
  - Параллельное с помощью LINQ

2. Замерьте время выполнения для 100 000, 1 000 000 и 10 000 000

3. Укажите в таблице результаты замеров, указав:
  - Окружение (характеристики компьютера и ОС)
  - Время выполнения последовательного вычисления
  - Время выполнения параллельного вычисления
  - Время выполнения LINQ

## Результаты

Результаты получены на машине с Win11, CPU AMD Ryzen 5 PRO 4650U 2.10 GHz, 16Gb RAM

| Метод         | 100 000  | 1 000 000 | 10 000 000 |
|---------------|----------|-----------|------------|
| Sequential    |      0   |    2      |   20       |
| Parallel      |      7   |    9      |   18       |
| Parallel.LINQ |      7   |    10     |   36       |

## Ссылки
https://learn.microsoft.com/en-us/dotnet/standard/parallel-programming/how-to-write-a-parallel-for-loop-with-thread-local-variables
