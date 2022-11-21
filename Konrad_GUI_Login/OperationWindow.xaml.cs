using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Konrad_App;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Globalization;

namespace Konrad_GUI_Login
{
    /// <summary>
    /// Logika interakcji dla klasy OperationWindow.xaml
    /// </summary>
    public partial class OperationWindow : Window
    {
        private readonly BussinessLogic _bussinessLogic;
        public OperationWindow()
        {
            InitializeComponent();
        }
        public OperationWindow(BussinessLogic bussiness_logic): this()
        {
            _bussinessLogic = bussiness_logic;
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (txtDateOfOperation.Text != "" && cbTypeOfOperation.Text != "" && txtValueOfOperation.Text != "")
            {
                _bussinessLogic.Type_of_expenditure = cbTypeOfOperation.Text;
                string[] fdate = { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy" };
                if (DateTime.TryParseExact(txtDateOfOperation.Text, fdate, null, DateTimeStyles.None, out DateTime txtData))
                {
                    _bussinessLogic.Date_of_expenditure = txtData;
                }
                else if (string.IsNullOrEmpty(txtDateOfOperation.Text))
                {
                    string error = "Date cannot be empty!";
                    MessageBox.Show(error);
                    throw new Exception(error);
                }
                else
                {
                    string error = "An invalid date format was entered!";
                    MessageBox.Show(error);
                    throw new Exception(error);
                }
                if (float.TryParse(txtValueOfOperation.Text, out float value))
                {
                    _bussinessLogic.Operation_value = value;
                }
                else if (string.IsNullOrEmpty(txtValueOfOperation.Text))
                {
                    string error = "Value cannot be empty!";
                    MessageBox.Show(error);
                    throw new Exception(error);
                }
                else
                {
                    string error = "An invalid value format was entered!";
                    MessageBox.Show(error);
                    throw new Exception(error);
                }
                DialogResult = true;
            }
            else { return; }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
