using DI.MEF.WPF.ViewModels;
using System.Windows;

namespace DI.MEF.WPF.Views
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
