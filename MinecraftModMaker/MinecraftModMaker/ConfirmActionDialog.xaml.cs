using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MinecraftModMaker
{
    /// <summary>
    /// Interaction logic for ConfirmActionDialog.xaml
    /// </summary>
    public partial class ConfirmActionDialog : Window
    {
        private bool _ok;
        private bool _showAgain;
        public ConfirmActionDialog(string message)
        {
            InitializeComponent();
            messageLabel.Content = message;
        }

        public static ConfirmActionResult ShowDialog(string message, Window parent)
        {
            var dialog = new ConfirmActionDialog(message);
            dialog.Top = parent.Top + ((parent.Height - dialog.Height) / 2);
            dialog.Left = parent.Left + ((parent.Width - dialog.Width) / 2);
            dialog.ShowDialog();
            return new ConfirmActionResult { Ok = dialog._ok, ShowAgain = dialog._showAgain };
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            _ok = true;
            _showAgain = dontShowAgainCheckBox.IsChecked == false;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            _ok = false;
            _showAgain = dontShowAgainCheckBox.IsChecked == false;
            Close();
        }
    }
    public class ConfirmActionResult
    {
        public bool Ok;
        public bool ShowAgain;
    }
}
