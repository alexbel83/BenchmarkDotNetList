using BenchmarkDotNet.Running;
using BenchmarkDotNetList.Benchmarks;

internal class Program
{

	public static void Main(string[] args)
	{
		BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
		Console.ReadLine();
	}
}