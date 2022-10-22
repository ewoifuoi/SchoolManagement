using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMC.Models;
using SMC;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows;

namespace SMC.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindowViewModel(MainWindow window)
        {
            List<StuInfoModel> stuInfos = new List<StuInfoModel>()
            {
                new StuInfoModel() {StuId=1,StuName="张三",StuProfilePath="../test/1.png", StuMajor="计算机科学与技术", StuEmail="fwiofgjei@fdk.com"},
                new StuInfoModel() {StuId=2,StuName="李四",StuProfilePath="../test/2.png", StuMajor="计算机科学与技术", StuEmail="fwiof2528jei@fdk.com"},
                new StuInfoModel() {StuId=3,StuName="王五",StuProfilePath="../test/3.png", StuMajor="计算机科学与技术", StuEmail="rr@fdk.com"},
                new StuInfoModel() {StuId=4,StuName="Bob",StuProfilePath="../test/4.png", StuMajor="计算机科学与技术", StuEmail="fwio78fjei@fdk.com"},
                new StuInfoModel() {StuId=5,StuName="ewoifuoi",StuProfilePath="../test/5.png", StuMajor="计算机科学与技术", StuEmail="f233wiofjei@fdk.com"},
                new StuInfoModel() {StuId=6,StuName="可莉",StuProfilePath="../test/6.png", StuMajor="计算机科学与技术", StuEmail="fwiofwwwefejei@fdk.com"},
            };

            int i = 0;
            while (i < stuInfos.Count)
            {
                
                StackPanel sp = new StackPanel() { Orientation = Orientation.Horizontal };
                for(int j = 0; j < 4 && i < stuInfos.Count; j++)
                {
                    StudentView sv = new StudentView(stuInfos[i]);
                    sp.Children.Add(sv);
                    i++;
                }
                ListBoxItem l = new ListBoxItem();
                l.Content = sp;
                window.lb.Items.Add(l);
                
                
            }
        }
        

    }
}
