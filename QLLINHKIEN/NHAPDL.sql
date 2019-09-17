-- DANHMUC 
INSERT INTO DANHMUCLOAIHANG(TENDM) VALUES
('CPU - BO VI XU LI'), --1
('MAINBOARD - BO MACH CHU'),--2
('RAM - BO NHO TRONG'),--3
('O CUNG HDD'),--4
('O CUNG SSD'),--5
('ODD - O DIA QUANG'),--6
('VGA - CARD MAN HINH'),--7
('CARD AM THANH'),--8
('CASE - VO MAY TINH'),--9
('PSU - NGUON MAY TINH'),--10
('BAN PHIM - CHUOT')--11

-- LOAI HANG
INSERT INTO LOAIHANG(TENHANG,MADM) VALUES 
-- CPU
('Intel Core i3',1),
('Intel Core i5',1),
('Intel Core i7',1),
('Intel Core i9',1),
('AMD Ryzen 7',1),
('AMD Ryzen 9',1),

--MAIN
('Main ASUS',2),
('Main Asrock',2),
('Main GIGABYTE',2),
('Main MSI',2),
('Main INTEL H SERIES',2),
('Main INTEL B SERIES',2),
('Main INTEL Z SERIES',2),
('Main AMD A SERIES',2),
('Main AMD B SERIES',2),
('Main AMD Z SERIES',2),

-- RAM
('RAM ADATA',3),
('RAM ANTEC',3),
('RAM KINGMAX',3),
('RAM KINGSTON',3),
('RAM TEAM',3),

-- VGA
('VGA ASUS',7),
('VGA GIGABYTE',7),
('VGA GALAX',7),
('VGA MSI',7),
('VGA GTR SERIES',7),
('VGA GTR SUPER',7),
-- O CUNG SSD
('O CUNG SSD 2.5',5),
('O CUNG M.2 SATA',5),
('O CUNG M.2 NVME',5),
('O CUNG SSD 2.5',5),
('O CUNG SSD 240G-256G',5),
('O CUNG SSD 480G-512G',5),
('O CUNG SSD >960G',5),

-- O CUNG HDD
('O CUNG DESKTOP',4),
('O CUNG LAPTOP',4),
('O CUNG 2.5 INCH',4),
('O CUNG 3.5 INCH',4),

-- BAN PHIM - CHUOT
('BO BAN PHIM ,CHUOT',11),
('BAN PHIM',11),
('CHUOT MAY TINH',11),
('PHU KIEN BAN PHIM CHUOT',11),
('BAN DI CHUOT',11),

-- PSU - NGUON MAY TINH
('NGUON DUOI 400W',10),
('NGUON TU 400W-550W',10),
('NGUON TU 550W-650W',10),
('NGUON TU 650W-800',10),
('NGUON TU 800W-1000W',10),
('NGUON TREN 1000W',10),

-- CASE 
('VO CASE >1 TRIEU',9),
('VO CASE 1 - 2 TRIEU',9),
('VO CASE 2 - 3 TRIEU',9),
('VO CASE TREN 3 TRIEU',9),
('VO CASE MINI TOWER',9),
('VO CASE MID TOWER',9),
('VO CASE SUPER FULL TOWER',9)

