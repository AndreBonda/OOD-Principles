interface ISchedulable
{
    //Tempi di consegna
    int LeadDays();

    bool IsSchedulable(DateTime starting, DateTime ending);
}