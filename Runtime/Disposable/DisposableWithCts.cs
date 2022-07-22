using System.Threading;

namespace OriGames.Extensions.Disposable
{
    public abstract class DisposableWithCts : Disposable
    {
        protected readonly CancellationTokenSource Cts;
        protected CancellationToken Token => Cts.Token;

        protected DisposableWithCts()
        {
            Cts = new CancellationTokenSource();
        }

        public override void Dispose()
        {
            base.Dispose();

            Cts.Cancel();
            Cts.Dispose();
        }
    }
}
