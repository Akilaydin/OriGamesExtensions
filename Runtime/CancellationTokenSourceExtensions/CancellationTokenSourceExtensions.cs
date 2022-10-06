using System.Threading;

namespace OriGames.Extensions.CancellationTokenSourceExtensions
{
	public static class CancellationTokenSourceExtensions
	{
		public static void Destroy(this CancellationTokenSource cts)
		{
			cts.Cancel();
			cts.Dispose();
		}
	}
}
