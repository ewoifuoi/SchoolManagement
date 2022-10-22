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
using SMC.Services;

namespace SMC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            StudentDetails.Server = "http://127.0.0.1:5002";
            InitializeComponent();
            this.DataContext = new MainWindowViewModel(this);

        }
        public string Server
        {
            get { return (string)GetValue(ServerProperty); }
            set { SetValue(ServerProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Server.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ServerProperty =
            DependencyProperty.Register("Server", typeof(string), typeof(MainWindow), new PropertyMetadata(StudentDetails.Server));




        private string message;
        public async void GetServerTime()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(StudentDetails.Server + "/Test");
                    if (response.IsSuccessStatusCode)
                    {
                        message = "Server : " + await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        message = "ERROR!";
                    }
                }
                catch (Exception ex)
                {
                    message = "服务器连接失败 !";
                }
                
                

            }
            console.Items.Add(new TextBlock() { Text = message });
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var b = new ServerInput();
            b.ShowDialog();
        }
    }
}
