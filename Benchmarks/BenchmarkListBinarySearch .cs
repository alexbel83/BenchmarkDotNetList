using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNetList.Benchmarks
{
	public class BenchmarkListBinarySearch
	{
		private List<int> _items;
		private int _findValue;

		[Params(50000)]
		public int count;

		[GlobalSetup]
		public void Setup()
		{
			_items = Enumerable.Range(1, count).ToList();
			var random = new Random();
			_findValue = random.Next(count);
		}

		[Benchmark]
		public void CheckBinarySearch()
		{
			int index = _items.BinarySearch(_findValue);
		}

		[Benchmark]
		public void CheckFirst()
		{
			int index = _items.First(x => x == _findValue);
		}
	}
}
