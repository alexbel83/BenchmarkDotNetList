using BenchmarkDotNet.Attributes;
using BenchmarkDotNetList.Models;

namespace BenchmarkDotNetList.Benchmarks
{
	public class BenchmarkAddListWithCount
	{
		private List<ItemClass> _classItems;
		private List<ItemStruct> _structItems;


		[Params(100, 5000, 20000)]
		public int count;

		[GlobalSetup]
		public void Setup()
		{
			_classItems = Enumerable.Range(1, count)
									.Select(x => new ItemClass { ItemId = x, ItemName = x.ToString() })
									.ToList();
			_structItems = Enumerable.Range(1, count)
									.Select(x => new ItemStruct { ItemId = x, ItemName = x.ToString() })
									.ToList();
		}

		[Benchmark]
		public void AddClassToListWithForeach()
		{
			List<ItemClass> list = new List<ItemClass>();

			foreach (var item in _classItems)
			{
				list.Add(item);
			}
		}

		[Benchmark]
		public void AddClassToListWithMethodCount()
		{
			List<ItemClass> list = new List<ItemClass>();

			for (int i = 0; i < _classItems.Count(); i++)
			{
				list.Add(_classItems[i]);
			}
		}

		[Benchmark]
		public void AddClassToListWithCount()
		{
			List<ItemClass> list = new List<ItemClass>();

			for (int i = 0; i < _classItems.Count; i++)
			{
				list.Add(_classItems[i]);
			}
		}

		[Benchmark]
		public void AddClassToListWithSavedCount()
		{
			List<ItemClass> list = new List<ItemClass>();

			var _count = _classItems.Count;

			for (int i = 0; i < _count; i++)
			{
				list.Add(_classItems[i]);
			}
		}

		[Benchmark]
		public void AddStructToListWithCount()
		{
			List<ItemStruct> list = new List<ItemStruct>();

			for (int i = 0; i < _structItems.Count; i++)
			{
				list.Add(_structItems[i]);
			}
		}
	}
}
