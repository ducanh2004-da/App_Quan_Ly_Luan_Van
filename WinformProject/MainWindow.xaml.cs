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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WinformProject.View.Design;
using WinformProject.View.Page;
using WinformProject.View.SmallWindow;

namespace WinformProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Page cho form HS
        ThongTin thongTin = new ThongTin();
        BaoCao baoCao = new BaoCao();
        DKDT DKDT = new DKDT();
        Home Home = new Home();
        //Page cho form GV
        DSDT dSDT = new DSDT();
        XemBaoCao xemBaoCao = new XemBaoCao();
        //thành button bar
        StudentButton btnBarStudent = new StudentButton();
        TeacherButton btnBarTeacher = new TeacherButton();
        //btn Đăng Ký cho window phụ DKDT
        private DKDT1 dkdt1 = new DKDT1(); //cửa sổ đk đề tài tự chọn
        private DKDT2 dkdt2 = new DKDT2(); //cửa sổ đk đề tài có sẵn
        public MainWindow()
        {
            InitializeComponent();
            this.SizeChanged += MainWindow_SizeChanged;
            //HS
            btnBarStudent.btnHome.Click += btnHomeClick;
            btnBarStudent.btnThongTin.Click += btnThongTinClick;
            btnBarStudent.btnDKDT.Click += btnDKDTClick;
            btnBarStudent.btnBaoCao.Click += btnBaoCaoClick;
            //GV
            btnBarTeacher.btnHome.Click += btnHomeClick;
            btnBarTeacher.btnThongTin.Click += btnThongTinClick;
            btnBarTeacher.btnDSDT.Click += btnDSDTClick;
            btnBarTeacher.btnXemBaoCao.Click += btnXemBaoCaoClick;
            //gán btn cho nút DKDT
            DKDT.btn_DangKy.Click += ButtonDangKy_Click;
            dkdt1.btnDangKy.Click += BtnDangKyTuChon_Click;
            dkdt2.btnDangKy.Click += BtnDangKyCoSan_Click;
        }

        //xử lý chiều cao, rộng uc khi size của cửa sổ thay đổi
        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //HS
            setSizeUC(thongTin, e.NewSize.Width-120, e.NewSize.Height);
            setSizeUC(baoCao, e.NewSize.Width - 120, e.NewSize.Height);
            setSizeUC(DKDT, e.NewSize.Width - 120, e.NewSize.Height);
            //GV
            setSizeUC(dSDT, e.NewSize.Width - 120, e.NewSize.Height);
            setSizeUC(xemBaoCao, e.NewSize.Width - 120, e.NewSize.Height);
        }
        private void setSizeUC(UserControl UC, double width, double height)
        {
            UC.Width = width;
            UC.Height = height;
        }

        //Thêm animation lướt cho UC
        private void setAnimation(DoubleAnimation animation, double start, double end)
        {
            animation.From = start;
            animation.To = end;
            animation.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            animation.FillBehavior = FillBehavior.HoldEnd;
        }
        private void pageClose(UserControl page) //Hiệu ứng khi tắt màn hình của UC
        {
            DoubleAnimation animation = new DoubleAnimation();
            setSizeUC(page, canvas.ActualWidth, canvas.ActualHeight);
            setAnimation(animation, (canvas.ActualWidth - page.Width) / 2, canvas.ActualWidth);
            animation.Completed += (s, ea) => canvas.Children.Remove(page);
            page.BeginAnimation(Canvas.LeftProperty, animation);
        }

        private void closeAllPage()
        {
            canvas.Children.Clear();
        }

        //button Home
        private void btnHomeClick(object sender, RoutedEventArgs e)
        {
            //HS
            pageClose(thongTin);
            pageClose(DKDT);
            pageClose(baoCao);
            //GV
            pageClose(dSDT);
            pageClose(xemBaoCao);
        }

        //btn HS
        private void btnThongTinClick(object sender, RoutedEventArgs e)
        {
            closeAllPage();
            DoubleAnimation animation = new DoubleAnimation();
            setSizeUC(thongTin, canvas.ActualWidth, canvas.ActualHeight);
            canvas.Children.Add(thongTin);
            setAnimation(animation, canvas.ActualWidth, (canvas.ActualWidth - thongTin.Width) / 2);
            thongTin.BeginAnimation(Canvas.LeftProperty, animation);
        }

        private void btnDKDTClick(object sender, RoutedEventArgs e)
        {
            closeAllPage();
            DoubleAnimation animation = new DoubleAnimation();
            setSizeUC(DKDT, canvas.ActualWidth, canvas.ActualHeight);
            canvas.Children.Add(DKDT);
            setAnimation(animation, canvas.ActualWidth, (canvas.ActualWidth - DKDT.Width) / 2);
            DKDT.BeginAnimation(Canvas.LeftProperty, animation);
        }

        private void btnBaoCaoClick(object sender, RoutedEventArgs e)
        {
            closeAllPage();
            DoubleAnimation animation = new DoubleAnimation();
            setSizeUC(baoCao, canvas.ActualWidth, canvas.ActualHeight);
            canvas.Children.Add(baoCao);
            setAnimation(animation, canvas.ActualWidth, (canvas.ActualWidth - baoCao.Width) / 2);
            baoCao.BeginAnimation(Canvas.LeftProperty, animation);
        }

        //btn GV
        private void btnDSDTClick(object sender, RoutedEventArgs e)
        {
            closeAllPage();
            DoubleAnimation animation = new DoubleAnimation();
            setSizeUC(dSDT, canvas.ActualWidth, canvas.ActualHeight);
            canvas.Children.Add(dSDT);
            setAnimation(animation, canvas.ActualWidth, (canvas.ActualWidth - dSDT.Width) / 2);
            dSDT.BeginAnimation(Canvas.LeftProperty, animation);
        }
        private void btnXemBaoCaoClick(object sender, RoutedEventArgs e)
        {
            closeAllPage();
            DoubleAnimation animation = new DoubleAnimation();
            setSizeUC(xemBaoCao, canvas.ActualWidth, canvas.ActualHeight);
            canvas.Children.Add(xemBaoCao);
            setAnimation(animation, canvas.ActualWidth, (canvas.ActualWidth - xemBaoCao.Width) / 2);
            xemBaoCao.BeginAnimation(Canvas.LeftProperty, animation);
        }

        //Hàm setup cho form khi đăng nhập
        public void setUpMainWindow(string str)
        {
            btnBar.Children.Clear();
            if (str == "Student")
                btnBar.Children.Add(btnBarStudent);
            else btnBar.Children.Add(btnBarTeacher);
        }

        //Xử lý sự kiện đăng ký đề tài
        private void ButtonDangKy_Click(object sender, RoutedEventArgs e)
        {
            if (DKDT.DKDTBar.btn1.IsEnabled == false) //đk đề tài tự chọn
            {
                //dkdt1 = new DKDT1();
                dkdt1.Show();
            }
            else if (DKDT.DKDTBar.btn2.IsEnabled == false) //đk đề tài có sẵn
            {
                //dkdt2 = new DKDT2();
                dkdt2.Show();
            }
        }

        private void BtnDangKyTuChon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Đăng Ký Thành Công \n Hãy Chờ Duyệt");
        }
        private void BtnDangKyCoSan_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Đăng Ký Thành Công");
        }
    }
}
