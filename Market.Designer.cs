namespace BankDemo
{
    partial class MarketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.cardNubmerLabel = new System.Windows.Forms.Label();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.marketBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payButton = new System.Windows.Forms.Button();
            this.cardsDataGridView = new System.Windows.Forms.DataGridView();
            this.cardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(518, 120);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(229, 27);
            this.cardNumberTextBox.TabIndex = 0;
            // 
            // cardNubmerLabel
            // 
            this.cardNubmerLabel.AutoSize = true;
            this.cardNubmerLabel.Location = new System.Drawing.Point(518, 97);
            this.cardNubmerLabel.Name = "cardNubmerLabel";
            this.cardNubmerLabel.Size = new System.Drawing.Size(98, 20);
            this.cardNubmerLabel.TabIndex = 1;
            this.cardNubmerLabel.Text = "Card Number";
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Price,
            this.Amount});
            this.productsDataGridView.DataSource = this.productBindingSource1;
            this.productsDataGridView.Location = new System.Drawing.Point(19, 35);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 51;
            this.productsDataGridView.RowTemplate.Height = 29;
            this.productsDataGridView.Size = new System.Drawing.Size(274, 157);
            this.productsDataGridView.TabIndex = 2;
            // 
            // marketBindingSource2
            // 
            this.marketBindingSource2.DataSource = typeof(BankSimulator.Models.Market);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(BankSimulator.Models.Product);
            // 
            // marketBindingSource3
            // 
            this.marketBindingSource3.DataSource = typeof(BankSimulator.Models.Market);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(BankSimulator.Models.Product);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 80;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 50;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 91;
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(526, 191);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(93, 39);
            this.payButton.TabIndex = 3;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // cardsDataGridView
            // 
            this.cardsDataGridView.AutoGenerateColumns = false;
            this.cardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cardNumberDataGridViewTextBoxColumn});
            this.cardsDataGridView.DataSource = this.cardBindingSource;
            this.cardsDataGridView.Location = new System.Drawing.Point(23, 229);
            this.cardsDataGridView.Name = "cardsDataGridView";
            this.cardsDataGridView.RowHeadersWidth = 51;
            this.cardsDataGridView.RowTemplate.Height = 29;
            this.cardsDataGridView.Size = new System.Drawing.Size(254, 91);
            this.cardsDataGridView.TabIndex = 4;
            // 
            // cardBindingSource
            // 
            this.cardBindingSource.DataSource = typeof(BankSimulator.Card);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 51;
            // 
            // cardNumberDataGridViewTextBoxColumn
            // 
            this.cardNumberDataGridViewTextBoxColumn.DataPropertyName = "CardNumber";
            this.cardNumberDataGridViewTextBoxColumn.HeaderText = "CardNumber";
            this.cardNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cardNumberDataGridViewTextBoxColumn.Name = "cardNumberDataGridViewTextBoxColumn";
            this.cardNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // Market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cardsDataGridView);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.cardNubmerLabel);
            this.Controls.Add(this.cardNumberTextBox);
            this.Name = "Market";
            this.Text = "Market";
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox cardNumberTextBox;
        private Label cardNubmerLabel;
        private DataGridView productsDataGridView;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Price;
        private BindingSource marketBindingSource3;
        private BindingSource marketBindingSource2;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn Amount;
        private BindingSource productBindingSource1;
        private Button payButton;
        private DataGridView cardsDataGridView;
        private BindingSource cardBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cardNumberDataGridViewTextBoxColumn;
    }
}