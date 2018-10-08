namespace giaodien
{
	partial class fTableManeger
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinCáNhânToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lsvBill = new System.Windows.Forms.ListView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.btnAddFood = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbSwitchTable = new System.Windows.Forms.ComboBox();
			this.btnSwitchTable = new System.Windows.Forms.Button();
			this.nmDiscount = new System.Windows.Forms.NumericUpDown();
			this.btnDiscount = new System.Windows.Forms.Button();
			this.btnCheckOut = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(854, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// adminToolStripMenuItem
			// 
			this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.adminToolStripMenuItem.Text = "Admin";
			this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
			// 
			// thôngTinCáNhânToolStripMenuItem
			// 
			this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem});
			this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
			this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
			this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin tài khoản";
			this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
			// 
			// thôngTinCáNhânToolStripMenuItem1
			// 
			this.thôngTinCáNhânToolStripMenuItem1.Name = "thôngTinCáNhânToolStripMenuItem1";
			this.thôngTinCáNhânToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
			this.thôngTinCáNhânToolStripMenuItem1.Text = "Thông tin cá nhân";
			this.thôngTinCáNhânToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem1_Click);
			// 
			// đăngXuấtToolStripMenuItem
			// 
			this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
			this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
			this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lsvBill);
			this.panel2.Location = new System.Drawing.Point(487, 91);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(355, 310);
			this.panel2.TabIndex = 0;
			// 
			// lsvBill
			// 
			this.lsvBill.Location = new System.Drawing.Point(0, -19);
			this.lsvBill.Name = "lsvBill";
			this.lsvBill.Size = new System.Drawing.Size(355, 326);
			this.lsvBill.TabIndex = 0;
			this.lsvBill.UseCompatibleStateImageBehavior = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.numericUpDown1);
			this.panel3.Controls.Add(this.btnAddFood);
			this.panel3.Controls.Add(this.comboBox2);
			this.panel3.Controls.Add(this.comboBox1);
			this.panel3.Location = new System.Drawing.Point(487, 27);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(355, 61);
			this.panel3.TabIndex = 0;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(284, 19);
			this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnAddFood
			// 
			this.btnAddFood.Location = new System.Drawing.Point(203, 3);
			this.btnAddFood.Name = "btnAddFood";
			this.btnAddFood.Size = new System.Drawing.Size(75, 48);
			this.btnAddFood.TabIndex = 2;
			this.btnAddFood.Text = "Thêm món";
			this.btnAddFood.UseVisualStyleBackColor = true;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(3, 30);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(194, 21);
			this.comboBox2.TabIndex = 1;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(3, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(194, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// flpTable
			// 
			this.flpTable.Location = new System.Drawing.Point(12, 27);
			this.flpTable.Name = "flpTable";
			this.flpTable.Size = new System.Drawing.Size(469, 435);
			this.flpTable.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbSwitchTable);
			this.panel1.Controls.Add(this.btnSwitchTable);
			this.panel1.Controls.Add(this.nmDiscount);
			this.panel1.Controls.Add(this.btnDiscount);
			this.panel1.Controls.Add(this.btnCheckOut);
			this.panel1.Location = new System.Drawing.Point(490, 407);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(352, 55);
			this.panel1.TabIndex = 0;
			// 
			// cbSwitchTable
			// 
			this.cbSwitchTable.FormattingEnabled = true;
			this.cbSwitchTable.Location = new System.Drawing.Point(0, 31);
			this.cbSwitchTable.Name = "cbSwitchTable";
			this.cbSwitchTable.Size = new System.Drawing.Size(75, 21);
			this.cbSwitchTable.TabIndex = 7;
			// 
			// btnSwitchTable
			// 
			this.btnSwitchTable.Location = new System.Drawing.Point(0, 3);
			this.btnSwitchTable.Name = "btnSwitchTable";
			this.btnSwitchTable.Size = new System.Drawing.Size(75, 24);
			this.btnSwitchTable.TabIndex = 6;
			this.btnSwitchTable.Text = "Chuyển bàn";
			this.btnSwitchTable.UseVisualStyleBackColor = true;
			// 
			// nmDiscount
			// 
			this.nmDiscount.Location = new System.Drawing.Point(137, 34);
			this.nmDiscount.Name = "nmDiscount";
			this.nmDiscount.Size = new System.Drawing.Size(75, 20);
			this.nmDiscount.TabIndex = 5;
			this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnDiscount
			// 
			this.btnDiscount.Location = new System.Drawing.Point(137, 4);
			this.btnDiscount.Name = "btnDiscount";
			this.btnDiscount.Size = new System.Drawing.Size(75, 24);
			this.btnDiscount.TabIndex = 4;
			this.btnDiscount.Text = "Giảm giá";
			this.btnDiscount.UseVisualStyleBackColor = true;
			// 
			// btnCheckOut
			// 
			this.btnCheckOut.Location = new System.Drawing.Point(277, 4);
			this.btnCheckOut.Name = "btnCheckOut";
			this.btnCheckOut.Size = new System.Drawing.Size(75, 48);
			this.btnCheckOut.TabIndex = 3;
			this.btnCheckOut.Text = "Thanh toán";
			this.btnCheckOut.UseVisualStyleBackColor = true;
			// 
			// fTableManeger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(854, 474);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.flpTable);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.menuStrip1);
			this.Name = "fTableManeger";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần mềm quản lý quán cafe";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView lsvBill;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button btnAddFood;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.FlowLayoutPanel flpTable;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbSwitchTable;
		private System.Windows.Forms.Button btnSwitchTable;
		private System.Windows.Forms.NumericUpDown nmDiscount;
		private System.Windows.Forms.Button btnDiscount;
		private System.Windows.Forms.Button btnCheckOut;
	}
}