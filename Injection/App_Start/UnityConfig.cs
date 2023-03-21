using Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFormation.Repository;
using TpFormation.Services;
using Unity;
using Unity.Lifetime;

namespace Injection.App_Start
{
    public static class UnityConfig
    {
        public static void RegisterComponents(UnityContainer container)
        {
            container.RegisterType<ISchoolService, SchoolService>();
            container.RegisterType<ISchoolRepository,SchoolRepositoy >(new ContainerControlledLifetimeManager());

        }
    }
}
