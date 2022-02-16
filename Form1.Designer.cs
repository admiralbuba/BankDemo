namespace BankDemo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sendButton = new System.Windows.Forms.Button();
            this.messagesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.sumLabel = new System.Windows.Forms.Label();
            this.accountsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsBlocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(42, 372);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(89, 46);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messagesRichTextBox
            // 
            this.messagesRichTextBox.Location = new System.Drawing.Point(375, 93);
            this.messagesRichTextBox.Name = "messagesRichTextBox";
            this.messagesRichTextBox.Size = new System.Drawing.Size(241, 263);
            this.messagesRichTextBox.TabIndex = 6;
            this.messagesRichTextBox.Text = "";
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(140, 315);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(84, 27);
            this.SumTextBox.TabIndex = 7;
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(159, 292);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(38, 20);
            this.sumLabel.TabIndex = 8;
            this.sumLabel.Text = "Sum";
            // 
            // accountsDataGridView
            // 
            this.accountsDataGridView.AutoGenerateColumns = false;
            this.accountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Sum,
            this.IsBlocked});
            this.accountsDataGridView.DataSource = this.accountBindingSource;
            this.accountsDataGridView.Location = new System.Drawing.Point(42, 93);
            this.accountsDataGridView.Name = "accountsDataGridView";
            this.accountsDataGridView.RowHeadersWidth = 51;
            this.accountsDataGridView.RowTemplate.Height = 29;
            this.accountsDataGridView.Size = new System.Drawing.Size(268, 181);
            this.accountsDataGridView.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // Sum
            // 
            this.Sum.DataPropertyName = "Sum";
            this.Sum.HeaderText = "Sum";
            this.Sum.MinimumWidth = 6;
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            this.Sum.Width = 60;
            // 
            // IsBlocked
            // 
            this.IsBlocked.DataPropertyName = "IsBlocked";
            this.IsBlocked.HeaderText = "IsBlocked";
            this.IsBlocked.MinimumWidth = 6;
            this.IsBlocked.Name = "IsBlocked";
            this.IsBlocked.ReadOnly = true;
            this.IsBlocked.Width = 125;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(BankSimulator.Account);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(BankSimulator.Client);
            // 
            // accountBindingSource1
            // 
            this.accountBindingSource1.DataSource = typeof(BankSimulator.Account);
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(42, 315);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(84, 27);
            this.fromTextBox.TabIndex = 10;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(240, 315);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(84, 27);
            this.toTextBox.TabIndex = 11;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(60, 292);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(43, 20);
            this.fromLabel.TabIndex = 12;
            this.fromLabel.Text = "From";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(257, 292);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(25, 20);
            this.toLabel.TabIndex = 13;
            this.toLabel.Text = "To";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marketToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // marketToolStripMenuItem
            // 
            this.marketToolStripMenuItem.Name = "marketToolStripMenuItem";
            this.marketToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.marketToolStripMenuItem.Text = "Market";
            this.marketToolStripMenuItem.Click += new System.EventHandler(this.marketToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.accountsDataGridView);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.messagesRichTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bank";
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button sendButton;
        private RichTextBox messagesRichTextBox;
        private TextBox SumTextBox;
        private Label sumLabel;
        private DataGridView accountsDataGridView;
        private BindingSource clientBindingSource;
        private BindingSource accountBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Sum;
        private DataGridViewCheckBoxColumn IsBlocked;
        private BindingSource accountBindingSource1;
        private TextBox fromTextBox;
        private TextBox toTextBox;
        private Label fromLabel;
        private Label toLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem marketToolStripMenuItem;
    }
}