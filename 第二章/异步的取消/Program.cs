// See https://aka.ms/new-console-template for more information

// 一般来说不会直接 new CancellationToken();
CancellationTokenSource tokenSource = new CancellationTokenSource();
tokenSource.CancelAfter(5000);
CancellationToken token = tokenSource.Token;
await DownloadAsync("https://www.youzack.com", 100, token);
return;

async Task DownloadAsync(string url,int n,CancellationToken cancellationToken)
{
    await Task.Run(async () =>
    {
        using var client = new HttpClient();
        for (int i = 0; i < n; i++)
        {
            var html = await client.GetStringAsync(url);
            Console.WriteLine($"{DateTime.Now}:{html}");
            if (cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine("请求被取消");
                break;
            }
        }
    });
}