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
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = 0;
            List<Taikhoan> a = Taikhoan();
            foreach(Taikhoan bl in a)
            {
                if ((bl.Tendangnhap == txttentaikhoan.Text) && (bl.MatKhau == txtmatkhau.Text))
                {
                    b +=1;
                }
                else b +=0;

            }
            if(b==1)
            {
                Form1 c = new Form1();
                this.Hide();//Ẩn form đăng nhập
                c.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai Tên Đăng nhập hoặc Mật Khẩu");
            }
            
            
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }
       private List<Taikhoan> Taikhoan()
        {
            try
            {
                List<Taikhoan> Listtaikhoan = new List<Taikhoan>();
                StreamReader sr = new StreamReader("taikhoan.txt");//Tạo một Streamreader với file txt có sẵn
                string line = sr.ReadLine();
                while (line != null) // Nếu ko trống
                {
                    string[] ar = line.Split(';');
                    if (ar.Length == 4)
                    {
                        string tentaikhoan = ar[0];
                        string matkhau = ar[1];
                        string ten = ar[2];
                        DateTime ngaysinh = DateTime.Parse(ar[3]);
                        Taikhoan tk = new Taikhoan()
                        ;
                        tk.Tendangnhap = tentaikhoan;
                        tk.MatKhau = matkhau;
                        tk.Hovaten = ten;
                        tk.NgaySinh = ngaysinh;
                        Listtaikhoan.Add(tk);
                    }
                    line = sr.ReadLine();
                }

                sr.ReadLine();
                return Listtaikhoan;
            }
            catch { return null; }

            }
    }
}
