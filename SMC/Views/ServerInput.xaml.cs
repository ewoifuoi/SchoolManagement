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

using SMC.Services;
namespace SMC
{
    /// <summary>
    /// ServerInput.xaml 的交互逻辑
    /// </summary>
    public partial class ServerInput : Window
    {
        public bool isFirst = true;
        public ServerInput()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StudentDetails.Server = tb.Text;
            this.Close();
        }

        private void tb_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isFirst == true)
            {
                isFirst = false;
                tb.Text = "";
                tb.Foreground = new SolidColorBrush(Colors.Black);
            }
        }
    }
}
