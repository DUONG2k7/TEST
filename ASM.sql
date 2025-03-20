DROP DATABASE IF EXISTS SOF102_ASM;
CREATE DATABASE SOF102_ASM;
GO
USE SOF102_ASM;
GO

-- Bảng ROLES
CREATE TABLE ROLES (
    IDRole NVARCHAR(50) NOT NULL PRIMARY KEY,
    Role NVARCHAR(50)
);
GO

-- Bảng ACCOUNTS
CREATE TABLE ACCOUNTS (
    IdAcc NVARCHAR(50) PRIMARY KEY NOT NULL,
    Username NVARCHAR(50) NOT NULL,
    Password VARBINARY(MAX) NOT NULL,
    IDRole NVARCHAR(50),
    RoleBanDau NVARCHAR(50),
    Trangthai BIT,
    FOREIGN KEY (IDRole) REFERENCES ROLES(IDRole)
);
GO

-- Bảng LoginHistory
CREATE TABLE LoginHistory (
    IdLogin INT IDENTITY(1,1) PRIMARY KEY,
    IdAcc NVARCHAR(50),
    LichSuLogin DATETIME NOT NULL,
    FOREIGN KEY (IdAcc) REFERENCES ACCOUNTS(IdAcc)
);
GO

-- Bảng TEACHERS
CREATE TABLE TEACHERS (
    MaGV NVARCHAR(50) NOT NULL PRIMARY KEY,
    TenGV NVARCHAR(50),
    IdAcc NVARCHAR(50),
    Email NVARCHAR(50),
    SoDT NVARCHAR(15),
    Gioitinh BIT,
    Diachi NVARCHAR(50),
    Hinh VARBINARY(MAX),
    FOREIGN KEY (IdAcc) REFERENCES ACCOUNTS(IdAcc)
);
GO

-- Bảng CLASSES
CREATE TABLE CLASSES (
    MaLop NVARCHAR(50) NOT NULL PRIMARY KEY,
    ClassName NVARCHAR(50),
    SiSo INT, -- Số lượng học sinh trong lớp
    MaGV NVARCHAR(50), -- Giáo viên phụ trách lớp
	Trangthai BIT,
    FOREIGN KEY (MaGV) REFERENCES TEACHERS(MaGV)
);
GO

-- Bảng STUDENTS
CREATE TABLE STUDENTS (
    MaSV NVARCHAR(50) NOT NULL PRIMARY KEY,
    MaLop NVARCHAR(50) NOT NULL, -- Mỗi học sinh thuộc một lớp
    TenSV NVARCHAR(50),
    Email NVARCHAR(50),
    SoDT NVARCHAR(15),
    Gioitinh BIT,
    Diachi NVARCHAR(50),
    Hinh VARBINARY(MAX),
    FOREIGN KEY (MaLop) REFERENCES CLASSES(MaLop)
);
GO

-- Bảng GRADE
CREATE TABLE GRADE (
    ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    MaSV NVARCHAR(50) NOT NULL,
    Toan float,
    Van float,
    TiengAnh float,
    FOREIGN KEY (MaSV) REFERENCES STUDENTS(MaSV)
);
GO

-- Thêm dữ liệu vào bảng ROLES
INSERT INTO ROLES (IDRole, Role)
VALUES 
('R01', 'ADMIN'),
('R02', 'CBDT'),
('R03', 'GV'),
('R04', 'GLOBALBAN');
GO

-- Thêm dữ liệu vào bảng ACCOUNTS
INSERT INTO ACCOUNTS (IdAcc, Username, Password, IDRole, Trangthai)
VALUES 
('A01', 'A', HASHBYTES('SHA2_256', 'A'), 'R01', 0),
('A02', 'ADMIN2', HASHBYTES('SHA2_256', 'ADMIN2'), 'R01', 0),
('A03', 'ADMIN3', HASHBYTES('SHA2_256', 'ADMIN3'), 'R01', 0),

