using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangle_89_Trieu
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btTinhDienTich_Click(object sender, EventArgs e)
        {
            HinhChuNhat_89_Trieu hcn1 = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(int.Parse(txtHcn1x1.Text), int.Parse(txtHcn1y1.Text)),
                new Diem_89_Trieu(int.Parse(txtHcn1x2.Text), int.Parse(txtHcn1y2.Text)));
            HinhChuNhat_89_Trieu hcn2 = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(int.Parse(txtHcn2x1.Text), int.Parse(txtHcn2y1.Text)),
                new Diem_89_Trieu(int.Parse(txtHcn2x2.Text), int.Parse(txtHcn2y2.Text)));
            lbDienTichHCN1.Text = hcn1.TinhDienTich_89_Trieu().ToString();
            lbDienTichHCN2.Text = hcn2.TinhDienTich_89_Trieu().ToString();
        }

        private void btKiemTraTrungNhau_Click(object sender, EventArgs e)
        {
            HinhChuNhat_89_Trieu hcn1 = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(int.Parse(txtHcn1x1.Text), int.Parse(txtHcn1y1.Text)),
                new Diem_89_Trieu(int.Parse(txtHcn1x2.Text), int.Parse(txtHcn1y2.Text)));
            HinhChuNhat_89_Trieu hcn2 = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(int.Parse(txtHcn2x1.Text), int.Parse(txtHcn2y1.Text)),
                new Diem_89_Trieu(int.Parse(txtHcn2x2.Text), int.Parse(txtHcn2y2.Text)));
            lbKetQuaTrungNhau.Text = hcn1.KiemTraGiaoNhau_89_Trieu(hcn1).ToString();
        }
    }
}
