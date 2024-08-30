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
using WinformProject.View.SmallWindow;

namespace WinformProject.View.Page
{
    /// <summary>
    /// Interaction logic for DKDT.xaml
    /// </summary>
    public partial class DKDT : UserControl
    {
        public DKDT()
        {
            InitializeComponent();
        }

        private void ButtonDangKy_Click(object sender, RoutedEventArgs e)
        {
            if(DKDTBar.btn1.IsEnabled == false) // Đăng ký đề tài tự chọn
            {
                
            }
            else if (DKDTBar.btn2.IsEnabled == false)
            {
                
            }
        }
    }
}
