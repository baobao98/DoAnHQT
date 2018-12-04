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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.id_trans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_prop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 108);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill";
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
            this.dgvTransaction.Location = new System.Drawing.Point(88, 207);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.Size = new System.Drawing.Size(645, 213);
            this.dgvTransaction.TabIndex = 2;
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
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.label2);
            this.Name = "Transaction";
            this.Size = new System.Drawing.Size(964, 558);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_trans;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prop;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cus;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
    }
}
