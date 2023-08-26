// See https://aka.ms/new-console-template for more information

Func<int, int, int> func = (int x, int y) => x + y;
Action<string> action = str => Console.WriteLine(str);
Predicate<int> predicate = age => age >= 18;

Console.WriteLine(func);
action("hello");
Console.WriteLine(predicate);
