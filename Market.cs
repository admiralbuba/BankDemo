using BankSimulator;
using BankSimulator.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDemo
{
    public partial class MarketForm : Form
    {
        Client market;
        public MarketForm()
        {
            InitializeComponent();
            BankSingleton.Instance.ProcessingCenter.TransactionCompleted += () => UpdateDatabase();
            using BankSimulator.ApplicationContext db = new();
            var clients = db.Clients.Include(c => c.Bank).ToList();
            market = clients.FirstOrDefault(c => c.Id == 3);
            var products = db.Products.ToList();
            var cards = db.Cards.ToList();

            productsDataGridView.DataSource = products;
            cardsDataGridView.DataSource = cards;
        }
        private void UpdateDatabase()
        {
            using BankSimulator.ApplicationContext db = new();
            var products = db.Products.ToList();
            db.SaveChanges();
            if (InvokeRequired)
                Invoke(new Action(() =>
                {
                    productsDataGridView.DataSource = products;
                }));
        }
        private void payButton_Click(object sender, EventArgs e)
        {
            var sum = (int)productsDataGridView.SelectedCells[1].Value;
            using BankSimulator.ApplicationContext db = new();
            var products = db.Products.ToList();
            var pName = (string)productsDataGridView.SelectedCells[0].Value;
            var productToUpdate = products.FirstOrDefault(p => p.Name == pName);
            productToUpdate.Amount--;
            var account = db.Accounts.Where(x => x.Card.CardNumber == cardNumberTextBox.Text).FirstOrDefault();
            if (account != null)
                BankSingleton.Instance.ProcessingCenter.RegisterTransaction(new Transaction 
                { AccountIdFrom = account.Id, AccountIdTo = 3, Sum = sum });
        }
    }
}
