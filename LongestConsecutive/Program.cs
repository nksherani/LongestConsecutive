// See https://aka.ms/new-console-template for more information
using LongestConsecutive;

Console.WriteLine("Hello, World!");
List<int> list = new List<int>() { 1, 2, 3 };
Console.WriteLine(LongestConsecutiveSolution.Execute(list));

list = new List<int>() { 6, 7, 3, 1, 100, 102, 6, 12 };
Console.WriteLine(LongestConsecutiveSolution.Execute(list));

list = new List<int>() { 5, 6, 1, 2, 8, 9, 7 };
Console.WriteLine(LongestConsecutiveSolution.Execute(list));

list = new List<int>() { 5, 8, 10, 11 };
Console.WriteLine(LongestConsecutiveSolution.Execute(list));

list = new List<int>() { 5 };
Console.WriteLine(LongestConsecutiveSolution.Execute(list));