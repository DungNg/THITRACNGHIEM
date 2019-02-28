using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiem
{
    class CauHoi
    {
        public int sttBode { get; set; }

        public string NoiDung { get; set; }

        public string CauA { get; set; }

        public string CauB { get; set; }

        public string CauC { get; set; }

        public string CauD { get; set; }

        public int DapAn { get; set; }

        public int? ChonDapAn { get; set; }

        public bool ChamDiem()
        {
            return (ChonDapAn == DapAn);
        }

        public CauHoi()
        {
            sttBode = 0;
            NoiDung = "";
            CauA = "";
            CauB = "";
            CauC = "";
            CauD = "";
            DapAn = 0;
            ChonDapAn = null;
        }

        public CauHoi(int sttBode, string pNoiDung, string pCauA, string pCauB, string pCauC, string pCauD, int pDapAn, int? pChonDapAn)
        {
            this.sttBode = sttBode;
            NoiDung = pNoiDung;
            CauA = pCauA;
            CauB = pCauB;
            CauC = pCauC;
            CauD = pCauD;
            DapAn = pDapAn;
            ChonDapAn = pChonDapAn;
        }
    }
}
