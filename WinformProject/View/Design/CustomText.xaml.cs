using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for CustomText.xaml
    /// </summary>
    public partial class CustomText : UserControl
    {
        private String text_ThongTin;
        public string Text_ThongTin
        {
            get { return text_ThongTin; }
            set { text_ThongTin = value; Tb_ThongTin.Text = value; }
        }
        public CustomText()
        {
            InitializeComponent();
        }
    }
}
