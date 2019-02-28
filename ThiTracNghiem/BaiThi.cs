using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiem
{
    class BaiThi
    {
        public ThiSinh thi_sinh { get; set; }

        public CauHoi[] cau_hoi { get; set; }

        public BaiThi()
        {
            thi_sinh = new ThiSinh();
            cau_hoi = new CauHoi[] { };
        }

        public BaiThi(ThiSinh thi_sinh, CauHoi[] cau_hoi)
        {
            this.thi_sinh = thi_sinh;
            this.cau_hoi = cau_hoi;
        }

        public float ChamBai()
        {
            int socaudung = 0;
            

            for (int i = 0; i < Program.Socauhoithi; i++)
            {
                if (cau_hoi[i] != null)
                {
                    String dapan = "";
                    String dapanChon = "null";
                    if (cau_hoi[i].ChonDapAn != null) // những câu hỏi đã chọn đáp án
                    {
                        if (cau_hoi[i].ChamDiem()) // nếu câu trả lời đúng
                        {
                            socaudung++;
                        }
                    }
                    switch (cau_hoi[i].DapAn)
                    {
                        case 1: dapan = "A"; break;
                        case 2: dapan = "B"; break;
                        case 3: dapan = "C"; break;
                        case 4: dapan = "D"; break;
                    }
                    switch (cau_hoi[i].ChonDapAn)
                    {
                        case 1: dapanChon = "A"; break;
                        case 2: dapanChon = "B"; break;
                        case 3: dapanChon = "C"; break;
                        case 4: dapanChon = "D"; break;
                        default: dapanChon = "null"; break;
                    }                                     
                        Program.Noidungthi += cau_hoi[i].sttBode.ToString() + ":" + dapanChon + ",";
                    
                }
            }
            float Diem = Program.DiemChoMoiCauHoi * socaudung;
            Math.Round((Decimal)Diem, 2, MidpointRounding.AwayFromZero);
            Program.DiemBaiThi = Diem;
            return socaudung; // Điểm đã được tính
        }

        public string Xuat()
        {
            return string.Format("{0}\r\nSố đáp án đúng : {1}/{2} \nĐIỂM : {3}", thi_sinh.Xuat(), ChamBai(), Program.Socauhoithi, Program.DiemBaiThi);
        }
    }
}
