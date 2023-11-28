using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNetList.Benchmarks
{
	public class BenchmarkListAnyAndCount
	{
		private List<int> _items;

		[Params(20000)]
		public int count;

		[GlobalSetup]
		public void Setup()
		{
			_items = Enumerable.Range(1, 10000).ToList();
		}

		[Benchmark]
		public void CheckEmptyByCount()
		{
			for(int i = 0; i < count; i++)
			{
				if (_items.Count > 0)
				{

				}
			}
		}

		[Benchmark]
		public void CheckEmptyByAny()
		{
			for (int i = 0; i < count; i++)
			{
				if (_items.Any())
				{

				}
			}
		}
	}
}
