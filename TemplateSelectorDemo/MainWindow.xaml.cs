using System.Windows;

namespace TemplateSelectorDemo
{
     public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowModel();
        }
    }
}