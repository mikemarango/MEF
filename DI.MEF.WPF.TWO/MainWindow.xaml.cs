using DI.MEF.WPF.TWO.ViewModels;
using System.Windows;

namespace DI.MEF.WPF.TWO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainWindowViewModel mainWindowViewModel = App.Container.GetExportedValue<MainWindowViewModel>();
            DataContext = mainWindowViewModel;
        }
    }
}