('A04', 'CB', HASHBYTES('SHA2_256', 'CB'), 'R02', 0),
('A05', 'CBDT2', HASHBYTES('SHA2_256', 'CBDT2'), 'R02', 0),
('A06', 'CBDT3', HASHBYTES('SHA2_256', 'CBDT3'), 'R02', 0),

('A07', 'GV', HASHBYTES('SHA2_256', 'GV'), 'R03', 0),
('A08', 'GV2', HASHBYTES('SHA2_256', 'GV2'), 'R03', 0),
('A09', 'GV3', HASHBYTES('SHA2_256', 'GV3'), 'R03', 0);
GO

-- Thêm dữ liệu vào bảng TEACHERS
INSERT INTO TEACHERS (MaGV, TenGV, IdAcc, Email, SoDT, Gioitinh, Diachi, Hinh)
VALUES 
('GV01', N'Nguyễn Văn A', 'A07', 'nguyenvana@gmail.com', '0987654321', 1, N'Hà Nội', NULL),
('GV02', N'Lê Thị B', 'A08', 'lethib@gmail.com', '0912345678', 0, N'Hồ Chí Minh', NULL),
('GV03', N'Phạm Văn C', 'A09', 'phamvanc@gmail.com', '0923456789', 1, N'Đà Nẵng', NULL),
('GV04', N'Trần Thị D', NULL, 'tranthid@gmail.com', '0934567890', 0, N'Cần Thơ', NULL),
('GV05', N'Hoàng Văn E', NULL, 'hoangvane@gmail.com', '0945678901', 1, N'Hải Phòng', NULL),
('GV06', N'Vũ Thị F', NULL, 'vuthif@gmail.com', '0956789012', 0, N'Bình Dương', NULL),
('GV07', N'Đặng Văn G', NULL, 'dangvang@gmail.com', '0967890123', 1, N'Nha Trang', NULL),
('GV08', N'Phan Thị H', NULL, 'phanthih@gmail.com', '0978901234', 0, N'Đà Lạt', NULL);
GO

-- Thêm dữ liệu vào bảng CLASSES
INSERT INTO CLASSES (MaLop, ClassName, MaGV, Trangthai)
VALUES 
('L00', N'Chưa phân lớp', NULL, 0),
('L01', N'Lớp Toán A', 'GV01', 0),
('L02', N'Lớp Văn B', 'GV02', 0),
('L03', N'Lớp Anh C', NULL, 0);
GO

-- Thêm dữ liệu vào bảng STUDENTS với tổng 60 sinh viên, sắp xếp MaSV tăng dần
INSERT INTO STUDENTS (MaSV, MaLop, TenSV, Email, SoDT, Gioitinh, Diachi, Hinh)
VALUES 
-- 12 sinh viên chưa phân lớp (L00)
('SV01', 'L00', N'Nguyễn Văn A', 'nguyenvana@gmail.com', '0987654321', 1, N'Hà Nội', NULL),
('SV02', 'L00', N'Lê Thị B', 'lethib@gmail.com', '0912345678', 0, N'Hồ Chí Minh', NULL),
('SV03', 'L00', N'Phạm Văn C', 'phamvanc@gmail.com', '0923456789', 1, N'Đà Nẵng', NULL),
('SV04', 'L00', N'Trần Thị D', 'tranthid@gmail.com', '0934567890', 0, N'Cần Thơ', NULL),
('SV05', 'L00', N'Hoàng Văn E', 'hoangvane@gmail.com', '0945678901', 1, N'Hải Phòng', NULL),
('SV06', 'L00', N'Vũ Thị F', 'vuthif@gmail.com', '0956789012', 0, N'Bình Dương', NULL),
('SV07', 'L00', N'Đặng Văn G', 'dangvang@gmail.com', '0967890123', 1, N'Nha Trang', NULL),
('SV08', 'L00', N'Phan Thị H', 'phanthih@gmail.com', '0978901234', 0, N'Đà Lạt', NULL),
('SV09', 'L00', N'Ngô Văn I', 'ngovani@gmail.com', '0989012345', 1, N'Huế', NULL),
('SV10', 'L00', N'Bùi Thị J', 'buithij@gmail.com', '0990123456', 0, N'Hà Nam', NULL),
('SV11', 'L00', N'Đỗ Văn K', 'dovank@gmail.com', '0901234567', 1, N'Thái Bình', NULL),
('SV12', 'L00', N'Đinh Thị L', 'dinhthil@gmail.com', '0913456789', 0, N'Bắc Giang', NULL),

