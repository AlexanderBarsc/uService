namespace uService.Services
{
    public interface IBackgroundTaskQueue
    {
        ValueTask Queue(Func<CancellationToken, ValueTask> workItem);

        ValueTask<Func<CancellationToken, ValueTask>> Dequeue(CancellationToken cancellationToken);
    }
}
