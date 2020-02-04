namespace MegaDesk_Mosher
{
    partial class ViewAllQuotes
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
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.QuoteList = new System.Windows.Forms.DataGridView();
            this.deskQuoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.submitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.QuoteList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(12, 400);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(111, 38);
            this.CloseFormButton.TabIndex = 2;
            this.CloseFormButton.Text = "&Return To Main";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // QuoteList
            // 
            this.QuoteList.AutoGenerateColumns = false;
            this.QuoteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuoteList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.submitDateDataGridViewTextBoxColumn,
            this.clientFirstNameDataGridViewTextBoxColumn,
            this.clientLastNameDataGridViewTextBoxColumn,
            this.deskMaterial,
            this.quoteTotalDataGridViewTextBoxColumn});
            this.QuoteList.DataSource = this.deskQuoteBindingSource;
            this.QuoteList.Location = new System.Drawing.Point(68, 39);
            this.QuoteList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.QuoteList.Name = "QuoteList";
            this.QuoteList.Size = new System.Drawing.Size(559, 332);
            this.QuoteList.TabIndex = 3;
            this.QuoteList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // deskQuoteBindingSource
            // 
            this.deskQuoteBindingSource.DataSource = typeof(MegaDesk_Mosher.DeskQuote);
            // 
            // submitDateDataGridViewTextBoxColumn
            // 
            this.submitDateDataGridViewTextBoxColumn.DataPropertyName = "submitDate";
            this.submitDateDataGridViewTextBoxColumn.HeaderText = "Quote Date";
            this.submitDateDataGridViewTextBoxColumn.Name = "submitDateDataGridViewTextBoxColumn";
            // 
            // clientFirstNameDataGridViewTextBoxColumn
            // 
            this.clientFirstNameDataGridViewTextBoxColumn.DataPropertyName = "clientFirstName";
            this.clientFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.clientFirstNameDataGridViewTextBoxColumn.Name = "clientFirstNameDataGridViewTextBoxColumn";
            // 
            // clientLastNameDataGridViewTextBoxColumn
            // 
            this.clientLastNameDataGridViewTextBoxColumn.DataPropertyName = "clientLastName";
            this.clientLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.clientLastNameDataGridViewTextBoxColumn.Name = "clientLastNameDataGridViewTextBoxColumn";
            // 
            // deskMaterial
            // 
            this.deskMaterial.DataPropertyName = "deskMaterial";
            this.deskMaterial.HeaderText = "Desk Material";
            this.deskMaterial.Name = "deskMaterial";
            // 
            // quoteTotalDataGridViewTextBoxColumn
            // 
            this.quoteTotalDataGridViewTextBoxColumn.DataPropertyName = "quoteTotal";
            this.quoteTotalDataGridViewTextBoxColumn.HeaderText = "Quote Total";
            this.quoteTotalDataGridViewTextBoxColumn.Name = "quoteTotalDataGridViewTextBoxColumn";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuoteList);
            this.Controls.Add(this.CloseFormButton);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Quotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuoteList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.DataGridView QuoteList;
        private System.Windows.Forms.BindingSource deskQuoteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteTotalDataGridViewTextBoxColumn;
    }
}