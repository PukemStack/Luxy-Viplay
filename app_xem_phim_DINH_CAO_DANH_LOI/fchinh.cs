using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AxWMPLib;
using dgfokfhdpw855batsolma;
using Luxy_Viplay.Properties;
using xNet;

namespace app_xem_phim_DINH_CAO_DANH_LOI;

public class fchinh : Form
{
	private IContainer components;

	private Panel panel1;

	private PictureBox pictureBox1;

	private Button btnmovideo;

	private Button btnkichhoat;

	private Panel panel2;

	private Label label11;

	private Button btnxoa;

	private Button btnthem;

	private LinkLabel linkmua;

	private Button btnxem;

	private OpenFileDialog opd;

	private Label lbsolanxem;

	private Label label2;

	private Button button1;

	private Button button2;

	private AxWindowsMediaPlayer axWindowsMediaPlayer1;

	private Timer timer1;

	private ListBox listvideo;

	private Label label4;

	private Panel panel3;

	private Button button3;

	private Panel panel4;

	private Label lbhaychonfile;

	private Label label1;

	private Label lblanguage;

	private Label lbngonngu;

	private Button btnEnglish;

	private Button btnTiengViet;

	private Panel panel5;

	private Panel pnmua;

	private Button btnclosemua;

	private TextBox txtemail;

	private Label lbnhapemail;

	private Button btnmua;

	private Panel pnchuyenkhoan;

	private Label lbgia;

	private Label label5;

	private Panel panel7;

	private Label label7;

	private TableLayoutPanel tableLayoutPanel1;

	private Label label8;

	private Label label9;

	private Label label10;

	private Label label12;

	private Label label13;

	private Label label14;

	private Label label15;

	private Label label16;

	private Label label17;

	private Label lbnoidung1;

	private LinkLabel linkquaylai;

	private LinkLabel linkLabel1;

	private Label label19;

	private Label label20;

	private Label label21;

	private RadioButton radioButton2;

	private RadioButton radioButton1;

	private Label label3;

	private Panel pnchuyenpaypal;

	private TableLayoutPanel tableLayoutPanel2;

	private LinkLabel linkLabel3;

	private Label label22;

	private Label label23;

	private Label label24;

	private Label label25;

	private Label lbnoidung2;

	private Label label6;

	private LinkLabel linkLabel2;

	private Label label18;

	private Label label26;

	private string mavideo = "1";

	private string ngon_ngu = "1";

	private int solanxem;

	private string s1 = Directory.GetCurrentDirectory() + "\\dllfile";

	private string[] k1a = new string[5] { "jeqếj Dặp 7ạ píDyD$f", "3.1PB4n\\3qjm.n.XpyC.u4mIeqBBqyF$4mkpq.7\\", "", "JR\\Gq71.u n:np4D\\Gq71.un\\", "6gUiYliY&fh" };

	private string[] kqua = new string[6] { "Gq71.un 1kpk\\x4p\\Gq71.unC.u4mIeqBBq\\", "gyiyg\\%qkx7.npqjn\\IqD$_x4p\\", "gyiyg\\K4np\\3.1PB4n\\Z5kD$B4Yy%qkx7.npqjn\\", "W..xB4\\J.DD.7\\CBPx-q7n\\34xk\\", "gh&aDI08hklmn", "igcgYiYici&f" };

	private string dulieu = Directory.GetCurrentDirectory() + "\\file_dulieu";

	private string[] kbz = new string[6] { "nYkD&gifigh&id", "UUiidh&Yj1", "giYdy1j", "gi1Xcd", "&dlifhXy$BPx", "ifcfUccdcy1BB" };

	private string[] kmz = new string[7] { "e5c.$1jli", "gi", "i", "Y&fhgidh", "Udx8yj.14", "iddXyj.14", "6fUdbj..DK" };

	private string kn = "JR\\Gq71.u n:np4D\\Gq71.un\\Gq71.un 1kpk\\x4p\\Gq71.unC.u4mIeqBBq\\3.1PB4n\\3qjm.n.XpyC.u4mIeqBBqyakBq1kpq.7\\YyiyY\\K4np\\3.1PB4n\\Z5kD$B4Yy%qkx7.npqjn\\YyiyY\\%qkx7.npqjn\\IqD$_x4p\\";

	private string kw = "JR\\Gq71.u n:np4D\\uq71.un\\I:np4D\\I:np4DN4n.Pmj4n\\Gq71.unyIe4BBJ.DD.7yIekm41N4n.Pmj4n\\CNSI\\";

	private string kl = "JR\\Gq71.u n:np4D\\Gq71.un\\I:np4DhY\\JkpN..p\\kD-4p\\gYU%iOg%-fZvY-gg%g-d&id-iiJifvJYlcZZ\\";

	private string file_ngon_ngu = Path.Combine(Directory.GetCurrentDirectory(), "file_dulieu\\ngon_ngu.lagu");

	private solma sol = new solma();

	private string chonfilekichhoat = "VUI LÒNG CHỌN FILE MÃ KÍCH HOẠT (kichhoat-activate.kiact";

	private string chonvideomo = "VUI LÒNG CHỌN VIDEO ĐỂ XEM (*Video.luxy)";

	private string chonvideothem = "HÃY CHỌN CÁC VIDEO ĐỂ THÊM VÀO DANH SÁCH (*Video.luxy)";

	private int tchuotphai;

	private int doubleclick;

	private int kichthuocvideo = 1;

	private int tick;

	private int dachontronglist = -1;

	private string a;

	private int kiemtramail;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

