Đề tài: Website bán Laptop

Giáo viên hướng dẫn: TS. Lê Ngọc Anh
Sinh viên:   Phan Thanh Pulit - 3110410109
	Nguyễn Anh Dũng - 3110410017
	Nguyễn Hoàng Tuấn - 3110410169
I. Giới thiệu
Project ShopLaptop được xây dựng nhằm cung cấp các chức năng để quản lý cho người dùng là Admin và người dùng là người mua hàng online.
Trong đó các chức năng quản lý sử dụng Winform, các chức năng cho người dùng sử dụng ASP.NET MVC 4 và xây dựng webservice dựa trên WCF,
database được cài đặt trên SQL Server 2012.
II. Thiết kế, các chức năng
1. Thiết kế
- WCF: xây dựng web service.
- Winform: sử dụng xây dựng các chức năng quản lý.
- ASP.NET MVC 4: sử dụng thiết kế website bán hàng.
- Một tầng là SQL Server để lưu trữ dữ liệu. 
- Một tầng Webservice để truy suất cơ sở dữ liệu dung chung. (Có thể sử dụng 
chung cơ sở dữ liệu cho nhiều nền tảng) 
- Tầng giao diện website: 
 + Giao diện phía người dùng. Để xem chi tiết sản phẩm, mua hàng, quản lý 
    đơn hàng đã mua … 
- Tầng WinForm:
 + Quản lý sản phẩm, loại sản phẩm, nhà sản xuất, tồn kho, người dùng, 
thống kê báo cáo, …. 
2. Các chức năng
Chức năng trên Winform:
- Quản lý sản phẩm
+ Thêm sản phẩm
+ Xóa sản phẩm
+ Sửa sản phẩm
- Quản lý loại sản phẩm
+ Thêm loại sản phẩm
+ Xóa loại sản phẩm
+ Sửa loại sản phẩm
- Quản lý khách hàng
+ Thêm khách hàng
+ Sửa thông tin khách hàng
+ Xóa khách hàng
- Quản lý hóa đơn
+ Thêm hóa đơn
+ Sửa hóa đơn
+ Xóa hóa đơn
+ Xử lí đơn hàng
+ Xem chi tiết hóa đơn
- Quản lý tồn kho
+ Xem danh sách sản phẩm trong kho gồm (id, mã sản phẩm, ngày, số lượng)
- Báo cáo doanh thu theo khoảng thời gian

Chức năng trên website: Web ShopLaptop
- Hiện sản phẩm theo loại, sản phẩm mới
- Tìm kiếm: tìm kiếm cơ bản theo tên sản phẩm
- Giỏ hàng: thêm sản phẩm vào giỏ hàng, xóa sản phẩm trong giỏ hàng, cập nhật số lượng sản phẩm trong giỏ hàng, thanh toán hóa đơn
- Tài khoản người dùng: người dùng đăng ký tài khoản, người dùng đăng nhập, đổi mật khẩu, đổi thông tin người dùng.

