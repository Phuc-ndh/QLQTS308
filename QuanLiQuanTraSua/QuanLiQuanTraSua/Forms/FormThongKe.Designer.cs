namespace QuanLiQuanTraSua.Forms
{
    partial class FormThongKe
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
            this.textBoxDoanhThu = new System.Windows.Forms.TextBox();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewThongKe = new System.Windows.Forms.DataGridView();
            this.textBoxDoanhSo = new System.Windows.Forms.TextBox();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.textBoxDoanhSo);
            this.panelDesktop.Controls.Add(this.textBoxDoanhThu);
            this.panelDesktop.Controls.Add(this.textBoxTongTien);
            this.panelDesktop.Controls.Add(this.label6);
            this.panelDesktop.Controls.Add(this.label5);
            this.panelDesktop.Controls.Add(this.textBoxSoLuong);
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.btnThongKe);
            this.panelDesktop.Controls.Add(this.dateTimePickerTo);
            this.panelDesktop.Controls.Add(this.dateTimePickerFrom);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.dataGridViewThongKe);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1544, 822);
            this.panelDesktop.TabIndex = 6;
            // 
            // textBoxDoanhThu
            // 
            this.textBoxDoanhThu.BackColor = System.Drawing.Color.DarkOrchid;
            this.textBoxDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDoanhThu.ForeColor = System.Drawing.Color.LawnGreen;
            this.textBoxDoanhThu.Location = new System.Drawing.Point(1328, 53);
            this.textBoxDoanhThu.Name = "textBoxDoanhThu";
            this.textBoxDoanhThu.Size = new System.Drawing.Size(161, 30);
            this.textBoxDoanhThu.TabIndex = 13;
            this.textBoxDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBoxTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTongTien.ForeColor = System.Drawing.Color.Magenta;
            this.textBoxTongTien.Location = new System.Drawing.Point(1328, 19);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.Size = new System.Drawing.Size(161, 30);
            this.textBoxTongTien.TabIndex = 12;
            this.textBoxTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTongTien.TextChanged += new System.EventHandler(this.textBoxTongTien_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(1085, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tổng Tiền Khuyến Mãi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(1148, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng Tiền ";
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.BackColor = System.Drawing.Color.DarkMagenta;
            this.textBoxSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoLuong.ForeColor = System.Drawing.Color.White;
            this.textBoxSoLuong.Location = new System.Drawing.Point(877, 17);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(161, 30);
            this.textBoxSoLuong.TabIndex = 8;
            this.textBoxSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSoLuong.TextChanged += new System.EventHandler(this.textBoxSoLuong_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(674, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng Số Giao Dịch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(674, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Doanh Số";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnThongKe.IconColor = System.Drawing.Color.White;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.IconSize = 48;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(463, 20);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Rotation = 0D;
            this.btnThongKe.Size = new System.Drawing.Size(135, 60);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống Kê ";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(96, 55);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(255, 30);
            this.dateTimePickerTo.TabIndex = 4;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(96, 17);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(255, 30);
            this.dateTimePickerFrom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ";
            // 
            // dataGridViewThongKe
            // 
            this.dataGridViewThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThongKe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewThongKe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewThongKe.Location = new System.Drawing.Point(0, 117);
            this.dataGridViewThongKe.Name = "dataGridViewThongKe";
            this.dataGridViewThongKe.RowHeadersVisible = false;
            this.dataGridViewThongKe.RowHeadersWidth = 51;
            this.dataGridViewThongKe.RowTemplate.Height = 24;
            this.dataGridViewThongKe.Size = new System.Drawing.Size(1544, 705);
            this.dataGridViewThongKe.TabIndex = 0;
            this.dataGridViewThongKe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThongKe_CellContentClick);
            // 
            // textBoxDoanhSo
            // 
            this.textBoxDoanhSo.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxDoanhSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDoanhSo.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxDoanhSo.Location = new System.Drawing.Point(877, 57);
            this.textBoxDoanhSo.Name = "textBoxDoanhSo";
            this.textBoxDoanhSo.ReadOnly = true;
            this.textBoxDoanhSo.Size = new System.Drawing.Size(161, 30);
            this.textBoxDoanhSo.TabIndex = 14;
            this.textBoxDoanhSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 822);
            this.Controls.Add(this.panelDesktop);
            this.Name = "FormThongKe";
            this.Text = "Thống Kê Giao Dịch ";
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewThongKe;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDoanhThu;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDoanhSo;
    }
}