using QuanLiQuanTraSua.DAO;
using QuanLiQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanTraSua
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void ButtonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Thật Sự Muốn Thoát ?", " Thông Báo ", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = false;
            }
        }

        private void ButtonDangNhap_Click(object sender, EventArgs e)
        {
            string username = TextBoxDangNhap.Text;
            string password = TextBoxMatKhau.Text;
            if (Login(username, password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(username);
                FormMainMenu f = new FormMainMenu(loginAccount);
                this.Hide();
                f.ShowDialog();
                //this.Show();
            }
            else
            {
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Hợp Lệ ! Vui Lòng Kiểm Tra Lại <3");
            }


        }
        bool Login(string username , string password)
        {
            return AccountDAO.Instance.login(username, password);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
