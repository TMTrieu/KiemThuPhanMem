📖 Giới thiệu

Đề tài tập trung áp dụng các công cụ và kỹ thuật kiểm thử phần mềm để đánh giá chất lượng website Unica.vn.
Quy trình bao gồm:

Viết và chạy Unit Test (NUnit) cho bài toán hình chữ nhật.

Kiểm thử Website Unica.vn với Selenium WebDriver.

Kiểm thử API bằng Postman kết hợp Json Server.

🛠️ Công nghệ sử dụng
Ngôn ngữ: C#, JavaScript

Kiểm thử Unit: NUnit, MSTest

Kiểm thử UI Web: Selenium WebDriver, ChromeDriver

Kiểm thử API: Postman, Json Server (Node.js)


Cấu trúc dự án

├── Rectangle_89_Trieu/               # Bài tập NUnit – kiểm thử hình chữ nhật

│   ├── Diem_89_Trieu.cs

│   ├── HinhChuNhat_89_Trieu.cs

│   ├── Data_89_Trieu/Data1HCN.csv

│   └── RectangleTester_89_Trieu/     # Unit Test

│
├── TestWebUnica/                     # Kiểm thử Website Unica

│   ├── UnitTest1.cs                  # Test login, tìm kiếm, xóa tài khoản

│   └── Packages.config (Selenium)

│

├── JsonServer_89_Trieu/              # Kiểm thử API bằng Postman

│   ├── NhanVien_89_Trieu.json

│   ├── package.json

│   └── (npm start để chạy json-server)

│

└── README.md

🔍 Các chức năng kiểm thử
1️⃣ NUnit – Kiểm thử Hình chữ nhật

Xác định HCN bởi 2 điểm (trên-trái và dưới-phải).

Viết test kiểm tra:

Nhập điểm hợp lệ / không hợp lệ.

Tính diện tích.

Kiểm tra giao nhau giữa 2 HCN.

Dữ liệu test lấy từ file CSV và assert bằng NUnit.

2️⃣ Selenium – Kiểm thử Website Unica.vn

Đăng nhập: Test Pass/Fail khi đúng/sai tài khoản & mật khẩu.

Xóa tài khoản: Test case xác nhận việc xóa thành công/thất bại.

Tìm kiếm khóa học: Kiểm thử tìm kiếm theo tên khóa học và tác giả.

3️⃣ Postman – Kiểm thử API

GET: Lấy danh sách & chi tiết nhân viên.

POST: Thêm nhân viên mới.

PUT: Cập nhật thông tin nhân viên.
DELETE: Xóa nhân viên.
PATCH: Sửa một phần thông tin nhân viên.

Test case viết trực tiếp trong Postman (Kiểm tra status code, dữ liệu JSON trả về).
