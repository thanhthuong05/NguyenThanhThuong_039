using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau01
{
    class  SinhVien
    {
        private string HoTen;
        private double diemToan;
        private double diemVan;
        private double diemNgoaiNgu;
        private string KhoiHoc;

        public SinhVien() { }
        public string hoTen
        {
            set { hoTen = value; }
            get { return hoTen; }
        }
        public double DiemToan
        {
            set { diemToan = value; }
            get { return diemToan; }
        }
        public double DiemVan
        {
            set { diemVan = value; }
            get { return diemVan; }
        }
        public double DiemNgoaiNgu
        {
            set { DiemNgoaiNgu = value; }
            get { return DiemNgoaiNgu; }
        }
        public string khoiHoc
        {
            set { khoiHoc = value; }
            get { return khoiHoc; }
        }
        public double TinhDiemTrungBinh()
        {
            double heSo = 1;
            switch (khoiHoc)
            {
                case 'A':
                    heSo = 2;
                    break;
                case 'B':
                    heSo = 2;
                    break;
                case 'C':
                    heSo = 2;
                    break;
            }
            return (diemToan + diemVan + diemNgoaiNgu) / 3;
        }
        public string XepLoai()
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
