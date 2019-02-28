using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace ThiTracNghiem
{
    public partial class FrmThi : DevExpress.XtraEditors.XtraForm
    {
        private CauHoi[] dscauhoi = new CauHoi[99];
        public int stt = 0;
        public FrmThi()
        {
            InitializeComponent();
        }

        private void FrmThi_Load(object sender, EventArgs e)
        {
            panel6.Visible = false;
            groupBox4.Enabled = false; //4 radio button chon cau hoi
            LayThongTin();
            LbOff(true);
        }


        private System.Windows.Forms.Timer timer1;
        private int counter;
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
            LbOff(false);
            counter = (Program.Thoigianthi) * 60;
            Laydethi();
            xuatcauhoi(stt);
            start();
        }

        private void start()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();

            //for (int i = 0; i < Program.Socauhoithi; i++)
            //{
            //    GroupBox dapan = new GroupBox
            //    {
            //        Name = "" + (i + 1),
            //        Size = new Size(39, 115),
            //        Text = "" + (i + 1)
            //    };
            //    RadioButton rd1 = new RadioButton
            //    {
            //        Name = "A" + dapan.Name,
            //        Location = new Point(5, 20),
            //    };
            //    rd1.MouseClick += check_Click;
            //    RadioButton rd2 = new RadioButton
            //    {
            //        Name = "B" + dapan.Name,
            //        Location = new Point(5, 45)
            //    };
            //    rd2.MouseClick += check_Click;
            //    RadioButton rd3 = new RadioButton
            //    {
            //        Name = "C" + dapan.Name,
            //        Location = new Point(5, 70)
            //    };
            //    rd3.MouseClick += check_Click;
            //    RadioButton rd4 = new RadioButton
            //    {
            //        Name = "D" + dapan.Name,
            //        Location = new Point(5, 95)
            //    };
            //    rd4.MouseClick += check_Click;
            //    dapan.Controls.Add(rd1);
            //    dapan.Controls.Add(rd2);
            //    dapan.Controls.Add(rd3);
            //    dapan.Controls.Add(rd4);
            //    flowLayoutPanel1.Controls.Add(dapan);
            //}
        }

        //void check_Click(object sender, EventArgs e)
        //{
        //    for(int i=0;i<Program.Socauhoithi;i++)
        //    {

        //    }
        //}

        private void LayThongTin()
        {
            try
            {
                if (Program.mGroup == "SINHVIEN")
                {
                    SqlDataReader rd = Program.ExecSqlDataReader("EXEC SP_Laythongtinsv '" + Program.username + "'");
                    rd.Read();
                    lbNgaysinh.Text = rd.GetDateTime(3).ToString("dd/MM/yyyy");

                    lbMalop.Text = Program.Lopthi;
                    lbMasv.Text = Program.username;
                    lbTensv.Text = Program.mHoten;
                    lbMonthi.Text = Program.Monthi;
                    lbNgaythi.Text = Program.Ngaythi.ToString();
                    lbLanthi.Text = Program.Lanthi.ToString();
                    rd.Close();
                }
                else
                {
                    lbNgaysinh.Text = DateTime.Today.ToString();
                    lbMalop.Text = Program.Lopthi;
                    lbMasv.Text = "GIÁO VIÊN THI THỬ";
                    lbTensv.Text = "GIÁO VIÊN THI THỬ";
                    lbMonthi.Text = Program.Monthi;
                    lbNgaythi.Text = Program.Ngaythi.ToString();
                    lbLanthi.Text = Program.Lanthi.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy thông tin sinh viên! " + ex.Message);
            }
        }

        private void LbOff(bool x)
        {
            btnBatdau.Enabled = x;
            btnNopbai.Enabled = !x;
            lbStt.Visible = !x;
            lbCauhoi.Visible = !x;
            //lbA.Visible = !x;
            //lbB.Visible = !x;
            //lbC.Visible = !x;
            //lbD.Visible = !x;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                lbConlai.Text = "00:00";
                Nopbai();                
            }
            lbConlai.Text = counter / 60 + ":" + ((counter % 60) >= 10 ? (counter % 60).ToString() : "0" + counter % 60);
        }

        private void btnNopbai_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
            groupBox4.Enabled = false;
            counter = 0;
            LbOff(false);
            Nopbai();

        }        

        void Nopbai()
        {
            if (Program.mGroup == "SINHVIEN")
            {
                BaiThi bai_thi = new BaiThi();
                bai_thi.thi_sinh = new ThiSinh(Program.username, Program.mHoten, DateTime.Parse(lbNgaysinh.Text));
                bai_thi.cau_hoi = dscauhoi;
                btnNopbai.Enabled = false;
                timer1.Stop();
                //btnTruoc.Enabled = false;
                //btnSau.Enabled = false;                
                MessageBox.Show(bai_thi.Xuat(), "KẾT QUẢ");

                // Sau khi có kết quả thi thì ghi kết quả vào table : BANGDIEM
                //MessageBox.Show(Program.Noidungthi);
                GhiDiem();
            }
            else
            {
                BaiThi bai_thi = new BaiThi();
                bai_thi.thi_sinh = new ThiSinh(Program.username, Program.mHoten, DateTime.Parse(lbNgaysinh.Text));
                bai_thi.cau_hoi = dscauhoi;
                btnNopbai.Enabled = false;
                timer1.Stop();
                //btnTruoc.Enabled = false;
                //btnSau.Enabled = false;                
                MessageBox.Show(bai_thi.Xuat(), "KẾT QUẢ");
            }
        }

        void Laydethi()
        {
            int sttMang = 0;
            string lenh = "EXEC SP_LAYDETHI '" + lbMalop.Text + "','" +lbMonthi.Text + "','" + lbLanthi.Text + "','" + Program.Macs + "'";
            SqlDataReader rd;
            // SP trả về thứ tự các Field : 
            // 0 CAUHOI 1 MAMH 2 TRINHDO 3 NOIDUNG 4A 5B 6C 7D 8DAPAN 9MAGV
            try
            {
                rd = Program.ExecSqlDataReader(lenh);
                // Ghi toàn bộ câu hỏi được trả về vào 1 mảng
                if (rd.HasRows)
                {
                    for (sttMang = 0; sttMang < Program.Socauhoithi; sttMang++)
                    {
                        rd.Read();
                        int sttBode = rd.GetInt32(0);
                        String noidung = rd.GetString(3);
                        String a = rd.GetString(4);
                        String b = rd.GetString(5);
                        String c = rd.GetString(6);
                        String d = rd.GetString(7);
                        String strDapan = rd.GetString(8);
                        int dapAn = 0;
                        if (strDapan == "A")
                        {
                            dapAn = 1;
                        }
                        else if (strDapan == "B")
                        {
                            dapAn = 2;
                        }
                        else if (strDapan == "C")
                        {
                            dapAn = 3;
                        }
                        else if (strDapan == "D")
                        {
                            dapAn = 4;
                        }
                        else
                        {
                            dapAn = 0;
                        }
                        // tạo câu hỏi
                        dscauhoi[sttMang] = new CauHoi(sttBode, noidung, a, b, c, d, dapAn, null);
                        //MessageBox.Show(noidung);
                    }
                    rd.Close();
                }
                else
                {
                    MessageBox.Show("Kết quả trả về rỗng !!!", "", MessageBoxButtons.OK);
                    rd.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gọi thực hiện truy vấn SQL " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void xuatcauhoi(int stt)
        {
            try
            {
                lbCauhoi.Text = dscauhoi[stt].NoiDung;
                lbStt.Text = "Câu hỏi số: " + (stt + 1).ToString() + "/" + Program.Socauhoithi;
                //lbA.Text   = "Câu A: "+dscauhoi[stt].CauA;
                //lbB.Text   = "Câu B: "+dscauhoi[stt].CauB;
                //lbC.Text   = "Câu C: "+dscauhoi[stt].CauC;
                //lbD.Text   = "Câu D: "+dscauhoi[stt].CauD;
                rd1.Text   = dscauhoi[stt].CauA;
                rd2.Text   = dscauhoi[stt].CauB;
                rd3.Text   = dscauhoi[stt].CauC;
                rd4.Text   = dscauhoi[stt].CauD;
                if (dscauhoi[stt].ChonDapAn == null)
                    rd1.Checked = rd2.Checked = rd3.Checked = rd4.Checked = false;
                else
                    if (dscauhoi[stt].ChonDapAn == 1)
                    rd1.Checked = true;
                else
                        if (dscauhoi[stt].ChonDapAn == 2)
                    rd2.Checked = true;
                else
                            if (dscauhoi[stt].ChonDapAn == 3)
                    rd3.Checked = true;
                else
                                if (dscauhoi[stt].ChonDapAn == 4)
                    rd4.Checked = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có câu hỏi thi ", "", MessageBoxButtons.OK);
                return;
            }

        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (stt < dscauhoi.Length - 1)
            {
                stt++;
                xuatcauhoi(stt);
            }
            if (stt != 0)
            {
                btnTruoc.Enabled = true;
            }
            if (stt == Program.Socauhoithi - 1)
            {
                btnSau.Enabled = false;
            }
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (stt > 0)
            {
                stt--;
                xuatcauhoi(stt);
            }
            if (stt == 0)
            {
                btnTruoc.Enabled = false;
            }
            else
            {
                btnTruoc.Enabled = true;
            }
            if (stt != 0)
            {
                btnSau.Enabled = true;
            }
        }

        public void GhiDiem()
        {
            /*
            @MASV CHAR (8),
	        @MAMH CHAR (5),
	        @LAN SMALLINT,
	        @NGAYTHI DATETIME,
	        @DIEM FLOAT,
	        @BAITHI NTEXT
            */
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Kết nối mới chưa được khởi tạo !!!", "", MessageBoxButtons.OK);
                return;
            }
            string lenh;
            try
            {
                //lenh1 = "EXEC SP_NHAP_DIEM '" +Program.username+ "','" +Program.Monthi+ "','" +Program.Lanthi+ "','" +(Program.Ngaythi).ToString("yyyy/MM/dd h:mm:ss tt")+ "','" +"1"+ "','" +"1"+ "'";
                lenh = "EXEC SP_NHAP_DIEM '"+Program.username+"','"+Program.Monthi+"','"+Program.Lanthi+"','"+ (Program.Ngaythi).ToString("yyyy/MM/dd h:mm:ss tt") + "','"+Program.DiemBaiThi+"','"+Program.Noidungthi+"'";
                Program.ExecSqlNonQuery(lenh);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Lỗi khi ghi điểm ", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd1.Checked)
                dscauhoi[stt].ChonDapAn = 1;
            else dscauhoi[stt].ChonDapAn = null;
        }

        private void rd2_CheckedChanged(object sender, EventArgs e)
        {
            if (rd2.Checked)
                dscauhoi[stt].ChonDapAn = 2;
            else dscauhoi[stt].ChonDapAn = null;
        }

        private void rd3_CheckedChanged(object sender, EventArgs e)
        {
            if (rd3.Checked)
                dscauhoi[stt].ChonDapAn = 3;
            else dscauhoi[stt].ChonDapAn = null;
        }

        private void rd4_CheckedChanged(object sender, EventArgs e)
        {
            if (rd4.Checked)
                dscauhoi[stt].ChonDapAn = 4;
            else dscauhoi[stt].ChonDapAn = null;
        }
    }
}