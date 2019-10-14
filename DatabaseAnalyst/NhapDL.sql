INSERT INTO DANHMUC(TENDANHMUC) VALUES 
(N'Mainboard - Bo mạch chủ'),
(N'CPU - Bộ vi xử lý'),
(N'RAM - Bộ nhớ trong'),
(N'Ổ cứng HDD'),
(N'Ổ cứng SSD'),
(N'ODD - Ỗ đĩa quang'),
(N'VGA - Card màn hình'),
(N'Card âm thanh'),
(N'Case - Vỏ máy tính'),
(N'PSU - Nguồn máy tính'),
(N'Bàn phím - Chuột')

INSERT INTO NHANVIEN(USERNAME,PASSWORD,HOTEN,SDT,DIACHI,NAMSINH,LOAINHANVIEN,GIOITINH) VALUES 
('hoainam','hoainam1998',N'Nguyễn Khoa Hoài Nam','0987564321',N'Hùng Vương - Quy Nhơn','1998-01-01',0,0),
('thanhthien','thanhthien1998',N'Từ Thanh Thiện','0987564322',N'Ngô Mây - Quy Nhơn','1998-02-01',1,0),
('hoahau','hoahau2000',N'Nguyễn Thị Hoa Hậu','0987564324',N'An Dương Vương - Quy Nhơn','1998-02-04',2,1)

INSERT INTO NHACUNGCAP(TENNCC,DIACHI,FAX,EMAIL) VALUES 
('FPT Trading',N'Quận 3 - TP.Ho Chi Minh','0987654321','FPTTradinh@gmail.com'),
('Smart Tech',N'Quận 7 - TP.Ho Chi Minh','0987654324','SmartTech@gmail.com'),
('Dream Viet Trading',N'Quận Sơn Trà - TP.Đà Nẵng','0987654326','DreamViet@gmail.com'),
('Fast Trading',N'Quận 1 - TP.Ho Chi Minh','0987654330','FastTrading@gmail.com')

