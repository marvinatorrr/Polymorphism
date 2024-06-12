using Polymorphism;
using System.Diagnostics;

// Dynamic polymorphism test
var dynamicParser = new MyParserA();
var dynamicStopWatch = Stopwatch.StartNew();
for (var i = 0; i < 1_000_000; i++)
{
    dynamicParser.Traverse(new Node());
}
dynamicStopWatch.Stop();
Console.WriteLine($"Dynamic polymorphism time elapsed: {dynamicStopWatch.ElapsedMilliseconds} ms");

// Static polymorphism test
var staticParser = new StaticParser<StaticParserA>();
var staticStopWatch = Stopwatch.StartNew();
for (var i = 0; i < 1_000_000; i++)
{
    staticParser.Traverse(new Node());
}
staticStopWatch.Stop();
Console.WriteLine($"Static polymorphism time elapsed: {staticStopWatch.ElapsedMilliseconds} ms");

