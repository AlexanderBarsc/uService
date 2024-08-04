namespace uService.Services
{
    public class QueuedHostedService : BackgroundService
    {
        
        private readonly IBackgroundTaskQueue _taskQueue;

        public QueuedHostedService(IBackgroundTaskQueue taskQueue)
        {
            _taskQueue = taskQueue;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
           
                var workItem =
                    await _taskQueue.Dequeue(stoppingToken);

                await workItem(stoppingToken);

            }
        }
    }
}