INSERT INTO HANG(TENHANG,THONGSO,BAOHANH,SOLUONG,GIA,NHASANXUAT,MADANHMUC) VALUES 
-- MAINBOARD
('Mainboard ASUS WS C621E SAGE (Dual CPU Workstations)',
N'Mainboard Asus WS C621E SAGE, 
sử dụng chipset C621 của Intel dành cho Workstations.
 Mainboard này hỗ trợ tới 2 bộ vi xử lý Intel Xeon Scalable 
 sử dụng socket LGA-3647, kèm theo khả năng ép xung cao cấp. 
 Asus WS C621E SAGE đáp ứng xử lý công việc lớn dành cho doanh nghiệp, 
 người làm trong các lĩnh vực thiết kế đồ họa, video, render, 
 phân tích dữ liệu, ảo hóa hay AI - Trí tuệ nhân tạo cần tới.'
 ,36,418,18990000,'ASUS',1),

 ('Mainboard Gigabyte H310M-DS2',
 N'CPU: Support for 8th Generation Intel® Core™ i7 processors/
 Intel® Core™ i5 processors/Intel® Core™ i3 processors/
 Intel® Pentium® processors/Intel® Celeron® processors in the LGA1151 package
L3 cache varies with CPU
Chipset	Intel® H310 Express Chipset
Bộ nhớ	• 2 x DDR4 DIMM sockets supporting up to 32 GB of system memory
• Dual channel memory architecture
• Support for DDR4 2666/2400/2133 MHz memory modules'
 ,36,744,1679000,'GIGABYTE',1),

 -- CPU 
 ('CPU Intel Core i5 9600K 3.7 GHz turbo up to 4.6 GHz /6 Cores 6 Threads/ 9MB /Socket 1151/Coffee Lake',
 N'Bộ vi xử lý Intel Core i5 9600K, 6 nhân 6 luồng, 9MB cache
Là sản phẩm dựa trên kiến trúc Coffee Lake Refresh thế hệ mới nhất
Bộ vi xử lý này có tần số cơ bản là 3.7 GHz turbo lên tới 4.6 GHz. Mức TDP 95W
Hỗ trợ RAM DDR4 2666 / Dual Channel'
 ,36,972,6299000,'INTEL',2),

  ('CPU Intel Core i5 9400 2.9 GHz turbo up to 4.1 GHz /6 Cores 6 Threads/ 9MB /Socket 1151/Coffee Lake',
 N'Bộ vi xử lý Intel Core i5 9400, 6 nhân 6 luồng, 9MB cache L3
Là sản phẩm dựa trên kiến trúc Coffee Lake Refresh thế hệ mới nhất
Bộ vi xử lý này có tần số cơ bản là 2.9 GHz Turbo lên tới 4.1GHz. Mức TDP 65W
Hỗ trợ RAM DDR4 2666 / Dual Channel'
 ,36,794,4599000,'INTEL',2),

 ('CPU Intel Core i7 - 7800X 3.5 GHz Turbo 4.0 GHz / 8.25MB / 6 Cores, 12 Threads / socket 2066',
 N'Sử dụng socket 2066 chạy trên mainboard X299 mới nhất và rất nhiều nâng cấp. 
 Nhờ công nghệ này, xung nhịp đơn và đôi nhân của CPU có thể được tăng lên đáng kể.

Bộ nhớ đệm được chia sẻ tối ưu và cân bằng, 
Intel Core i7 - 7800X bộ đệm tối đa trên mỗi nhân là 1.375 MB
 và sử dụng công nghệ bộ nhớ MLC sẽ mang lại hiệu năng xử lý cao hơn với độ trễ thấp.

Số lane PCIe hỗ trợ là 28, 
cùng 4 kênh RAM DDR4 tại 2400. Mức tiêu thụ điện năng chỉ 140W.
Sản phẩm này nhắm tới phân khúc người dụng máy trạm làm việc 
sản xuất nội dung số, game thủ và cộng đồng OC.'
 ,36,735,8999000,'INTEL',2),

  ('CPU Intel Core i7 9700K 3.6 GHz turbo up to 4.9 GHz /8 Cores 8 Threads/12MB /Socket 1151/Coffee Lake',
 N'Bộ vi xử lý Intel Core i7 9700K, 8 nhân 8 luồng, 12MB cache
Là sản phẩm dựa trên kiến trúc Coffee Lake Refresh thế hệ mới nhất
Bộ vi xử lý này có tần số cơ bản là 3.6 GHz turbo lên tới 4.9 GHz. Mức TDP 95W
Hỗ trợ RAM DDR4 2666 / Dual Channel'
 ,36,870,9699000,'INTEL',2),

 ('CPU Intel Core i9 9900K 3.6 GHz turbo up to 5.0 GHz / 8 Cores 16 Threads / 16MB / Socket 1151 / Coffee Lake',
 N'Bộ vi xử lý Intel Core i9 9900K, 8 nhân 16 luồng, 16MB cache
Là sản phẩm dựa trên kiến trúc Coffee Lake Refresh thế hệ mới nhất
Bộ vi xử lý này có tần số cơ bản là 3.6 GHz turbo lên tới 5.0 GHz. Mức TDP 95W
Hỗ trợ RAM DDR4 2666 / Dual Channel'
 ,36,847,12999000,'INTEL',2),

  ('CPU AMD Ryzen 5 3600X 3.8 GHz (4.4GHz Max Boost) / 36MB Cache / 6 cores / 12 threads / 95W',
 N'CPU Ryzen thế hệ thứ 3, tiến trình sản xuất 7nm
6 nhân, 12 luồng, xung nhịp mặc định 3.8 GHz, xung nhịp boost tối đa 4.4 GHz
Hỗ trợ PCI-e 4.0
Có hỗ trợ ép xung
Đi kèm tản nhiệt Wraith Spire'
 ,36,372,6490000,'AMD',2),

  ('CPU AMD Ryzen 7 3800X 3.9 GHz (4.5GHz Max Boost) / 36MB Cache / 8 cores / 16 threads / 105W',
 N'CPU Ryzen thế hệ thứ 3, tiến trình sản xuất 7nm
8 nhân, 16 luồng, xung nhịp mặc định 3.9 GHz, xung nhịp boost tối đa 4.5 GHz
Hỗ trợ PCI-e 4.0
Có hỗ trợ ép xung
Đi kèm tản nhiệt Wraith Prism với RGB LED'
 ,36,653,9990000,'AMD',2),

 --RAM
   ('DDRam 4 Kingston Predator RGB 8GB/2933-HX429C15PB3A/8',
 N'Chủng loại	Predator RGB
Dung lượng	8GBx1
Kiểu Ram	DDR4
Bus Ram hỗ trợ	2933 Mhz
Độ trễ	17 CL(IDD)
Tản nhiệt	Led RGB
Điện áp	1.2V'
 ,36,169,3149000,'Kingston',3),

 ('Ram Cosair 32GB/3200 (2x16G)  CMW32GX4M2C3200C16  - Vengeance RGB Pro',
 N'Chủng loại: Bộ nhớ trong
Hãng sản xuất: Corsair
Series: Vengeance PRO RGB
Loại RAM: DDR4
Đóng gói: 32GB (2x16GB)
Bus: 3200MHz
Độ trễ: 16-18-18-36
Điện áp: 1.35V
Tản nhiệt: Nhôm truyền thống'
 ,36,770,6999000,'Cosair',3),

 ('Kit Ram 4 Gskill Trident Z Royal 16GB/3600 (2x8GB) F4-3600C18D-16GTRS',
 N'Chủng loại Trident Z Royal
Dung lượng	16GB
Kiểu Ram	DDR4
Bus Ram hỗ trợ	3600 Mhz
Độ trễ	18-22-22-42'
 ,36,480,4.999000,'Gskill',3),

 --hdd
  ('HDD Western Purple 2TB/5400 Sata 3 64Mb',
N'Ổ cứng gắn trong Western Purple 2TB chuyên dụng cho thiết bị giám sát, 
đầu ghi camera, thích hợp sử dụng cho các cá nhân, 
văn phòng hoặc các doanh nghiệp với hệ thống lên đến 64 camera.
Thông số kỹ thuật: dung lượng 2TB; giao tiếp SATA 3 (6Gb/s max); 
64MB Cache, tốc độ quay 5400RPM. Công nghệ AllFrame tối ưu hóa, cải thiện hiệu suất, giảm tỉ lệ lỗi/khung.
HDD WD PURPLE 2TB là dòng ổ cứng sản xuất ra để chuyên dùng cho thiết bị ghi hình Camera giám sát, c
hạy rất êm, giải nhiệt tốt bằng 70% so với ổ cứng PC thông thường, 
thích hợp trong hệ thống camera giám sát tại nhà và doanh nghiệp vừa và nhỏ.'
 ,36,607,1590000,'Western Digital',4),

   ('HDD Seagate SkyHawk SURVEILLANCE 6TB/7200, Sata 3, 256MB Cache',
N'Tối ưu hóa cho DVR và NVRs, ổ cứng giám sát Skyhawk được điều chỉnh

để làm việc 24x7 với dung lượng tới 10 TB. trang bị tăng cường firmware

ImagePerfect giảm thiểu thời gian chết đồng thời xử lý công việc nhanh 

hơn 3 lần so với ổ cứng máy tính để bàn và hỗ trợ lên đến 64 camera HD.'
 ,36,372,5570000,'SEAGATE',4),

