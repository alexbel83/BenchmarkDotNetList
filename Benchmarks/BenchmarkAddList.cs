using BenchmarkDotNet.Attributes;
using BenchmarkDotNetList.Models;

namespace BenchmarkDotNetList.Benchmarks
{
	public class BenchmarkAddList
	{
		private int _currentCount;

		[Params(100, 5000, 20000)]
		public int count;

		[GlobalSetup]
		public void Setup()
		{
			_currentCount = count;
		}

		[Benchmark]
		public void AddClassToList()
		{
			List<ItemClass> list = new List<ItemClass>();

			for (int i = 0; i < _currentCount; i++)
			{
				list.Add(new ItemClass());
			}
		}

		[Benchmark]
		public void AddClassToListWitgCapacity()
		{
			List<ItemClass> list = new List<ItemClass>(_currentCount);

			for (int i = 0; i < _currentCount; i++)
			{
				list.Add(new ItemClass());
			}
		}

		[Benchmark]
		public void AddStructToList()
		{
			List<ItemStruct> list = new List<ItemStruct>();

			for (int i = 0; i < _currentCount; i++)
			{
				list.Add(new ItemStruct());
			}
		}

		[Benchmark]
		public void AddStructToListWithCapacity()
		{
			List<ItemStruct> list = new List<ItemStruct>(_currentCount);

			for (int i = 0; i < _currentCount; i++)
			{
				list.Add(new ItemStruct());
			}
		}

		[Benchmark]
		public void AddClassToArray()
		{
			ItemClass[] list = new ItemClass[_currentCount];

			for (int i = 0; i < _currentCount; i++)
			{
				list[i] = new ItemClass();
			}
		}

		[Benchmark]
		public void AddStructToArray()
		{
			ItemStruct[] list = new ItemStruct[_currentCount];

			for (int i = 0; i < _currentCount; i++)
			{
				list[i] = new ItemStruct();
			}
		}
	}
}
