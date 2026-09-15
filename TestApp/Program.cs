using System;
using System.Reflection;

Console.WriteLine("Source Generator launched");

var currentAssembly = Assembly.GetExecutingAssembly();
var typeViaAssembly = currentAssembly.GetType("GeneratedNamespace.GeneratedHeavyData");
Console.WriteLine($"The GeneratedNamespace.GeneratedHeavyData: {typeViaAssembly != null}");

int arrayLength = GeneratedNamespace.GeneratedHeavyData.Data.Length;
Console.WriteLine($"Data array lenght: {arrayLength:N0} байт");