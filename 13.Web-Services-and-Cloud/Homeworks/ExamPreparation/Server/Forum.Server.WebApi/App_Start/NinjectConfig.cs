namespace Forum.Server.WebApi
{
    using System;
    using System.Web;

    using Forum.Data;
    using Forum.Data.Repositories;

    using Ninject;
    using Ninject.Extensions.Conventions;
    using Ninject.Web.Common;

    public static class NinjectConfig
    {
        public static Action<IKernel> DependenciesRegistration = kernel =>
        {
            kernel.Bind<IForumDbContext>().To<ForumDbContext>().InRequestScope();
            kernel.Bind(typeof(IRepository<>)).To(typeof(GenericRepository<>)).InRequestScope();
        };

        public static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        private static void RegisterServices(IKernel kernel)
        {
            DependenciesRegistration(kernel);

            // todo  kernel.Bind<IRandomProvider>().To<RandomProvider>();            

            kernel.Bind(b => b
                .From("Forum.Services.Data")
                .SelectAllClasses()
                .BindDefaultInterface());
        }
    }
}