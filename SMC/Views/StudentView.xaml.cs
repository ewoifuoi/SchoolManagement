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
using SMC.Models;
using SMC.ViewModels;

namespace SMC
{
    /// <summary>
    /// StudentView.xaml 的交互逻辑
    /// </summary>
    public partial class StudentView : UserControl
    {
        public StudentView(StuInfoModel stu)
        { 
            _stu = stu;
            StudentView.stu = stu;

            InitializeComponent();
            
        }

        

        public static StuInfoModel stu;
        public StuInfoModel _stu
        {
            get { return (StuInfoModel)GetValue(_stuProperty); }
            set { SetValue(_stuProperty, value); }
        }

        // Using a DependencyProperty as the backing store for _stu.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty _stuProperty =
            DependencyProperty.Register("_stu", typeof(StuInfoModel), typeof(StudentView), new PropertyMetadata(stu));





        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var t = new Details();
            t.SetStu(_stu);
            t.ShowDialog();
        }
    }
}
