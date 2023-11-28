using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNetList.Benchmarks
{
	public class BenchmarkListAddRange
	{
		private List<int> _items;

		[Params(5000, 20000)]
		public int count;

		[GlobalSetup]
		public void Setup()
		{
			_items = Enumerable.Range(1, count).ToList();
		}

		[Benchmark]
		public void AddToList()
		{
			List<int> list = new List<int>();

			for(int i = 0; i < _items.Count; i++)
			{
				list.Add(i);
			}
		}

		[Benchmark]
		public void AddRangeToList()
		{
			List<int> list = new List<int>();

			list.AddRange(_items);
		}
	}
}