using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiem
{
    class ThiSinh
    {
        public string MaSV { get; set; }

        public string HoTen { get; set; }

        public DateTime NgaySinh { get; set; }


        public ThiSinh()
        {
            MaSV = "";
            HoTen = "";
            NgaySinh = DateTime.Today;

        }

        public ThiSinh(string pMaSV, string pHoTen, DateTime pNgaySinh)
        {
            MaSV = pMaSV;
            HoTen = pHoTen;
            NgaySinh = pNgaySinh;

        }

        public string Xuat()
        {
            string kq = "KẾT QUẢ LÀM BÀI THI TRẮC NGHIỆM";
            kq += "\nSinh Viên  : " + HoTen + ".\nMã Sinh Viên : " + MaSV + " ." + "\nNgày sinh : " + NgaySinh.ToString("dd/MM/yyy") + ".";
            return kq;
        }
    }
}
