using System.Windows;

namespace MinecraftModMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItemNewBlock_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New block was selected. Do you wish to procceed?");
        }
    }
}