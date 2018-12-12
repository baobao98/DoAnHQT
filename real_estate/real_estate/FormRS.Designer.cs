namespace real_estate
{
    partial class FormRS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRS));
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSale = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProject = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBill = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCustomer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbBellNumber = new System.Windows.Forms.Label();
            this.picBell = new System.Windows.Forms.PictureBox();
            this.tbExit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bell1 = new real_estate.user_control.bell();
            this.dashboard = new real_estate.user_control.dashboard();
            this.transaction = new real_estate.user_control.Transaction();
            this.realEstate1 = new real_estate.user_control.RealEstate();
            this.projectType1 = new real_estate.user_control.ProjectType();
            this.projects1 = new real_estate.user_control.Projects();
            this.products1 = new real_estate.user_control.Products();
            this.marketing1 = new real_estate.user_control.Marketing();
            this.employee2 = new real_estate.user_control.Employee();
            this.customer2 = new real_estate.user_control.Customer();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBell)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.bunifuFlatButton2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnSale);
            this.panel2.Controls.Add(this.btnProject);
            this.panel2.Controls.Add(this.btnBill);
            this.panel2.Controls.Add(this.btnProduct);
            this.panel2.Controls.Add(this.btnCustomer);
            this.panel2.Controls.Add(this.btnEmp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 590);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton2.ButtonText = "Dashboard";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 60D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 117);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(206, 48);
            this.bunifuFlatButton2.TabIndex = 11;
            this.bunifuFlatButton2.Text = "Dashboard";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(41, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Real Estate";
            // 
            // btnSale
            // 
            this.btnSale.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSale.BorderRadius = 0;
            this.btnSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSale.ButtonText = "Sales";
            this.btnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSale.DisabledColor = System.Drawing.Color.Gray;
            this.btnSale.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSale.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSale.Iconimage")));
            this.btnSale.Iconimage_right = null;
            this.btnSale.Iconimage_right_Selected = null;
            this.btnSale.Iconimage_Selected = null;
            this.btnSale.IconMarginLeft = 0;
            this.btnSale.IconMarginRight = 0;
            this.btnSale.IconRightVisible = true;
            this.btnSale.IconRightZoom = 0D;
            this.btnSale.IconVisible = true;
            this.btnSale.IconZoom = 60D;
            this.btnSale.IsTab = false;
            this.btnSale.Location = new System.Drawing.Point(-3, 444);
            this.btnSale.Name = "btnSale";
            this.btnSale.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSale.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSale.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSale.selected = false;
            this.btnSale.Size = new System.Drawing.Size(206, 48);
            this.btnSale.TabIndex = 6;
            this.btnSale.Text = "Sales";
            this.btnSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSale.Textcolor = System.Drawing.Color.White;
            this.btnSale.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnProject
            // 
            this.btnProject.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProject.BorderRadius = 0;
            this.btnProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnProject.ButtonText = "Projects";
            this.btnProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProject.DisabledColor = System.Drawing.Color.Gray;
            this.btnProject.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProject.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProject.Iconimage")));
            this.btnProject.Iconimage_right = null;
            this.btnProject.Iconimage_right_Selected = null;
            this.btnProject.Iconimage_Selected = null;
            this.btnProject.IconMarginLeft = 0;
            this.btnProject.IconMarginRight = 0;
            this.btnProject.IconRightVisible = true;
            this.btnProject.IconRightZoom = 0D;
            this.btnProject.IconVisible = true;
            this.btnProject.IconZoom = 60D;
            this.btnProject.IsTab = false;
            this.btnProject.Location = new System.Drawing.Point(-3, 387);
            this.btnProject.Name = "btnProject";
            this.btnProject.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProject.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnProject.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProject.selected = false;
            this.btnProject.Size = new System.Drawing.Size(209, 59);
            this.btnProject.TabIndex = 5;
            this.btnProject.Text = "Projects";
            this.btnProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProject.Textcolor = System.Drawing.Color.White;
            this.btnProject.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnBill
            // 
            this.btnBill.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBill.BorderRadius = 0;
            this.btnBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBill.ButtonText = "Bills";
            this.btnBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBill.DisabledColor = System.Drawing.Color.Gray;
            this.btnBill.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBill.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBill.Iconimage")));
            this.btnBill.Iconimage_right = null;
            this.btnBill.Iconimage_right_Selected = null;
            this.btnBill.Iconimage_Selected = null;
            this.btnBill.IconMarginLeft = 0;
            this.btnBill.IconMarginRight = 0;
            this.btnBill.IconRightVisible = true;
            this.btnBill.IconRightZoom = 0D;
            this.btnBill.IconVisible = true;
            this.btnBill.IconZoom = 60D;
            this.btnBill.IsTab = false;
            this.btnBill.Location = new System.Drawing.Point(-3, 331);
            this.btnBill.Name = "btnBill";
            this.btnBill.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBill.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBill.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBill.selected = false;
            this.btnBill.Size = new System.Drawing.Size(209, 59);
            this.btnBill.TabIndex = 4;
            this.btnBill.Text = "Bills";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBill.Textcolor = System.Drawing.Color.White;
            this.btnBill.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProduct.BorderRadius = 0;
            this.btnProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnProduct.ButtonText = "Products";
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProduct.Iconimage")));
            this.btnProduct.Iconimage_right = null;
            this.btnProduct.Iconimage_right_Selected = null;
            this.btnProduct.Iconimage_Selected = null;
            this.btnProduct.IconMarginLeft = 0;
            this.btnProduct.IconMarginRight = 0;
            this.btnProduct.IconRightVisible = true;
            this.btnProduct.IconRightZoom = 0D;
            this.btnProduct.IconVisible = true;
            this.btnProduct.IconZoom = 60D;
            this.btnProduct.IsTab = false;
            this.btnProduct.Location = new System.Drawing.Point(-3, 276);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProduct.selected = false;
            this.btnProduct.Size = new System.Drawing.Size(209, 57);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Products";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProduct.Textcolor = System.Drawing.Color.White;
            this.btnProduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomer.BorderRadius = 0;
            this.btnCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCustomer.ButtonText = "Customers";
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.DisabledColor = System.Drawing.Color.Gray;
            this.btnCustomer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCustomer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Iconimage")));
            this.btnCustomer.Iconimage_right = null;
            this.btnCustomer.Iconimage_right_Selected = null;
            this.btnCustomer.Iconimage_Selected = null;
            this.btnCustomer.IconMarginLeft = 0;
            this.btnCustomer.IconMarginRight = 0;
            this.btnCustomer.IconRightVisible = true;
            this.btnCustomer.IconRightZoom = 0D;
            this.btnCustomer.IconVisible = true;
            this.btnCustomer.IconZoom = 60D;
            this.btnCustomer.IsTab = false;
            this.btnCustomer.Location = new System.Drawing.Point(-3, 219);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCustomer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCustomer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCustomer.selected = false;
            this.btnCustomer.Size = new System.Drawing.Size(209, 58);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCustomer.Textcolor = System.Drawing.Color.White;
            this.btnCustomer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmp.BorderRadius = 0;
            this.btnEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnEmp.ButtonText = "Employees";
            this.btnEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmp.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmp.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEmp.Iconimage")));
            this.btnEmp.Iconimage_right = null;
            this.btnEmp.Iconimage_right_Selected = null;
            this.btnEmp.Iconimage_Selected = null;
            this.btnEmp.IconMarginLeft = 0;
            this.btnEmp.IconMarginRight = 0;
            this.btnEmp.IconRightVisible = true;
            this.btnEmp.IconRightZoom = 0D;
            this.btnEmp.IconVisible = true;
            this.btnEmp.IconZoom = 60D;
            this.btnEmp.IsTab = false;
            this.btnEmp.Location = new System.Drawing.Point(-3, 166);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEmp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEmp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmp.selected = false;
            this.btnEmp.Size = new System.Drawing.Size(209, 56);
            this.btnEmp.TabIndex = 1;
            this.btnEmp.Text = "Employees";
            this.btnEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmp.Textcolor = System.Drawing.Color.White;
            this.btnEmp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel3.Controls.Add(this.lbBellNumber);
            this.panel3.Controls.Add(this.picBell);
            this.panel3.Controls.Add(this.tbExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(206, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(964, 32);
            this.panel3.TabIndex = 3;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // lbBellNumber
            // 
            this.lbBellNumber.AutoSize = true;
            this.lbBellNumber.ForeColor = System.Drawing.Color.White;
            this.lbBellNumber.Location = new System.Drawing.Point(914, 4);
            this.lbBellNumber.Name = "lbBellNumber";
            this.lbBellNumber.Size = new System.Drawing.Size(13, 13);
            this.lbBellNumber.TabIndex = 11;
            this.lbBellNumber.Text = "0";
            // 
            // picBell
            // 
            this.picBell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBell.Image = ((System.Drawing.Image)(resources.GetObject("picBell.Image")));
            this.picBell.Location = new System.Drawing.Point(887, 4);
            this.picBell.Name = "picBell";
            this.picBell.Size = new System.Drawing.Size(28, 25);
            this.picBell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBell.TabIndex = 10;
            this.picBell.TabStop = false;
            this.picBell.Click += new System.EventHandler(this.picBell_Click);
            // 
            // tbExit
            // 
            this.tbExit.AutoSize = true;
            this.tbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbExit.Location = new System.Drawing.Point(934, 3);
            this.tbExit.Name = "tbExit";
            this.tbExit.Size = new System.Drawing.Size(26, 25);
            this.tbExit.TabIndex = 0;
            this.tbExit.Text = "X";
            this.tbExit.Click += new System.EventHandler(this.tbExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bell1);
            this.panel1.Controls.Add(this.dashboard);
            this.panel1.Controls.Add(this.transaction);
            this.panel1.Controls.Add(this.realEstate1);
            this.panel1.Controls.Add(this.projectType1);
            this.panel1.Controls.Add(this.projects1);
            this.panel1.Controls.Add(this.products1);
            this.panel1.Controls.Add(this.marketing1);
            this.panel1.Controls.Add(this.employee2);
            this.panel1.Controls.Add(this.customer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(206, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 558);
            this.panel1.TabIndex = 4;
            // 
            // bell1
            // 
            this.bell1.Location = new System.Drawing.Point(612, 6);
            this.bell1.Name = "bell1";
            this.bell1.Size = new System.Drawing.Size(303, 156);
            this.bell1.TabIndex = 10;
            // 
            // dashboard
            // 
            this.dashboard.Location = new System.Drawing.Point(0, -1);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(964, 558);
            this.dashboard.TabIndex = 9;
            // 
            // transaction
            // 
            this.transaction.BackColor = System.Drawing.Color.White;
            this.transaction.Location = new System.Drawing.Point(0, 0);
            this.transaction.Name = "transaction";
            this.transaction.Size = new System.Drawing.Size(964, 558);
            this.transaction.TabIndex = 8;
            // 
            // realEstate1
            // 
            this.realEstate1.Location = new System.Drawing.Point(0, -3);
            this.realEstate1.Name = "realEstate1";
            this.realEstate1.Size = new System.Drawing.Size(964, 558);
            this.realEstate1.TabIndex = 7;
            // 
            // projectType1
            // 
            this.projectType1.Location = new System.Drawing.Point(0, 0);
            this.projectType1.Name = "projectType1";
            this.projectType1.Size = new System.Drawing.Size(964, 558);
            this.projectType1.TabIndex = 6;
            // 
            // projects1
            // 
            this.projects1.Location = new System.Drawing.Point(0, 0);
            this.projects1.Name = "projects1";
            this.projects1.Size = new System.Drawing.Size(964, 558);
            this.projects1.TabIndex = 5;
            // 
            // products1
            // 
            this.products1.Location = new System.Drawing.Point(0, 0);
            this.products1.Name = "products1";
            this.products1.Size = new System.Drawing.Size(964, 558);
            this.products1.TabIndex = 4;
            // 
            // marketing1
            // 
            this.marketing1.Location = new System.Drawing.Point(0, 0);
            this.marketing1.Name = "marketing1";
            this.marketing1.Size = new System.Drawing.Size(964, 558);
            this.marketing1.TabIndex = 3;
            // 
            // employee2
            // 
            this.employee2.Location = new System.Drawing.Point(0, 0);
            this.employee2.Name = "employee2";
            this.employee2.Size = new System.Drawing.Size(964, 558);
            this.employee2.TabIndex = 2;
            // 
            // customer2
            // 
            this.customer2.Location = new System.Drawing.Point(0, -1);
            this.customer2.Name = "customer2";
            this.customer2.Size = new System.Drawing.Size(964, 558);
            this.customer2.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí bất động sản";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBell)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnCustomer;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmp;
        private user_control.Employee employee1;
        private user_control.Customer customer1;
        private Bunifu.Framework.UI.BunifuFlatButton btnProduct;
        private Bunifu.Framework.UI.BunifuFlatButton btnProject;
        private Bunifu.Framework.UI.BunifuFlatButton btnBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label tbExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnSale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private user_control.RealEstate realEstate1;
        private user_control.ProjectType projectType1;
        private user_control.Projects projects1;
        private user_control.Products products1;
        private user_control.Marketing marketing1;
        private user_control.Employee employee2;
        private user_control.Customer customer2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private user_control.Transaction transaction;
        private user_control.dashboard dashboard;
        private System.Windows.Forms.PictureBox picBell;
        private user_control.bell bell1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbBellNumber;
    }
}

