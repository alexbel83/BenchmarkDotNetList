using BenchmarkDotNet.Attributes;
using BenchmarkDotNetList.Models;

namespace BenchmarkDotNetList.Benchmarks
{
	public class BenchmarkListForeachAndFor
	{
		private List<ItemClass> _items;

		[Params(2000000)]
		public int count;

		[GlobalSetup]
		public void Setup()
		{
			_items = Enumerable.Range(1, count)
				.Select(x => new ItemClass { ItemId = x })
				.ToList();
		}

		[Benchmark]
		public void CheckForeach()
		{
			int sum = 0;
			
			foreach (var item in _items)
			{
				sum += item.ItemId;
			}
		}

		[Benchmark]
		public void CheckFor()
		{
			int sum = 0;

			for(int i = 0; i < _items.Count; i++)
			{
				sum += _items[i].ItemId;
			}
		}
	}
}
