using System;
using Konrad_App;
using ChartOfExpedinturesActual;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Threading;

namespace Konrad_GUI_Login
{
    /// <summary>
    /// Logika interakcji dla klasy FirstMainWindow.xaml
    /// </summary>
    public partial class FirstMainWindow : Window
    {
        bool is_changed = false;
        HistoryOfTransactions transactions_history;
        Form1 chart;
        MainWindow window_main = new MainWindow();
        public FirstMainWindow() { }

        public FirstMainWindow(string login)
        {
            InitializeComponent();
            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(0.001);
            LiveTime.Tick += timer_Tick;
            LiveTime.Start();
            string xml_file = login + ".xml";
            string path_to_chart = $"C:/Users/Admin/Documents/Konrad Studia" +
                $"/Programowanie C#/Application/Konrad_GUI_Login/bin/Debug/{xml_file}";

            chart = new Form1(path_to_chart);
            transactions_history = HistoryOfTransactions.ReadXML(xml_file);
            lstOperationsStory.ItemsSource = new ObservableCollection<BussinessLogic>(transactions_history.list_of_transactions);
            txtAccountBalance.Text = transactions_history.account_balance.ToString();
        }

        private void btnAddIncome_Click(object sender, RoutedEventArgs e)
        {
            string kind = "Income";
            UpdateExpenses(kind);
        }

        private void btnAddExpenditure_Click(object sender, RoutedEventArgs e)
        {
            string kind = "Expenditure";
            UpdateExpenses(kind);
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            AskAboutSave();
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            AskAboutSave();
            window_main.Show();
        }
        private void SaveFile()
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                HistoryOfTransactions.SaveXML(filename, transactions_history);
            }
        }
        private void AskAboutSave()
        {
            if (is_changed is true)
            {
                MessageBoxResult result = MessageBox.Show("Do you want to save the changes made?",
                    "", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.No)
                {
                    first_main_window.Close();
                }
                if (result == MessageBoxResult.Yes)
                {
                    SaveFile();
                    MessageBox.Show("Saved successfully!");
                    first_main_window.Close();
                }
                if (result == MessageBoxResult.Cancel)
                {
                    first_main_window.Close();
                }
            }
            else
            {
                first_main_window.Close();
            }
        }
        private void UpdateExpenses(string kind)
        {
            BussinessLogic bussiness_logic = new BussinessLogic();
            OperationWindow operation_window = new OperationWindow(bussiness_logic);
            operation_window.ShowDialog();

            if (operation_window.DialogResult == true)
            {
                transactions_history.list_of_transactions.Add(bussiness_logic);

                if (kind == "Income")
                {
                    bussiness_logic.Option_of_transactions = "+";
                    transactions_history.account_balance.Account_value += bussiness_logic.Operation_value;
                }
                if (kind == "Expenditure")
                {
                    bussiness_logic.Option_of_transactions = "-";
                    transactions_history.account_balance.Account_value -= bussiness_logic.Operation_value;
                }

                txtAccountBalance.Text = transactions_history.account_balance.ToString();
                is_changed = true;
            }
            lstOperationsStory.ItemsSource =
                new ObservableCollection<BussinessLogic>(transactions_history.list_of_transactions);
        }

        private void btnSeeChart_Click(object sender, RoutedEventArgs e)
        {
            chart.ShowDialog();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            LiveTimeLabel.Content = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
