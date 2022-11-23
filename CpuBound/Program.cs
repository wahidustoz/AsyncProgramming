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


var stopwatch = new Stopwatch();
stopwatch.Start();


Console.WriteLine($"Overall time {stopwatch.ElapsedMilliseconds}ms.");