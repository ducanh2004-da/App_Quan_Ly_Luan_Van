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
    /// Interaction logic for StudentButton.xaml
    /// </summary>
    public partial class StudentButton : UserControl
    {
        public StudentButton()
        {
            InitializeComponent();
        }

        private void btnDKDT_Click(object sender, RoutedEventArgs e)
        {
            LockBtn(btnDKDT);
        }

        private void btnThongTin_Click(object sender, RoutedEventArgs e)
        {
            LockBtn(btnThongTin);
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            LockBtn(btnHome);
        }

        private void btnBaoCao_Click(object sender, RoutedEventArgs e)
        {
            LockBtn(btnBaoCao);
        }

        private void LockBtn(Button btn)
        {
            btnHome.IsEnabled = true;
            btnThongTin.IsEnabled = true;
            btnDKDT.IsEnabled = true;
            btnBaoCao.IsEnabled = true;
            btn.IsEnabled = false;
        }
    }
}
