using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace SMC.Models
{

    public class StuInfoModel : DependencyObject
    {
        public string StuName
        {
            get { return (string)GetValue(StuNameProperty); }
            set { SetValue(StuNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for StuName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StuNameProperty =
            DependencyProperty.Register("StuName", typeof(string), typeof(StuInfoModel), new PropertyMetadata("未设置姓名"));



        public int StuId
        {
            get { return (int)GetValue(StuIdProperty); }
            set { SetValue(StuIdProperty, value); }
        }

        // Using a DependencyProperty as the backing store for StuId.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StuIdProperty =
            DependencyProperty.Register("StuId", typeof(int), typeof(StuInfoModel), new PropertyMetadata(0));



        public string StuMajor
        {
            get { return "主修专业 : " + (string)GetValue(MajorProperty); }
            set { SetValue(MajorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Major.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MajorProperty =
            DependencyProperty.Register("Major", typeof(string), typeof(StuInfoModel), new PropertyMetadata("未设置专业"));



        public string StuProfilePath
        {
            get { return (string)GetValue(StuProfilePathProperty); }
            set { SetValue(StuProfilePathProperty, value); }
        }

        // Using a DependencyProperty as the backing store for StuProfilePath.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StuProfilePathProperty =
            DependencyProperty.Register("StuProfilePath", typeof(string), typeof(StuInfoModel), new PropertyMetadata("4.png"));



        public string StuEmail
        {
            get { return (string)GetValue(StuEmailProperty); }
            set { SetValue(StuEmailProperty, value); }
        }

        // Using a DependencyProperty as the backing store for StuEmail.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StuEmailProperty =
            DependencyProperty.Register("StuEmail", typeof(string), typeof(StuInfoModel), new PropertyMetadata("未设置邮箱"));

    }
}
