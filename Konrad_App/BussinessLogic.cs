using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Konrad_App
{
    [Serializable]
    public class AccountValue
    {
        float account_value;
        public float Account_value { get => account_value; set => account_value = value; }
        public AccountValue() { }
        public AccountValue(float account_value)
        {
            Account_value = account_value;
        }
        public override string ToString()
        {
            return $"{account_value:0.00} zł";
        }
    }
    [Serializable]
    public class BussinessLogic
    {
        string option_of_transactions;
        string type_of_expenditure;
        float operation_value;
        DateTime date_of_expenditure;

        public float Operation_value { get => operation_value; set => operation_value = value; }
        public string Type_of_expenditure { get => type_of_expenditure; set => type_of_expenditure = value; }
        public DateTime Date_of_expenditure { get => date_of_expenditure; set => date_of_expenditure = value; }
        public string Option_of_transactions { get => option_of_transactions; set => option_of_transactions = value; }
        public BussinessLogic() { }
        public BussinessLogic(DateTime date_of_expenditure, string type_of_expenditure, 
            float operation_value, string option_of_transactions)
        {
            Date_of_expenditure = date_of_expenditure;
            Type_of_expenditure = type_of_expenditure;
            Operation_value = operation_value;
            Option_of_transactions = option_of_transactions;
        }
        public override string ToString()
        {
            return $"Date: {date_of_expenditure:dd-MM-yyyy} Type: \"{type_of_expenditure}\" Value: " +
                $"{operation_value:0.00} zł    ({option_of_transactions})";
        }
    }
    [Serializable]
    public class HistoryOfTransactions
    {
        public AccountValue account_balance;
        public List<BussinessLogic> list_of_transactions;
        public HistoryOfTransactions() { }
        public HistoryOfTransactions(AccountValue account_balance)
        {
            list_of_transactions = new List<BussinessLogic>();
            this.account_balance = account_balance;
        }
        public void AddIncome(BussinessLogic transaction)
        {
            transaction.Option_of_transactions = "+";
            list_of_transactions.Add(transaction);
            account_balance.Account_value += transaction.Operation_value;
        }
        public void AddExpenditure(BussinessLogic transaction)
        {
            transaction.Option_of_transactions = "-";
            list_of_transactions.Add(transaction);
            account_balance.Account_value -= transaction.Operation_value;
        }
        public static void SaveXML(string filename, HistoryOfTransactions hs)
        {
            XmlSerializer xs = new XmlSerializer(typeof(HistoryOfTransactions));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                xs.Serialize(fs, hs);
            }
        }
        public static HistoryOfTransactions ReadXML(string filename)
        {
            if (!File.Exists(filename)) { return null; }
            XmlSerializer xs = new XmlSerializer(typeof(HistoryOfTransactions));
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                return xs.Deserialize(fs) as HistoryOfTransactions;
            }
        }
    }
}
