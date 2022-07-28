interface IScheduler {
    bool IsScheduled(ISchedulable target, DateTime starting, DateTime ending);
}