using BankSimulator;
using Microsoft.EntityFrameworkCore;

namespace BankDemo
{
    public partial class Form1 : Form
    {
        ProcessingCenter pc;
        public Form1()
        {
            InitializeComponent();
            pc = new();
            pc.Notify += x => AppentdText(x);
            pc.TransactionCompleted += () => RefreshGrid();
            Task.Run(() => pc.Start());
            using BankSimulator.ApplicationContext db = new();
            var accounts = db.Accounts.ToList();

            accountsDataGridView.DataSource = accounts;
        }
        private void AppentdText(string message)
        {
            if(InvokeRequired)
                Invoke(new Action(() => messagesRichTextBox.AppendText(message + "\n")));
        }
        private void RefreshGrid()
        {
            using BankSimulator.ApplicationContext db = new();
            var accounts = db.Accounts.ToList();
            if (InvokeRequired)
                Invoke(new Action(() =>
                {
                    accountsDataGridView.DataSource = accounts;
                }));
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            pc.RegisterTransaction(new Transaction()
            {
                AccountIdFrom = Int32.Parse(fromTextBox.Text),
                AccountIdTo = Int32.Parse(toTextBox.Text),
                Sum = Int32.Parse(SumTextBox.Text)
            });
        }
    }
}