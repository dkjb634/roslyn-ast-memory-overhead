using System;

Console.WriteLine("Source Generator запущен успешно!");
// Класс GeneratedHeavyData создан генератором. Мы можем его увидеть через рефлексию
var type = Type.GetType("GeneratedNamespace.GeneratedHeavyData");
Console.WriteLine($"Сгенерированный класс найден: {type != null}");