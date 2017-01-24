namespace WcfServiceStrings.Library
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IStringService
    {
        [OperationContract]
        int GetSubStringCount(string originalString, string subString);     
    }    
}