-- ssd
('SSD Samsung 860 EVO 500GB SATA3 6Gb/s 2.5" ( Đọc 550MB/s, Ghi 520MB/s)',
N'Hãng sản xuất
Samsung

Chủng loại
860 EVO

Dung lượng
500GB

Chuẩn kết nối
SATA III 6Gb/s.

Kích thước
2.5"

Tốc độ Đọc
lên tới 550MB/s

Tốc độ Ghi
lên tới 520MB/s

Chíp nhớ
3D V-NAND'
 ,60,372,2789000,'SAMSUNG',5),

 ('SSD Plextor PX-256M8VC Series 256GB SATA3 6Gb/s 2.5" (Doc 560MB/s, Ghi 510MB/s)',
N'Hãng sản xuất	Plextor
Chủng loại	M8VC
Dung lượng	256GB
Chuẩn cắm	Sata 3
Tốc độ đọc	lên tới 560MB/s'
 ,36,188,1099000,'PLEXTOR',5),

  ('SSD Kingston SSDNow UV500 240GB Sata3 2.5',
N'Chủng loại	UV500
Dung lượng	240GB
Chuẩn cắm	Sata 3
Tốc độ	Đọc 520MB/s, Ghi 500MB/s
Loại ổ cứng	3D NAND
Kích thước	2.5”'
 ,60,612,1190000,'Kingston',5),


 --vga
   
