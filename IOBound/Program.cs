using System.Diagnostics;

async Task ThisTakes5Seconds()
{
    await Task.Delay(TimeSpan.FromSeconds(5));
    Console.WriteLine("5 second task is over.");
}

async Task ThisTakes2Second()
{
    await Task.Delay(TimeSpan.FromSeconds(2));
    Console.WriteLine("2 second task is over.");
}


var stopwatch = new Stopwatch();
stopwatch.Start();



Console.WriteLine($"All done in {stopwatch.ElapsedMilliseconds}ms");

