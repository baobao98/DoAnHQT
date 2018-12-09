namespace real_estate
{
    partial class VIP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIP));
            this.dgvVip = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idcusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_cus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trannsactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trannsactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptnExit = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trannsactionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trannsactionBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVip
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvVip.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVip.AutoGenerateColumns = false;
            this.dgvVip.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvVip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVip.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcusDataGridViewTextBoxColumn,
            this.name_cus,
            this.amountDataGridViewTextBoxColumn});
            this.dgvVip.DataSource = this.trannsactionBindingSource1;
            this.dgvVip.DoubleBuffered = true;
            this.dgvVip.EnableHeadersVisualStyles = false;
            this.dgvVip.GridColor = System.Drawing.Color.DarkGray;
            this.dgvVip.HeaderBgColor = System.Drawing.Color.DarkGreen;
            this.dgvVip.HeaderForeColor = System.Drawing.Color.White;
            this.dgvVip.Location = new System.Drawing.Point(52, 177);
            this.dgvVip.Name = "dgvVip";
            this.dgvVip.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVip.RowTemplate.Height = 24;
            this.dgvVip.Size = new System.Drawing.Size(318, 167);
            this.dgvVip.TabIndex = 0;
            this.dgvVip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVip_CellContentClick);
            // 
            // idcusDataGridViewTextBoxColumn
            // 
            this.idcusDataGridViewTextBoxColumn.DataPropertyName = "id_cus";
            this.idcusDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idcusDataGridViewTextBoxColumn.Name = "idcusDataGridViewTextBoxColumn";
            // 
            // name_cus
            // 
            this.name_cus.DataPropertyName = "name_cus";
            this.name_cus.HeaderText = "Customer";
            this.name_cus.Name = "name_cus";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // trannsactionBindingSource1
            // 
            this.trannsactionBindingSource1.DataSource = typeof(DAL.trannsaction);
            // 
            // trannsactionBindingSource
            // 
            this.trannsactionBindingSource.DataSource = typeof(DAL.trannsaction);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.ptnExit);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Location = new System.Drawing.Point(-14, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 47);
            this.panel1.TabIndex = 104;
            // 
            // ptnExit
            // 
            this.ptnExit.BackColor = System.Drawing.Color.DarkGreen;
            this.ptnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptnExit.BackgroundImage")));
            this.ptnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptnExit.Location = new System.Drawing.Point(386, 12);
            this.ptnExit.Name = "ptnExit";
            this.ptnExit.Size = new System.Drawing.Size(37, 30);
            this.ptnExit.TabIndex = 105;
            this.ptnExit.Click += new System.EventHandler(this.ptnExit_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit.Location = new System.Drawing.Point(435, 1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(41, 36);
            this.Exit.TabIndex = 103;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(115, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 74);
            this.panel2.TabIndex = 105;
            // 
            // VIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(419, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvVip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIP";
            this.Load += new System.EventHandler(this.VIP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trannsactionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trannsactionBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvVip;
        private System.Windows.Forms.BindingSource trannsactionBindingSource1;
        private System.Windows.Forms.BindingSource trannsactionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Exit;
        private System.Windows.Forms.Panel ptnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_cus;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}