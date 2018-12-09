namespace real_estate.user_control
{
    partial class Customer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BirthDay = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idcusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailcusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonecusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Phone = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.InformationPanel = new System.Windows.Forms.Panel();
            this.Information = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SearchBoxx = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.dateTimeBirthDay = new System.Windows.Forms.DateTimePicker();
            this.btnSetAppointment = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMail = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVip = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.InformationPanel.SuspendLayout();
            this.PanelSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.Cancel);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Location = new System.Drawing.Point(881, 367);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 113);
            this.panel4.TabIndex = 109;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(99, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 60);
            this.btnUpdate.TabIndex = 69;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.SeaGreen;
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancel.Image = ((System.Drawing.Image)(resources.GetObject("Cancel.Image")));
            this.Cancel.Location = new System.Drawing.Point(262, 22);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(65, 60);
            this.Cancel.TabIndex = 74;
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(20, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 60);
            this.btnAdd.TabIndex = 66;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(180, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 60);
            this.btnDelete.TabIndex = 68;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport.BackgroundImage")));
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExport.Location = new System.Drawing.Point(262, 28);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(65, 60);
            this.btnExport.TabIndex = 113;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(43, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 10);
            this.panel1.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "label1";
            // 
            // BirthDay
            // 
            this.BirthDay.AutoSize = true;
            this.BirthDay.Location = new System.Drawing.Point(72, 153);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(62, 17);
            this.BirthDay.TabIndex = 103;
            this.BirthDay.Text = "BirthDay";
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcusDataGridViewTextBoxColumn,
            this.namecusDataGridViewTextBoxColumn,
            this.emailcusDataGridViewTextBoxColumn,
            this.phonecusDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.createdateDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.customerBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView.Location = new System.Drawing.Point(43, 326);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(779, 316);
            this.dataGridView.TabIndex = 102;
            // 
            // idcusDataGridViewTextBoxColumn
            // 
            this.idcusDataGridViewTextBoxColumn.DataPropertyName = "id_cus";
            this.idcusDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idcusDataGridViewTextBoxColumn.Name = "idcusDataGridViewTextBoxColumn";
            // 
            // namecusDataGridViewTextBoxColumn
            // 
            this.namecusDataGridViewTextBoxColumn.DataPropertyName = "name_cus";
            this.namecusDataGridViewTextBoxColumn.HeaderText = "Name";
            this.namecusDataGridViewTextBoxColumn.Name = "namecusDataGridViewTextBoxColumn";
            // 
            // emailcusDataGridViewTextBoxColumn
            // 
            this.emailcusDataGridViewTextBoxColumn.DataPropertyName = "email_cus";
            this.emailcusDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailcusDataGridViewTextBoxColumn.Name = "emailcusDataGridViewTextBoxColumn";
            // 
            // phonecusDataGridViewTextBoxColumn
            // 
            this.phonecusDataGridViewTextBoxColumn.DataPropertyName = "phone_cus";
            this.phonecusDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phonecusDataGridViewTextBoxColumn.Name = "phonecusDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // createdateDataGridViewTextBoxColumn
            // 
            this.createdateDataGridViewTextBoxColumn.DataPropertyName = "create_date";
            this.createdateDataGridViewTextBoxColumn.HeaderText = "CreateDay";
            this.createdateDataGridViewTextBoxColumn.Name = "createdateDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(DAL.customer);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(72, 242);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(49, 17);
            this.Phone.TabIndex = 101;
            this.Phone.Text = "Phone";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(72, 197);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 100;
            this.Email.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(140, 242);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(275, 22);
            this.txtPhone.TabIndex = 99;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 194);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(555, 22);
            this.txtEmail.TabIndex = 98;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(72, 108);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(45, 17);
            this.Name.TabIndex = 97;
            this.Name.Text = "Name";
            // 
            // InformationPanel
            // 
            this.InformationPanel.BackColor = System.Drawing.Color.SeaGreen;
            this.InformationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.InformationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InformationPanel.Controls.Add(this.Information);
            this.InformationPanel.Location = new System.Drawing.Point(43, 39);
            this.InformationPanel.Name = "InformationPanel";
            this.InformationPanel.Size = new System.Drawing.Size(737, 41);
            this.InformationPanel.TabIndex = 105;
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Information.Location = new System.Drawing.Point(286, 9);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(92, 20);
            this.Information.TabIndex = 41;
            this.Information.Text = "Information";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(555, 22);
            this.txtName.TabIndex = 95;
            // 
            // PanelSearch
            // 
            this.PanelSearch.BackColor = System.Drawing.Color.SeaGreen;
            this.PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSearch.Controls.Add(this.button2);
            this.PanelSearch.Controls.Add(this.SearchBoxx);
            this.PanelSearch.Controls.Add(this.SearchBox);
            this.PanelSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.PanelSearch.Location = new System.Drawing.Point(866, 39);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(364, 57);
            this.PanelSearch.TabIndex = 93;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.ForeColor = System.Drawing.Color.SeaGreen;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(292, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 53);
            this.button2.TabIndex = 111;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // SearchBoxx
            // 
            this.SearchBoxx.Location = new System.Drawing.Point(12, 17);
            this.SearchBoxx.Name = "SearchBoxx";
            this.SearchBoxx.Size = new System.Drawing.Size(274, 22);
            this.SearchBoxx.TabIndex = 1;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(13, 21);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(0, 22);
            this.SearchBox.TabIndex = 0;
            // 
            // dateTimeBirthDay
            // 
            this.dateTimeBirthDay.CustomFormat = " dd  /  MM  /  yyyy";
            this.dateTimeBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeBirthDay.Location = new System.Drawing.Point(140, 150);
            this.dateTimeBirthDay.Name = "dateTimeBirthDay";
            this.dateTimeBirthDay.Size = new System.Drawing.Size(160, 22);
            this.dateTimeBirthDay.TabIndex = 110;
            // 
            // btnSetAppointment
            // 
            this.btnSetAppointment.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSetAppointment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSetAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnSetAppointment.Image")));
            this.btnSetAppointment.Location = new System.Drawing.Point(20, 28);
            this.btnSetAppointment.Name = "btnSetAppointment";
            this.btnSetAppointment.Size = new System.Drawing.Size(65, 60);
            this.btnSetAppointment.TabIndex = 68;
            this.btnSetAppointment.UseVisualStyleBackColor = false;
            this.btnSetAppointment.Click += new System.EventHandler(this.btnSetAppointment_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(920, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 142);
            this.panel3.TabIndex = 107;
            // 
            // btnMail
            // 
            this.btnMail.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMail.Image = ((System.Drawing.Image)(resources.GetObject("btnMail.Image")));
            this.btnMail.Location = new System.Drawing.Point(99, 28);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(65, 60);
            this.btnMail.TabIndex = 111;
            this.btnMail.UseVisualStyleBackColor = false;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnVip);
            this.panel2.Controls.Add(this.btnMail);
            this.panel2.Controls.Add(this.btnSetAppointment);
            this.panel2.Location = new System.Drawing.Point(881, 505);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 113);
            this.panel2.TabIndex = 112;
            // 
            // btnVip
            // 
            this.btnVip.BackColor = System.Drawing.Color.SeaGreen;
            this.btnVip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVip.Image = ((System.Drawing.Image)(resources.GetObject("btnVip.Image")));
            this.btnVip.Location = new System.Drawing.Point(180, 28);
            this.btnVip.Name = "btnVip";
            this.btnVip.Size = new System.Drawing.Size(65, 60);
            this.btnVip.TabIndex = 112;
            this.btnVip.UseVisualStyleBackColor = false;
            this.btnVip.Click += new System.EventHandler(this.btnVip_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dateTimeBirthDay);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BirthDay);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.InformationPanel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.PanelSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(1285, 687);
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.InformationPanel.ResumeLayout(false);
            this.InformationPanel.PerformLayout();
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BirthDay;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Panel InformationPanel;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel PanelSearch;
        private System.Windows.Forms.TextBox SearchBoxx;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailcusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonecusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSetAppointment;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVip;
        private System.Windows.Forms.Button btnExport;
    }
}
