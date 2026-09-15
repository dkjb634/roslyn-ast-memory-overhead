using System;
using System.Reflection;

Console.WriteLine("Source Generator запущен успешно!");

// Способ 1: Ищем класс в конкретной сборке консольного приложения
var currentAssembly = Assembly.GetExecutingAssembly();
var typeViaAssembly = currentAssembly.GetType("GeneratedNamespace.GeneratedHeavyData");
Console.WriteLine($"Сгенерированный класс найден (через Assembly): {typeViaAssembly != null}");

// Способ 2: Или можно просто использовать класс напрямую в коде без всякой рефлексии!
// Компилятор его уже видит. Можем проверить длину массива:
int arrayLength = GeneratedNamespace.GeneratedHeavyData.Data.Length;
Console.WriteLine($"Длина восстановленного массива данных: {arrayLength:N0} байт");