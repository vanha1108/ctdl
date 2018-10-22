using HUY.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HUY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            loadbanan();
            Loadmonan();
        }
        private void Loadmonan()
        {
            try
            {
                List<Monan> Listmonan = new List<Monan>();
                StreamReader sr = new StreamReader("monan.txt");//Tạo một Streamreader với file txt có sẵn
                string line = sr.ReadLine();
                while (line != null) // Nếu ko trống
                {
                    string[] ar = line.Split(';');
                    if (ar.Length == 3)
                    {
                        int id = int.Parse(ar[0]);
                        string tenmon = ar[1];
                        int dongia = int.Parse(ar[2]);
                        Monan mon = new Monan();
                        mon.Id = id;
                        mon.Tenmon = tenmon;
                        mon.Gia = dongia;
                        Listmonan.Add(mon);
                    }
                    line = sr.ReadLine();
                }
                sr.ReadLine();
                combooder.DataSource = Listmonan;
                combooder.DisplayMember = "Tenmon";
                
            }
            catch {  }
            


        }
        private void loadbanan()
        {
            try
            {
                StreamReader sr = new StreamReader("banan.txt");//Tạo một Streamreader với file txt có sẵn
                string line = sr.ReadLine();
                while (line != null) // Nếu ko trống
                {
                    string[] ar = line.Split(';');
                    if (ar.Length == 3)
                    {
                        int stt = int.Parse(ar[0]);
                        string ten = ar[1];
                        string trangthai = ar[2];
                        Banan ban = new Banan();
                        ban.Stt = stt;
                        ban.Ten = ten;
                        ban.Trangthai = trangthai;

                        Button btn = new Button() { Width = 95, Height = 95 };
                        btn.Text = ban.Ten + Environment.NewLine + ban.Trangthai;
                        btn.Click += btn_Click;
                        btn.Tag = (int)ban.Stt;
                        if (ban.Trangthai == "Trống")
                        {
                            btn.BackColor = Color.Aqua;
                        }
                        else
                        {
                            if (ban.Trangthai == "Có Người")
                            {
                                btn.BackColor = Color.LightPink;
                            }
                            else
                            {
                                btn.BackColor = Color.Aqua;
                            }
                        }


                        flowLayoutPanel1.Controls.Add(btn);


                    }
                    //Di chuyen đầu đọc tới dòng kế tiếp
                    line = sr.ReadLine();
                }
                sr.ReadLine();
            }
            catch { }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangnhap h = new frmDangnhap();
            h.Show();
        }
    }
}