('Vga Card Gigabyte N107TGAMING-8GD',
N'Chủng loại
NVIDIA® GeForce® GTX 1070 Ti

Core Clock
1721 MHz / 1632 MHz (OC Mode)
1683 MHz / 1607 MHz (Gaming Mode)

Cuda Cores
2432 Units

Memory Clock Speed
8008 MHz

Bộ nhớ/ băng thông
8GB DDR5 / 256-bit

Chuẩn giao tiếp
PCI Express 3.0 x16

Cổng giao tiếp
DisplayPort x 2 (v1.4) / HDMI x 2 (v2.0) / DL-DVI-D

Kích thước
H=41 L=280 W=114 mm

DirectX
DirectX 12

Độ phân giải tối đa
7680x4320

Điện năng tiêu thụ
180 W

Đề nghị sử dụng nguồn
500 W hoặc hơn

Nguồn phụ
8-pin x 1

Hỗ trợ SLI
Có'
 ,36,745,10690000,'GIGABYTE',7),

 ('VGA Card nVidia Quadro P2200 5GB GDDR6',
N'Hãng sản xuất
MSI

Chủng loại
Radeon™ RX 5700 XT

GPU
NAVI 10 XT

Chuẩn giao tiếp
PCI Express 4.0

Bộ nhớ VGA
GDDR6 8GB

Băng thông
256-bit

Memory Speed
14 Gbps

Engine Clock
1925 MHz (OC Mode)
1815 MHz (Gaming Mode)

Cổng giao tiếp
HDMI Output 2.0b: Yes x 1
Display Port 1.4 : Yes x 3 
HDCP Support 2.2: Yes

Nguồn yêu cầu
750 W

Kích thước
232 x 126 x 46 mm'

 ,36,691,9999000,'MSI',7),

 ('VGA Card NVidia Quadro P2200 5GB GDDR66',
N'NVIDIA Quadro P2200
Pascal GPU
1,280 NVIDIA® CUDA® Cores
5GB GDDR5x Memory
Display Resolution:
4x 4096x2160 @ 120Hz
4x 5120x2880 @ 60Hz'
 ,36,832,11999000,'NVidia',7),

 --CASE
 ('Case Asus TUF Gaming GT501VC - Tempered Glass Mid-Tower',
N'Hãng sản xuất
ASUS

Model
TUF Gaming GT501VC

Loại case
Mid Tower

Màu sắc
Đen

Hỗ trợ mainboard
E-ATX(12”x10.9”), ATX, Micro ATX, Mini ITX

Khay lắp ổ 3.5''
4 x 3.5’’ or 2.5’’

Khay lắp ổ 2.5''
3 x 2.5''

Khe mở rộng
7 +2 (khe dựng dọc)

Cổng kết nối
2 x USB 3.1 Gen1
1 x Headphone
1 x Microphone

Hệ thống làm mát
Front: 2 x 140mm/ 3 x 120mm
Top: 2 x 140mm/ 3 x 120mm
Rear: 1 x 140mm/120mm

Chiều dài tối đa GPU
420mm

Chiều cao tối đa tản nhiệt CPU
180mm

Kích thước
251 x 545 x 552 mm

Trọng lượng
9.9kg

Hỗ trợ radiator
Front: 120, 140, 240, 280, 360 mm
Top 120, 140, 240, 280, 360 mm
Rear: 120, 140mm'
 ,36,434,2990000,'ASUS',9),

  ('Case Golden Field G20 Full Tower- Sói Bạc',
N'Hãng sản xuất
GOLDEN FIELD

Chủng loại
GOLDEN FIELD G20

Kích thước (rộng x dài x cao)
558(L) x 531(H) x 261(W)

Chất liệu
Khung Thép (SECC) + Mặt lưới sắt tản nhiệt siêu mạnh.

Màu
Trắng

Chuẩn Mainboard
ATX/Micro ATX

Khe cắm mở rộng
N/A

Khay 5.25”
0

Khay 3.5''
2

Khay 2.5”
2

Cổng giao tiếp bên ngoài
USB 3.0, usb 2.0, và tai nghe  + microphone

Hệ thống làm mát
Hỗ trợ 3 quạt
     + Sau: 120 x 120mm fan LED x 1 (Có sẵn)
     + Nóc: 120 x 120 mm fan LED x 1 (Có sẵn)

Tản nước tương thích
N/A

Phụ kiện đi kèm
Ốc vít, vỏ thùng

Khả năng tương thích
Hỗ trợ VGA 260mm, CPU: 135MM'
 ,36,460,4299000,'Golden Field',9),

 ('Case Thermaltake View 91 RGB Tempered Glass (CA-1I9-00F1WN-00)',
N'Hãng sản xuất
THERMALTAKE

Chủng loại
Case Thermaltake View 91 RGB Tempered Glass )CA-1I9-00F1WN-00)

