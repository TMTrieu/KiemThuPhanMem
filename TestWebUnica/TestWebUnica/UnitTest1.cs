using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using static System.Net.WebRequestMethods;

namespace TestWebUnica
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver_89_Trieu = new ChromeDriver();
        string Email_89_Trieu;
        string MatKhau_89_Trieu;
        [TestInitialize]
        public void SetUp_89_Trieu()
        {
            driver_89_Trieu.Navigate().GoToUrl("https://unica.vn/");
            Email_89_Trieu = "2254052085trieu@ou.edu.vn";
            MatKhau_89_Trieu = "TMTZ1204";
        }

        /*[TestMethod]
        public void TC1_DangKy_89_Trieu()
        {
            //Nhấn vào nút "Đăng ký"
            driver_89_Trieu.FindElement(By.XPath("/html/body/header/div[1]/div/div/div[2]/div[5]/a")).Click();
            //Điền Email/SĐT
            driver_89_Trieu.FindElement(By.Id("full_name")).SendKeys("Trần Minh Triều");
            driver_89_Trieu.FindElement(By.Name("email")).SendKeys(Email_89_Trieu);
            driver_89_Trieu.FindElement(By.CssSelector("[id=\'preview_phone\']")).SendKeys("0708098359");
            driver_89_Trieu.FindElement(By.Name("password")).SendKeys(MatKhau_89_Trieu);
            driver_89_Trieu.FindElement(By.Name("password_confirmation")).SendKeys(MatKhau_89_Trieu);

            driver_89_Trieu.FindElement(By.Id("submitRegister")).Submit();
            // xác nhận đăng nhập thành công khi ảnh đại diện của tài khoản xuất hiện
            IWebElement AnhDaiDien_89_Trieu = driver_89_Trieu.FindElement(By.XPath("//*[@id=\"dropdownUserAvatarButton\"]/img"));
            Assert.IsTrue(AnhDaiDien_89_Trieu.Displayed, "Đăng nhập thất bại!");
        }*/

        [TestMethod]
        public void TC1_DangNhap_Pass_89_Trieu()
        {
            //Nhấn vào nút "Đăng nhập"
            driver_89_Trieu.FindElement(By.LinkText("Đăng nhập")).Click();
            //Điền Email
            driver_89_Trieu.FindElement(By.Name("email")).SendKeys(Email_89_Trieu);
            // Điền mật khẩu
            driver_89_Trieu.FindElement(By.Name("password")).SendKeys(MatKhau_89_Trieu);
            // Nhấn nút đăng nhập
            driver_89_Trieu.FindElement(By.Id("submitLogin")).Submit();
            System.Threading.Thread.Sleep(2000);
            // xác nhận đăng nhập thành công khi ảnh đại diện của tài khoản xuất hiện
            IWebElement AnhDaiDien_89_Trieu = driver_89_Trieu.FindElement(By.XPath("//*[@id=\"dropdownUserAvatarButton\"]/img"));
            Assert.IsTrue(AnhDaiDien_89_Trieu.Displayed, "Đăng nhập thất bại!");
        }

        [TestMethod]
        public void TC2_DangNhapSaiTaiKhoan_Fail_89_Trieu()
        {
            //Nhấn vào nút "Đăng nhập"
            driver_89_Trieu.FindElement(By.LinkText("Đăng nhập")).Click();
            //Điền Email
            driver_89_Trieu.FindElement(By.Name("email")).SendKeys("2254052085trieu@gmail.com");
            // Điền mật khẩu
            driver_89_Trieu.FindElement(By.Name("password")).SendKeys(MatKhau_89_Trieu);
            // Nhấn nút đăng nhập
            driver_89_Trieu.FindElement(By.Id("submitLogin")).Submit();
            //chờ 2 giây để load
            System.Threading.Thread.Sleep(2000);
            // xác nhận đăng nhập thành công khi ảnh đại diện của tài khoản xuất hiện
            IWebElement AnhDaiDien_89_Trieu = driver_89_Trieu.FindElement(By.XPath("//*[@id=\"dropdownUserAvatarButton\"]/img"));
            Assert.IsTrue(AnhDaiDien_89_Trieu.Displayed, "Sai tai khoan!");
        }

        [TestMethod]
        public void TC3_DangNhapSaiMatKhau_Fail_89_Trieu()
        {
            //Nhấn vào nút "Đăng nhập"
            driver_89_Trieu.FindElement(By.LinkText("Đăng nhập")).Click();
            //Điền Email
            driver_89_Trieu.FindElement(By.Name("email")).SendKeys(Email_89_Trieu);
            // Điền mật khẩu
            driver_89_Trieu.FindElement(By.Name("password")).SendKeys("TMTZ1111");
            // Nhấn nút đăng nhập
            driver_89_Trieu.FindElement(By.Id("submitLogin")).Submit();
            //chờ 2 giây để load
            System.Threading.Thread.Sleep(2000);
            // xác nhận đăng nhập thành công khi ảnh đại diện của tài khoản xuất hiện
            IWebElement AnhDaiDien_89_Trieu = driver_89_Trieu.FindElement(By.XPath("//*[@id=\"dropdownUserAvatarButton\"]/img"));
            Assert.IsTrue(AnhDaiDien_89_Trieu.Displayed, "Sai mat khau!");
        }

        [TestMethod]
        public void TC4_XoaTaiKhoan_Pass_89_Trieu()
        {
            // Khởi tạo WebDriverWait với thời gian chờ tối đa 10 giây
            WebDriverWait wait = new WebDriverWait(driver_89_Trieu, TimeSpan.FromSeconds(10));
            //Nhấn vào nút "Đăng nhập"
            driver_89_Trieu.FindElement(By.LinkText("Đăng nhập")).Click();
            //Điền Email
            driver_89_Trieu.FindElement(By.Name("email")).SendKeys(Email_89_Trieu);
            //Điền mật khẩu
            driver_89_Trieu.FindElement(By.Name("password")).SendKeys(MatKhau_89_Trieu);
            //Nhấn nút đăng nhập
            driver_89_Trieu.FindElement(By.Id("submitLogin")).Submit();
            //Chờ 3 giây
            System.Threading.Thread.Sleep(3000);
            // Nếu URL chứa "recover", thực hiện phục hồi tài khoản
            if (driver_89_Trieu.Url.Contains("recover"))
                driver_89_Trieu.FindElement(By.XPath("/html/body/div[1]/div/div[2]/a/button")).Click();
            //chờ đến khi đăng nhập xong
            wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"dropdownUserAvatarButton\"]/img")).Displayed);
            //Di chuyển tới hồ sơ cá nhân
            driver_89_Trieu.Navigate().GoToUrl("https://id.unica.vn/info");
            wait.Until(driver => driver.Url.Contains("info"));
            // nhấn nút xóa tài khoản
            driver_89_Trieu.FindElement(By.Id("removeAccountUnica")).Click();
            // chờ đến khi load xong
            wait.Until(driver => driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[2]/div[3]/button")).Displayed);
            //nhấn button xác nhận xóa tài khoản
            driver_89_Trieu.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[2]/div[3]/button")).Click();
            // chờ đến khi load xong
            wait.Until(driver => driver.FindElement(By.Id("inputPassword")).Displayed);
            //truyền mật khẩu
            driver_89_Trieu.FindElement(By.Id("inputPassword")).SendKeys(MatKhau_89_Trieu);
            //xóa tài khoản
            driver_89_Trieu.FindElement(By.XPath("//*[@id=\"deleteAccount\"]")).Submit();
            //chờ 2 giây
            System.Threading.Thread.Sleep(2000);
            //xác nhận xóa thành công khi được chuyển đến đường dẫn mới
            Assert.IsTrue(driver_89_Trieu.Url.ToString() == "https://id.unica.vn/?src=https://unica.vn/dashboard/user/delete");
        }

        [TestMethod]
        public void TC5_XoaTaiKhoan_Fail_89_Trieu()
        {
            // Khởi tạo WebDriverWait với thời gian chờ tối đa 10 giây
            WebDriverWait wait = new WebDriverWait(driver_89_Trieu, TimeSpan.FromSeconds(10));
            //Nhấn vào nút "Đăng nhập"
            driver_89_Trieu.FindElement(By.LinkText("Đăng nhập")).Click();
            //Điền Email
            driver_89_Trieu.FindElement(By.Name("email")).SendKeys(Email_89_Trieu);
            //Điền mật khẩu
            driver_89_Trieu.FindElement(By.Name("password")).SendKeys(MatKhau_89_Trieu);
            //Nhấn nút đăng nhập
            driver_89_Trieu.FindElement(By.Id("submitLogin")).Submit();
            //Chờ 3 giây
            System.Threading.Thread.Sleep(3000);
            // Nếu URL chứa "recover", thực hiện phục hồi tài khoản
            if (driver_89_Trieu.Url.Contains("recover"))
                driver_89_Trieu.FindElement(By.XPath("/html/body/div[1]/div/div[2]/a/button")).Click();
            //chờ đến khi đăng nhập xong
            wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"dropdownUserAvatarButton\"]/img")).Displayed);
            //Di chuyển tới hồ sơ cá nhân
            driver_89_Trieu.Navigate().GoToUrl("https://id.unica.vn/info");
            wait.Until(driver => driver.Url.Contains("info"));
            // nhấn nút xóa tài khoản
            driver_89_Trieu.FindElement(By.Id("removeAccountUnica")).Click();
            // chờ đến khi load xong
            wait.Until(driver => driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[2]/div[3]/button")).Displayed);
            //nhấn button xác nhận xóa tài khoản
            driver_89_Trieu.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[2]/div[3]/button")).Click();
            // chờ đến khi load xong
            wait.Until(driver => driver.FindElement(By.Id("inputPassword")).Displayed);
            //truyền mật khẩu
            driver_89_Trieu.FindElement(By.Id("inputPassword")).SendKeys("MatKhau_89_Trieu");
            //xóa tài khoản
            driver_89_Trieu.FindElement(By.XPath("//*[@id=\"deleteAccount\"]")).Submit();
            //chờ 2 giây
            System.Threading.Thread.Sleep(2000);
            //xác nhận xóa thành công khi được chuyển đến đường dẫn mới
            Assert.IsTrue(driver_89_Trieu.Url.ToString() == "https://id.unica.vn/?src=https://unica.vn/dashboard/user/delete");
        }

        [TestMethod]
        public void TC6_TimKiemTheoKhoaHoc_Pass_89_Trieu()
        {
            // Tìm kiếm khóa học    
            driver_89_Trieu.FindElement(By.Id("text_search")).SendKeys("photoshop");
            //nhấn tìm kiếm
            driver_89_Trieu.FindElement(By.Id("text_search")).Submit();

            // Chờ 2 giây 
            System.Threading.Thread.Sleep(2000);

            // Lấy chuỗi số lượng kết quả khóa học: có "33 kết quả cho 'photoshop"
            string KetQua_89_Trieu = driver_89_Trieu.FindElement(By.CssSelector(".font-bold.text-xl.lg\\:text-2xl")).Text;
            //tách chữ để lấy số khóa học
            int SoKhoaHoc_89_Trieu = int.Parse(KetQua_89_Trieu.Split(' ')[0]);
            // mặc định 1 trang của Unica thực tế luôn có 16 khóa học
            int SoKhoaHoc1Trang_89_Trieu = 16;
            // tính số trang cần thực hiện tìm kiếm
            int SoTrang_89_Trieu = (SoKhoaHoc_89_Trieu / SoKhoaHoc1Trang_89_Trieu) + 1;

            // Tìm kiếm qua các trang
            bool TimThay_89_Trieu = false;
            for (int trangHienTai_89_Trieu = 0; trangHienTai_89_Trieu < SoTrang_89_Trieu && !TimThay_89_Trieu; trangHienTai_89_Trieu++)
            {
                try
                {
                    // Tìm tất cả tiêu đề trên trang hiện tại
                    var TieuDe_89_Trieu = driver_89_Trieu.FindElements(By.CssSelector(".font-bold.text-base.leading-5"));
                    foreach (var TungTieuDe_89_Trieu in TieuDe_89_Trieu)
                    {
                        string TenTieuDe_89_Trieu = TungTieuDe_89_Trieu.Text;
                        if (TenTieuDe_89_Trieu.Contains("Phù Thủy Photoshop"))
                        {
                            TimThay_89_Trieu = true;
                            break;
                        }
                    }

                    // Chuyển sang trang tiếp theo nếu chưa tìm thấy
                    if (!TimThay_89_Trieu && trangHienTai_89_Trieu < SoTrang_89_Trieu - 1)
                    {
                        driver_89_Trieu.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[17]/ul/li[5]/a")).Click();
                        System.Threading.Thread.Sleep(2000);
                    }
                }
                // ném ngoại lệ nếu không tìm thấy
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
            // Kiểm tra kết quả cuối cùng
            Assert.IsTrue(TimThay_89_Trieu);
        }

        [TestMethod]
        public void TC7_TimKiemTheoKhoaHoc_Fail_89_Trieu()
        {
            // Tìm kiếm khóa học
            driver_89_Trieu.FindElement(By.Id("text_search")).SendKeys("nấu ăn");
            //nhấn tìm kiếm
            driver_89_Trieu.FindElement(By.Id("text_search")).Submit();

            // Chờ 2 giây 
            System.Threading.Thread.Sleep(2000);
            // Ket qua là chuỗi "2 kết quả cho "nấu ăn"
            // Lấy chuỗi số lượng kết quả khóa học
            string KetQua_89_Trieu = driver_89_Trieu.FindElement(By.CssSelector(".font-bold.text-xl.lg\\:text-2xl")).Text;
            //tách chữ để lấy số khóa học
            int SoKhoaHoc_89_Trieu = int.Parse(KetQua_89_Trieu.Split(' ')[0]);
            // mặc định 1 trang của Unica có 16 khóa học
            int SoKhoaHoc1Trang_89_Trieu = 16;
            // tính số trang cần thực hiện tìm kiếm
            int SoTrang_89_Trieu = (SoKhoaHoc_89_Trieu / SoKhoaHoc1Trang_89_Trieu) + 1;

            // Tìm kiếm qua các trang
            bool TimThay_89_Trieu = false;
            for (int trangHienTai_89_Trieu = 0; trangHienTai_89_Trieu < SoTrang_89_Trieu && !TimThay_89_Trieu; trangHienTai_89_Trieu++)
            {
                try
                {
                    // Tìm tất cả tiêu đề trên trang hiện tại
                    var TieuDe_89_Trieu = driver_89_Trieu.FindElements(By.CssSelector(".font-bold.text-base.leading-5"));
                    foreach (var TungTieuDe_89_Trieu in TieuDe_89_Trieu)
                    {
                        string TenTieuDe_89_Trieu = TungTieuDe_89_Trieu.Text;
                        if (TenTieuDe_89_Trieu.Contains("Phù Thủy Photoshop"))
                        {
                            TimThay_89_Trieu = true;
                            break;
                        }
                    }

                    // Chuyển sang trang tiếp theo nếu chưa tìm thấy
                    if (!TimThay_89_Trieu && trangHienTai_89_Trieu < SoTrang_89_Trieu - 1)
                    {
                        driver_89_Trieu.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[17]/ul/li[5]/a")).Click();
                        System.Threading.Thread.Sleep(2000);
                    }
                }
                // ném ngoại lệ nếu không tìm thấy
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
            // Kiểm tra kết quả cuối cùng
            Assert.IsTrue(TimThay_89_Trieu);
        }

        [TestMethod]
        public void TC8_TimKiemTheoTacGia_Pass_89_Trieu()
        {
            // Tìm kiếm khóa học
            driver_89_Trieu.FindElement(By.Id("text_search")).SendKeys("Hoang Hiep");
            //nhấn tìm kiếm
            driver_89_Trieu.FindElement(By.Id("text_search")).Submit();

            // Chờ 2 giây 
            System.Threading.Thread.Sleep(2000);

            // Lấy chuỗi số lượng kết quả khóa học: có "8 kết quả cho "Hoang Hiep"
            string KetQua_89_Trieu = driver_89_Trieu.FindElement(By.CssSelector(".font-bold.text-xl.lg\\:text-2xl")).Text;
            //tách chữ để lấy số khóa học
            int SoKhoaHoc_89_Trieu = int.Parse(KetQua_89_Trieu.Split(' ')[0]);
            // mặc định 1 trang của Unica có 16 khóa học
            int SoKhoaHoc1Trang_89_Trieu = 16;
            // tính số trang cần thực hiện tìm kiếm
            int SoTrang_89_Trieu = (SoKhoaHoc_89_Trieu / SoKhoaHoc1Trang_89_Trieu) + 1;

            // Tìm kiếm qua các trang
            bool TimThay_89_Trieu = false;
            for (int trangHienTai_89_Trieu = 0; trangHienTai_89_Trieu < SoTrang_89_Trieu && !TimThay_89_Trieu; trangHienTai_89_Trieu++)
            {
                try
                {
                    // Tìm tất cả tiêu đề trên trang hiện tại
                    var TieuDe_89_Trieu = driver_89_Trieu.FindElements(By.CssSelector(".font-bold.text-base.leading-5"));
                    foreach (var TungTieuDe_89_Trieu in TieuDe_89_Trieu)
                    {
                        string TenTieuDe_89_Trieu = TungTieuDe_89_Trieu.Text;
                        if (TenTieuDe_89_Trieu.Contains("Phù Thủy Photoshop"))
                        {
                            TimThay_89_Trieu = true;
                            break;
                        }
                    }

                    // Chuyển sang trang tiếp theo nếu chưa tìm thấy
                    if (!TimThay_89_Trieu && trangHienTai_89_Trieu < SoTrang_89_Trieu - 1)
                    {
                        driver_89_Trieu.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[17]/ul/li[5]/a")).Click();
                        System.Threading.Thread.Sleep(2000);
                    }
                }
                // ném ngoại lệ nếu không tìm thấy
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
            // Kiểm tra kết quả cuối cùng
            Assert.IsTrue(TimThay_89_Trieu);
        }

        [TestMethod]
        public void TC9_TimKiemTheoTacGia_Fail_89_Trieu()
        {
            // Tìm kiếm tác giả không có space
            driver_89_Trieu.FindElement(By.Id("text_search")).SendKeys("HoangHiep");
            //nhấn tìm kiếm
            driver_89_Trieu.FindElement(By.Id("text_search")).Submit();

            // Chờ 2 giây 
            System.Threading.Thread.Sleep(2000);

            // Ket qua là chuỗi "Xin lỗi, chúng tôi không thấy kết quả cho "HoangHiep"" sẽ ném ngoại lệ NoSuchElementException
            // Lấy chuỗi số lượng kết quả khóa học
            string KetQua_89_Trieu = driver_89_Trieu.FindElement(By.CssSelector(".font-bold.text-xl.lg\\:text-2xl")).Text;
            //tách chữ để lấy số khóa học
            int SoKhoaHoc_89_Trieu = int.Parse(KetQua_89_Trieu.Split(' ')[0]);
            // mặc định 1 trang của Unica có 16 khóa học
            int SoKhoaHoc1Trang_89_Trieu = 16;
            // tính số trang cần thực hiện tìm kiếm
            int SoTrang_89_Trieu = (SoKhoaHoc_89_Trieu / SoKhoaHoc1Trang_89_Trieu) + 1;

            // Tìm kiếm qua các trang
            bool TimThay_89_Trieu = false;
            for (int trangHienTai_89_Trieu = 0; trangHienTai_89_Trieu < SoTrang_89_Trieu && !TimThay_89_Trieu; trangHienTai_89_Trieu++)
            {
                try
                {
                    // Tìm tất cả tiêu đề trên trang hiện tại
                    var TieuDe_89_Trieu = driver_89_Trieu.FindElements(By.CssSelector(".font-bold.text-base.leading-5"));
                    foreach (var TungTieuDe_89_Trieu in TieuDe_89_Trieu)
                    {
                        string TenTieuDe_89_Trieu = TungTieuDe_89_Trieu.Text;
                        if (TenTieuDe_89_Trieu.Contains("Phù Thủy Photoshop"))
                        {
                            TimThay_89_Trieu = true;
                            break;
                        }
                    }

                    // Chuyển sang trang tiếp theo nếu chưa tìm thấy
                    if (!TimThay_89_Trieu && trangHienTai_89_Trieu < SoTrang_89_Trieu - 1)
                    {
                        driver_89_Trieu.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[17]/ul/li[5]/a")).Click();
                        System.Threading.Thread.Sleep(2000);
                    }
                }
                // ném ngoại lệ nếu không tìm thấy
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
            // Kiểm tra kết quả cuối cùng
            Assert.IsTrue(TimThay_89_Trieu);
        }
    }
}
