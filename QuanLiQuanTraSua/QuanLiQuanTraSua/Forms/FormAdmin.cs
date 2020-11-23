using QuanLiQuanTraSua.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanTraSua.Forms
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            LoadAccount();
        }
        void LoadAccount()
        {
            dataGridViewMenu.DataSource = AccountDAO.Instance.GetListAccount();
            dataGridViewMenu.Columns[0].HeaderText = "Tên Đăng Nhập";
            dataGridViewMenu.Columns[1].HeaderText = "Tên Hiển Thị";
            dataGridViewMenu.Columns[2].HeaderText = "Mật Khẩu";
            dataGridViewMenu.Columns[3].HeaderText = "Quyền Quản Trị";
        }
        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }
        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }
        void DeleteAccount(string userName)
        {
            //if (loginAccount == null)
            //{
            //    return;
            //}
            //if (loginAccount.UserName.Equals(userName))
            //{
            //    MessageBox.Show("Vui lòng không xóa chính bạn");
            //    return;
            //}
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }
        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }

        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            string userName = textBoxId.Text;
            string displayName = textBoxTen.Text;
            int type = (int)numericUpDown1.Value;

            AddAccount(userName, displayName, type);
        }

        private void iconButtonHienThi_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void iconButtonChinhSua_Click(object sender, EventArgs e)
        {
            string userName = textBoxId.Text;
            string displayName = textBoxTen.Text;
            int type = (int)numericUpDown1.Value;

            EditAccount(userName, displayName, type);
            LoadAccount();
        }

        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            string userName = textBoxId.Text;

            DeleteAccount(userName);
        }

        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int numrow;
            numrow = e.RowIndex;
            if (numrow == -1)
                return;
            textBoxId.Text = dataGridViewMenu.Rows[numrow].Cells[0].Value.ToString();
            textBoxTen.Text = dataGridViewMenu.Rows[numrow].Cells[1].Value.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string userName = textBoxId.Text;

            ResetPass(userName);
            LoadAccount();
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