Kích thước (rộng x dài x cao)
691 x 344 x 645 mm

Chất liệu
Thép cao cấp, nhôm cao cấp, kính cường lực

Màu
Đen

Chuẩn Mainboard
Mini-ITX, Micro-ATX, ATX, E-ATX, XL-ATX

Khe cắm mở rộng
10+2

Khay 5.25”
N/A

Khay 3.5''
12

Khay 2.5”
12

Cổng giao tiếp bên ngoài
USB3.0 × 4, USB3.1 Type-C × 1, Audio × 1, Mic × 1 (hỗ trợ HD Audio)

Hệ thống làm mát
Phía trước: 120mm x 4 fan / 140mm x 3 fan
Phía trên: 120mm x 4 fan / 140mm x 3 fan / 200mm x 2 fan
Phía hông (sau tray MB): 120mm x 8 fan / 140mm x 8 fan / 200mm x 6 fan
Phía sau: 120mm x 1 fan / 140mm x 1 fan
Phía đáy: 120mm x 3 fan / 140mm x 3 fan

Tản nước tương thích
Phía trước: 120 / 140 / 240 / 280 / 360 / 420 / 480 radiator 
Phía trên: 120 / 140 / 240 / 280 / 360 / 420 / 480 radiator 
Phía hông(sau tray MB): 120 / 140 / 240 / 280 / 360 / 420 / 480 radiator
Phía sau: 120 / 140 radiator
Phía đáy: 120 / 140 / 240 / 280 / 360 / 420 radiator 

Phụ kiện đi kèm
Ốc vít, vỏ thùng

Chuẩn nguồn
ATX PS2

