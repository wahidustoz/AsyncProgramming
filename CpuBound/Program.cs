using System.Diagnostics;
using System.Numerics;


BigInteger GetNthFibonacci(int n)
{
	if (n == 1 || n == 2)
		return 1;

	return GetNthFibonacci(n - 1) + GetNthFibonacci(n - 2);
}

async Task<BigInteger> GetNthFibonacciAsync(int n)
	=> await Task.FromResult(GetNthFibonacci(n));


async Task CpuThreadAsync()
{
	var stopwatch = new Stopwatch();
	stopwatch.Start();

	var tasklar = new Task[]
	{
		Task.Run(() => GetNthFibonacciAsync(42)),
		Task.Run(() => GetNthFibonacciAsync(42))
	};

	await Task.WhenAll(tasklar);

	Console.WriteLine($"CPU thread {stopwatch.ElapsedMilliseconds}ms vaqt ketdi.");
}

async Task IoThreadAsync()
{
	var stopwatch = new Stopwatch();
	stopwatch.Start();

	var tasklar = new Task[] 
	{ 
		GetNthFibonacciAsync(42), 
		GetNthFibonacciAsync(42) 
	};

	await Task.WhenAll(tasklar);

	Console.WriteLine($"IO thread {stopwatch.ElapsedMilliseconds}ms vaqt ketdi.");
}
 

var stopwatch = new Stopwatch();
stopwatch.Start();

var tasklar = new Task[]
{ 
	// Task.Run(() => CpuThreadAsync()), 
	// Task.Run(() => IoThreadAsync()) 
	CpuThreadAsync(),
	IoThreadAsync()
};

await Task.WhenAll(tasklar);

Console.WriteLine($"Hammasiga {stopwatch.ElapsedMilliseconds}ms vaqt ketdi.");