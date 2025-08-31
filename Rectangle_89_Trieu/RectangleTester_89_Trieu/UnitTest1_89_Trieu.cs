using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rectangle_89_Trieu;

namespace RectangleTester_89_Trieu
{
    [TestClass]
    public class UnitTest1_89_Trieu
    {
        // kiểm thử nhập sai tọa độ điểm không hợp lệ
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TC1_TestNhapSaiDiem_Pass_89_Trieu()
        {
            HinhChuNhat_89_Trieu hcn_89_Trieu = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(-3, -2), new Diem_89_Trieu(-1, 6));
            // điểm trên trái có y=-2, điểm dưới phải có y = 6, -2<6 nhập sai điểm nên sẽ ném ngoại lệ
        }

        // kiểm thử nhập sai tọa độ điểm không hợp lệ, 2 điểm là một đường thẳng
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TC2_TestNhapDiemLaDuongThang_Pass_89_Trieu()
        {
            HinhChuNhat_89_Trieu hcn_89_Trieu = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(-3, -2), new Diem_89_Trieu(-3, 6));
            // điểm trên trái có x=-3, điểm dưới phải có x = -3, là 1 đường thẳng, nhập sai điểm nên sẽ ném ngoại lệ
        }

        // Kiểm thử tính diện tích của hình chữ nhật
        [TestMethod]
        public void TC3_TestTinhDienTich_Pass_89_Trieu()
        {
            HinhChuNhat_89_Trieu hcn_89_Trieu = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(5, 3), new Diem_89_Trieu(8, 2));
            // Chiều dài = |8 - 5| = 3, Chiều rộng = |2 - 3| = 1
            // Diện tích của hình chữ nhật = chiều dài * chiều rộng = 3 * 1 = 3
            double expected_89_Trieu = 3;
            double actual_89_Trieu = hcn_89_Trieu.TinhDienTich_89_Trieu();
            Assert.AreEqual(expected_89_Trieu, actual_89_Trieu, "Sai diện tích HCN");
        }

        [TestMethod]
        public void TC4_TestTinhDienTich_Pass_89_Trieu()
        {
            HinhChuNhat_89_Trieu hcn_89_Trieu = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(-2, 9), new Diem_89_Trieu(3, 6));
            // Chiều dài = |-2 - 3| = 5, Chiều rộng = |9 - 6| = 3
            // Diện tích của hình chữ nhật = chiều dài * chiều rộng = 5 * 3 = 15
            double expected_89_Trieu = 15;
            double actual_89_Trieu = hcn_89_Trieu.TinhDienTich_89_Trieu();
            Assert.AreEqual(expected_89_Trieu, actual_89_Trieu, "Sai diện tích HCN");
        }

        //Kiểm thử tính diện tích thất bại
        [TestMethod]
        public void TC5_TestTinhDienTich_Fail_89_Trieu()
        {
            HinhChuNhat_89_Trieu hcn_89_Trieu = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(1, 4), new Diem_89_Trieu(5, 2));
            // Chiều dài = |1 - 5| = 4, Chiều rộng = |4 - 2| = 2
            // Diện tích của hình chữ nhật = chiều dài * chiều rộng = 4 * 2 = 8
            double expected_89_Trieu = 15;
            double actual_89_Trieu = hcn_89_Trieu.TinhDienTich_89_Trieu();
            Assert.AreEqual(expected_89_Trieu, actual_89_Trieu, "Sai diện tích HCN");
        }

        [TestMethod]
        public void TC6_TestTinhDienTich_Fail_89_Trieu()
        {
            HinhChuNhat_89_Trieu hcn_89_Trieu = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(-3, 6), new Diem_89_Trieu(-1, -2));
            // Chiều dài = |(-3) - (-1)| = 2, Chiều rộng = |(-2) - 6| = 8
            // Diện tích của hình chữ nhật = chiều dài * chiều rộng = 2 * 8 = 16
            double expected_89_Trieu = 8;
            double actual_89_Trieu = hcn_89_Trieu.TinhDienTich_89_Trieu();
            Assert.AreEqual(expected_89_Trieu, actual_89_Trieu, "Sai diện tích HCN");
        }

        // test case kiểm tra HCN có diện tích bằng 0
        [TestMethod]
        public void TC7_TestDienTichBangKhong_Fail_89_Trieu()
        {
            // ném ngoại lệ vì nhập sai tọa độ 2 điểm không hợp lệ
            var hcn_89_Trieu = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(1, 1), new Diem_89_Trieu(1, 1));
            double expected_89_Trieu = 8;
            double actual_89_Trieu = hcn_89_Trieu.TinhDienTich_89_Trieu();
            Assert.AreEqual(expected_89_Trieu, actual_89_Trieu, "Sai diện tích HCN");
        }

        // Kiểm thử kiểm tra giao nhau giữa 2 hình chữ nhật thành công
        [TestMethod]
        public void TC8_TestKiemTraGiaoNhau_Pass_89_Trieu()
        {
            var hcn1_89_Trieu = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(1, 6), new Diem_89_Trieu(4, 1));
            var hcn2_89_Trieu = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(5, 3), new Diem_89_Trieu(8, 2));
            // hcn2_89_Trieu có x2 =8, hcn1 có x1 = 1 
            // kết quả là false vì hcn2_89_Trieu nằm hoàn toàn bên trái hcn1_89_Trieu nên 2 hcn không giao nhau
            bool actual_89_Trieu = hcn1_89_Trieu.KiemTraGiaoNhau_89_Trieu(hcn2_89_Trieu);
            Assert.IsFalse(actual_89_Trieu);
        }

        [TestMethod]
        public void TC9_TestKiemTraGiaoNhau_Pass_89_Trieu()
        {
            var hcn1_89_Trieu = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(-4, 4), new Diem_89_Trieu(2, -2));
            var hcn2_89_Trieu = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(-2, 9), new Diem_89_Trieu(3, 6));

            // kết quả là false vì hcn2_89_Trieu nằm hoàn toàn ở trên hcn1_89_Trieu nên 2 hcn không giao nhau
            bool expected_89_Trieu = false;
            bool actual_89_Trieu = hcn1_89_Trieu.KiemTraGiaoNhau_89_Trieu(hcn2_89_Trieu);
            Assert.AreEqual(expected_89_Trieu, actual_89_Trieu);
        }

        // Kiểm thử kiểm tra giao nhau giữa 2 hình chữ nhật thất bại
        [TestMethod]
        public void TC10_TestKiemTraGiaoNhau_Fail_89_Trieu()
        {
            var hcn1_89_Trieu = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(1, 3), new Diem_89_Trieu(4, 1));
            var hcn2_89_Trieu = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(1, 4), new Diem_89_Trieu(5, 2));
            // 2 hcn giao với nhau nên kết quả là true
            bool expected_89_Trieu = false;
            bool actual_89_Trieu = hcn1_89_Trieu.KiemTraGiaoNhau_89_Trieu(hcn2_89_Trieu);
            Assert.AreEqual(expected_89_Trieu, actual_89_Trieu);
        }

        [TestMethod]
        public void TC11_TestKiemTraGiaoNhau_Fail_89_Trieu()
        {
            var hcn1_89_Trieu = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(-5, -2), new Diem_89_Trieu(-1, -4));
            var hcn2_89_Trieu = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(1, 6), new Diem_89_Trieu(3, 1));
            // 2 hcn không giao nhau nên trả về false
            bool actual_89_Trieu = hcn1_89_Trieu.KiemTraGiaoNhau_89_Trieu(hcn2_89_Trieu);
            Assert.IsTrue(actual_89_Trieu);
        }

        // test case kiểm tra 2 HCN chạm nhau ở cạnh
        [TestMethod]
        public void TC12_TestHCNChamNhau_Fail_89_Trieu()
        {
            var hcn1 = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(0, 4), new Diem_89_Trieu(4, 0));
            var hcn2 = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(4, 5), new Diem_89_Trieu(8, 0));
            // 2 hcn giao nhau tại cạnh x=4
            Assert.IsFalse(hcn1.KiemTraGiaoNhau_89_Trieu(hcn2));
        }

        // test case kiểm tra 2 HCN trùng nhau
        [TestMethod]
        public void TC13_Test2HCNTrungNhau_Fail_89_Trieu()
        {
            var hcn1 = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(1, 4), new Diem_89_Trieu(3, 2));
            var hcn2 = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(1, 4), new Diem_89_Trieu(3, 2));
            Assert.IsFalse(hcn1.KiemTraGiaoNhau_89_Trieu(hcn2));
        }

        // test case kiểm tra 1 hcn nằm trong hcn khác 
        [TestMethod]
        public void TC14_Test2HCNNamTrongNhau_Fail_89_Trieu()
        {
            var hcnLon = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(0, 5), new Diem_89_Trieu(5, 0));
            var hcnNho = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(1, 4), new Diem_89_Trieu(4, 1));
            Assert.IsFalse(hcnLon.KiemTraGiaoNhau_89_Trieu(hcnNho));
        }

        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"D:\KTPM\Rectangle_89_Trieu\RectangleTester_89_Trieu\Data_89_Trieu\Data1HCN_89_Trieu.csv", "Data1HCN_89_Trieu#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        // Test với dữ liệu từ file CSV Data1HCN_89_Trieu.csv
        public void TC15_TinhDienTich_FromCSV_89_Trieu()

        {
            // Đọc dữ liệu từ từng cột trong CSV
            int x1_89_Trieu = int.Parse(TestContext.DataRow[0].ToString());
            int y1_89_Trieu = int.Parse(TestContext.DataRow[1].ToString());
            int x2_89_Trieu = int.Parse(TestContext.DataRow[2].ToString());
            int y2_89_Trieu = int.Parse(TestContext.DataRow[3].ToString());
            double expected_89_Trieu = double.Parse(TestContext.DataRow["expected_89_Trieu"].ToString());

            // Tạo hình chữ nhật từ 2 điểm
            var hcn_89_Trieu = new HinhChuNhat_89_Trieu(new Diem_89_Trieu(x1_89_Trieu, y1_89_Trieu), new Diem_89_Trieu(x2_89_Trieu, y2_89_Trieu));

            // Tính diện tích thực tế
            double actual_89_Trieu = hcn_89_Trieu.TinhDienTich_89_Trieu();

            // So sánh kết quả thực tế và mong đợi
            Assert.AreEqual(expected_89_Trieu, actual_89_Trieu, "Sai diện tích với tọa độ");
        }
    }

}