Khả năng tương thích
Chiều dài VGA tối đa: 470mm
Chiều cao tản CPU tối đa: 200mm'
 ,36,504,11899000,'Thermaltake',9),

 --psu
 ('Nguồn SeaSonic 750W M12II EVO - 80 PLUS®BRONZE - FULL MODULAR (M12II-750 EVO) (750GM2)',
N'Hãng sản xuất
Seasonic

Chủng loại
750W M12II Bronze Evo Edition

Chuẩn nguồn
ATX

Tiêu chuẩn chất lượng
80 PLUS® Bronze

Mầu
Sơn tĩnh điện đen toàn bộ

Công suất danh định
750w

Công suất thực
đạt mức tải 100% / công suất danh định

Đầu cấp điện cho main
20+4Pin

Đầu cấp điện cho hệ thống
1 x 20+4-pin.
1 x 8-pin CPU
1 x (4+4)-pin CPU
4 x 8(6+2)-pin PCI-E
8 x SATA
5 x Molex
2 x Floppy

Quạt
120mm chống ồn

Đường điện vào
100-240V

Phụ kiện đi kèm
Hộp, Sách, Dây nguồn'
 ,60,301,2599000,'SeaSonic',10),

 ('Nguồn máy tính Raidmax RX-735AP-R 80 plus Bronze',
N'Hãng sản xuất
RAIDMAX

Chủng loại
Nguồn máy tính Raidmax RX-735AP-R 80 plus Bronze

Chuẩn nguồn
Support with Intel ATX12V V2.3

Tiêu chuẩn chất lượng
Chứng chỉ 80 Plus Bzone   - Tuổi thọ 100,000 giờ

Màu
Sơn tĩnh điện đen toán bộ LED RGB

Công suất danh định
735W

Công suất thực
>79%

Đầu cấp điện cho main
M/B 20+4pin * 1
CPU4 +4pin * 1
PCI-E 6+2 PIN *4
SATA * 8
Molex 4pin * 3
Đĩa mềm * 1

Đầu cấp điện cho hệ thống
- Output :
+5V 20A
+3.3V 20A
+12V1 53A
-12V 0.3A
-5Vsb 2.5A

Bảo vệ đầy đủ với OVP, UVP, OPP, và SCP
Quạt

Quạt hệ thống : 13,5cm Fan * 1
Đường điện vào
Input: 100-240VAC, 15 / 7A, 50 / 60HZ

Phụ kiện đi kèm
Hộp, Dây nguồn, sách hướng dẫn'
 ,60,310,4999000,'Raidmax',10),

  ('Nguồn Thermaltake Toughpower iRGB 1200W - Platinum (PS-TPI-1200F2FDPE-1)',
N'Model
 Thermaltake Toughpower iRGB PLUS 1200W

Type
ATX 12V v2.4 and EPS v2.92

PFC
Active PFC
80 PLUS Certification
Platinum

Input Voltage
100-240 Vac

Input Curent
14 A

Input Frequency
50-60 Hz

Max Power
1200 W

Color
Black

Fan Type
hydraulic bearing fan, 140 mm

Efficiency
>94%

Dimensions(W x H x L)
150 × 86 × 180 mm'
 ,60,246,6189000,'Thermaltake',10),

 --ban phim chuot
 ('Mouse Fuhlen G300L Optical USB - Gaming',
N'Thương hiệu
Fuhlen

Chủng loại
Chuột máy tính có dây gaming

Chuẩn kết nối
USB 2.0

Màu sắc
Đen

Đèn led
N/A

Độ phân giải
2000/4000/6000/8000 DPI

Mắt đọc
Optical

Kích thước
13.5 x 7.2 x 4.0 cm

Trọng lượng
95gr

Hệ điều hành hỗ trợ
Windows (XP, Vista, 7&8), Mac OS

Phụ kiện
Đĩa driver, sách'

 ,24,100,1509000,'Fuhlen',11),

  ('Mouse Logitech G302 USB Black',
N'Chuột được thiết kế cho Game thủ chuyên nghiệp. G302 MOBA Gaming Mouse.
Chuột Logitech G302 sử dụng cảm biến quang học công nghệ Logitech Delta Zero™.
Tích hợp 6 nút có thể lập trình được, gán các tác vụ khác '

 ,24,188,1509000,'Logitech',11),

  ('Keyboard Vortex 3 Limited Edition Cherry Red switch',
N'Thương hiệu bàn phím cơ cao cấp của Đài Loan
Phiên bản Limited của dòng Poker 3
Toàn bộ phím được gia cố bằng nhôm nguyên khối
Độ bền siêu bền bỉ theo thời gian
Thiết kế Mini cực kì nhỏ gọn'

 ,24,550,4199000,'Vortex',11),

  ('Keyboard Durgod V104S RGB Mechanical Cherry Brown Switch Black',
N'Thương hiệu bàn phím cơ Durgod hoàn toàn mới
Được sản xuất và lắp ráp tại nhà máy uy tín tại Trung Quốc
Chất lượng tổng thể cứng cáp, chắc chắn
Switch sử dụng 100% Cherry MX from Germany
Anti-Ghosting 100% và NKRO qua cổng USB'

 ,24,838,2499000,'Durgod',11)










