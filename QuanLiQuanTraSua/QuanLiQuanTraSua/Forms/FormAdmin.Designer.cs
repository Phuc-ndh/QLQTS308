namespace QuanLiQuanTraSua.Forms
{
    partial class FormAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButtonXoa = new FontAwesome.Sharp.IconButton();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.iconButtonChinhSua = new FontAwesome.Sharp.IconButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.iconButtonThem = new FontAwesome.Sharp.IconButton();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.iconButtonHienThi = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.panel1.Size = new System.Drawing.Size(1544, 822);
            this.panel1.TabIndex = 6;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(90)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 50;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(265, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(130, 62);
            this.iconButton1.TabIndex = 17;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(335, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(331, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(482, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quyền Quản Trị";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(160, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên Hiển Thị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "UserName";
            // 
            // iconButtonXoa
            // 
            this.iconButtonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(90)))));
            this.iconButtonXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonXoa.FlatAppearance.BorderSize = 0;
            this.iconButtonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonXoa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonXoa.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonXoa.IconSize = 50;
            this.iconButtonXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoa.Location = new System.Drawing.Point(525, 0);
            this.iconButtonXoa.Name = "iconButtonXoa";
            this.iconButtonXoa.Rotation = 0D;
            this.iconButtonXoa.Size = new System.Drawing.Size(130, 62);
            this.iconButtonXoa.TabIndex = 10;
            this.iconButtonXoa.UseVisualStyleBackColor = false;
            this.iconButtonXoa.Click += new System.EventHandler(this.iconButtonXoa_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxId.Location = new System.Drawing.Point(3, 50);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(155, 22);
            this.textBoxId.TabIndex = 8;
            // 
            // iconButtonChinhSua
            // 
            this.iconButtonChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(90)))));
            this.iconButtonChinhSua.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonChinhSua.FlatAppearance.BorderSize = 0;
            this.iconButtonChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonChinhSua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonChinhSua.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonChinhSua.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonChinhSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonChinhSua.IconSize = 50;
            this.iconButtonChinhSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonChinhSua.Location = new System.Drawing.Point(395, 0);
            this.iconButtonChinhSua.Name = "iconButtonChinhSua";
            this.iconButtonChinhSua.Rotation = 0D;
            this.iconButtonChinhSua.Size = new System.Drawing.Size(130, 62);
            this.iconButtonChinhSua.TabIndex = 7;
            this.iconButtonChinhSua.UseVisualStyleBackColor = false;
            this.iconButtonChinhSua.Click += new System.EventHandler(this.iconButtonChinhSua_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(486, 50);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(169, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTen
            // 
            this.textBoxTen.Location = new System.Drawing.Point(164, 50);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(165, 22);
            this.textBoxTen.TabIndex = 4;
            // 
            // iconButtonThem
            // 
            this.iconButtonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(90)))));
            this.iconButtonThem.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonThem.FlatAppearance.BorderSize = 0;
            this.iconButtonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonThem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonThem.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThem.IconSize = 50;
            this.iconButtonThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThem.Location = new System.Drawing.Point(135, 0);
            this.iconButtonThem.Name = "iconButtonThem";
            this.iconButtonThem.Rotation = 0D;
            this.iconButtonThem.Size = new System.Drawing.Size(130, 62);
            this.iconButtonThem.TabIndex = 3;
            this.iconButtonThem.UseVisualStyleBackColor = false;
            this.iconButtonThem.Click += new System.EventHandler(this.iconButtonThem_Click);
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMenu.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewMenu.Location = new System.Drawing.Point(0, 141);
            this.dataGridViewMenu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersVisible = false;
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.RowTemplate.Height = 24;
            this.dataGridViewMenu.Size = new System.Drawing.Size(655, 680);
            this.dataGridViewMenu.TabIndex = 2;
            this.dataGridViewMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellClick);
            this.dataGridViewMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellContentClick);
            // 
            // iconButtonHienThi
            // 
            this.iconButtonHienThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(90)))));
            this.iconButtonHienThi.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonHienThi.FlatAppearance.BorderSize = 0;
            this.iconButtonHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHienThi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonHienThi.ForeColor = System.Drawing.Color.White;
            this.iconButtonHienThi.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButtonHienThi.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonHienThi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHienThi.IconSize = 50;
            this.iconButtonHienThi.Location = new System.Drawing.Point(5, 0);
            this.iconButtonHienThi.Name = "iconButtonHienThi";
            this.iconButtonHienThi.Rotation = 0D;
            this.iconButtonHienThi.Size = new System.Drawing.Size(130, 62);
            this.iconButtonHienThi.TabIndex = 1;
            this.iconButtonHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHienThi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHienThi.UseVisualStyleBackColor = false;
            this.iconButtonHienThi.Click += new System.EventHandler(this.iconButtonHienThi_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.textBoxId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBoxTen);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 75);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(90)))));
            this.panel3.Controls.Add(this.iconButtonHienThi);
            this.panel3.Controls.Add(this.iconButtonThem);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.iconButtonChinhSua);
            this.panel3.Controls.Add(this.iconButtonXoa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(655, 62);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(90)))));
            this.panel4.Controls.Add(this.dataGridViewMenu);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(655, 821);
            this.panel4.TabIndex = 20;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 822);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdmin";
            this.Text = "Quản Trị Hệ Thống";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonXoa;
        private System.Windows.Forms.TextBox textBoxId;
        private FontAwesome.Sharp.IconButton iconButtonChinhSua;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBoxTen;
        private FontAwesome.Sharp.IconButton iconButtonThem;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private FontAwesome.Sharp.IconButton iconButtonHienThi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}