-- 12 sinh viên lớp L01
('SV13', 'L01', N'Trần Văn D', 'tranvand@gmail.com', '0967891234', 1, N'Hà Nội', NULL),
('SV14', 'L01', N'Nguyễn Thị E', 'nguyenthie@gmail.com', '0934567890', 0, N'Hà Nội', NULL),
('SV15', 'L01', N'Lê Văn A', 'levana@gmail.com', '0978123456', 1, N'Hà Nội', NULL),
('SV16', 'L01', N'Phạm Thị B', 'phamthib@gmail.com', '0956784321', 0, N'Hà Nội', NULL),
('SV17', 'L01', N'Hoàng Văn C', 'hoangvanc@gmail.com', '0912345678', 1, N'Hà Nội', NULL),
('SV18', 'L01', N'Vũ Thị D', 'vuthid@gmail.com', '0987654321', 0, N'Hà Nội', NULL),
('SV19', 'L01', N'Đặng Văn E', 'dangvane@gmail.com', '0938765432', 1, N'Hà Nội', NULL),
('SV20', 'L01', N'Bùi Thị F', 'buithif@gmail.com', '0965432187', 0, N'Hà Nội', NULL),
('SV21', 'L01', N'Ngô Văn G', 'ngovang@gmail.com', '0976543210', 1, N'Hà Nội', NULL),
('SV22', 'L01', N'Đỗ Thị H', 'dothih@gmail.com', '0954321890', 0, N'Hà Nội', NULL),
('SV23', 'L01', N'Đinh Văn I', 'dinhvani@gmail.com', '0987894561', 1, N'Hà Nội', NULL),
('SV24', 'L01', N'Phan Thị J', 'phanthij@gmail.com', '0923456789', 0, N'Hà Nội', NULL),

-- 12 sinh viên lớp L02
('SV25', 'L02', N'Nguyễn Văn K', 'nguyenvank@gmail.com', '0943216789', 1, N'Hồ Chí Minh', NULL),
('SV26', 'L02', N'Lý Thị L', 'lythil@gmail.com', '0969876543', 0, N'Hồ Chí Minh', NULL),
('SV27', 'L02', N'Hoàng Văn M', 'hoangvanm@gmail.com', '0932109876', 1, N'Hồ Chí Minh', NULL),
('SV28', 'L02', N'Vũ Thị N', 'vuthin@gmail.com', '0910987654', 0, N'Hồ Chí Minh', NULL),
('SV29', 'L02', N'Đặng Văn O', 'dangvano@gmail.com', '0956781234', 1, N'Hồ Chí Minh', NULL),
('SV30', 'L02', N'Bùi Thị P', 'buithip@gmail.com', '0987656789', 0, N'Hồ Chí Minh', NULL),
('SV31', 'L02', N'Ngô Văn Q', 'ngovanq@gmail.com', '0967896543', 1, N'Hồ Chí Minh', NULL),
('SV32', 'L02', N'Đỗ Thị R', 'dothir@gmail.com', '0954321678', 0, N'Hồ Chí Minh', NULL),
('SV33', 'L02', N'Đinh Văn S', 'dinhvans@gmail.com', '0932105678', 1, N'Hồ Chí Minh', NULL),
('SV34', 'L02', N'Phan Thị T', 'phanthit@gmail.com', '0978654321', 0, N'Hồ Chí Minh', NULL),
('SV35', 'L02', N'Nguyễn Văn U', 'nguyenvanu@gmail.com', '0998765432', 1, N'Hồ Chí Minh', NULL),
('SV36', 'L02', N'Lê Thị V', 'lethiv@gmail.com', '0923456781', 0, N'Hồ Chí Minh', NULL),

