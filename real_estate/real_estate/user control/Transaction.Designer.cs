namespace real_estate.user_control
{
    partial class Transaction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.id_trans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_prop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnProp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_trans,
            this.id_prop,
            this.id_cus,
            this.amount,
            this.status,
            this.payment});
            this.dgvTransaction.Location = new System.Drawing.Point(60, 277);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.Size = new System.Drawing.Size(646, 249);
            this.dgvTransaction.TabIndex = 2;
            this.dgvTransaction.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaction_CellDoubleClick);
            // 
            // id_trans
            // 
            this.id_trans.DataPropertyName = "id_trans";
            this.id_trans.HeaderText = "ID";
            this.id_trans.Name = "id_trans";
            // 
            // id_prop
            // 
            this.id_prop.DataPropertyName = "id_prop";
            this.id_prop.HeaderText = "ID Property";
            this.id_prop.Name = "id_prop";
            // 
            // id_cus
            // 
            this.id_cus.DataPropertyName = "id_cus";
            this.id_cus.HeaderText = "ID Customer";
            this.id_cus.Name = "id_cus";
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // payment
            // 
            this.payment.DataPropertyName = "payment";
            this.payment.HeaderText = "Payment";
            this.payment.Name = "payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by Customer";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(174, 241);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(154, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnProp
            // 
            this.btnProp.BackColor = System.Drawing.Color.SeaGreen;
            this.btnProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProp.ForeColor = System.Drawing.Color.White;
            this.btnProp.Location = new System.Drawing.Point(356, 32);
            this.btnProp.Name = "btnProp";
            this.btnProp.Size = new System.Drawing.Size(94, 59);
            this.btnProp.TabIndex = 5;
            this.btnProp.Text = "Add";
            this.btnProp.UseVisualStyleBackColor = false;
            this.btnProp.Click += new System.EventHandler(this.btnProp_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPayment);
            this.panel1.Controls.Add(this.lable);
            this.panel1.Controls.Add(this.cbCustomer);
            this.panel1.Controls.Add(this.btnProp);
            this.panel1.Location = new System.Drawing.Point(60, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 133);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Customer :";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(124, 78);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(121, 20);
            this.txtPayment.TabIndex = 8;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(31, 78);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(54, 13);
            this.lable.TabIndex = 7;
            this.lable.Text = "Payment :";
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(124, 32);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbCustomer.TabIndex = 6;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTransaction);
            this.Name = "Transaction";
            this.Size = new System.Drawing.Size(964, 558);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_trans;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prop;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cus;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnProp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label2;
    }
}
