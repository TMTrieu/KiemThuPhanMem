using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_89_Trieu
{
    public class HinhChuNhat_89_Trieu
    {
        public Diem_89_Trieu TrenTrai_89_Trieu;
        public Diem_89_Trieu DuoiPhai_89_Trieu;
        public HinhChuNhat_89_Trieu(Diem_89_Trieu TrenTrai_89_Trieu, Diem_89_Trieu DuoiPhai_89_Trieu)
        {
            // Ném ngoại lệ khi nhập tọa độ 2 điểm không đúng điểm trên bên trái và điểm dưới bên phải
            if (TrenTrai_89_Trieu.x_89_Trieu >= DuoiPhai_89_Trieu.x_89_Trieu || TrenTrai_89_Trieu.y_89_Trieu <= DuoiPhai_89_Trieu.y_89_Trieu)
            {
                throw new ArgumentException("Điểm thứ nhất phải là trên trái, điểm thứ hai phải là dưới phải!");
            }
            this.TrenTrai_89_Trieu = TrenTrai_89_Trieu;
            this.DuoiPhai_89_Trieu = DuoiPhai_89_Trieu;
        }
        public double TinhDienTich_89_Trieu()
        {
            double ChieuDai_89_Trieu = Math.Abs(TrenTrai_89_Trieu.x_89_Trieu - DuoiPhai_89_Trieu.x_89_Trieu);
            double ChieuRong_89_Trieu = Math.Abs(TrenTrai_89_Trieu.y_89_Trieu - DuoiPhai_89_Trieu.y_89_Trieu);
            return ChieuDai_89_Trieu * ChieuRong_89_Trieu;

        }
        public bool KiemTraGiaoNhau_89_Trieu(HinhChuNhat_89_Trieu hcn_89_Trieu)
        {
            if (// Hình chữ nhật 2 nằm bên phải hình chữ nhật 1
                this.TrenTrai_89_Trieu.x_89_Trieu > hcn_89_Trieu.DuoiPhai_89_Trieu.x_89_Trieu ||
                // Hình chữ nhật 2 nằm bên trái hình chữ nhật 1
                this.DuoiPhai_89_Trieu.x_89_Trieu < hcn_89_Trieu.TrenTrai_89_Trieu.x_89_Trieu ||
                // Hình chữ nhật 2 nằm dưới hình chữ nhật 1
                this.DuoiPhai_89_Trieu.y_89_Trieu > hcn_89_Trieu.TrenTrai_89_Trieu.y_89_Trieu ||
                // Hình chữ nhật 2 nằm trên hình chữ nhật 1
                this.TrenTrai_89_Trieu.y_89_Trieu < hcn_89_Trieu.DuoiPhai_89_Trieu.y_89_Trieu)
            {
                // Trả về false khi hai hình chữ nhật không giao nhau
                return false;
            }
            // Trả về true khi hai hình chữ nhật giao nhau
            return true;
        }
    }
}
