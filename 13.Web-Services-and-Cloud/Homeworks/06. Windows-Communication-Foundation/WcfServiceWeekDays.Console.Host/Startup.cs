namespace WcfServiceWeekDays.Console
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;

    using WcfServiceWeekDays.Library;

    public class Startup
    {
        public static void Main()
        {
            var serviceAddress = new Uri("http://localhost:12345/WcfServiceWeekDays.svc");
            var selfHost = new ServiceHost(typeof(ServiceWeekDays), serviceAddress);

            var smb = new ServiceMetadataBehavior { HttpGetEnabled = true };
            selfHost.Description.Behaviors.Add(smb);

            using (selfHost)
            {
                selfHost.Open();
                Console.WriteLine("The service is started at endpoint " + serviceAddress);

                Console.WriteLine("Press [Enter] to exit.");
                Console.ReadLine();
            }
        }
    }
}
