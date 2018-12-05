namespace real_estate
{
    partial class Appointmentt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointmentt));
            this.comboBoxIDCus = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Panel();
            this.labelID = new System.Windows.Forms.Label();
            this.tStatus = new System.Windows.Forms.Label();
            this.dateTimeAppo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxIDCus
            // 
            this.comboBoxIDCus.FormattingEnabled = true;
            this.comboBoxIDCus.Location = new System.Drawing.Point(119, 293);
            this.comboBoxIDCus.Name = "comboBoxIDCus";
            this.comboBoxIDCus.Size = new System.Drawing.Size(277, 24);
            this.comboBoxIDCus.TabIndex = 70;
            this.comboBoxIDCus.SelectedIndexChanged += new System.EventHandler(this.comboBoxIDCus_SelectedIndexChanged_1);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(119, 200);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(363, 22);
            this.txtStatus.TabIndex = 100;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(119, 74);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(363, 101);
            this.txtDes.TabIndex = 101;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 46);
            this.panel1.TabIndex = 102;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit.Location = new System.Drawing.Point(456, 6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(41, 36);
            this.Exit.TabIndex = 103;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(20, 79);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(79, 17);
            this.labelID.TabIndex = 104;
            this.labelID.Text = "Description";
            // 
            // tStatus
            // 
            this.tStatus.AutoSize = true;
            this.tStatus.Location = new System.Drawing.Point(21, 203);
            this.tStatus.Name = "tStatus";
            this.tStatus.Size = new System.Drawing.Size(48, 17);
            this.tStatus.TabIndex = 105;
            this.tStatus.Text = "Status";
            // 
            // dateTimeAppo
            // 
            this.dateTimeAppo.CustomFormat = " dd  /  MM  /  yyyy  ";
            this.dateTimeAppo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAppo.Location = new System.Drawing.Point(119, 247);
            this.dateTimeAppo.Name = "dateTimeAppo";
            this.dateTimeAppo.Size = new System.Drawing.Size(183, 22);
            this.dateTimeAppo.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 112;
            this.label2.Text = "Customer";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(21, 252);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(38, 17);
            this.Date.TabIndex = 113;
            this.Date.Text = "Date";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(27, 376);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 10);
            this.panel3.TabIndex = 114;
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
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(170, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 70);
            this.btnCancel.TabIndex = 115;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnCheck);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Location = new System.Drawing.Point(153, 421);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 100);
            this.panel2.TabIndex = 116;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
            this.btnCheck.Location = new System.Drawing.Point(34, 15);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(123, 70);
            this.btnCheck.TabIndex = 116;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Appointmentt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(511, 558);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeAppo);
            this.Controls.Add(this.tStatus);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.comboBoxIDCus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointmentt";
            this.Text = "Appointmentt";
            this.Load += new System.EventHandler(this.Appointmentt_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxIDCus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Exit;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label tStatus;
        private System.Windows.Forms.DateTimePicker dateTimeAppo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCheck;
    }
}