using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPBT03
{
    public partial class DonDatHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                KhoiTaoDuLieu();
            }
        }

        private void KhoiTaoDuLieu()
        {
            ddlLoaiBanh.Items.Add(new ListItem("Bánh Croissant", "01"));
            ddlLoaiBanh.Items.Add(new ListItem("Bánh bò nướng", "02"));
            ddlLoaiBanh.Items.Add(new ListItem("Patess chauds", "03"));
            ddlLoaiBanh.Items.Add(new ListItem("Hamburger", "04"));
          

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnInDon_Click(object sender, EventArgs e)
        //{
        //    string kq = "<div class=' text-center fw-bold bg-info alert alert-danger p-0 m-0  h1'>KẾT QUẢ ĐĂNG KÝ </div> ";
        //    kq += "<div class='container border border-danger text-danger'>";
        //    kq += string.Format("<b>Khách hàng :</b> {0}<br> ", txtKhachHang.Text);
        //    kq += string.Format(" <b>Địa chỉ:</b> {0} <br>", txtDiaChi.Text);
        //    kq += string.Format(" <b>Mã số thuế:</b> {0} <br><br>", txtMSThue.Text);
        //    kq += string.Format("<b> <h3>Đặt các loại bánh sau</h3> </b>");
        //    kq += string.Format("<table cellpadding='5' cellspacing='2' class='border border-warning table table-bordered text-danger w-100' ><tr><td><strong> {0}</strong ></td><td  class='text-end'><strong> {1}</strong ></td></tr> </table>", lstDanhSach.SelectedItem.Text, txtSoLuong.Text);
        //    kq += "</div>";
        //    lbInDon.Text = kq;
        //}
        {
            
            string kq = "<div class=' mt-3 border border-danger'>";
            kq += "<div class='text-center fw-bold bg-info  p-0 m-0 h1'>HOÁ ĐƠN ĐẶT HÀNG</div>";
            kq += "<div class='container border border-danger text-danger'>";
            kq += string.Format("<b>Khách hàng:</b> {0}<br>", txtKhachHang.Text); 
            kq += string.Format("<b>Địa chỉ:</b> {0}<br>", txtDiaChi.Text);
            kq += string.Format("<b>Mã số thuế:</b> {0}<br><br>", txtMSThue.Text);
            kq += "<b><h3>Đặt các loại bánh sau</h3></b>";
            kq += "<table cellpadding='5' cellspacing='2' class='border border-warning table table-bordered text-danger w-100'>";
            foreach (ListItem item in lstDanhSach.Items)
                {
                    string data = item.Text;
                    string[] arr = data.Split(new char[] { '(', ')' });    
                    kq += $"<tr><td><strong>{arr[0]}</strong></td><td class='text-end'><strong>{arr[1]} cái</strong></td></tr>";
}
kq += "</table></div> </div>"; lbInDon.Text = kq; }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            List<ListItem> itemsToRemove = new List<ListItem>();

            foreach (ListItem item in lstDanhSach.Items)
            {
                if (item.Selected)
                {
                    itemsToRemove.Add(item);
                }
            }

            foreach (ListItem item in itemsToRemove)
            {
                lstDanhSach.Items.Remove(item);
            }


        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            bool find = false;
            string LoaiBanh = ddlLoaiBanh.SelectedItem.Text;
            int SoLuong = int.Parse(txtSoLuong.Text);
            foreach (ListItem item in lstDanhSach.Items)
            {
                if (item.Text.StartsWith(LoaiBanh))
                {
                    string[] arr = item.Text.Split(new char[] { '(', ')' });
                    SoLuong += int.Parse(arr[1]);
                    item.Text = $"{LoaiBanh} ({SoLuong})";
                }
            }
            if (int.TryParse(txtSoLuong.Text, out SoLuong) && SoLuong > 0)
            {
                lstDanhSach.Items.Add(string.Format("{0} ({1})", LoaiBanh, SoLuong));
            }
            else
            {
                lblErrorMessage.Text = "Sai cấu trúc: Vui lòng nhập số lượng hợp lệ.";

            }
        }
    }
}

 