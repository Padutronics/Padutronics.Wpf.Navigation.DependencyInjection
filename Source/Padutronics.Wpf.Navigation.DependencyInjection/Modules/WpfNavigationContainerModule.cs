using Padutronics.DependencyInjection;

namespace Padutronics.Wpf.Navigation.DependencyInjection.Modules;

public sealed class WpfNavigationContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<INavigator>().Use<Navigator>().SingleInstance();
    }
}