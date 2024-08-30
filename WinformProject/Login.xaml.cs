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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace WinformProject
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                //MessageBox.Show("username: " + txtUserName.Text + ".\npassword: " + txtPassWord.Password + ".");
                string sqlStr = string.Format("SELECT Role FROM Account WHERE Username = '{0}' AND PassWord = '{1}' ", txtUserName.Text, txtPassWord.Password); 
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                SqlCommand command = new SqlCommand(sqlStr, conn);
                object result = command.ExecuteScalar();
                if(result != null )
                {
                    //MessageBox.Show(result.ToString());
                    this.Hide();
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.setUpMainWindow(result.ToString());
                    mainWindow.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("your password or username is wrong");
                }
                
            }
            catch (Exception exc)            {
                MessageBox.Show("you fail to login: "+exc );
            }
            finally
            {
                conn.Close();
            }
        }

        private void ClearName_Click(object sender, RoutedEventArgs e)
        {
            txtUserName.Text = string.Empty;
        }

        private void ClearPassWord_Click(object sender, RoutedEventArgs e)
        {
            txtPassWord.Password = string.Empty;
        }
    }
}
