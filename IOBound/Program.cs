using System.Diagnostics;

async Task FayllarniYuklash()
{
    await Task.Delay(TimeSpan.FromSeconds(5));

    Console.WriteLine($"Fayllarni yuklash tugadi");
}

async Task UchgachaSanash()
{
    for(int i = 1; i < 4; i++)
    {
        await Task.Delay(TimeSpan.FromSeconds(1));
        Console.WriteLine($"Uchgacha sanash: {i}");
    }

    Console.WriteLine($"Uchgacha sanash tugadi");
}

var stopwatch = new Stopwatch();
stopwatch.Start();

var tasklar = new Task[] { FayllarniYuklash(), UchgachaSanash() };
await Task.WhenAll(tasklar);

Console.WriteLine($"Hammasiga {stopwatch.ElapsedMilliseconds}ms vaqt ketdi.");