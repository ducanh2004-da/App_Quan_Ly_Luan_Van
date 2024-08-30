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
    /// Interaction logic for TeacherButton.xaml
    /// </summary>
    public partial class TeacherButton : UserControl
    {
        public TeacherButton()
        {
            InitializeComponent();
        }
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            LockBtn(btnHome);
        }

        private void btnThongTin_Click(object sender, RoutedEventArgs e)
        {
            LockBtn(btnThongTin);
        }

        private void btnDSDT_Click(object sender, RoutedEventArgs e)
        {
            LockBtn(btnDSDT);
        }
        private void btnXemBaoCao_Click(object sender, RoutedEventArgs e)
        {
            LockBtn(btnXemBaoCao);
        }
        private void LockBtn(Button btn)
        {
            btnHome.IsEnabled = true;
            btnThongTin.IsEnabled = true;
            btnDSDT.IsEnabled = true;
            btnXemBaoCao.IsEnabled = true;
            btn.IsEnabled = false;
        }
    }
}
