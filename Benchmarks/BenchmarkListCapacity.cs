using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNetList.Benchmarks
{
	public class BenchmarkListCapacity
	{
		[Params(100, 5000, 20000)]
		public int count;

		[Benchmark]
		public void AddToList()
		{
			List<int> list = new List<int>();

			for(int i = 0; i < count; i++)
			{
				list.Add(i);
			}
		}

		[Benchmark]
		public void AddToListWithCapacity()
		{
			List<int> list = new List<int>(count);

			for (int i = 0; i < count; i++)
			{
				list.Add(i);
			}
		}
	}
}
