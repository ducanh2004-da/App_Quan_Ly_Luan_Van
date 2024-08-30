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

namespace WinformProject.View.Design
{
    /// <summary>
    /// Interaction logic for DKMHBar.xaml
    /// </summary>
    public partial class DKDTBar : UserControl
    {
        public int hight1 =40;
        public int hight2 = 30;
        public DKDTBar()
        {
            InitializeComponent();
            lockBtn(btn1);
        }
        private void lockBtn(Button btn)
        {
            //thay đổi chiều cao
            btn1.Height = hight2;
            btn2.Height = hight2;
            btn3.Height = hight2;
            btn.Height = hight1;
            //khóa
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn.IsEnabled = false;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            lockBtn(btn1);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            lockBtn(btn2);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            lockBtn(btn3);
        }
    }
    
}
