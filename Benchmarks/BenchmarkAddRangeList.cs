using BenchmarkDotNet.Attributes;
using BenchmarkDotNetList.Models;

namespace BenchmarkDotNetList.Benchmarks
{
	public class BenchmarkAddRangeList
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
		public void AddClassToList()
		{
			List<ItemClass> list = new List<ItemClass>();

			foreach (var item in _classItems)
			{
				list.Add(item);
			}
		}

		[Benchmark]
		public void AddRangeClassToList()
		{
			List<ItemClass> list = new List<ItemClass>();

			list.AddRange(_classItems);
		}

		[Benchmark]
		public void AddClassToListWithCapacity()
		{
			List<ItemClass> list = new List<ItemClass>(_classItems.Capacity);

			foreach (var item in _classItems)
			{
				list.Add(item);
			}
		}

		[Benchmark]
		public void AddRangeClassToListWithCapacity()
		{
			List<ItemClass> list = new List<ItemClass>(_classItems.Capacity);

			list.AddRange(_classItems);
		}

		[Benchmark]
		public void AddStructToList()
		{
			List<ItemStruct> list = new List<ItemStruct>();

			foreach (var item in _structItems)
			{
				list.Add(item);
			}
		}

		[Benchmark]
		public void AddRangeStructToList()
		{
			List<ItemStruct> list = new List<ItemStruct>();

			list.AddRange(_structItems);
		}

		[Benchmark]
		public void AddStructToListWithCapacity()
		{
			List<ItemStruct> list = new List<ItemStruct>(_structItems.Count);

			foreach (var item in _structItems)
			{
				list.Add(item);
			}
		}

		[Benchmark]
		public void AddRangeStructToListWithCapacity()
		{
			List<ItemStruct> list = new List<ItemStruct>(_structItems.Count);

			list.AddRange(_structItems);
		}

	}
}
