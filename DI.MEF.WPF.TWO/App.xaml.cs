using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using System.Windows;

namespace DI.MEF.WPF.TWO
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static CompositionContainer Container;

        protected override void OnStartup(StartupEventArgs e)
        {
            AggregateCatalog aggregateCatalog = new AggregateCatalog();
            aggregateCatalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            Container = new CompositionContainer(aggregateCatalog);

            base.OnStartup(e);
        }
    }
}
