namespace QuanLiQuanTraSua.Forms
{
    partial class FormMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonHienThi = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButtonXoa = new FontAwesome.Sharp.IconButton();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.iconButtonChinhSua = new FontAwesome.Sharp.IconButton();
            this.numericUpDownGia = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTheLoai = new System.Windows.Forms.ComboBox();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.iconButtonThem = new FontAwesome.Sharp.IconButton();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxId);
            this.panel1.Controls.Add(this.numericUpDownGia);
            this.panel1.Controls.Add(this.comboBoxTheLoai);
            this.panel1.Controls.Add(this.textBoxTen);
            this.panel1.Controls.Add(this.dataGridViewMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1544, 822);
            this.panel1.TabIndex = 3;
            // 
            // iconButtonHienThi
            // 
            this.iconButtonHienThi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHienThi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonHienThi.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.iconButtonHienThi.IconColor = System.Drawing.Color.Black;
            this.iconButtonHienThi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHienThi.IconSize = 40;
            this.iconButtonHienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHienThi.Location = new System.Drawing.Point(0, 3);
            this.iconButtonHienThi.Name = "iconButtonHienThi";
            this.iconButtonHienThi.Rotation = 0D;
            this.iconButtonHienThi.Size = new System.Drawing.Size(146, 54);
            this.iconButtonHienThi.TabIndex = 15;
            this.iconButtonHienThi.Text = "Hiển Thị";
            this.iconButtonHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonHienThi.UseVisualStyleBackColor = true;
            this.iconButtonHienThi.Click += new System.EventHandler(this.iconButtonHienThi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Loại Nước";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên Món";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // iconButtonXoa
            // 
            this.iconButtonXoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonXoa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonXoa.IconColor = System.Drawing.Color.Black;
            this.iconButtonXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonXoa.IconSize = 40;
            this.iconButtonXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoa.Location = new System.Drawing.Point(0, 166);
            this.iconButtonXoa.Name = "iconButtonXoa";
            this.iconButtonXoa.Rotation = 0D;
            this.iconButtonXoa.Size = new System.Drawing.Size(146, 51);
            this.iconButtonXoa.TabIndex = 10;
            this.iconButtonXoa.Text = "Xóa";
            this.iconButtonXoa.UseVisualStyleBackColor = true;
            this.iconButtonXoa.Click += new System.EventHandler(this.iconButtonXoa_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxId.Location = new System.Drawing.Point(391, 22);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 8;
            // 
            // iconButtonChinhSua
            // 
            this.iconButtonChinhSua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonChinhSua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonChinhSua.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonChinhSua.IconColor = System.Drawing.Color.Black;
            this.iconButtonChinhSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonChinhSua.IconSize = 40;
            this.iconButtonChinhSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonChinhSua.Location = new System.Drawing.Point(0, 110);
            this.iconButtonChinhSua.Name = "iconButtonChinhSua";
            this.iconButtonChinhSua.Rotation = 0D;
            this.iconButtonChinhSua.Size = new System.Drawing.Size(146, 56);
            this.iconButtonChinhSua.TabIndex = 7;
            this.iconButtonChinhSua.Text = "Chỉnh Sửa";
            this.iconButtonChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonChinhSua.UseVisualStyleBackColor = true;
            this.iconButtonChinhSua.Click += new System.EventHandler(this.iconButtonChinhSua_Click);
            // 
            // numericUpDownGia
            // 
            this.numericUpDownGia.Location = new System.Drawing.Point(391, 177);
            this.numericUpDownGia.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownGia.Name = "numericUpDownGia";
            this.numericUpDownGia.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownGia.TabIndex = 6;
            // 
            // comboBoxTheLoai
            // 
            this.comboBoxTheLoai.FormattingEnabled = true;
            this.comboBoxTheLoai.Location = new System.Drawing.Point(391, 124);
            this.comboBoxTheLoai.Name = "comboBoxTheLoai";
            this.comboBoxTheLoai.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTheLoai.TabIndex = 5;
            // 
            // textBoxTen
            // 
            this.textBoxTen.Location = new System.Drawing.Point(391, 71);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(100, 22);
            this.textBoxTen.TabIndex = 4;
            // 
            // iconButtonThem
            // 
            this.iconButtonThem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonThem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonThem.IconColor = System.Drawing.Color.Black;
            this.iconButtonThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThem.IconSize = 40;
            this.iconButtonThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThem.Location = new System.Drawing.Point(0, 57);
            this.iconButtonThem.Name = "iconButtonThem";
            this.iconButtonThem.Rotation = 0D;
            this.iconButtonThem.Size = new System.Drawing.Size(146, 53);
            this.iconButtonThem.TabIndex = 3;
            this.iconButtonThem.Text = "Thêm ";
            this.iconButtonThem.UseVisualStyleBackColor = true;
            this.iconButtonThem.Click += new System.EventHandler(this.iconButtonThem_Click);
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMenu.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewMenu.Location = new System.Drawing.Point(0, 177);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersVisible = false;
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.RowTemplate.Height = 24;
            this.dataGridViewMenu.Size = new System.Drawing.Size(1544, 645);
            this.dataGridViewMenu.TabIndex = 2;
            this.dataGridViewMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellClick);
            this.dataGridViewMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellContentClick);
            this.dataGridViewMenu.Click += new System.EventHandler(this.dataGridViewMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButtonHienThi);
            this.panel2.Controls.Add(this.iconButtonThem);
            this.panel2.Controls.Add(this.iconButtonChinhSua);
            this.panel2.Controls.Add(this.iconButtonXoa);
            this.panel2.Location = new System.Drawing.Point(83, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 217);
            this.panel2.TabIndex = 16;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 822);
            this.Controls.Add(this.panel1);
            this.Name = "FormMenu";
            this.Text = "Chỉnh Sửa Thông Tin Sản Phẩm ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxId;
        private FontAwesome.Sharp.IconButton iconButtonChinhSua;
        private System.Windows.Forms.NumericUpDown numericUpDownGia;
        private System.Windows.Forms.ComboBox comboBoxTheLoai;
        private System.Windows.Forms.TextBox textBoxTen;
        private FontAwesome.Sharp.IconButton iconButtonThem;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private FontAwesome.Sharp.IconButton iconButtonXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonHienThi;
        private System.Windows.Forms.Panel panel2;
    }
}