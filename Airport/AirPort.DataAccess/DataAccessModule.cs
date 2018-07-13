using Autofac;

namespace AirPort.DataAccess
{
    public class DataAccessModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<FlightRepository>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<CrewRepository>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<AirCraftRepository>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<AirCraftTypeRepository>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<PilotRepository>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<StewardessRepository>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<TicketRepository>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<DepartureRepository>().AsImplementedInterfaces().InstancePerLifetimeScope();

        }
    }
}
