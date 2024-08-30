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
using WinformProject.View.Design;

namespace WinformProject.View.Page
{
    /// <summary>
    /// Interaction logic for DSDT.xaml
    /// </summary>
    public partial class DSDT : UserControl
    {
        SuaDTButton suuaDTButton = new SuaDTButton();
        public DSDT()
        {
            InitializeComponent();
            DKDTBar.btn1.Click += btn1_Click;
            DKDTBar.btn2.Click += btn2_Click;
            DKDTBar.btn3.Click += btn3_Click;
        }

        private void ButtonDuyet_Click(object sender, RoutedEventArgs e)
        {
            if (DKDTBar.btn1.IsEnabled == false)
            {
                MessageBox.Show("Duyệt đề tài tự chọn");
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Space.Children.Clear();
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Space.Children.Add(suuaDTButton);
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Space.Children.Clear();
        }
    }
}