SELECT *FROM LOAIHANG;
SELECT *FROM HANG;
-- HANG
INSERT INTO HANG(TENHANG,THONGSO,BAOHANH,SOLUONG,GIA,MALOAIHANG) VALUES 
('CPU Intel Pentium Gold G5400 ',N'Tiến trình sản xuất 14nm
2 nhân, 4 luồng, xung nhịp cơ bản 3.7 GHz, không có Turbo boost
Hỗ trợ RAM DDR4, bus tối đa 2400 MHz
Tích hợp card đồ hoạ Intel® UHD Graphics 610
Có đi kèm quạt tản nhiệt',36,145331, 3199000,1),
('CPU Intel Core i3-9100F',N'Intel Core i3 9100
Là sản phẩm dựa trên kiến trúc Coffee Lake Refresh thế hệ mới nhất
Bộ vi xử lý này có tần số cơ bản là 3.7 GHz. Mức TDP 65W
Hỗ trợ RAM DDR4 2400 / Dual Channel',36,35754, 2199000,1),
('CPU Intel Core i3-7100 3.9 GHz / 3MB / HD 630 Series Graphics / Socket 1151 (Kabylake)',36,145332, 3199000,1),

('CPU Intel Core i5 9400 2.9 GHz turbo up to 4.1 GHz /6 Cores 6 Threads/ 9MB /Socket 1151/Coffee Lake',36,34859, 4599000,2),
('CPU Intel Core i5 9600K 3.7 GHz turbo up to 4.6 GHz /6 Cores 6 Threads/ 9MB /Socket 1151/Coffee Lake',36,39850, 6299000 ,2),
('CPU Intel Core i5-9600KF 3.70Ghz Turbo up to 4.60GHz / 9MB / 6 Cores, 6 Threads / Socket 1151 / Coffee Lake',36,5834, 6799000 ,2),

('CPU Intel Core i7 - 7800X 3.5 GHz Turbo 4.0 GHz / 8.25MB / 6 Cores, 12 Threads / socket 2066',36,39371,8999000 ,3),
('CPU Intel Core i7 - 7820X 3.6 GHz Turbo 4.3 Up to 4.5 GHz / 11MB / 8 Cores, 16 Threads / socket 2066',36,47735,15199000 ,3),
('CPU Intel Core i7-9800X 3.8 GHz Turbo 4.4 GHz up to 4.5 GHz / 16.5 MB / 8 Cores, 16 Threads / socket 2066 (No Fan)',36,3462,19900000 ,3),

('CPU Intel Core i9 9900K 3.6 GHz turbo up to 5.0 GHz / 8 Cores 16 Threads / 16MB / Socket 1151 / Coffee Lake',36,82671,12999000 ,4),
('CPU Intel Core i9 7920X 2.9Ghz Turbo 4.3 Up to 4.4Ghz / 16.5MB / 12 Cores, 24 Threads / Socket 2066',36,12447,28599000 ,4),
('CPU Intel Core i9 7980XE EXTREME EDITION 2.6 GHz Turbo up to 4.2 GHz / 24.75 MB / 18 Cores, 36 Threads / Socket 2066',36,63429,53999000 ,4),

('CPU AMD Ryzen 7 3700X 3.6 GHz (4.4GHz Max Boost) / 36MB Cache / 8 cores / 16 threads / 65W',36,7126,8690000 ,5),
('CPU AMD Ryzen 7 3800X 3.9 GHz (4.5GHz Max Boost) / 36MB Cache / 8 cores / 16 threads / 105W',36,2299, 9990000 ,5),

('CPU AMD Ryzen 9 3900X 3.8 GHz (4.6GHz Max Boost) / 70MB Cache / 12 cores / 24 threads / 105W',36,6848, 13090000 ,6),

('Mainboard Asus ROG STRIX Z390-E GAMING',36,832,5759000 ,7),
('Mainboard Asus TUF X299 MARK 1',36,5210, 8399000 ,7),

('Mainboard Asrock X570 Taichi',36,1720, 8259000 ,8),
('Mainboard Asrock X570 Steel Legend',36,1326,5859000 ,8),


('Mainboard Gigabyte Z390 Aorus Xtreme',36,7879,14699000 ,9),
('Mainboard Gigabyte Z390 Aorus Ultra ',36,15713,6499000 ,9),

('Mainboard MSI MPG X570 GAMING EDGE Wi-Fi',36,1269, 6599000 ,10),
('Mainboard MSI MPG Z390 GAMING PLUS',36,9077, 4099000,10),

('Mainboard INTEL PRIME H310M-D',36,18419, 1699000,11),

('Mainboard INTEL B360-F GAMING',36,5763,3099000 ,12),

('Mainboard INTEL PRIME Z390-P',36,331,3199000 ,13),

('Mainboard AMD A320M GAMING PRO',36,74916,2129000 ,14),

('Mainboard AMD B450 AORUS - M',36,9577,2499000 ,15),

('Mainboard AMD Z470 Gaming Pro Carbon',36,355,4899000 ,16),

('DDRam 4 Adata Spectrix D80 32GB/3200 (2x16GB) - Red',36,586,6990000 ,17),

('DDRam 4 ANTECMEMORY 16GB/3000 (2*8GB) 5D - RGB Led',36,509,2499000 ,18),

('DDRam 4 Kingmax Zeus RGB 16GB/3000 - KMAXD4RGB16GB3000',36,715, 2599000,19),

('Kit Ram 4 Kingston HyperX Predator RGB 16GB/3200 (2*8GB)-HX432C16PB3AK2/16',36,1041,2799000,20),

('RAM Team Delta RGB 16GB/3000MHz (2*8GB) LED Black',36,973,2599000,21),

('Vga Card ASUS ROG STRIX RTX 2060 - O6G GAMING',36,366,10599000,22),
('Vga Card ASUS DUAL RTX 2080 - O8G',36,659,20999000,22),

('Vga Card Gigabyte AORUS RTX 2080Ti XTREME WATERFORCE WB 11G',36,878,41400000,23),

('VGA Galax RTX 2060 (1 Click OC) - 6GB DDR6 ',36,197,9490000,24),

('Vga Card MSI RTX 2060 GAMING Z 6G',36,9047,10899000,25),

('Vga Card EVGA GeForce GTX 1660 SC ULTRA GAMING 6GB',36,1303,6690000,26),

('Vga Card Asus ROG STRIX GTR 2070S-O8G-GAMING',36,931,16999000,27),

('SSD Samsung 860 EVO 500GB SATA3 6Gb/s 2.5',36,701,2789000,28),

('Samsung 860 EVO 1TB M2 SATA 6Gb/s',36,791,5499000 ,29),

('Samsung 860 EVO 1TB M2 SATA 6Gb/s',36,791,5499000 ,29)




































SELECT *FROM HANG




 


















