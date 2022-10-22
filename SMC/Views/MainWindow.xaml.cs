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
using SMC.ViewModels;
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

            this.DataContext = new MainWindowViewModel(this);



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
        private void listBoxDevice_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            var listbox = sender as System.Windows.Controls.ListBox;
            var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
            eventArg.RoutedEvent = UIElement.MouseWheelEvent;
            eventArg.Source = sender;
            listbox.RaiseEvent(eventArg);
        }
    }
}
