using System.Threading.Channels;

namespace uService.Services
{
    public class BackgroundTaskQueue : IBackgroundTaskQueue
    {
        private readonly Channel<Func<CancellationToken, ValueTask>> _fronta;

        public BackgroundTaskQueue(int kapacita)
        {
            var options = new BoundedChannelOptions(kapacita)
            {
                FullMode = BoundedChannelFullMode.Wait
            };
            _fronta = Channel.CreateBounded<Func<CancellationToken, ValueTask>>(options);
        }

        public async ValueTask Queue(Func<CancellationToken, ValueTask> item)
        {
            if(item == null)
            {
                throw new ArgumentNullException();
            }    

            await _fronta.Writer.WriteAsync(item);
        }

        public async ValueTask<Func<CancellationToken, ValueTask>> Dequeue(CancellationToken cancellationToken)
        {
            var workItem = await _fronta.Reader.ReadAsync(cancellationToken);

            return workItem;
        }
    }
}
