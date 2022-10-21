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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;

namespace SMC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
        }
        private string message;
        public async void GetServerTime()
        {
            using (HttpClient client = new HttpClient())
            {
                
                var response = await client.GetAsync("http://localhost:5002/GetTime");
                if(response.IsSuccessStatusCode)
                {
                    message = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    message = "ERROR!";
                }

            }
            MessageBox.Show(message);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GetServerTime();
        }
    }
}
