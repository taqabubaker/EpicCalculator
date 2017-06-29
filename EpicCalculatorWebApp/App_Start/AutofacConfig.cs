using Autofac;
using Autofac.Integration.Mvc;
using EpicCalculator.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace EpicCalculatorWebApp.App_Start
{
    public class AutofacConfig
    {
        public static IContainer RegisterAll()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacWebTypesModule());
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<EpicCalculatorClient>().As<IEpicCalculatorClient>().InstancePerLifetimeScope();           

            var container = Container(builder);
            return container;
        }

        private static IContainer Container(ContainerBuilder builder)
        {
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            return container;
        }
    }
}