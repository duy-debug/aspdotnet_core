# Bài tập ASP.NET Core
# Bài tập 1
Tạo một Project có tên BaiTap1, tạo một controller có tên là CalculatorController thực hiện chức năng nhập vào 2 số thực, chọn phép toán, tính và in kết quả có giao diện như sau:

Xây dựng trang web theo các cách tiếp nhận tham số yêu cầu:
• Sử dụng Request <br>
• Sử dụng đối số của Action <br>
• Sử dụng tham số IFormCollection <br>
• Sử dụng Model
# Bài tập 2
Tạo một Project có tên BaiTap2, tạo một controller có tên là StudentController thực hiện chức năng sau:

• Đăng ký thông tin sinh viên <br>
• Hiển thị thông tin sinh viên đã đăng ký <br>
• Tại phần đăng ký, thêm chức năng tải ảnh lên. Tại phần hiển thị thông tin sinh viên, hiện hình ảnh vừa tải lên. <br>
• Khi tải lại trang, thông tin sinh viên đăng ký không bị mất (Lưu thông tin sinh viên vào .txt)
# Bài tập 3
Tạo một Project có tên BaiTap3, tạo controller có tên là EmailController thực hiện đăng nhập vào email và gửi mail đến 1 địa chỉ khác (dùng mail yahoo hoặc gmail).

Thông tin gửi mail bao gồm:

  • Địa chỉ mail người gửi <br>
  • Mật khẩu người gửi <br>
  • Địa chỉ mail cần gửi đến <br>
  • Tiêu đề <br>
  • Nội dung gửi <br>
  Lưu ý, email phải nhập đúng định dạng và bắt buộc không được rỗng.

# Bài tập 4
• Tạo một Layout chung và chuyển qua các tính năng được thông qua Navbar cho các bài tập 1, 2, 3. Thêm tính năng cho phép đổi logo trên Navbar.

# Bài tập 5
**Đề bài: Xây dựng web quản lý thông tin nhân viên (tìm kiếm cơ bản)**

1. **Thiết kế cơ sở dữ liệu (CSDL): Tạo CSDL có tên QLNV_MãSV gồm 2 bảng:** <br>
• **Phòng ban**: (Mã phòng ban, Tên phòng ban) <br>
• **Nhân viên**: (Mã nhân viên, Họ nhân viên, Tên nhân viên, Giới tính, Ngày sinh, Lương, Ảnh nhân viên, Địa chỉ, Mã phòng ban) <br>
2.  **Tạo DbContext dựa trên CSDL** <br>
3.  **Xây dựng các chức năng quản lý:** <br>
• Quản lý **phòng ban** và **nhân viên** với các chức năng: <br>
• **Thêm mới** <br>
• **Chỉnh sửa** <br>
• **Xóa** <br>
• **Hiển thị danh sách** <br>
5. **Chức năng tìm kiếm cơ bản**: <br>
• Cho phép tìm kiếm nhân viên theo các tiêu chí: <br>
• Mã nhân viên <br>
• Họ tên <br>
• Giới tính <br>
• Địa chỉ <br>
• Phòng ban <br>
# Bài tập 6
**Xây dựng web quản lý sinh viên** <br>

1. **Thiết kế cơ sở dữ liệu (CSDL)** <br>
Tạo CSDL có tên **QLSV_MãSV** gồm 3 bảng: <br>

**Phòng ban (Departments)** <br>

• Mã phòng ban (DepartmentID) <br>
• Tên phòng ban (DepartmentName) <br>
**Sinh viên (Students)** <br>

• Mã sinh viên (StudentID) <br>
• Họ sinh viên (LastName) <br>
• Tên sinh viên (FirstName) <br>
• Giới tính (Gender) <br>
• Ngày sinh (BirthDate) 
• Địa chỉ (Address) <br>
• Ảnh đại diện (PhotoURL) <br>
• Mã phòng ban (DepartmentID - Khóa ngoại) <br>
**Người dùng (Users)** <br>

• Mã người dùng (UserID) <br>
• Tên đăng nhập (Username - Duy nhất) <br>
• Mật khẩu (PasswordHash - Được băm bằng BCrypt) <br>
• Vai trò (Role: Admin, User) <br>
**2. Tạo DbContext dựa trên CSDL** <br>

• Sử dụng Entity Framework Core để quản lý kết nối và truy vấn CSDL. <br>
• DbContext chứa các DbSet cho các bảng trong CSDL. <br>
**3. Xây dựng các chức năng quản lý phòng ban và sinh viên** <br>

**Thêm mới** <br>
**Chỉnh sửa** <br>
**Xóa** <br>
**Hiển thị danh sách** <br>
**4. Chức năng tìm kiếm sinh viên** <br>

• Cho phép tìm kiếm sinh viên theo các tiêu chí: <br>
• Mã sinh viên <br>
• Họ tên <br>
• Giới tính <br>
• Địa chỉ <br>
• Phòng ban <br>
**5. Chức năng đăng nhập và phân quyền** <br> 

**Sử dụng Form Authentication để xác thực người dùng.** <br>
**Mật khẩu được băm bằng BCrypt trước khi lưu vào CSDL.** <br>
**Phân quyền:** <br>
• Admin: Quản lý sinh viên, phòng ban, người dùng. <br>
• User: Chỉ xem thông tin sinh viên. <br>
**6. Chức năng quản trị hệ thống** <br>

**Quản lý tài khoản người dùng:** <br>
• Thêm mới <br>
• Chỉnh sửa <br>
• Xóa <br>
• Đổi mật khẩu <br>
**Chỉ tài khoản có vai trò Admin mới được thực hiện.** <br>
