using System;
using Konrad_App;
using System.Windows.Forms;

namespace ChartOfExpedinturesActual
{
    public partial class Form1 : Form
    {
        HistoryOfTransactions transactions_history;
        public Form1()
        { }
        public Form1(string path_to_chart)
        {
            InitializeComponent();
            transactions_history = HistoryOfTransactions.ReadXML(path_to_chart);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(BussinessLogic transactions in transactions_history.list_of_transactions)
            {
                ChartExpedintures.Series[transactions.Type_of_expenditure].Points.AddXY(transactions.Date_of_expenditure, transactions.Operation_value);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