-- 12 sinh viên lớp L03
('SV37', 'L03', N'Nguyễn Văn W', 'nguyenvanw@gmail.com', '0967890987', 1, N'Đà Nẵng', NULL),
('SV38', 'L03', N'Trần Thị X', 'tranthix@gmail.com', '0956785432', 0, N'Đà Nẵng', NULL),
('SV39', 'L03', N'Hoàng Văn Y', 'hoangvany@gmail.com', '0912348756', 1, N'Đà Nẵng', NULL),
('SV40', 'L03', N'Phạm Thị Z', 'phamthiz@gmail.com', '0934561897', 0, N'Đà Nẵng', NULL),
('SV41', 'L03', N'Lê Văn A1', 'levana1@gmail.com', '0987651342', 1, N'Đà Nẵng', NULL),
('SV42', 'L03', N'Vũ Thị B1', 'vuthib1@gmail.com', '0943216781', 0, N'Đà Nẵng', NULL),
('SV43', 'L03', N'Đặng Văn C1', 'dangvanc1@gmail.com', '0932107856', 1, N'Đà Nẵng', NULL),
('SV44', 'L03', N'Bùi Thị D1', 'buithid1@gmail.com', '0910987653', 0, N'Đà Nẵng', NULL),
('SV45', 'L03', N'Ngô Văn E1', 'ngovane1@gmail.com', '0956781232', 1, N'Đà Nẵng', NULL),
('SV46', 'L03', N'Đỗ Thị F1', 'dothif1@gmail.com', '0987656779', 0, N'Đà Nẵng', NULL),
('SV47', 'L03', N'Đinh Văn G1', 'dinhvang1@gmail.com', '0967896523', 1, N'Đà Nẵng', NULL),
('SV48', 'L03', N'Phan Thị H1', 'phanthih1@gmail.com', '0954321654', 0, N'Đà Nẵng', NULL);

-- Thêm điểm cho nửa còn lại sinh viên ở các lớp L01, L02, L03
INSERT INTO GRADE (MaSV, Toan, Van, TiengAnh)
VALUES 
-- Lớp L01 (6 sinh viên còn lại)
('SV19', 7.0, 8.5, 6.5),
('SV20', 8.5, 7.0, 7.5),
('SV21', 6.0, 7.5, 8.0),
('SV22', 7.5, 6.5, 8.5),
('SV23', 8.0, 9.0, 7.0),
('SV24', 6.5, 7.0, 8.0),

-- Lớp L02 (6 sinh viên còn lại)
('SV31', 8.0, 7.0, 7.5),
('SV32', 7.5, 6.5, 8.0),
('SV33', 7.0, 8.5, 6.5),
('SV34', 6.5, 7.0, 8.5),
('SV35', 8.5, 9.0, 7.0),
('SV36', 7.0, 6.5, 8.0),

-- Lớp L03 (6 sinh viên còn lại)
('SV43', 7.5, 6.0, 8.5),
('SV44', 8.0, 9.0, 7.5),
('SV45', 7.0, 7.5, 6.5),
('SV46', 6.5, 8.0, 7.0),
('SV47', 8.5, 9.0, 7.5),
('SV48', 7.0, 6.5, 8.0);
GO

DROP TABLE IF EXISTS GRADE;
DROP TABLE IF EXISTS STUDENTS;
DROP TABLE IF EXISTS CLASSES;
DROP TABLE IF EXISTS TEACHERS;
DROP TABLE IF EXISTS LoginHistory;
DROP TABLE IF EXISTS ACCOUNTS;
DROP TABLE IF EXISTS ROLES;
