using BenchmarkDotNet.Attributes;
using BenchmarkDotNetList.Models;

namespace BenchmarkDotNetList.Benchmarks
{
	public class BenchmarkListStructAndClass
	{
		[Params(5000, 20000)]
		public int count;

		[Benchmark]
		public void AddStructToList()
		{
			List<ItemStruct> list = new List<ItemStruct>();

			for (int i = 0; i < count; i++)
			{
				list.Add(new ItemStruct());
			}
		}

		[Benchmark]
		public void AddStructToListWithCapacity()
		{
			List<ItemStruct> list = new List<ItemStruct>(count);

			for (int i = 0; i < count; i++)
			{
				list.Add(new ItemStruct());
			}
		}

		[Benchmark]
		public void AddClassToList()
		{
			List<ItemClass> list = new List<ItemClass>();

			for (int i = 0; i < count; i++)
			{
				list.Add(new ItemClass());
			}
		}

		[Benchmark]
		public void AddClassToListWithCapacity()
		{
			List<ItemClass> list = new List<ItemClass>(count);

			for (int i = 0; i < count; i++)
			{
				list.Add(new ItemClass());
			}
		}
	}
}