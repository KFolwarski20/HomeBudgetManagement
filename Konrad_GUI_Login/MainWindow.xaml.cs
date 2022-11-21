using Konrad_App;
using System;
using System.Windows;
using System.Windows.Threading;

namespace Konrad_GUI_Login
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserList user_list = UserList.ReadXML("users.xml");
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(0.001);
            LiveTime.Tick += timer_Tick;
            LiveTime.Start();
            txtLogin.Text = "";
            bxPassword.Password = "";
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            bool check_status = false;

            foreach (LoginData u in user_list.list_of_users)
            {
                if (txtLogin.Text == u.Login.ToString() && bxPassword.Password == u.Password.ToString())
                {
                    check_status = true;
                    break;
                }
            }
            if (!(check_status is true))
            {
                MessageBox.Show("Incorrect username or password!");
            }
            else
            {
                window_main.Hide();
                FirstMainWindow first_main_window = new FirstMainWindow(txtLogin.Text);
                first_main_window.Show();
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            bool find_empty_data = false;

            AccountValue ac = new AccountValue(0.00f);
            HistoryOfTransactions hs = new HistoryOfTransactions(ac);

            foreach (LoginData u in user_list.list_of_users)
            {
                if (txtLogin.Text == u.Login.ToString())
                {
                    MessageBox.Show("This login is taken. Provide other login!");
                    find_empty_data = true;
                }
            }
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                find_empty_data = true;
                MessageBox.Show("Login cannot be empty!");
            }
            if (string.IsNullOrEmpty(bxPassword.Password))
            {
                find_empty_data = true;
                MessageBox.Show("Password cannot be empty!");
            }
            if (find_empty_data == false)
            {
                LoginData ld = new LoginData
                {
                    Login = txtLogin.Text,
                    Password = bxPassword.Password
                };

                user_list.list_of_users.Add(ld);

                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                Nullable<bool> result = dlg.ShowDialog();

                if (result == true)
                {
                    UserList.SaveXML("users.xml", user_list);
                }

                HistoryOfTransactions.SaveXML($"{txtLogin.Text}.xml", hs);

                window_main.Hide();

                FirstMainWindow first_main_window = new FirstMainWindow(txtLogin.Text);
                first_main_window.Show();
            }
        }
        void timer_Tick(object sender, EventArgs e)
        {
            LiveTimeLabel.Content = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
