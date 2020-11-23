using QuanLiQuanTraSua.DAO;
using QuanLiQuanTraSua.DTO;
using QuanLiTraSua.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanTraSua.Forms
{
    public partial class FormTongQuan : Form
    {
        public FormTongQuan()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }
       
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QuanLiTraSua.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float TongTien = 0;
            foreach (QuanLiTraSua.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                TongTien += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txbTongTien.Text = TongTien.ToString("c" , culture);
            textBoxThucDon.Text = TongTien.ToString("c" , culture);

        }
        private void btn_Click1(object sender, EventArgs e)
        {
            int foodID = ((sender as Button).Tag as Food).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(foodID);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        void LoadTable()
        {
            fPanel.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Trangthai;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Trangthai)
                {
                    case "Trống":
                        btn.BackColor = Color.DeepSkyBlue;
                        btn.ForeColor = Color.Gainsboro;
                        break;

                    default:
                        btn.BackColor = Color.DarkViolet;
                        btn.ForeColor = Color.Gainsboro;
                        break;
                }
                fPanel.Controls.Add(btn);
            }
        }
        public void A_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }
        public void A_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
            LoadTable();
        }

         public void A_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }


        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            List<Food> foodList = FoodDAO.Instance.GetListTraSua();
            foreach (Food item in foodList)
            {
                Button btn = new Button() { Width = FoodDAO.FoodWidth, Height = FoodDAO.FoodHeight };
                btn.Text = item.Name + Environment.NewLine;
                btn.Click += btn_Click1;
                //btn.Tag = item;
                //switch (item.Trangthai)
                //{
                //    case "Trống":
                //        btn.BackColor = Color.DeepSkyBlue;
                //        btn.ForeColor = Color.Gainsboro;
                //        break;

                //    default:
                //        btn.BackColor = Color.DarkViolet;
                //        btn.ForeColor = Color.Gainsboro;
                //        break;
                //}
                flowLayoutPanel.Controls.Add(btn);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Vui Lòng Chọn Bàn Cần Thêm");
                return;
            }


            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }

            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }


            ShowBill(table.ID);
            LoadTable();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if( table == null)
            {
                MessageBox.Show("Vui Lòng Chọn Bàn Cần Thanh Toán ");
                return;
            }

            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);
            int discount = (int)numericUpDownGiamGia.Value;
            double totalPrice = Convert.ToDouble(txbTongTien.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền - Giảm giá\n= {3}", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    ShowBill(table.ID);

                    LoadTable();
                }
            }
        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButtonThemBan_Click(object sender, EventArgs e)
        {

            
            
        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButtonCaPhe_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            List<Food> foodList = FoodDAO.Instance.GetListCaPhe();
            foreach (Food item in foodList)
            {
                Button btn = new Button() { Width = FoodDAO.FoodWidth, Height = FoodDAO.FoodHeight };
                btn.Text = item.Name + Environment.NewLine;
                //btn.Click += btn_Click;
                //btn.Tag = item;
                //switch (item.Trangthai)
                //{
                //    case "Trống":
                //        btn.BackColor = Color.DeepSkyBlue;
                //        btn.ForeColor = Color.Gainsboro;
                //        break;

                //    default:
                //        btn.BackColor = Color.DarkViolet;
                //        btn.ForeColor = Color.Gainsboro;
                //        break;
                //}
                flowLayoutPanel.Controls.Add(btn);
            }
        }

        private void iconButtonMonThem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            List<Food> foodList = FoodDAO.Instance.GetListMonThem();
            foreach (Food item in foodList)
            {
                Button btn = new Button() { Width = FoodDAO.FoodWidth, Height = FoodDAO.FoodHeight };
                btn.Text = item.Name + Environment.NewLine;
                //btn.Click += btn_Click;
                //btn.Tag = item;
                //switch (item.Trangthai)
                //{
                //    case "Trống":
                //        btn.BackColor = Color.DeepSkyBlue;
                //        btn.ForeColor = Color.Gainsboro;
                //        break;

                //    default:
                //        btn.BackColor = Color.DarkViolet;
                //        btn.ForeColor = Color.Gainsboro;
                //        break;
                //}
                flowLayoutPanel.Controls.Add(btn);
            }
        }

        private void iconButtonNuocEp_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            List<Food> foodList = FoodDAO.Instance.GetListNuocEp();
            foreach (Food item in foodList)
            {
                Button btn = new Button() { Width = FoodDAO.FoodWidth, Height = FoodDAO.FoodHeight };
                btn.Text = item.Name + Environment.NewLine;
                //btn.Click += btn_Click;
                //btn.Tag = item;
                //switch (item.Trangthai)
                //{
                //    case "Trống":
                //        btn.BackColor = Color.DeepSkyBlue;
                //        btn.ForeColor = Color.Gainsboro;
                //        break;

                //    default:
                //        btn.BackColor = Color.DarkViolet;
                //        btn.ForeColor = Color.Gainsboro;
                //        break;
                //}
                flowLayoutPanel.Controls.Add(btn);
            }
        }
    }
}
