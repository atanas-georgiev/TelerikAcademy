namespace WcfServiceWeekDays.Library
{
    using System;
    using System.ServiceModel;

    [ServiceContract]
    public interface IServiceWeekDays
    {
        [OperationContract]
        string GetDayOfWeekInBulgarian(DateTime dateTime);
    }
}
