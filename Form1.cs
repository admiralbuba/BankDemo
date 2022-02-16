using BankSimulator;
using Microsoft.EntityFrameworkCore;

namespace BankDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            BankSingleton.Instance.ProcessingCenter.Notify += x => AppentdText(x);
            BankSingleton.Instance.ProcessingCenter.TransactionCompleted += () => RefreshGrid();
            Task.Run(() => BankSingleton.Instance.ProcessingCenter.Start());
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
            BankSingleton.Instance.ProcessingCenter.RegisterTransaction(new Transaction()
            {
                AccountIdFrom = Int32.Parse(fromTextBox.Text),
                AccountIdTo = Int32.Parse(toTextBox.Text),
                Sum = Int32.Parse(SumTextBox.Text)
            });
        }

        private void marketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MarketForm().Show();
        }
    }
}