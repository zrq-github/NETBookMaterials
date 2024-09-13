Console.WriteLine("1-Main:" + Thread.CurrentThread.ManagedThreadId);
Console.WriteLine(await CalcAsync(10000));
Console.WriteLine("2-Main:" + Thread.CurrentThread.ManagedThreadId);
//static Task<decimal> CalcAsync(int n,int mode=0)
//{
//	Console.WriteLine("CalcAsync:" + Thread.CurrentThread.ManagedThreadId);
//	decimal result = 1;
//	Random rand = new Random();
//	for (int i = 0; i < n * n; i++)
//	{
//		result = result + (decimal)rand.NextDouble();
//	}
//	return Task.FromResult(result);
//}

//async Task<decimal> CalcAsync(int n)
//{
//    Console.WriteLine("CalcAsync:" + Thread.CurrentThread.ManagedThreadId);
//    return await Task.Run(() =>
//    {
//        Console.WriteLine("Task.Run:" + Thread.CurrentThread.ManagedThreadId);
//        decimal result = 1;
//        Random rand = new Random();
//        for (int i = 0; i < n * n; i++)
//        {
//            result = result + (decimal)rand.NextDouble();
//        }
//        return result;
//    });
//}

async Task<decimal> CalcAsync(int n)
{
    Console.WriteLine("CalcAsync:" + Thread.CurrentThread.ManagedThreadId);
    return await CalcAsyncA(n);
}
static Task<decimal> CalcAsyncA(int n)
{
	Console.WriteLine("CalcAsyncA:" + Thread.CurrentThread.ManagedThreadId);
	decimal result = 1;
	Random rand = new Random();
	for (int i = 0; i < n * n; i++)
	{
		result = result + (decimal)rand.NextDouble();
	}
	return Task.FromResult(result);
}

