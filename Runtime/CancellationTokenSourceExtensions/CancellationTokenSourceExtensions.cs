using System.Threading;

namespace OriGames.Extensions.CancellationTokenSourceExtensions
{
	public static class CancellationTokenSourceExtensions
	{
		/// <summary>
		/// Cancels and Disposes the given CancellationTokenSource
		/// </summary>
		/// <param name="cts"></param>
		public static void Destroy(this CancellationTokenSource cts)
		{
			cts.Cancel();
			cts.Dispose();
		}
	}
}
