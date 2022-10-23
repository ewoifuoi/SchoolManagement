using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
namespace SMC.Common
{
    /// <summary>
    /// 用于在列表中显示当前状态和输入日志的模拟终端
    /// </summary>
    public static class Console
    {
        public static ListBox lb = null;

        /// <summary>
        /// 当前时间 : + 终端输出
        /// </summary>
        /// <param name="context">内容字符串</param>
        public static void log(string context)
        {
            if(lb != null) lb.Items.Add(new TextBlock() { Text = DateTime.Now.ToString("T") + "  " + context });
        }

        public static void log(string owner, string context)
        {
            if (lb != null) lb.Items.Add(new TextBlock() { Text = DateTime.Now.ToString("T") + "  " +owner + " : " + context });
        }
    }
}
