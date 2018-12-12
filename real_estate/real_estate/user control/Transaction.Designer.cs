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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.id_trans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_prop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnProp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTransaction
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransaction.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_trans,
            this.id_prop,
            this.id_cus,
            this.amount,
            this.status,
            this.payment,
            this.create_date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransaction.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransaction.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTransaction.Location = new System.Drawing.Point(59, 268);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaction.Size = new System.Drawing.Size(746, 246);
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
            // create_date
            // 
            this.create_date.DataPropertyName = "create_date";
            this.create_date.HeaderText = "Create Date";
            this.create_date.Name = "create_date";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 10);
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
            this.btnProp.Image = ((System.Drawing.Image)(resources.GetObject("btnProp.Image")));
            this.btnProp.Location = new System.Drawing.Point(847, 356);
            this.btnProp.Name = "btnProp";
            this.btnProp.Size = new System.Drawing.Size(64, 61);
            this.btnProp.TabIndex = 5;
            this.btnProp.UseVisualStyleBackColor = false;
            this.btnProp.Click += new System.EventHandler(this.btnProp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Customer :";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(137, 140);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(320, 20);
            this.txtPayment.TabIndex = 8;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(61, 147);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(54, 13);
            this.lable.TabIndex = 7;
            this.lable.Text = "Payment :";
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(137, 98);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(320, 21);
            this.cbCustomer.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(669, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 43);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(178, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(46, 40);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(59, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 10);
            this.panel2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(59, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(465, 31);
            this.panel4.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(693, 98);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(186, 97);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.btnProp);
            this.Name = "Transaction";
            this.Size = new System.Drawing.Size(964, 558);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnProp;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_trans;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prop;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cus;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
