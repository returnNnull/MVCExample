using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVCExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private MainWindowController controller;
        public MainWindow()
        {
            var logic = new Logic();
            controller = new MainWindowController(logic);
            logic.listener += UpdateUi;
            InitializeComponent();
        }

        private void UpdateUi(int sum)
        {
            MessageBox.Show(sum.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(num1TextBox.Text);
            int b = int.Parse(num2TextBox.Text);
            controller.Sum(a, b);
            StartProgress();

        }

        private async void StartProgress()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
               
                    progress.Value = i;
                }
            });
        }
    }
}
