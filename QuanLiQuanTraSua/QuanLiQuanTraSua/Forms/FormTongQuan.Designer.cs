namespace QuanLiQuanTraSua.Forms
{
    partial class FormTongQuan
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelHoaDon = new System.Windows.Forms.Panel();
            this.numericUpDownGiamGia = new System.Windows.Forms.NumericUpDown();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxThucDon = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddFood = new FontAwesome.Sharp.IconButton();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButtonMonThem = new FontAwesome.Sharp.IconButton();
            this.iconButtonNuocEp = new FontAwesome.Sharp.IconButton();
            this.iconButtonCaPhe = new FontAwesome.Sharp.IconButton();
            this.iconButtonTraSua = new FontAwesome.Sharp.IconButton();
            this.fPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDesktop.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGiamGia)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(94)))));
            this.panelDesktop.Controls.Add(this.panel4);
            this.panelDesktop.Controls.Add(this.panel1);
            this.panelDesktop.Controls.Add(this.panel2);
            this.panelDesktop.Controls.Add(this.fPanel);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1682, 902);
            this.panelDesktop.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lsvBill);
            this.panel4.Controls.Add(this.panelHoaDon);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(875, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(807, 902);
            this.panel4.TabIndex = 13;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(0, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(807, 633);
            this.lsvBill.TabIndex = 1;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Trà Sữa";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ghi Chú";
            this.columnHeader5.Width = 500;
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(90)))));
            this.panelHoaDon.Controls.Add(this.numericUpDownGiamGia);
            this.panelHoaDon.Controls.Add(this.iconButton2);
            this.panelHoaDon.Controls.Add(this.textBox4);
            this.panelHoaDon.Controls.Add(this.txbTongTien);
            this.panelHoaDon.Controls.Add(this.textBox2);
            this.panelHoaDon.Controls.Add(this.textBoxThucDon);
            this.panelHoaDon.Controls.Add(this.btnCheckOut);
            this.panelHoaDon.Controls.Add(this.label5);
            this.panelHoaDon.Controls.Add(this.label4);
            this.panelHoaDon.Controls.Add(this.label3);
            this.panelHoaDon.Controls.Add(this.label2);
            this.panelHoaDon.Controls.Add(this.label1);
            this.panelHoaDon.Location = new System.Drawing.Point(3, 639);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(521, 260);
            this.panelHoaDon.TabIndex = 8;
            // 
            // numericUpDownGiamGia
            // 
            this.numericUpDownGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownGiamGia.Location = new System.Drawing.Point(391, 16);
            this.numericUpDownGiamGia.Name = "numericUpDownGiamGia";
            this.numericUpDownGiamGia.Size = new System.Drawing.Size(113, 24);
            this.numericUpDownGiamGia.TabIndex = 12;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.DarkOrchid;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.AliceBlue;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 48;
            this.iconButton2.Location = new System.Drawing.Point(295, 186);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(110, 62);
            this.iconButton2.TabIndex = 11;
            this.iconButton2.Text = "In Hóa Đơn";
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(391, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(113, 24);
            this.textBox4.TabIndex = 9;
            // 
            // txbTongTien
            // 
            this.txbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongTien.Location = new System.Drawing.Point(225, 125);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(138, 24);
            this.txbTongTien.TabIndex = 8;
            this.txbTongTien.Text = "0";
            this.txbTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(129, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 24);
            this.textBox2.TabIndex = 7;
            // 
            // textBoxThucDon
            // 
            this.textBoxThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxThucDon.Location = new System.Drawing.Point(129, 18);
            this.textBoxThucDon.Name = "textBoxThucDon";
            this.textBoxThucDon.Size = new System.Drawing.Size(114, 24);
            this.textBoxThucDon.TabIndex = 6;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckOut.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCheckOut.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCheckOut.IconColor = System.Drawing.Color.AliceBlue;
            this.btnCheckOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckOut.IconSize = 48;
            this.btnCheckOut.Location = new System.Drawing.Point(129, 186);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Rotation = 0D;
            this.btnCheckOut.Size = new System.Drawing.Size(110, 62);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "Thanh Toán";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(106, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng Tiền ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(304, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khác";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(275, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giảm Giá %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(33, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phụ Thu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thực Đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.btnAddFood);
            this.panel1.Controls.Add(this.nmFoodCount);
            this.panel1.Controls.Add(this.cbFood);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Location = new System.Drawing.Point(568, 639);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 260);
            this.panel1.TabIndex = 11;
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFood.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddFood.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddFood.IconColor = System.Drawing.Color.AliceBlue;
            this.btnAddFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddFood.IconSize = 48;
            this.btnAddFood.Location = new System.Drawing.Point(73, 186);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Rotation = 0D;
            this.btnAddFood.Size = new System.Drawing.Size(110, 62);
            this.btnAddFood.TabIndex = 6;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(131, 124);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(120, 22);
            this.nmFoodCount.TabIndex = 2;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(3, 68);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(248, 24);
            this.cbFood.TabIndex = 1;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbFood_SelectedIndexChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 18);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(248, 24);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel2.Controls.Add(this.flowLayoutPanel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(534, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 633);
            this.panel2.TabIndex = 12;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Turquoise;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 66);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(335, 316);
            this.flowLayoutPanel.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Controls.Add(this.iconButtonMonThem);
            this.panel3.Controls.Add(this.iconButtonNuocEp);
            this.panel3.Controls.Add(this.iconButtonCaPhe);
            this.panel3.Controls.Add(this.iconButtonTraSua);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 66);
            this.panel3.TabIndex = 0;
            // 
            // iconButtonMonThem
            // 
            this.iconButtonMonThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonMonThem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMonThem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonMonThem.IconColor = System.Drawing.Color.Black;
            this.iconButtonMonThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMonThem.IconSize = 48;
            this.iconButtonMonThem.Location = new System.Drawing.Point(255, 0);
            this.iconButtonMonThem.Name = "iconButtonMonThem";
            this.iconButtonMonThem.Rotation = 0D;
            this.iconButtonMonThem.Size = new System.Drawing.Size(85, 66);
            this.iconButtonMonThem.TabIndex = 3;
            this.iconButtonMonThem.Text = "Thêm";
            this.iconButtonMonThem.UseVisualStyleBackColor = true;
            this.iconButtonMonThem.Click += new System.EventHandler(this.iconButtonMonThem_Click);
            // 
            // iconButtonNuocEp
            // 
            this.iconButtonNuocEp.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonNuocEp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonNuocEp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonNuocEp.IconColor = System.Drawing.Color.Black;
            this.iconButtonNuocEp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonNuocEp.IconSize = 48;
            this.iconButtonNuocEp.Location = new System.Drawing.Point(170, 0);
            this.iconButtonNuocEp.Name = "iconButtonNuocEp";
            this.iconButtonNuocEp.Rotation = 0D;
            this.iconButtonNuocEp.Size = new System.Drawing.Size(85, 66);
            this.iconButtonNuocEp.TabIndex = 2;
            this.iconButtonNuocEp.Text = "Trái Cây";
            this.iconButtonNuocEp.UseVisualStyleBackColor = true;
            this.iconButtonNuocEp.Click += new System.EventHandler(this.iconButtonNuocEp_Click);
            // 
            // iconButtonCaPhe
            // 
            this.iconButtonCaPhe.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonCaPhe.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonCaPhe.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonCaPhe.IconColor = System.Drawing.Color.Black;
            this.iconButtonCaPhe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCaPhe.IconSize = 48;
            this.iconButtonCaPhe.Location = new System.Drawing.Point(85, 0);
            this.iconButtonCaPhe.Name = "iconButtonCaPhe";
            this.iconButtonCaPhe.Rotation = 0D;
            this.iconButtonCaPhe.Size = new System.Drawing.Size(85, 66);
            this.iconButtonCaPhe.TabIndex = 1;
            this.iconButtonCaPhe.Text = "Cà Phê";
            this.iconButtonCaPhe.UseVisualStyleBackColor = true;
            this.iconButtonCaPhe.Click += new System.EventHandler(this.iconButtonCaPhe_Click);
            // 
            // iconButtonTraSua
            // 
            this.iconButtonTraSua.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonTraSua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonTraSua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonTraSua.IconColor = System.Drawing.Color.Black;
            this.iconButtonTraSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTraSua.IconSize = 48;
            this.iconButtonTraSua.Location = new System.Drawing.Point(0, 0);
            this.iconButtonTraSua.Name = "iconButtonTraSua";
            this.iconButtonTraSua.Rotation = 0D;
            this.iconButtonTraSua.Size = new System.Drawing.Size(85, 66);
            this.iconButtonTraSua.TabIndex = 0;
            this.iconButtonTraSua.Text = "Trà Sữa";
            this.iconButtonTraSua.UseVisualStyleBackColor = true;
            this.iconButtonTraSua.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // fPanel
            // 
            this.fPanel.AutoScroll = true;
            this.fPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.fPanel.Location = new System.Drawing.Point(0, 0);
            this.fPanel.Name = "fPanel";
            this.fPanel.Size = new System.Drawing.Size(534, 902);
            this.fPanel.TabIndex = 0;
            // 
            // FormTongQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 902);
            this.Controls.Add(this.panelDesktop);
            this.Name = "FormTongQuan";
            this.Text = "Khu Vực Quản Lí Khách Hàng";
            this.panelDesktop.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelHoaDon.ResumeLayout(false);
            this.panelHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGiamGia)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.FlowLayoutPanel fPanel;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panelHoaDon;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxThucDon;
        private FontAwesome.Sharp.IconButton btnCheckOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAddFood;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.NumericUpDown numericUpDownGiamGia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButtonMonThem;
        private FontAwesome.Sharp.IconButton iconButtonNuocEp;
        private FontAwesome.Sharp.IconButton iconButtonCaPhe;
        private FontAwesome.Sharp.IconButton iconButtonTraSua;
        private System.Windows.Forms.Panel panel4;
    }
}