// See https://aka.ms/new-console-template for more information

using Query;

Func<List<int>, List<int>> func = Queries.PopulationOver18;

Action<List<int>> action = Queries.PrintResult;
