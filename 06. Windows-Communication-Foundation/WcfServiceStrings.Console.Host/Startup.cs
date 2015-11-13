namespace WcfServiceStrings.Console.Host
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;

    using WcfServiceStrings.Library;

    public class Startup
    {
        public static void Main()
        {
            var serviceAddress = new Uri("http://localhost:12346/WcfServiceStrings.svc");
            var selfHost = new ServiceHost(typeof(StringService), serviceAddress);

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
