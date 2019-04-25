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
            var result = ConfirmActionDialog.ShowDialog("New block was selected. Do you wish to procceed?", this);
            MessageBox.Show($"Ok: {result.Ok}, ShowAgain {result.ShowAgain}");
        }
    }
}