    private void InitializeComponent()
    {
        components = new Container();
        panel1 = new Panel();
        button3 = new Button();
        panel3 = new Panel();
        btnmovideo = new Button();
        pictureBox1 = new PictureBox();
        lbsolanxem = new Label();
        btnkichhoat = new Button();
        panel2 = new Panel();
        btnEnglish = new Button();
        btnTiengViet = new Button();
        btnthem = new Button();
        btnxoa = new Button();
        btnxem = new Button();
        label11 = new Label();
        listvideo = new ListBox();
        lblanguage = new Label();
        lbngonngu = new Label();
        panel5 = new Panel();
        linkmua = new LinkLabel();
        opd = new OpenFileDialog();
        label2 = new Label();
        button1 = new Button();
        button2 = new Button();
        timer1 = new Timer(components);
        label4 = new Label();
        panel4 = new Panel();
        lbhaychonfile = new Label();
        label1 = new Label();
        pnmua = new Panel();
        label19 = new Label();
        linkLabel1 = new LinkLabel();
        pnchuyenpaypal = new Panel();
        label26 = new Label();
        label18 = new Label();
        tableLayoutPanel2 = new TableLayoutPanel();
        linkLabel3 = new LinkLabel();
        label22 = new Label();
        label23 = new Label();
        label24 = new Label();
        label25 = new Label();
        lbnoidung2 = new Label();
        label6 = new Label();
        linkLabel2 = new LinkLabel();
        pnchuyenkhoan = new Panel();
        label20 = new Label();
        label3 = new Label();
        linkquaylai = new LinkLabel();
        tableLayoutPanel1 = new TableLayoutPanel();
        label8 = new Label();
        label9 = new Label();
        label10 = new Label();
        label12 = new Label();
        label13 = new Label();
        label14 = new Label();
        label15 = new Label();
        label16 = new Label();
        label17 = new Label();
        lbnoidung1 = new Label();
        label5 = new Label();
        btnmua = new Button();
        btnclosemua = new Button();
        txtemail = new TextBox();
        lbnhapemail = new Label();
        panel7 = new Panel();
        label7 = new Label();
        lbgia = new Label();
        radioButton2 = new RadioButton();
        radioButton1 = new RadioButton();
        label21 = new Label();
        panel1.SuspendLayout();
        ((ISupportInitialize)pictureBox1).BeginInit();
        panel2.SuspendLayout();
        panel4.SuspendLayout();
        pnmua.SuspendLayout();
        pnchuyenpaypal.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        pnchuyenkhoan.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        panel7.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ActiveCaptionText;
        panel1.BorderStyle = BorderStyle.Fixed3D;
        panel1.Controls.Add(button3);
        panel1.Controls.Add(panel3);
        panel1.Controls.Add(btnmovideo);
        panel1.Controls.Add(pictureBox1);
        panel1.Location = new Point(318, 4);
        panel1.Margin = new Padding(4);
        panel1.Name = "panel1";
        panel1.Size = new Size(651, 469);
        panel1.TabIndex = 0;
        // 
        // button3
        // 
        button3.Anchor = AnchorStyles.Bottom;
        button3.BackColor = Color.FromArgb(128, 255, 128);
        button3.Cursor = Cursors.Hand;
        button3.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
        button3.FlatAppearance.BorderSize = 4;
        button3.FlatAppearance.MouseDownBackColor = Color.Fuchsia;
        button3.FlatAppearance.MouseOverBackColor = Color.Red;
        button3.FlatStyle = FlatStyle.Flat;
        button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button3.ForeColor = Color.Black;
        button3.Location = new Point(243, 332);
        button3.Margin = new Padding(4);
        button3.Name = "button3";
        button3.Size = new Size(161, 65);
        button3.TabIndex = 9;
        button3.Text = "THU NHỎ";
        button3.UseVisualStyleBackColor = false;
        button3.Visible = false;
        button3.Click += button3_Click;
        // 
        // panel3
        // 
        panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panel3.Location = new Point(0, 274);
        panel3.Name = "panel3";
        panel3.Size = new Size(651, 192);
        panel3.TabIndex = 4;
        panel3.Visible = false;
        // 
        // btnmovideo
        // 
        btnmovideo.BackColor = Color.FromArgb(255, 255, 192);
        btnmovideo.Cursor = Cursors.Hand;
        btnmovideo.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
        btnmovideo.FlatAppearance.BorderSize = 4;
        btnmovideo.FlatAppearance.MouseDownBackColor = Color.Fuchsia;
        btnmovideo.FlatAppearance.MouseOverBackColor = Color.Red;
        btnmovideo.FlatStyle = FlatStyle.Flat;
        btnmovideo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnmovideo.Location = new Point(220, 187);
        btnmovideo.Margin = new Padding(4);
        btnmovideo.Name = "btnmovideo";
        btnmovideo.Size = new Size(206, 80);
        btnmovideo.TabIndex = 1;
        btnmovideo.Text = "MỞ VIDEO";
        btnmovideo.UseVisualStyleBackColor = false;
        btnmovideo.Click += btnmovideo_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = SystemColors.ActiveBorder;
        pictureBox1.Location = new Point(-2, 429);
        pictureBox1.Margin = new Padding(4);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(651, 47);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // lbsolanxem
        // 
        lbsolanxem.AutoSize = true;
        lbsolanxem.ForeColor = Color.FromArgb(0, 64, 0);
        lbsolanxem.Location = new Point(8, 598);
        lbsolanxem.Name = "lbsolanxem";
        lbsolanxem.Size = new Size(57, 20);
        lbsolanxem.TabIndex = 2;
        lbsolanxem.Text = "label6";
        // 
        // btnkichhoat
        // 
        btnkichhoat.BackColor = Color.FromArgb(255, 255, 192);
        btnkichhoat.Cursor = Cursors.Hand;
        btnkichhoat.FlatAppearance.BorderColor = Color.Purple;
        btnkichhoat.FlatAppearance.BorderSize = 3;
        btnkichhoat.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 64);
        btnkichhoat.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
        btnkichhoat.FlatStyle = FlatStyle.Flat;
        btnkichhoat.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnkichhoat.ForeColor = Color.FromArgb(64, 0, 64);
        btnkichhoat.Location = new Point(40, 516);
        btnkichhoat.Name = "btnkichhoat";
        btnkichhoat.Size = new Size(197, 66);
        btnkichhoat.TabIndex = 2;
        btnkichhoat.Text = "Kích hoạt";
        btnkichhoat.UseVisualStyleBackColor = false;
        btnkichhoat.Click += btnkichhoat_Click;
        // 
        // panel2
        // 
        panel2.BackColor = Color.Purple;
        panel2.Controls.Add(btnEnglish);
        panel2.Controls.Add(btnTiengViet);
        panel2.Controls.Add(btnthem);
        panel2.Controls.Add(btnxoa);
        panel2.Controls.Add(btnxem);
        panel2.Controls.Add(label11);
        panel2.Controls.Add(panel1);
        panel2.Controls.Add(listvideo);
        panel2.Controls.Add(lblanguage);
        panel2.Controls.Add(lbngonngu);
        panel2.Controls.Add(panel5);
        panel2.Location = new Point(0, 1);
        panel2.Name = "panel2";
        panel2.Size = new Size(974, 479);
        panel2.TabIndex = 3;
        panel2.MouseClick += panel2_MouseClick;
        // 
        // btnEnglish
        // 
        btnEnglish.Cursor = Cursors.Hand;
        btnEnglish.Location = new Point(178, 432);
        btnEnglish.Name = "btnEnglish";
        btnEnglish.Size = new Size(132, 43);
        btnEnglish.TabIndex = 9;
        btnEnglish.Text = "English";
        btnEnglish.UseVisualStyleBackColor = true;
        btnEnglish.Click += btnEnglish_Click;
        // 
        // btnTiengViet
        // 
        btnTiengViet.Cursor = Cursors.Hand;
        btnTiengViet.Location = new Point(178, 433);
        btnTiengViet.Name = "btnTiengViet";
        btnTiengViet.Size = new Size(133, 43);
        btnTiengViet.TabIndex = 8;
        btnTiengViet.Text = "Tiếng Việt";
        btnTiengViet.UseVisualStyleBackColor = true;
        btnTiengViet.Click += btnTiengViet_Click;
        // 
        // btnthem
        // 
        btnthem.BackColor = Color.Green;
        btnthem.Cursor = Cursors.Hand;
        btnthem.FlatAppearance.BorderColor = Color.Yellow;
        btnthem.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
        btnthem.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
        btnthem.FlatStyle = FlatStyle.Flat;
        btnthem.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnthem.ForeColor = Color.White;
        btnthem.Location = new Point(14, 45);
        btnthem.Name = "btnthem";
        btnthem.Size = new Size(75, 27);
        btnthem.TabIndex = 3;
        btnthem.Text = "Thêm";
        btnthem.UseVisualStyleBackColor = false;
        btnthem.Click += btnthem_Click;
        // 
        // btnxoa
        // 
        btnxoa.BackColor = Color.FromArgb(192, 0, 0);
        btnxoa.Cursor = Cursors.Hand;
        btnxoa.FlatAppearance.BorderColor = Color.Yellow;
        btnxoa.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
        btnxoa.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
        btnxoa.FlatStyle = FlatStyle.Flat;
        btnxoa.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnxoa.ForeColor = Color.White;
        btnxoa.Location = new Point(14, 78);
        btnxoa.Name = "btnxoa";
        btnxoa.Size = new Size(75, 27);
        btnxoa.TabIndex = 4;
        btnxoa.Text = "Xóa";
        btnxoa.UseVisualStyleBackColor = false;
        btnxoa.Visible = false;
        btnxoa.Click += btnxoa_Click;
        // 
        // btnxem
        // 
        btnxem.BackColor = Color.Yellow;
        btnxem.Cursor = Cursors.Hand;
        btnxem.FlatAppearance.BorderColor = Color.Yellow;
        btnxem.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
        btnxem.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
        btnxem.FlatStyle = FlatStyle.Flat;
        btnxem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnxem.ForeColor = Color.Black;
        btnxem.Location = new Point(264, 45);
        btnxem.Name = "btnxem";
        btnxem.Size = new Size(86, 39);
        btnxem.TabIndex = 6;
        btnxem.Text = "XEM";
        btnxem.UseVisualStyleBackColor = false;
        btnxem.Visible = false;
        btnxem.Click += btnxem_Click;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label11.ForeColor = Color.Yellow;
        label11.Location = new Point(25, 16);
        label11.Name = "label11";
        label11.Size = new Size(244, 27);
        label11.TabIndex = 1;
        label11.Text = "Danh sách video yêu thích";
        label11.TextAlign = ContentAlignment.MiddleCenter;
        label11.UseCompatibleTextRendering = true;
        // 
        // listvideo
        // 
        listvideo.BackColor = Color.Purple;
        listvideo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        listvideo.ForeColor = Color.White;
        listvideo.FormattingEnabled = true;
        listvideo.ItemHeight = 20;
        listvideo.Location = new Point(29, 45);
        listvideo.Name = "listvideo";
        listvideo.RightToLeft = RightToLeft.Yes;
        listvideo.Size = new Size(249, 364);
        listvideo.TabIndex = 7;
        listvideo.Tag = "";
        listvideo.MouseClick += listvideo_MouseClick;
        // 
        // lblanguage
        // 
        lblanguage.AutoSize = true;
        lblanguage.BackColor = Color.FromArgb(0, 0, 64);
        lblanguage.ForeColor = Color.White;
        lblanguage.Location = new Point(4, 444);
        lblanguage.Name = "lblanguage";
        lblanguage.Size = new Size(174, 20);
        lblanguage.TabIndex = 11;
        lblanguage.Text = "change Language to";
        // 
        // lbngonngu
        // 
        lbngonngu.AutoSize = true;
        lbngonngu.BackColor = Color.FromArgb(0, 0, 64);
        lbngonngu.ForeColor = Color.White;
        lbngonngu.Location = new Point(4, 444);
        lbngonngu.Name = "lbngonngu";
        lbngonngu.Size = new Size(169, 20);
        lbngonngu.TabIndex = 10;
        lbngonngu.Text = "đổi ngôn ngữ thành:";
        // 
        // panel5
        // 
        panel5.BackColor = Color.FromArgb(0, 0, 64);
        panel5.Location = new Point(3, 435);
        panel5.Name = "panel5";
        panel5.Size = new Size(307, 38);
        panel5.TabIndex = 12;
        // 
        // linkmua
        // 
        linkmua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        linkmua.AutoSize = true;
        linkmua.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        linkmua.LinkColor = Color.FromArgb(64, 0, 64);
        linkmua.Location = new Point(659, 594);
        linkmua.Name = "linkmua";
        linkmua.Size = new Size(231, 24);
        linkmua.TabIndex = 4;
        linkmua.TabStop = true;
        linkmua.Text = "Mua file kích hoạt ở đây";
        linkmua.LinkClicked += linkmua_LinkClicked;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.ForeColor = Color.White;
        label2.Location = new Point(81, 4);
        label2.Name = "label2";
        label2.Size = new Size(738, 16);
        label2.TabIndex = 6;
        label2.Text = "đây là phần mềm xem video chuyên dụng. chỉ phát video với định dạng đuôi .LUXY. chi tiết xin liên hệ luxyviplay@gmail.com";
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(255, 255, 192);
        button1.Cursor = Cursors.Hand;
        button1.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
        button1.FlatAppearance.BorderSize = 4;
        button1.FlatAppearance.MouseDownBackColor = Color.Fuchsia;
        button1.FlatAppearance.MouseOverBackColor = Color.Red;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button1.ForeColor = Color.FromArgb(64, 0, 64);
        button1.Location = new Point(492, 463);
        button1.Margin = new Padding(4);
        button1.Name = "button1";
        button1.Size = new Size(336, 61);
        button1.TabIndex = 3;
        button1.Text = "MỞ VIDEO KHÁC";
        button1.UseVisualStyleBackColor = false;
        button1.Visible = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.BackColor = Color.FromArgb(128, 255, 128);
        button2.Cursor = Cursors.Hand;
        button2.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
        button2.FlatAppearance.BorderSize = 4;
        button2.FlatAppearance.MouseDownBackColor = Color.Fuchsia;
        button2.FlatAppearance.MouseOverBackColor = Color.Red;
        button2.FlatStyle = FlatStyle.Flat;
        button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button2.ForeColor = Color.Black;
        button2.Location = new Point(827, 463);
        button2.Margin = new Padding(4);
        button2.Name = "button2";
        button2.Size = new Size(147, 61);
        button2.TabIndex = 7;
        button2.Text = "PHÓNG TO";
        button2.UseVisualStyleBackColor = false;
        button2.Visible = false;
        button2.Click += button2_Click;
        // 
        // timer1
        // 
        timer1.Interval = 600;
        timer1.Tick += timer1_Tick;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.ForeColor = Color.Navy;
        label4.Location = new Point(7, 596);
        label4.Margin = new Padding(4);
        label4.Name = "label4";
        label4.Size = new Size(463, 20);
        label4.TabIndex = 8;
        label4.Text = "ĐANG KÍCH HOẠT! VUI LÒNG CHỜ!....                            ";
        label4.Visible = false;
        // 
        // panel4
        // 
        panel4.BackColor = Color.FromArgb(64, 0, 64);
        panel4.Controls.Add(label2);
        panel4.Location = new Point(0, 630);
        panel4.Name = "panel4";
        panel4.Size = new Size(974, 23);
        panel4.TabIndex = 9;
        // 
        // lbhaychonfile
        // 
        lbhaychonfile.AutoSize = true;
        lbhaychonfile.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbhaychonfile.ForeColor = Color.Purple;
        lbhaychonfile.Location = new Point(1, 594);
        lbhaychonfile.Name = "lbhaychonfile";
        lbhaychonfile.Size = new Size(470, 24);
        lbhaychonfile.TabIndex = 10;
        lbhaychonfile.Text = "     HÃY CHỌN FILE KÍCH HOẠT!                         ";
        lbhaychonfile.Visible = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ForeColor = Color.Red;
        label1.Location = new Point(10, 595);
        label1.Name = "label1";
        label1.Size = new Size(476, 24);
        label1.TabIndex = 11;
        label1.Text = "HÃY KÍCH HOẠT ĐỂ XEM VIDEO HƠN 25MB       ";
        // 
        // pnmua
        // 
        pnmua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        pnmua.BackColor = Color.SeaShell;
        pnmua.Controls.Add(label19);
        pnmua.Controls.Add(linkLabel1);
        pnmua.Controls.Add(pnchuyenpaypal);
        pnmua.Controls.Add(pnchuyenkhoan);
        pnmua.Controls.Add(btnmua);
        pnmua.Controls.Add(btnclosemua);
        pnmua.Controls.Add(txtemail);
        pnmua.Controls.Add(lbnhapemail);
        pnmua.Controls.Add(panel7);
        pnmua.Controls.Add(radioButton2);
        pnmua.Controls.Add(radioButton1);
        pnmua.Controls.Add(label21);
        pnmua.Location = new Point(282, 126);
        pnmua.Name = "pnmua";
        pnmua.Size = new Size(639, 466);
        pnmua.TabIndex = 12;
        pnmua.Visible = false;
        // 
        // label19
        // 
        label19.AutoSize = true;
        label19.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label19.Location = new Point(463, 415);
        label19.Name = "label19";
        label19.Size = new Size(143, 16);
        label19.TabIndex = 8;
        label19.Text = "luxyviplay@gmail.com";
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        linkLabel1.Location = new Point(461, 390);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(157, 16);
        linkLabel1.TabIndex = 5;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "facebook.com/luxyviplay";
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // pnchuyenpaypal
        // 
        pnchuyenpaypal.Controls.Add(label26);
        pnchuyenpaypal.Controls.Add(label18);
        pnchuyenpaypal.Controls.Add(tableLayoutPanel2);
        pnchuyenpaypal.Controls.Add(label6);
        pnchuyenpaypal.Controls.Add(linkLabel2);
        pnchuyenpaypal.Location = new Point(1, 6);
        pnchuyenpaypal.Name = "pnchuyenpaypal";
        pnchuyenpaypal.Size = new Size(596, 460);
        pnchuyenpaypal.TabIndex = 12;
        pnchuyenpaypal.Visible = false;
        // 
        // label26
        // 
        label26.AutoSize = true;
        label26.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label26.ForeColor = Color.Green;
        label26.Location = new Point(21, 273);
        label26.Name = "label26";
        label26.Size = new Size(573, 20);
        label26.TabIndex = 11;
        label26.Text = "thời gian sử lý có thể mất vài giờ, chúng tôi sẽ gửi file kích hoạt vào email của bạn";
        // 
        // label18
        // 
        label18.AutoSize = true;
        label18.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label18.ForeColor = Color.FromArgb(64, 0, 64);
        label18.Location = new Point(34, 384);
        label18.Name = "label18";
        label18.Size = new Size(426, 16);
        label18.TabIndex = 7;
        label18.Text = "                       nếu đợi lâu hay gặp sự cố hãy liên hệ chúng tôi:";
        label18.TextAlign = ContentAlignment.TopRight;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.80565F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.19435F));
        tableLayoutPanel2.Controls.Add(linkLabel3, 1, 0);
        tableLayoutPanel2.Controls.Add(label22, 0, 0);
        tableLayoutPanel2.Controls.Add(label23, 0, 1);
        tableLayoutPanel2.Controls.Add(label24, 1, 1);
        tableLayoutPanel2.Controls.Add(label25, 0, 2);
        tableLayoutPanel2.Controls.Add(lbnoidung2, 1, 2);
        tableLayoutPanel2.Location = new Point(30, 100);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 3;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
        tableLayoutPanel2.Size = new Size(566, 116);
        tableLayoutPanel2.TabIndex = 10;
        // 
        // linkLabel3
        // 
        linkLabel3.Anchor = AnchorStyles.Left;
        linkLabel3.AutoSize = true;
        linkLabel3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        linkLabel3.Location = new Point(200, 9);
        linkLabel3.Name = "linkLabel3";
        linkLabel3.Size = new Size(124, 20);
        linkLabel3.TabIndex = 9;
        linkLabel3.TabStop = true;
        linkLabel3.Text = "@bonghongnau";
        linkLabel3.LinkClicked += linkLabel3_LinkClicked;
        // 
        // label22
        // 
        label22.Anchor = AnchorStyles.Right;
        label22.AutoSize = true;
        label22.Location = new Point(56, 9);
        label22.Name = "label22";
        label22.Size = new Size(137, 20);
        label22.TabIndex = 10;
        label22.Text = "Tài khoản nhận:";
        // 
        // label23
        // 
        label23.Anchor = AnchorStyles.Right;
        label23.AutoSize = true;
        label23.Location = new Point(122, 47);
        label23.Name = "label23";
        label23.Size = new Size(71, 20);
        label23.TabIndex = 11;
        label23.Text = "Số tiền:";
        // 
        // label24
        // 
        label24.Anchor = AnchorStyles.Left;
        label24.AutoSize = true;
        label24.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label24.Location = new Point(200, 47);
        label24.Name = "label24";
        label24.Size = new Size(71, 20);
        label24.TabIndex = 12;
        label24.Text = "$50USD";
        // 
        // label25
        // 
        label25.Anchor = AnchorStyles.Right;
        label25.AutoSize = true;
        label25.Location = new Point(108, 86);
        label25.Name = "label25";
        label25.Size = new Size(85, 20);
        label25.TabIndex = 13;
        label25.Text = "Nội dung:";
        // 
        // lbnoidung2
        // 
        lbnoidung2.Anchor = AnchorStyles.Left;
        lbnoidung2.AutoSize = true;
        lbnoidung2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lbnoidung2.ForeColor = Color.Red;
        lbnoidung2.Location = new Point(200, 86);
        lbnoidung2.Name = "lbnoidung2";
        lbnoidung2.Size = new Size(35, 20);
        lbnoidung2.TabIndex = 14;
        lbnoidung2.Text = "abc";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.ForeColor = Color.Green;
        label6.Location = new Point(40, 63);
        label6.Name = "label6";
        label6.Size = new Size(339, 20);
        label6.TabIndex = 8;
        label6.Text = "chỉ cần gửi tiền vào tài khoản Paypal sau:";
        // 
        // linkLabel2
        // 
        linkLabel2.AutoSize = true;
        linkLabel2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        linkLabel2.Location = new Point(16, 21);
        linkLabel2.Name = "linkLabel2";
        linkLabel2.Size = new Size(153, 17);
        linkLabel2.TabIndex = 7;
        linkLabel2.TabStop = true;
        linkLabel2.Text = "<< Quay lại trang trước";
        linkLabel2.LinkClicked += linkLabel2_LinkClicked;
        // 
        // pnchuyenkhoan
        // 
        pnchuyenkhoan.Controls.Add(label20);
        pnchuyenkhoan.Controls.Add(label3);
        pnchuyenkhoan.Controls.Add(linkquaylai);
        pnchuyenkhoan.Controls.Add(tableLayoutPanel1);
        pnchuyenkhoan.Controls.Add(label5);
        pnchuyenkhoan.Location = new Point(1, 3);
        pnchuyenkhoan.Name = "pnchuyenkhoan";
        pnchuyenkhoan.Size = new Size(596, 462);
        pnchuyenkhoan.TabIndex = 4;
        pnchuyenkhoan.Visible = false;
        // 
        // label20
        // 
        label20.AutoSize = true;
        label20.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label20.ForeColor = Color.FromArgb(64, 0, 64);
        label20.Location = new Point(33, 387);
        label20.Name = "label20";
        label20.Size = new Size(426, 16);
        label20.TabIndex = 5;
        label20.Text = "                       nếu đợi lâu hay gặp sự cố hãy liên hệ chúng tôi:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.ForeColor = Color.Green;
        label3.Location = new Point(21, 324);
        label3.Name = "label3";
        label3.Size = new Size(573, 20);
        label3.TabIndex = 6;
        label3.Text = "thời gian sử lý có thể mất vài giờ, chúng tôi sẽ gửi file kích hoạt vào email của bạn";
        // 
        // linkquaylai
        // 
        linkquaylai.AutoSize = true;
        linkquaylai.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        linkquaylai.Location = new Point(16, 29);
        linkquaylai.Name = "linkquaylai";
        linkquaylai.Size = new Size(153, 17);
        linkquaylai.TabIndex = 4;
        linkquaylai.TabStop = true;
        linkquaylai.Text = "<< Quay lại trang trước";
        linkquaylai.LinkClicked += linkquaylai_LinkClicked;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.90648F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.09352F));
        tableLayoutPanel1.Controls.Add(label8, 0, 0);
        tableLayoutPanel1.Controls.Add(label9, 1, 0);
        tableLayoutPanel1.Controls.Add(label10, 0, 1);
        tableLayoutPanel1.Controls.Add(label12, 1, 1);
        tableLayoutPanel1.Controls.Add(label13, 0, 2);
        tableLayoutPanel1.Controls.Add(label14, 1, 2);
        tableLayoutPanel1.Controls.Add(label15, 0, 3);
        tableLayoutPanel1.Controls.Add(label16, 1, 3);
        tableLayoutPanel1.Controls.Add(label17, 0, 4);
        tableLayoutPanel1.Controls.Add(lbnoidung1, 1, 4);
        tableLayoutPanel1.Location = new Point(37, 105);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 5;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.Size = new Size(556, 181);
        tableLayoutPanel1.TabIndex = 3;
        // 
        // label8
        // 
        label8.Anchor = AnchorStyles.Right;
        label8.AutoSize = true;
        label8.Location = new Point(120, 8);
        label8.Name = "label8";
        label8.Size = new Size(109, 20);
        label8.TabIndex = 0;
        label8.Text = "Ngân Hàng: ";
        label8.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label9
        // 
        label9.Anchor = AnchorStyles.Left;
        label9.AutoSize = true;
        label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label9.ForeColor = Color.FromArgb(0, 0, 192);
        label9.Location = new Point(236, 8);
        label9.Name = "label9";
        label9.Size = new Size(252, 20);
        label9.TabIndex = 1;
        label9.Text = "Vietinbank (chi nhánh Bình Thuận)";
        label9.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label10
        // 
        label10.Anchor = AnchorStyles.Right;
        label10.AutoSize = true;
        label10.Location = new Point(103, 44);
        label10.Name = "label10";
        label10.Size = new Size(126, 20);
        label10.TabIndex = 2;
        label10.Text = "Số Tài Khoản: ";
        label10.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label12
        // 
        label12.Anchor = AnchorStyles.Left;
        label12.AutoSize = true;
        label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label12.ForeColor = Color.FromArgb(0, 0, 192);
        label12.Location = new Point(236, 44);
        label12.Name = "label12";
        label12.Size = new Size(117, 20);
        label12.TabIndex = 3;
        label12.Text = "109002364944";
        label12.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label13
        // 
        label13.Anchor = AnchorStyles.Right;
        label13.AutoSize = true;
        label13.Location = new Point(102, 80);
        label13.Name = "label13";
        label13.Size = new Size(127, 20);
        label13.TabIndex = 4;
        label13.Text = "chủ tài khoản: ";
        label13.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label14
        // 
        label14.Anchor = AnchorStyles.Left;
        label14.AutoSize = true;
        label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label14.ForeColor = Color.FromArgb(0, 0, 192);
        label14.Location = new Point(236, 80);
        label14.Name = "label14";
        label14.Size = new Size(140, 20);
        label14.TabIndex = 5;
        label14.Text = "Nguyen Thai Hung";
        label14.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label15
        // 
        label15.Anchor = AnchorStyles.Right;
        label15.AutoSize = true;
        label15.Location = new Point(149, 116);
        label15.Name = "label15";
        label15.Size = new Size(80, 20);
        label15.TabIndex = 6;
        label15.Text = "Số Tiền: ";
        label15.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label16
        // 
        label16.Anchor = AnchorStyles.Left;
        label16.AutoSize = true;
        label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label16.ForeColor = Color.FromArgb(0, 0, 192);
        label16.Location = new Point(236, 116);
        label16.Name = "label16";
        label16.Size = new Size(118, 20);
        label16.TabIndex = 7;
        label16.Text = "1.000.000 VNĐ";
        label16.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label17
        // 
        label17.Anchor = AnchorStyles.Right;
        label17.AutoSize = true;
        label17.Location = new Point(141, 152);
        label17.Name = "label17";
        label17.Size = new Size(88, 20);
        label17.TabIndex = 8;
        label17.Text = "nội dung: ";
        label17.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbnoidung1
        // 
        lbnoidung1.Anchor = AnchorStyles.Left;
        lbnoidung1.AutoSize = true;
        lbnoidung1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lbnoidung1.ForeColor = Color.Red;
        lbnoidung1.Location = new Point(236, 152);
        lbnoidung1.Name = "lbnoidung1";
        lbnoidung1.Size = new Size(35, 20);
        lbnoidung1.TabIndex = 9;
        lbnoidung1.Text = "abc";
        lbnoidung1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.ForeColor = Color.Green;
        label5.Location = new Point(40, 70);
        label5.Name = "label5";
        label5.Size = new Size(333, 20);
        label5.TabIndex = 2;
        label5.Text = "chỉ cần chuyển khoản theo thông tin sau";
        // 
        // btnmua
        // 
        btnmua.BackColor = Color.Navy;
        btnmua.Cursor = Cursors.Hand;
        btnmua.FlatAppearance.BorderSize = 2;
        btnmua.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 64);
        btnmua.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
        btnmua.FlatStyle = FlatStyle.Flat;
        btnmua.ForeColor = Color.White;
        btnmua.Location = new Point(406, 225);
        btnmua.Name = "btnmua";
        btnmua.Size = new Size(137, 59);
        btnmua.TabIndex = 3;
        btnmua.Text = "MUA";
        btnmua.UseVisualStyleBackColor = false;
        btnmua.Click += btnmua_Click;
        // 
        // btnclosemua
        // 
        btnclosemua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnclosemua.BackColor = Color.Red;
        btnclosemua.Cursor = Cursors.Hand;
        btnclosemua.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnclosemua.Location = new Point(596, 0);
        btnclosemua.Name = "btnclosemua";
        btnclosemua.Size = new Size(43, 44);
        btnclosemua.TabIndex = 2;
        btnclosemua.Text = "x";
        btnclosemua.UseVisualStyleBackColor = false;
        btnclosemua.Click += btnclosemua_Click;
        // 
        // txtemail
        // 
        txtemail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtemail.Location = new Point(210, 91);
        txtemail.Name = "txtemail";
        txtemail.Size = new Size(333, 26);
        txtemail.TabIndex = 1;
        txtemail.TextChanged += txtemail_TextChanged;
        // 
        // lbnhapemail
        // 
        lbnhapemail.AutoSize = true;
        lbnhapemail.Location = new Point(77, 94);
        lbnhapemail.Name = "lbnhapemail";
        lbnhapemail.Size = new Size(127, 20);
        lbnhapemail.TabIndex = 0;
        lbnhapemail.Text = "Email của bạn:";
        // 
        // panel7
        // 
        panel7.BackColor = Color.FromArgb(192, 255, 192);
        panel7.Controls.Add(label7);
        panel7.Controls.Add(lbgia);
        panel7.Location = new Point(222, 239);
        panel7.Name = "panel7";
        panel7.Size = new Size(286, 31);
        panel7.TabIndex = 7;
        // 
        // label7
        // 
        label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label7.AutoSize = true;
        label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label7.Location = new Point(12, 6);
        label7.Name = "label7";
        label7.Size = new Size(50, 20);
        label7.TabIndex = 6;
        label7.Text = "   Giá:";
        // 
        // lbgia
        // 
        lbgia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lbgia.AutoSize = true;
        lbgia.ForeColor = Color.Red;
        lbgia.Location = new Point(58, 6);
        lbgia.Name = "lbgia";
        lbgia.Size = new Size(0, 20);
        lbgia.TabIndex = 5;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Cursor = Cursors.Hand;
        radioButton2.Location = new Point(355, 161);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(188, 24);
        radioButton2.TabIndex = 11;
        radioButton2.TabStop = true;
        radioButton2.Text = "tôi không ở việt nam";
        radioButton2.UseVisualStyleBackColor = true;
        radioButton2.CheckedChanged += radioButton2_CheckedChanged;
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Cursor = Cursors.Hand;
        radioButton1.Location = new Point(143, 161);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(189, 24);
        radioButton1.TabIndex = 10;
        radioButton1.TabStop = true;
        radioButton1.Text = "Tôi đang ở Việt Nam";
        radioButton1.UseVisualStyleBackColor = true;
        radioButton1.CheckedChanged += radioButton1_CheckedChanged;
        // 
        // label21
        // 
        label21.AutoSize = true;
        label21.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label21.ForeColor = Color.FromArgb(64, 0, 64);
        label21.Location = new Point(77, 132);
        label21.Name = "label21";
        label21.Size = new Size(344, 20);
        label21.TabIndex = 9;
        label21.Text = "Bạn có đang ở Việt Nam không? (vui lòng chọn)";
        // 
        // fchinh
        // 
        AutoScaleDimensions = new SizeF(10F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(975, 652);
        Controls.Add(pnmua);
        Controls.Add(lbhaychonfile);
        Controls.Add(label4);
        Controls.Add(button1);
        Controls.Add(button2);
        Controls.Add(linkmua);
        Controls.Add(panel2);
        Controls.Add(btnkichhoat);
        Controls.Add(panel4);
        Controls.Add(label1);
        Controls.Add(lbsolanxem);
        Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "fchinh";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Luxy Viplay";
        FormClosed += fchinh_FormClosed;
        Load += fchinh_Load;
        MouseClick += fchinh_MouseClick;
        panel1.ResumeLayout(false);
        ((ISupportInitialize)pictureBox1).EndInit();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        pnmua.ResumeLayout(false);
        pnmua.PerformLayout();
        pnchuyenpaypal.ResumeLayout(false);
        pnchuyenpaypal.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        pnchuyenkhoan.ResumeLayout(false);
        pnchuyenkhoan.PerformLayout();
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        panel7.ResumeLayout(false);
        panel7.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    public fchinh()
	{
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		InitializeComponent();
		if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "file_dulieu\\")))
		{
			Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "file_dulieu\\"));
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "file_dulieu\\"))
		{
			Attributes = FileAttributes.Hidden
		};
		if (File.Exists(Path.Combine(dulieu, "list.lst")))
		{
			string[] array = File.ReadAllLines(Path.Combine(dulieu, "list.lst"));
			int num = 0;
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (File.Exists(text))
				{
					listvideo.Items.Add(text);
				}
				else
				{
					num = 1;
				}
			}
			if (num == 1)
			{
				string[] contents = listvideo.Items.OfType<string>().ToArray();
				File.WriteAllLines(Path.Combine(dulieu, "list.lst"), contents);
			}
		}
		if (!File.Exists(file_ngon_ngu))
		{
			File.WriteAllText(file_ngon_ngu, "1");
		}
		else
		{
			DirectoryInfo directoryInfo2 = new DirectoryInfo(file_ngon_ngu)
			{
				Attributes = FileAttributes.Normal
			};
			ngon_ngu = File.ReadAllText(file_ngon_ngu);
			setngonngu(ngon_ngu, "");
		}
		sol.createfd();
		sol.tinhsolanxem(mavideo);
		solanxem = sol.solanxem;
		if (solanxem < 100)
		{
			label1.Hide();
		}
		else
		{
			label1.Show();
		}
		setngonngu(ngon_ngu, "lbsolanxem");
	}

	public void setngonngu(string ngon_ngu, string thamso)
	{
		if (thamso == "")
		{
			if (ngon_ngu == "2")
			{
				btnmua.Text = "BUY";
				label7.Text = "Price:";
				radioButton2.Text = "I am not in Vietnam";
				radioButton1.Text = "I am in Vietnam";
				label21.Text = "Are you in Vietnam? (please select)";
				lbnhapemail.Text = "      your Email:";
				label9.Text = "Vietinbank (Binh Thuan branch)";
				linkquaylai.Text = "<< Return to previous page";
				label17.Text = "Content:";
				label15.Text = "Amount:";
				label13.Text = "account owner: ";
				label10.Text = "Account Number: ";
				label8.Text = "Bank Name: ";
				label5.Text = "just transfer money according to the following information";
				label18.Text = "If you wait too long or encounter problems, please contact us:";
				label20.Text = "If you wait too long or encounter problems, please contact us:";
				label26.Text = "processing time may take a few hours, we will send the activation file to your email";
				label3.Text = "processing time may take a few hours, we will send the activation file to your email";
				label25.Text = "Content:";
				label23.Text = "Amount:";
				label22.Text = "Receiving account:";
				label6.Text = "Just transfer money to this Paypal account:";
				linkLabel2.Text = "<< Return to previous page";
				chonfilekichhoat = "PLEASE CHOOSE ACTIVATION FILE (kichhoat-activate.kiact)";
				chonvideomo = "PLEASE SELECT A VIDEO TO PLAY (*Video.luxy)";
				chonvideothem = "PLEASE SELECT VIDEOS TO ADD TO LIST (*Video.luxy)";
				btnkichhoat.Text = "Activate";
				lbhaychonfile.Text = "    PLEASE CHOOSE ACTIVATION FILE!           ";
				button1.Text = "PLAY ANOTHER VIDEO";
				button2.Text = "FULL SCREEN";
				button3.Text = "exit full screen";
				label4.Text = "ACTIVATING! PLEASE WAIT!......                            ";
				label1.Text = "PLEASE ACTIVATE FOR VIDEOS OVER 25MB";
				btnthem.Text = "Add";
				btnxem.Text = "PLAY";
				btnxoa.Text = "Remove";
				label11.Text = "Favorite videos list";
				linkmua.Text = "Buy activation file here";
				label2.Text = "This is specialized video APP. Only play videos with .LUXY extension format. For details, please contact luxyviplay@gmail.com";
				lblanguage.Hide();
				lbngonngu.Show();
				btnEnglish.Hide();
				btnTiengViet.Show();
			}
			else
			{
				btnmua.Text = "MUA";
				label7.Text = "   Giá:";
				radioButton2.Text = "tôi không ở việt nam";
				radioButton1.Text = "Tôi đang ở Việt Nam";
				label21.Text = "Bạn có đang ở Việt Nam không? (vui lòng chọn)";
				lbnhapemail.Text = "Email của bạn:";
				label9.Text = "Vietinbank (chi nhánh Bình Thuận)";
				linkquaylai.Text = "<< Quay lại trang trước";
				label17.Text = "Nội dung:";
				label15.Text = "Số tiền:";
				label13.Text = "chủ tài khoản: ";
				label10.Text = "Số Tài Khoản: ";
				label8.Text = "Ngân Hàng: ";
				label5.Text = "chỉ cần chuyển khoản theo thông tin sau";
				label18.Text = "                       nếu đợi lâu hay gặp sự cố hãy liên hệ chúng tôi:";
				label20.Text = "                       nếu đợi lâu hay gặp sự cố hãy liên hệ chúng tôi:";
				label3.Text = "thời gian sử lý có thể mất vài giờ, chúng tôi sẽ gửi file kích hoạt vào email của bạn";
				label26.Text = "thời gian sử lý có thể mất vài giờ, chúng tôi sẽ gửi file kích hoạt vào email của bạn";
				label25.Text = "Nội dung:";
				label23.Text = "Số tiền:";
				label22.Text = "Tài khoản nhận:";
				label6.Text = "chỉ cần gửi tiền vào tài khoản Paypal sau:";
				linkLabel2.Text = "<< Quay lại trang trước";
				chonfilekichhoat = "VUI LÒNG CHỌN FILE KÍCH HOẠT (kichhoat-activate.kiact)";
				chonvideomo = "VUI LÒNG CHỌN VIDEO ĐỂ XEM (*Video.luxy)";
				chonvideothem = "VUI LÒNG CHỌN VIDEO ĐỂ THÊM VÀO DANH SÁCH (*Video.luxy)";
				btnkichhoat.Text = "Kích hoạt";
				lbhaychonfile.Text = "     HÃY CHỌN FILE KÍCH HOẠT!                         ";
				button1.Text = "MỞ VIDEO KHÁC";
				button2.Text = "PHÓNG TO";
				button3.Text = "THU NHỎ";
				label4.Text = "ĐANG KÍCH HOẠT! VUI LÒNG CHỜ!....                           ";
				label1.Text = "HÃY KÍCH HOẠT ĐỂ XEM VIDEO HƠN 25MB    ";
				btnthem.Text = "Thêm";
				btnxem.Text = "XEM";
				btnxoa.Text = "Xóa";
				label11.Text = "Danh sách video yêu thích";
				linkmua.Text = "Mua file kích hoạt ở đây";
				label2.Text = "đây là phần mềm xem video chuyên dụng. chỉ phát video với định dạng đuôi .LUXY chi tiết xin liên hệ luxyviplay@gmail.com";
				lblanguage.Show();
				lbngonngu.Hide();
				btnEnglish.Show();
				btnTiengViet.Hide();
			}
		}
		if (thamso == "chuatraloi")
		{
			if (ngon_ngu == "1")
			{
				MessageBox.Show("bạn chưa chọn trả lời - bạn có đang ở việt nam không?");
			}
			else
			{
				MessageBox.Show("You have not selected an answer yet - Are you in Vietnam?");
			}
		}
		if (thamso == "saiemail")
		{
			if (ngon_ngu == "1")
			{
				MessageBox.Show("hãy nhập Email đúng để chúng tôi gửi file kích hoạt cho bạn");
			}
			else
			{
				MessageBox.Show("Please enter the correct Email so we can send you the activation file");
			}
		}
		if (thamso == "lbthanhcong")
		{
			if (ngon_ngu == "1")
			{
				lbsolanxem.Text = "thành công! bạn được xem 100 video trên 25MB";
			}
			else
			{
				lbsolanxem.Text = "Successful! you can play 100 videos OVER 25MB";
			}
		}
		if (thamso == "lbsolanxem")
		{
			if (ngon_ngu == "1")
			{
				lbsolanxem.Text = "bạn đã xem " + solanxem + " Video trên 25MB, còn lại " + (100 - solanxem) + " lượt nữa";
			}
			else
			{
				lbsolanxem.Text = "You've played " + solanxem + " videos over 25MB. still " + (100 - solanxem) + " times more";
			}
		}
		if (thamso == "thanhcong")
		{
			if (ngon_ngu == "1")
			{
				MessageBox.Show("kích hoạt thành công! giờ bạn có thể xem 100 video lớn hơn 25MB");
			}
			else
			{
				MessageBox.Show("Successful activation! Now you can play 100 videos OVER 25MB");
			}
		}
		if (thamso == "videobixoa")
		{
			if (ngon_ngu == "1")
			{
				MessageBox.Show("video này đã bị xóa");
			}
			else
			{
				MessageBox.Show("this video has been deleted");
			}
		}
		if (thamso == "nhanhqua")
		{
			if (ngon_ngu == "1")
			{
				MessageBox.Show("bạn thao tác quá nhanh!");
			}
			else
			{
				MessageBox.Show("you act too fast!!!");
			}
		}
		if (thamso == "haykichhoat")
		{
			if (ngon_ngu == "1")
			{
				MessageBox.Show("Video LỚN HƠN 25MB - bạn phải KÍCH HOẠT để xem");
			}
			else
			{
				MessageBox.Show("this Video is OVER 25MB - you must ACTIVATE to view");
			}
		}
		if (thamso == "vancon")
		{
			if (ngon_ngu == "1")
			{
				MessageBox.Show("bạn vẫn còn " + (100 - solanxem) + " lần xem video trên 25MB, hãy để dành file kích hoạt");
			}
			else
			{
				MessageBox.Show("You still have " + (100 - solanxem) + " more times to play videos OVER 25MB, save the activation file");
			}
		}
		if (thamso == "ketnoi")
		{
			if (ngon_ngu == "1")
			{
				MessageBox.Show("vui lòng kết nối Internet để kích hoạt");
			}
			else
			{
				MessageBox.Show("Please connect to the internet to activate");
			}
		}
		if (thamso == "maychuban")
		{
			if (ngon_ngu == "1")
			{
				MessageBox.Show("máy chủ bận, thử lại sau nhé");
			}
			else
			{
				MessageBox.Show("The server is busy, please try again later");
			}
		}
		if (thamso == "dasudung")
		{
			if (ngon_ngu == "1")
			{
				MessageBox.Show("mã kích hoạt này đã sử dụng rồi");
			}
			else
			{
				MessageBox.Show("This activation code has already been used");
			}
		}
		if (thamso == "loiphanmem")
		{
			if (ngon_ngu == "1")
			{
				MessageBox.Show("phần mềm bị lỗi. đừng lo hãy tải lại phần mềm và kích hoạt lại");
			}
			else
			{
				MessageBox.Show("sofware has errors. Don't worry, download the software again and reactivate");
			}
		}
		if (thamso == "matketnoi")
		{
			if (ngon_ngu == "1")
			{
				MessageBox.Show("không kết nối được máy chủ");
			}
			else
			{
				MessageBox.Show("Could not connect to server");
			}
		}
		if (thamso == "sai")
		{
			if (ngon_ngu == "1")
			{
				MessageBox.Show("mã kích hoạt không đúng");
			}
			else
			{
				MessageBox.Show("Activation code is incorrect");
			}
		}
		if (thamso == "chuachonfile")
		{
			if (ngon_ngu == "1")
			{
				MessageBox.Show("bạn chưa chọn file mã kích hoạt!");
			}
			else
			{
				MessageBox.Show("You have not selected the activation code file!");
			}
		}
	}

	private void btnmovideo_Click(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "File Video|*.luxy";
			openFileDialog.Title = chonvideomo;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				a = openFileDialog.FileName;
				if (File.Exists(a))
				{
					doit(a);
				}
				else
				{
					setngonngu(ngon_ngu, "videobixoa");
				}
			}
		}
		catch
		{
			setngonngu(ngon_ngu, "nhanhqua");
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "File Video|*.luxy";
			openFileDialog.Title = chonvideomo;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				a = openFileDialog.FileName;
				if (File.Exists(a))
				{
					doit(a);
				}
				else
				{
					setngonngu(ngon_ngu, "videobixoa");
				}
			}
		}
		catch
		{
			setngonngu(ngon_ngu, "nhanhqua");
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		if (kichthuocvideo == 1)
		{
			FormBorderStyle = FormBorderStyle.None;
			WindowState = FormWindowState.Maximized;
			panel2.Dock = DockStyle.Fill;
			panel1.Dock = DockStyle.Fill;
			panel1.BringToFront();
			panel2.BringToFront();
			axWindowsMediaPlayer1.stretchToFit = true;
			axWindowsMediaPlayer1.Width *= 2;
			axWindowsMediaPlayer1.Height *= 2;
			axWindowsMediaPlayer1.uiMode = "none";
			kichthuocvideo = 2;
		}
	}

	private void axWindowsMediaPlayer1_MouseUpEvent(object sender, _WMPOCXEvents_MouseUpEvent e)
	{
		if (e.nButton == 2)
		{
			tchuotphai = 1;
			axWindowsMediaPlayer1.URL = "http://www.matnatim.com/*.mp4";
			return;
		}
		if (tchuotphai == 1 && axWindowsMediaPlayer1.URL == "http://www.matnatim.com/*.mp4")
		{
			sol.loadcodecluxy(a, mavideo);
			axWindowsMediaPlayer1.URL = Path.Combine(Path.Combine(sol.dichma(k1a[3]), sol.dichma(kqua[0]), sol.dichma(k1a[1]), sol.dichma(kqua[2]), sol.dichma(kqua[1])), sol.dichma(k1a[0]));
			sol.xplay();
		}
		timer1.Enabled = true;
		doubleclick++;
		if (doubleclick >= 2 && tick < 1)
		{
			if (kichthuocvideo == 1)
			{
				FormBorderStyle = FormBorderStyle.None;
				WindowState = FormWindowState.Maximized;
				panel2.Dock = DockStyle.Fill;
				panel1.Dock = DockStyle.Fill;
				panel1.BringToFront();
				panel2.BringToFront();
				axWindowsMediaPlayer1.stretchToFit = true;
				axWindowsMediaPlayer1.Width *= 2;
				axWindowsMediaPlayer1.Height *= 2;
				axWindowsMediaPlayer1.uiMode = "none";
				kichthuocvideo = 2;
			}
			else
			{
				FormBorderStyle = FormBorderStyle.FixedSingle;
				WindowState = FormWindowState.Normal;
				panel2.Anchor = (AnchorStyles)(1 - Left);
				panel1.Anchor = (AnchorStyles)(1 - Left);
				panel1.SendToBack();
				panel2.SendToBack();
				pnmua.BringToFront();
				axWindowsMediaPlayer1.stretchToFit = false;
				AxWindowsMediaPlayer axWindowsMediaPlayer = axWindowsMediaPlayer1;
				axWindowsMediaPlayer.Width = axWindowsMediaPlayer.Width;
				AxWindowsMediaPlayer axWindowsMediaPlayer2 = axWindowsMediaPlayer1;
				axWindowsMediaPlayer2.Height = axWindowsMediaPlayer2.Height;
				axWindowsMediaPlayer1.uiMode = "full";
				kichthuocvideo = 1;
			}
		}
		if (axWindowsMediaPlayer1.fullScreen)
		{
			axWindowsMediaPlayer1.fullScreen = false;
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		tick++;
		if (tick >= 1)
		{
			timer1.Enabled = false;
			tick = 0;
			doubleclick = 0;
		}
	}

	private void btnthem_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "File Video|*.luxy";
		openFileDialog.Title = chonvideothem;
		openFileDialog.Multiselect = true;
		if (openFileDialog.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		int num = 0;
		string[] fileNames = openFileDialog.FileNames;
		string[] array = fileNames;
		foreach (string text in array)
		{
			if (!listvideo.Items.Contains(text))
			{
				listvideo.Items.Add(text);
				num = 1;
			}
		}
		if (num == 1)
		{
			string[] contents = listvideo.Items.OfType<string>().ToArray();
			File.WriteAllLines(Path.Combine(dulieu, "list.lst"), contents);
		}
	}

	private void btnxoa_Click(object sender, EventArgs e)
	{
		listvideo.Items.RemoveAt(listvideo.SelectedIndex);
		string[] contents = listvideo.Items.OfType<string>().ToArray();
		File.WriteAllLines(Path.Combine(dulieu, "list.lst"), contents);
		btnxem.Hide();
		btnxoa.Hide();
		dachontronglist = -1;
	}

	private void listvideo_MouseClick(object sender, MouseEventArgs e)
	{
		if (listvideo.SelectedIndex == dachontronglist)
		{
			listvideo.SelectedIndex = -1;
			btnxoa.Hide();
			btnxem.Hide();
		}
		else
		{
			btnxoa.Show();
			btnxem.Show();
		}
		dachontronglist = listvideo.SelectedIndex;
	}

	private void fchinh_MouseClick(object sender, MouseEventArgs e)
	{
		if (listvideo.SelectedIndex == dachontronglist)
		{
			listvideo.SelectedIndex = -1;
			btnxoa.Hide();
			btnxem.Hide();
		}
		dachontronglist = -1;
	}

	private void panel2_MouseClick(object sender, MouseEventArgs e)
	{
		if (listvideo.SelectedIndex == dachontronglist)
		{
			listvideo.SelectedIndex = -1;
			btnxoa.Hide();
			btnxem.Hide();
		}
		listvideo.SelectedIndex = -1;
		dachontronglist = -1;
	}

	private void btnxem_Click(object sender, EventArgs e)
	{
		try
		{
			a = listvideo.SelectedItem.ToString();
			if (File.Exists(a))
			{
				doit(a);
			}
			else
			{
				setngonngu(ngon_ngu, "videobixoa");
			}
		}
		catch
		{
			setngonngu(ngon_ngu, "nhanhqua");
		}
	}

	public void doit(string a)
	{
		sol.loadcodecluxy(a, mavideo);
		axWindowsMediaPlayer1.URL = Path.Combine(Path.Combine(sol.dichma(k1a[3]), sol.dichma(kqua[0]), sol.dichma(k1a[1]), sol.dichma(kqua[2]), sol.dichma(kqua[1])), sol.dichma(k1a[0]));
		axWindowsMediaPlayer1.Show();
		btnmovideo.Hide();
		button1.Show();
		button2.Show();
		pnmua.BringToFront();
		try
		{
			sol.xplay();
		}
		catch
		{
			setngonngu(ngon_ngu, "nhanhqua");
		}
		if (sol.thieu == 1)
		{
			setngonngu(ngon_ngu, "haykichhoat");
		}
		if (sol.thieu == 2)
		{
			solanxem++;
			setngonngu(ngon_ngu, "lbsolanxem");
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);

	private void fchinh_Load(object sender, EventArgs e)
	{
		SetWindowDisplayAffinity(Handle, 1u);
		if (axWindowsMediaPlayer1.fullScreen)
		{
			axWindowsMediaPlayer1.fullScreen = false;
		}
	}

	private void btnkichhoat_Click(object sender, EventArgs e)
	{
		if (solanxem < 100)
		{
			setngonngu(ngon_ngu, "vancon");
			return;
		}
		if (!IsConnectedToInternet())
		{
			setngonngu(ngon_ngu, "ketnoi");
			return;
		}
		lbhaychonfile.Show();
		label4.Show();
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "kiact file|*.kiact";
		openFileDialog.Title = chonfilekichhoat;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			label4.BringToFront();
			lbhaychonfile.Hide();
			string fileName = openFileDialog.FileName;
			string[] array = File.ReadAllLines(fileName);
			string text = sol.dichma(array[1]);
			string text2 = mavideo + text;
			string text3 = "0";
			string text4 = array[2];
			string text5 = sol.dichma(text4);
			string text6 = sol.dichma(array[0]);
			HttpRequest httpRequest = new HttpRequest();
			string text7 = "";
			try
			{
				text7 = httpRequest.Get(text5).ToString();
			}
			catch
			{
				label4.Hide();
				lbsolanxem.Show();
				setngonngu(ngon_ngu, "maychuban");
			}
			string[] array2 = text7.Split('~');
			int num = 0;
			for (int i = 0; i < array2.Length; i++)
			{
				int length = text6.Length;
				if (array2[i].Contains(text6))
				{
					text3 = array2[i].Substring(length);
					break;
				}
				num++;
			}
			if (num >= array2.Length)
			{
				label4.Hide();
				lbsolanxem.Show();
				setngonngu(ngon_ngu, "sai");
				return;
			}
			sol.kichhoat(mavideo, text2, text3, text6, text5);
			if (sol.nkichhoat == 1)
			{
				label4.Hide();
				lbsolanxem.Show();
				setngonngu(ngon_ngu, "dasudung");
			}
			if (sol.nkichhoat == 3 || sol.nkichhoat == 4 || sol.nkichhoat == 5)
			{
				solanxem = 0;
				label4.Hide();
				setngonngu(ngon_ngu, "lbthanhcong");
				lbsolanxem.Show();
				label1.Hide();
				setngonngu(ngon_ngu, "thanhcong");
			}
		}
		else
		{
			lbhaychonfile.Hide();
			label4.Hide();
			lbsolanxem.Show();
			setngonngu(ngon_ngu, "chuachonfile");
		}
	}

	public bool IsConnectedToInternet()
	{
		try
		{
			Dns.GetHostEntry("www.google.com");
			return true;
		}
		catch
		{
			return false;
		}
	}

	private void axWindowsMediaPlayer1_MouseMoveEvent(object sender, _WMPOCXEvents_MouseMoveEvent e)
	{
		if (WindowState == FormWindowState.Maximized)
		{
			if (panel3.Bounds.Contains(Cursor.Position))
			{
				axWindowsMediaPlayer1.uiMode = "full";
				button3.Show();
			}
			else
			{
				axWindowsMediaPlayer1.uiMode = "none";
				button3.Hide();
			}
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		FormBorderStyle = FormBorderStyle.FixedSingle;
		WindowState = FormWindowState.Normal;
		panel2.Anchor = (AnchorStyles)(1 - Left);
		panel1.Anchor = (AnchorStyles)(1 - Left);
		panel1.SendToBack();
		panel2.SendToBack();
		pnmua.BringToFront();
		axWindowsMediaPlayer1.stretchToFit = false;
		AxWindowsMediaPlayer axWindowsMediaPlayer = axWindowsMediaPlayer1;
		axWindowsMediaPlayer.Width = axWindowsMediaPlayer.Width;
		AxWindowsMediaPlayer axWindowsMediaPlayer2 = axWindowsMediaPlayer1;
		axWindowsMediaPlayer2.Height = axWindowsMediaPlayer2.Height;
		axWindowsMediaPlayer1.uiMode = "full";
		kichthuocvideo = 1;
		button3.Hide();
	}

	private void fchinh_FormClosed(object sender, FormClosedEventArgs e)
	{
		try
		{
			sol.xplay();
		}
		catch
		{
		}
	}

	private void btnEnglish_Click(object sender, EventArgs e)
	{
		ngon_ngu = "2";
		File.WriteAllText(file_ngon_ngu, ngon_ngu);
		setngonngu("2", "");
		setngonngu("2", "lbsolanxem");
	}

	private void btnTiengViet_Click(object sender, EventArgs e)
	{
		ngon_ngu = "1";
		File.WriteAllText(file_ngon_ngu, ngon_ngu);
		setngonngu("1", "");
		setngonngu("1", "lbsolanxem");
	}

	private void linkmua_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (!pnmua.Visible)
		{
			pnmua.Show();
			return;
		}
		pnchuyenpaypal.Hide();
		pnmua.Hide();
		pnchuyenkhoan.Hide();
	}

	private void btnclosemua_Click(object sender, EventArgs e)
	{
		pnchuyenpaypal.Hide();
		pnmua.Hide();
		pnchuyenkhoan.Hide();
	}

	private void btnmua_Click(object sender, EventArgs e)
	{
		if (kiemtramail == 1)
		{
			string text = txtemail.Text.Replace("@", " a ");
			string text2 = text.Replace(".", " ");
			lbnoidung1.Text = text2;
			lbnoidung2.Text = text2;
			if (radioButton1.Checked)
			{
				pnchuyenkhoan.Show();
			}
			if (radioButton2.Checked)
			{
				pnchuyenpaypal.Show();
			}
			if (!radioButton1.Checked && !radioButton2.Checked)
			{
				setngonngu(ngon_ngu, "chuatraloi");
			}
		}
		else
		{
			setngonngu(ngon_ngu, "saiemail");
		}
	}

	private void linkquaylai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		pnchuyenkhoan.Hide();
	}

	private void radioButton1_CheckedChanged(object sender, EventArgs e)
	{
		if (radioButton1.Checked)
		{
			lbgia.Text = "1.000.000VNĐ";
		}
	}

	private void radioButton2_CheckedChanged(object sender, EventArgs e)
	{
		if (radioButton2.Checked)
		{
			lbgia.Text = "$50USD";
		}
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		pnchuyenpaypal.Hide();
	}

	private void txtemail_TextChanged(object sender, EventArgs e)
	{
		if (Regex.IsMatch(txtemail.Text, "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,5})+)$"))
		{
			kiemtramail = 1;
			txtemail.ForeColor = Color.Black;
		}
		else
		{
			kiemtramail = 0;
			txtemail.ForeColor = Color.Red;
		}
	}

	private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string fileName = "https://paypal.me/bonghongnau";
		Process.Start(fileName);
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.facebook.com/luxyviplay");
	}
}
