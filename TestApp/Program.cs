using System;
using System.Reflection;

Console.WriteLine("Source Generator launched");

var currentAssembly = Assembly.GetExecutingAssembly();
var typeViaAssembly = currentAssembly.GetType("GeneratedNamespace.GeneratedHeavyData");
Console.WriteLine($" GeneratedNamespace.GeneratedHeavyData: {typeViaAssembly != null}");

int arrayLength = GeneratedNamespace.GeneratedHeavyData.Data.Length;
Console.WriteLine($"Restored array length: {arrayLength:N0} bytes");