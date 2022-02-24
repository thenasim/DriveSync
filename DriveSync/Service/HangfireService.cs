using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangfire;
using Hangfire.MemoryStorage;
using Hangfire.Storage;

namespace DriveSync.Service
{
    internal class HangfireService
    {
        private static BackgroundJobServer? _server = null;

        public HangfireService()
        {
            GlobalConfiguration.Configuration.UseMemoryStorage();
            _server ??= new BackgroundJobServer();
        }

        public void RunPeriodic(string jobName, TimeOnly delayTime, Action myAction)
        {
            RecurringJob.AddOrUpdate(jobName, () => MessageBox.Show("Yes Yes"), $"0/1 * * * *");
        }

        public ExecutionTime GetExecutionTime(string jobName)
        {
            var executionTime = new ExecutionTime();

            using var connection = JobStorage.Current.GetConnection();
            var job = connection.GetRecurringJobs().FirstOrDefault(p => p.Id == jobName);

            if(job is { LastExecution: { } })
                executionTime.LastExecutionTime = job.LastExecution ?? DateTime.Now;
            if (job is { NextExecution: { } })
                executionTime.NextExecutionTime = job.NextExecution ?? DateTime.Now;

            return executionTime;
        }
    }

    public class ExecutionTime
    {
        public DateTime LastExecutionTime { get; set; }
        public DateTime NextExecutionTime { get; set; }
    }
}
