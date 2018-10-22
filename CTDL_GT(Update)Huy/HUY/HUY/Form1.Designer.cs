namespace HUY
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.numberthemmon = new System.Windows.Forms.NumericUpDown();
            this.btnthemmon = new System.Windows.Forms.Button();
            this.combooder = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvmonan = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtgiamgia = new System.Windows.Forms.TextBox();
            this.ttxtthanhtien = new System.Windows.Forms.TextBox();
            this.btndangxuat = new System.Windows.Forms.Button();
            this.btnquanly = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberthemmon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numberthemmon);
            this.panel1.Controls.Add(this.btnthemmon);
            this.panel1.Controls.Add(this.combooder);
            this.panel1.Location = new System.Drawing.Point(416, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 71);
            this.panel1.TabIndex = 0;
            // 
            // numberthemmon
            // 
            this.numberthemmon.Location = new System.Drawing.Point(314, 33);
            this.numberthemmon.Name = "numberthemmon";
            this.numberthemmon.Size = new System.Drawing.Size(40, 20);
            this.numberthemmon.TabIndex = 2;
            // 
            // btnthemmon
            // 
            this.btnthemmon.Location = new System.Drawing.Point(231, 15);
            this.btnthemmon.Name = "btnthemmon";
            this.btnthemmon.Size = new System.Drawing.Size(75, 47);
            this.btnthemmon.TabIndex = 1;
            this.btnthemmon.Text = "Thêm món";
            this.btnthemmon.UseVisualStyleBackColor = true;
            // 
            // combooder
            // 
            this.combooder.FormattingEnabled = true;
            this.combooder.Location = new System.Drawing.Point(13, 30);
            this.combooder.Name = "combooder";
            this.combooder.Size = new System.Drawing.Size(213, 21);
            this.combooder.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvmonan);
            this.panel2.Location = new System.Drawing.Point(416, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 272);
            this.panel2.TabIndex = 3;
            // 
            // lvmonan
            // 
            this.lvmonan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lvmonan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvmonan.FullRowSelect = true;
            this.lvmonan.GridLines = true;
            this.lvmonan.Location = new System.Drawing.Point(3, 3);
            this.lvmonan.Name = "lvmonan";
            this.lvmonan.Size = new System.Drawing.Size(372, 266);
            this.lvmonan.TabIndex = 0;
            this.lvmonan.UseCompatibleStateImageBehavior = false;
            this.lvmonan.View = System.Windows.Forms.View.Details;
            this.lvmonan.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "STT";
            this.columnHeader5.Width = 36;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên món";
            this.columnHeader6.Width = 151;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Đơn giá";
            this.columnHeader7.Width = 112;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số lượng";
            this.columnHeader8.Width = 64;
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Location = new System.Drawing.Point(695, 377);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(75, 61);
            this.btnthanhtoan.TabIndex = 4;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(567, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Thành tiền";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(441, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Giảm giá";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtgiamgia
            // 
            this.txtgiamgia.Location = new System.Drawing.Point(429, 415);
            this.txtgiamgia.Name = "txtgiamgia";
            this.txtgiamgia.Size = new System.Drawing.Size(100, 20);
            this.txtgiamgia.TabIndex = 7;
            // 
            // ttxtthanhtien
            // 
            this.ttxtthanhtien.Location = new System.Drawing.Point(554, 415);
            this.ttxtthanhtien.Name = "ttxtthanhtien";
            this.ttxtthanhtien.Size = new System.Drawing.Size(100, 20);
            this.ttxtthanhtien.TabIndex = 8;
            // 
            // btndangxuat
            // 
            this.btndangxuat.Location = new System.Drawing.Point(12, 12);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(75, 23);
            this.btndangxuat.TabIndex = 0;
            this.btndangxuat.Text = "Đăng xuất";
            this.btndangxuat.UseVisualStyleBackColor = true;
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // btnquanly
            // 
            this.btnquanly.Location = new System.Drawing.Point(273, 12);
            this.btnquanly.Name = "btnquanly";
            this.btnquanly.Size = new System.Drawing.Size(122, 23);
            this.btnquanly.TabIndex = 10;
            this.btnquanly.Text = "Quản lý món ăn";
            this.btnquanly.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(398, 397);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnquanly);
            this.Controls.Add(this.btndangxuat);
            this.Controls.Add(this.ttxtthanhtien);
            this.Controls.Add(this.txtgiamgia);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnthanhtoan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberthemmon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numberthemmon;
        private System.Windows.Forms.Button btnthemmon;
        private System.Windows.Forms.ComboBox combooder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvmonan;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtgiamgia;
        private System.Windows.Forms.TextBox ttxtthanhtien;
        private System.Windows.Forms.Button btndangxuat;
        private System.Windows.Forms.Button btnquanly;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

