using Serilog;

namespace Topshelf.GettingStarted
{
    public class Service
    {
        public void Start()
        {
            Log.Information("Started");
        }

        public void Stop()
        {
            Log.Information("Stopped");
        }
    }
}