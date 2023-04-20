using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapThongTinSinhVien
{
    class Hocsinh
    {
        public string Hoten;
        public double DiemToan;
        public double DiemVan;
        public double DiemAnhVan;
        public double DiemTrungbinh;
    }
    internal class Program
    {
        class Hocsinh
        {
            public string Hoten;
            public double DiemToan;
            public double DiemVan;
            public double DiemAnhVan;
            public double DiemTrungbinh;

            public Hocsinh NhapThongTinHocSinh()
            {
                Hocsinh hs = new Hocsinh();
                Console.Write("Nhap ho ten hoc sinh: ");
                hs.Hoten = Console.ReadLine();
                Console.Write("Nhap diem toan: ");
                hs.DiemToan = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem van: ");
                hs.DiemVan = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem anh van: ");
                hs.DiemAnhVan = double.Parse(Console.ReadLine());
                hs.DiemTrungbinh = (hs.DiemToan + hs.DiemVan + hs.DiemAnhVan) / 3;
                Console.WriteLine("Diem trung binh cua hoc sinh la: " + hs.DiemTrungbinh);
                Console.WriteLine("======================");
                return hs;
            }
            public void XuatThongTinHocSinh()
            {
                Console.WriteLine("Thong tin hoc sinh:");
                Console.WriteLine("Ho ten: " + Hoten);
                Console.WriteLine("Diem Toan: " + DiemToan);
                Console.WriteLine("Diem Van: " + DiemVan);
                Console.WriteLine("Diem Anh Van: " + DiemAnhVan);
                Console.WriteLine("Diem Trung Binh: " + DiemTrungbinh);
            }
            public static void DiemTrungBinhCaoNhat(List<Hocsinh> mylist, int n)
            {
                Console.WriteLine("Hoc sinh co Diem Trung Binh cao nhat: ");
                //int max = a[0];
                //for (int i = 1; i < n; i++)
                //    if (a[i] > max)
                //        max = a[i];
                //cout << "max = " << max << endl;
                //return max;
                //int Max = DiemTrungBinhCaoNhat();
            }



            static void Main(string[] args)
            {
                //Khởi tạo danh sách học sinh
                List<Hocsinh> listhocsinh = new List<Hocsinh>();
                Console.Write("Nhap so luong hoc sinh: ");
                string SoLuongHocSinh = Console.ReadLine();

                // Kiểm tra chữ số nhập vào có phải số nguyên hay k
                int KiemTraSoNguyen = int.Parse(SoLuongHocSinh);

                //Thực hiện vòng lặp để nhập thông tin học sinh
                for (int i = 0; i < KiemTraSoNguyen; i++)
                {
                    Hocsinh hs = new Hocsinh();
                    Console.WriteLine("Thong tin hoc sinh thu " + (i + 1));
                    hs = hs.NhapThongTinHocSinh();
                    listhocsinh.Add(hs);
                }

                //Thực hiện vòng lặp để xuất thông tin học sinh
                foreach (Hocsinh hs in listhocsinh)
                {
                    hs.XuatThongTinHocSinh();
                }

                //Sắp xếp theo ddiemr trung bình từ thấp đến cao

                listhocsinh.Sort(
                    (p1, p2) =>
                    {
                        if (p1.DiemTrungbinh == p2.DiemTrungbinh) return 0;
                        if (p1.DiemTrungbinh < p2.DiemTrungbinh) return -1;
                        return 1;
                    }
                    );
                //In ra màn hình điểm trung bình từ thấp đến cao
                Console.WriteLine("====================");
                Console.WriteLine("Diem TB tu thap den cao:");



                //Thực hiện vòng lặp để xuất thông tin học sinh
                foreach (Hocsinh hs in listhocsinh)
                {
                    Console.WriteLine($"{hs.Hoten} - {hs.DiemTrungbinh}");
                }
                // Xuất ra màn hình học sinh có điểm trung bình cao nhất
            }
                
        }
    }
}

