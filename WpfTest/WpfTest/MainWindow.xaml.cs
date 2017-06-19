using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfTest.Models;
using WpfTest.Repository;

namespace WpfTest
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        private NotifyIcon notify;

        public MainWindow()
        {
            InitializeComponent();

            notify = new NotifyIcon();
            notify.Icon = new System.Drawing.Icon("testIcon.ico");
            notify.Text = "Show Post";
            notify.BalloonTipText = "Test Of Notifyicon";
            notify.ShowBalloonTip(1000);
            notify.Click += notifyIcon_click;
        }

        private void notifyIcon_click(object sender, EventArgs e)
        {
            this.Show();
            this.notify.Visible = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void minimum_btn_click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            //this.WindowState = WindowState.Minimized;
            this.notify.Visible = true;
        }

        private void show_Post(object sender, RoutedEventArgs e)
        {
            try
            {
                TestRepository repository = new TestRepository();
                Test_Post data = repository.GetPostData();

                if (data != null)
                {
                    System.Windows.MessageBox.Show("PostId: " + data.P_Id + "\nContent: " + data.Content + "\nPostTime: " + data.postTime + "\nShopName: " + data.S_Name );
                }
                else
                    System.Windows.MessageBox.Show("No Post was found.");
            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }
    }
}
