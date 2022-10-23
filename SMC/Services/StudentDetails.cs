using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMC.Models;
using SMC.ViewModels;
using System.Windows.Controls;
using System.Net.Http;
using System;
using System.Windows.Threading;

namespace SMC.Services
{
    public static class StudentDetails
    {

        public static string Server = "127.0.0.1";
        public static string Port = "5002";

        public static int GetNum()
        {
            using (HttpClient c = new HttpClient())
            {
                try
                {
                    var response = c.GetAsync("http://" + Server + ":" + Port + "/StuCount").Result;
                    return Convert.ToInt32(response.Content.ReadAsStringAsync().Result.ToString());
                }
                catch (Exception ex)
                {
                    return -1;
                }
            }
            return 0;
        }

        private static string message;
        public static string GetServerTime()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = client.GetAsync("http://" + Server + ":" + Port + "/Test").Result;               
                    return message = "Server : " + response.Content.ReadAsStringAsync().Result.ToString();
                }
                catch (Exception ex)
                {
                    return message = "服务器连接失败 !";
                }
            }
        }
    }
}
