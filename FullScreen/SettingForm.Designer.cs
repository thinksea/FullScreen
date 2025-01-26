namespace FullScreen
{
    partial class SettingForm
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
			colorDialog1 = new ColorDialog();
			label1 = new Label();
			cb主标题描边 = new CheckBox();
			cb显示主标题阴影 = new CheckBox();
			cb主标题阴影描边 = new CheckBox();
			btn主标题描边颜色 = new Button();
			btn主标题阴影的描边颜色 = new Button();
			btn主标题颜色 = new Button();
			btn保存 = new Button();
			btn取消 = new Button();
			cb主标题字体 = new ComboBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			gb主标题描边 = new GroupBox();
			gb显示主标题阴影 = new GroupBox();
			nud主标题阴影距离 = new NumericUpDown();
			label14 = new Label();
			nud主标题阴影的透明度 = new NumericUpDown();
			label5 = new Label();
			label10 = new Label();
			nud主标题字号 = new NumericUpDown();
			label6 = new Label();
			cb背景图文件 = new ComboBox();
			gb显示主标题 = new GroupBox();
			nud主标题垂直坐标 = new NumericUpDown();
			l主标题垂直坐标 = new Label();
			nud主标题水平坐标 = new NumericUpDown();
			l主标题水平坐标 = new Label();
			cb主标题垂直对齐方式 = new ComboBox();
			label19 = new Label();
			cb主标题水平对齐方式 = new ComboBox();
			label18 = new Label();
			tb主标题 = new TextBox();
			label16 = new Label();
			cb显示主标题 = new CheckBox();
			gb显示副标题 = new GroupBox();
			nud副标题垂直坐标 = new NumericUpDown();
			tb副标题 = new TextBox();
			l副标题垂直坐标 = new Label();
			label17 = new Label();
			nud副标题水平坐标 = new NumericUpDown();
			label7 = new Label();
			l副标题水平坐标 = new Label();
			cb副标题字体 = new ComboBox();
			cb副标题垂直对齐方式 = new ComboBox();
			nud副标题字号 = new NumericUpDown();
			label23 = new Label();
			btn副标题颜色 = new Button();
			cb副标题水平对齐方式 = new ComboBox();
			label22 = new Label();
			cb显示副标题阴影 = new CheckBox();
			gb显示副标题阴影 = new GroupBox();
			nud副标题阴影距离 = new NumericUpDown();
			label8 = new Label();
			nud副标题阴影的透明度 = new NumericUpDown();
			label9 = new Label();
			cb副标题阴影描边 = new CheckBox();
			label11 = new Label();
			btn副标题阴影的描边颜色 = new Button();
			label12 = new Label();
			label13 = new Label();
			cb副标题描边 = new CheckBox();
			gb副标题描边 = new GroupBox();
			label15 = new Label();
			btn副标题描边颜色 = new Button();
			cb显示副标题 = new CheckBox();
			label20 = new Label();
			btn背景颜色 = new Button();
			cb窗体置顶 = new CheckBox();
			cb背景图像布局 = new ComboBox();
			gb主标题描边.SuspendLayout();
			gb显示主标题阴影.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nud主标题阴影距离).BeginInit();
			((System.ComponentModel.ISupportInitialize)nud主标题阴影的透明度).BeginInit();
			((System.ComponentModel.ISupportInitialize)nud主标题字号).BeginInit();
			gb显示主标题.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nud主标题垂直坐标).BeginInit();
			((System.ComponentModel.ISupportInitialize)nud主标题水平坐标).BeginInit();
			gb显示副标题.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nud副标题垂直坐标).BeginInit();
			((System.ComponentModel.ISupportInitialize)nud副标题水平坐标).BeginInit();
			((System.ComponentModel.ISupportInitialize)nud副标题字号).BeginInit();
			gb显示副标题阴影.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nud副标题阴影距离).BeginInit();
			((System.ComponentModel.ISupportInitialize)nud副标题阴影的透明度).BeginInit();
			gb副标题描边.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(18, 68);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(32, 17);
			label1.TabIndex = 2;
			label1.Text = "字体";
			// 
			// cb主标题描边
			// 
			cb主标题描边.AutoSize = true;
			cb主标题描边.Checked = true;
			cb主标题描边.CheckState = CheckState.Checked;
			cb主标题描边.Location = new Point(24, 148);
			cb主标题描边.Margin = new Padding(2);
			cb主标题描边.Name = "cb主标题描边";
			cb主标题描边.Size = new Size(51, 21);
			cb主标题描边.TabIndex = 8;
			cb主标题描边.Text = "描边";
			cb主标题描边.UseVisualStyleBackColor = true;
			cb主标题描边.CheckedChanged += cb主标题描边_CheckedChanged;
			// 
			// cb显示主标题阴影
			// 
			cb显示主标题阴影.AutoSize = true;
			cb显示主标题阴影.Checked = true;
			cb显示主标题阴影.CheckState = CheckState.Checked;
			cb显示主标题阴影.Location = new Point(24, 242);
			cb显示主标题阴影.Margin = new Padding(2);
			cb显示主标题阴影.Name = "cb显示主标题阴影";
			cb显示主标题阴影.Size = new Size(75, 21);
			cb显示主标题阴影.TabIndex = 10;
			cb显示主标题阴影.Text = "显示阴影";
			cb显示主标题阴影.UseVisualStyleBackColor = true;
			cb显示主标题阴影.CheckedChanged += cb主标题显示阴影_CheckedChanged;
			// 
			// cb主标题阴影描边
			// 
			cb主标题阴影描边.AutoSize = true;
			cb主标题阴影描边.Location = new Point(15, 71);
			cb主标题阴影描边.Margin = new Padding(2);
			cb主标题阴影描边.Name = "cb主标题阴影描边";
			cb主标题阴影描边.Size = new Size(75, 21);
			cb主标题阴影描边.TabIndex = 4;
			cb主标题阴影描边.Text = "阴影描边";
			cb主标题阴影描边.UseVisualStyleBackColor = true;
			// 
			// btn主标题描边颜色
			// 
			btn主标题描边颜色.Location = new Point(60, 22);
			btn主标题描边颜色.Margin = new Padding(2);
			btn主标题描边颜色.Name = "btn主标题描边颜色";
			btn主标题描边颜色.Size = new Size(75, 25);
			btn主标题描边颜色.TabIndex = 1;
			btn主标题描边颜色.UseVisualStyleBackColor = true;
			btn主标题描边颜色.Click += btn主标题描边颜色_Click;
			// 
			// btn主标题阴影的描边颜色
			// 
			btn主标题阴影的描边颜色.Location = new Point(152, 68);
			btn主标题阴影的描边颜色.Margin = new Padding(2);
			btn主标题阴影的描边颜色.Name = "btn主标题阴影的描边颜色";
			btn主标题阴影的描边颜色.Size = new Size(75, 25);
			btn主标题阴影的描边颜色.TabIndex = 6;
			btn主标题阴影的描边颜色.UseVisualStyleBackColor = true;
			btn主标题阴影的描边颜色.Click += btn主标题阴影的描边颜色_Click;
			// 
			// btn主标题颜色
			// 
			btn主标题颜色.Location = new Point(74, 108);
			btn主标题颜色.Margin = new Padding(2);
			btn主标题颜色.Name = "btn主标题颜色";
			btn主标题颜色.Size = new Size(75, 25);
			btn主标题颜色.TabIndex = 5;
			btn主标题颜色.UseVisualStyleBackColor = true;
			btn主标题颜色.Click += btn主标题文本颜色_Click;
			// 
			// btn保存
			// 
			btn保存.Location = new Point(256, 572);
			btn保存.Margin = new Padding(2);
			btn保存.Name = "btn保存";
			btn保存.Size = new Size(75, 25);
			btn保存.TabIndex = 10;
			btn保存.Text = "保存(&S)";
			btn保存.UseVisualStyleBackColor = true;
			btn保存.Click += btn保存_Click;
			// 
			// btn取消
			// 
			btn取消.DialogResult = DialogResult.Cancel;
			btn取消.Location = new Point(362, 572);
			btn取消.Margin = new Padding(2);
			btn取消.Name = "btn取消";
			btn取消.Size = new Size(75, 25);
			btn取消.TabIndex = 11;
			btn取消.Text = "取消(&C)";
			btn取消.UseVisualStyleBackColor = true;
			// 
			// cb主标题字体
			// 
			cb主标题字体.DrawMode = DrawMode.OwnerDrawVariable;
			cb主标题字体.DropDownStyle = ComboBoxStyle.DropDownList;
			cb主标题字体.FormattingEnabled = true;
			cb主标题字体.Location = new Point(74, 66);
			cb主标题字体.Margin = new Padding(2);
			cb主标题字体.Name = "cb主标题字体";
			cb主标题字体.Size = new Size(226, 24);
			cb主标题字体.TabIndex = 3;
			cb主标题字体.DrawItem += cb主标题字体_DrawItem;
			cb主标题字体.MeasureItem += cb主标题字体_MeasureItem;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(18, 112);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(32, 17);
			label2.TabIndex = 4;
			label2.Text = "颜色";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(14, 27);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(32, 17);
			label3.TabIndex = 0;
			label3.Text = "颜色";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(112, 72);
			label4.Margin = new Padding(2, 0, 2, 0);
			label4.Name = "label4";
			label4.Size = new Size(32, 17);
			label4.TabIndex = 5;
			label4.Text = "颜色";
			// 
			// gb主标题描边
			// 
			gb主标题描边.Controls.Add(label3);
			gb主标题描边.Controls.Add(btn主标题描边颜色);
			gb主标题描边.Location = new Point(16, 149);
			gb主标题描边.Margin = new Padding(2);
			gb主标题描边.Name = "gb主标题描边";
			gb主标题描边.Padding = new Padding(2);
			gb主标题描边.Size = new Size(282, 77);
			gb主标题描边.TabIndex = 9;
			gb主标题描边.TabStop = false;
			// 
			// gb显示主标题阴影
			// 
			gb显示主标题阴影.Controls.Add(nud主标题阴影距离);
			gb显示主标题阴影.Controls.Add(label14);
			gb显示主标题阴影.Controls.Add(nud主标题阴影的透明度);
			gb显示主标题阴影.Controls.Add(label5);
			gb显示主标题阴影.Controls.Add(cb主标题阴影描边);
			gb显示主标题阴影.Controls.Add(label4);
			gb显示主标题阴影.Controls.Add(btn主标题阴影的描边颜色);
			gb显示主标题阴影.Location = new Point(16, 243);
			gb显示主标题阴影.Margin = new Padding(2);
			gb显示主标题阴影.Name = "gb显示主标题阴影";
			gb显示主标题阴影.Padding = new Padding(2);
			gb显示主标题阴影.Size = new Size(282, 127);
			gb显示主标题阴影.TabIndex = 11;
			gb显示主标题阴影.TabStop = false;
			// 
			// nud主标题阴影距离
			// 
			nud主标题阴影距离.Location = new Point(74, 25);
			nud主标题阴影距离.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
			nud主标题阴影距离.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nud主标题阴影距离.Name = "nud主标题阴影距离";
			nud主标题阴影距离.Size = new Size(61, 23);
			nud主标题阴影距离.TabIndex = 1;
			nud主标题阴影距离.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(11, 27);
			label14.Name = "label14";
			label14.Size = new Size(56, 17);
			label14.TabIndex = 0;
			label14.Text = "阴影距离";
			// 
			// nud主标题阴影的透明度
			// 
			nud主标题阴影的透明度.Location = new Point(204, 25);
			nud主标题阴影的透明度.Margin = new Padding(2);
			nud主标题阴影的透明度.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
			nud主标题阴影的透明度.Name = "nud主标题阴影的透明度";
			nud主标题阴影的透明度.Size = new Size(67, 23);
			nud主标题阴影的透明度.TabIndex = 3;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(150, 27);
			label5.Margin = new Padding(2, 0, 2, 0);
			label5.Name = "label5";
			label5.Size = new Size(44, 17);
			label5.TabIndex = 2;
			label5.Text = "透明度";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(179, 112);
			label10.Name = "label10";
			label10.Size = new Size(32, 17);
			label10.TabIndex = 6;
			label10.Text = "大小";
			// 
			// nud主标题字号
			// 
			nud主标题字号.Location = new Point(226, 110);
			nud主标题字号.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
			nud主标题字号.Minimum = new decimal(new int[] { 24, 0, 0, 0 });
			nud主标题字号.Name = "nud主标题字号";
			nud主标题字号.Size = new Size(72, 23);
			nud主标题字号.TabIndex = 7;
			nud主标题字号.Value = new decimal(new int[] { 24, 0, 0, 0 });
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(189, 22);
			label6.Margin = new Padding(2, 0, 2, 0);
			label6.Name = "label6";
			label6.Size = new Size(44, 17);
			label6.TabIndex = 2;
			label6.Text = "背景图";
			// 
			// cb背景图文件
			// 
			cb背景图文件.DropDownStyle = ComboBoxStyle.DropDownList;
			cb背景图文件.FormattingEnabled = true;
			cb背景图文件.Location = new Point(240, 18);
			cb背景图文件.Margin = new Padding(2);
			cb背景图文件.Name = "cb背景图文件";
			cb背景图文件.Size = new Size(219, 25);
			cb背景图文件.TabIndex = 3;
			// 
			// gb显示主标题
			// 
			gb显示主标题.Controls.Add(nud主标题垂直坐标);
			gb显示主标题.Controls.Add(l主标题垂直坐标);
			gb显示主标题.Controls.Add(nud主标题水平坐标);
			gb显示主标题.Controls.Add(l主标题水平坐标);
			gb显示主标题.Controls.Add(cb主标题垂直对齐方式);
			gb显示主标题.Controls.Add(label19);
			gb显示主标题.Controls.Add(cb主标题水平对齐方式);
			gb显示主标题.Controls.Add(label18);
			gb显示主标题.Controls.Add(tb主标题);
			gb显示主标题.Controls.Add(label16);
			gb显示主标题.Controls.Add(label10);
			gb显示主标题.Controls.Add(cb主标题字体);
			gb显示主标题.Controls.Add(nud主标题字号);
			gb显示主标题.Controls.Add(btn主标题颜色);
			gb显示主标题.Controls.Add(cb显示主标题阴影);
			gb显示主标题.Controls.Add(gb显示主标题阴影);
			gb显示主标题.Controls.Add(label2);
			gb显示主标题.Controls.Add(label1);
			gb显示主标题.Controls.Add(cb主标题描边);
			gb显示主标题.Controls.Add(gb主标题描边);
			gb显示主标题.Location = new Point(24, 65);
			gb显示主标题.Margin = new Padding(2);
			gb显示主标题.Name = "gb显示主标题";
			gb显示主标题.Padding = new Padding(2);
			gb显示主标题.Size = new Size(317, 481);
			gb显示主标题.TabIndex = 7;
			gb显示主标题.TabStop = false;
			// 
			// nud主标题垂直坐标
			// 
			nud主标题垂直坐标.Location = new Point(226, 429);
			nud主标题垂直坐标.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
			nud主标题垂直坐标.Name = "nud主标题垂直坐标";
			nud主标题垂直坐标.Size = new Size(72, 23);
			nud主标题垂直坐标.TabIndex = 19;
			// 
			// l主标题垂直坐标
			// 
			l主标题垂直坐标.AutoSize = true;
			l主标题垂直坐标.Location = new Point(178, 432);
			l主标题垂直坐标.Margin = new Padding(2, 0, 2, 0);
			l主标题垂直坐标.Name = "l主标题垂直坐标";
			l主标题垂直坐标.Size = new Size(39, 17);
			l主标题垂直坐标.TabIndex = 18;
			l主标题垂直坐标.Text = "Y坐标";
			// 
			// nud主标题水平坐标
			// 
			nud主标题水平坐标.Location = new Point(226, 389);
			nud主标题水平坐标.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
			nud主标题水平坐标.Name = "nud主标题水平坐标";
			nud主标题水平坐标.Size = new Size(72, 23);
			nud主标题水平坐标.TabIndex = 15;
			// 
			// l主标题水平坐标
			// 
			l主标题水平坐标.AutoSize = true;
			l主标题水平坐标.Location = new Point(178, 392);
			l主标题水平坐标.Margin = new Padding(2, 0, 2, 0);
			l主标题水平坐标.Name = "l主标题水平坐标";
			l主标题水平坐标.Size = new Size(40, 17);
			l主标题水平坐标.TabIndex = 14;
			l主标题水平坐标.Text = "X坐标";
			// 
			// cb主标题垂直对齐方式
			// 
			cb主标题垂直对齐方式.DropDownStyle = ComboBoxStyle.DropDownList;
			cb主标题垂直对齐方式.FormattingEnabled = true;
			cb主标题垂直对齐方式.Location = new Point(76, 429);
			cb主标题垂直对齐方式.Margin = new Padding(2);
			cb主标题垂直对齐方式.Name = "cb主标题垂直对齐方式";
			cb主标题垂直对齐方式.Size = new Size(85, 25);
			cb主标题垂直对齐方式.TabIndex = 17;
			cb主标题垂直对齐方式.SelectedIndexChanged += cb主标题垂直对齐方式_SelectedIndexChanged;
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Location = new Point(12, 432);
			label19.Margin = new Padding(2, 0, 2, 0);
			label19.Name = "label19";
			label19.Size = new Size(56, 17);
			label19.TabIndex = 16;
			label19.Text = "垂直对齐";
			// 
			// cb主标题水平对齐方式
			// 
			cb主标题水平对齐方式.DropDownStyle = ComboBoxStyle.DropDownList;
			cb主标题水平对齐方式.FormattingEnabled = true;
			cb主标题水平对齐方式.Location = new Point(76, 389);
			cb主标题水平对齐方式.Margin = new Padding(2);
			cb主标题水平对齐方式.Name = "cb主标题水平对齐方式";
			cb主标题水平对齐方式.Size = new Size(85, 25);
			cb主标题水平对齐方式.TabIndex = 13;
			cb主标题水平对齐方式.SelectedIndexChanged += cb主标题水平对齐方式_SelectedIndexChanged;
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Location = new Point(12, 392);
			label18.Margin = new Padding(2, 0, 2, 0);
			label18.Name = "label18";
			label18.Size = new Size(56, 17);
			label18.TabIndex = 12;
			label18.Text = "水平对齐";
			// 
			// tb主标题
			// 
			tb主标题.Location = new Point(74, 20);
			tb主标题.Margin = new Padding(2);
			tb主标题.Name = "tb主标题";
			tb主标题.Size = new Size(226, 23);
			tb主标题.TabIndex = 1;
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(18, 22);
			label16.Margin = new Padding(2, 0, 2, 0);
			label16.Name = "label16";
			label16.Size = new Size(44, 17);
			label16.TabIndex = 0;
			label16.Text = "主标题";
			// 
			// cb显示主标题
			// 
			cb显示主标题.AutoSize = true;
			cb显示主标题.Checked = true;
			cb显示主标题.CheckState = CheckState.Checked;
			cb显示主标题.Location = new Point(32, 64);
			cb显示主标题.Margin = new Padding(2);
			cb显示主标题.Name = "cb显示主标题";
			cb显示主标题.Size = new Size(87, 21);
			cb显示主标题.TabIndex = 6;
			cb显示主标题.Text = "显示主标题";
			cb显示主标题.UseVisualStyleBackColor = true;
			cb显示主标题.CheckedChanged += cb显示主标题_CheckedChanged;
			// 
			// gb显示副标题
			// 
			gb显示副标题.Controls.Add(nud副标题垂直坐标);
			gb显示副标题.Controls.Add(tb副标题);
			gb显示副标题.Controls.Add(l副标题垂直坐标);
			gb显示副标题.Controls.Add(label17);
			gb显示副标题.Controls.Add(nud副标题水平坐标);
			gb显示副标题.Controls.Add(label7);
			gb显示副标题.Controls.Add(l副标题水平坐标);
			gb显示副标题.Controls.Add(cb副标题字体);
			gb显示副标题.Controls.Add(cb副标题垂直对齐方式);
			gb显示副标题.Controls.Add(nud副标题字号);
			gb显示副标题.Controls.Add(label23);
			gb显示副标题.Controls.Add(btn副标题颜色);
			gb显示副标题.Controls.Add(cb副标题水平对齐方式);
			gb显示副标题.Controls.Add(label22);
			gb显示副标题.Controls.Add(cb显示副标题阴影);
			gb显示副标题.Controls.Add(gb显示副标题阴影);
			gb显示副标题.Controls.Add(label12);
			gb显示副标题.Controls.Add(label13);
			gb显示副标题.Controls.Add(cb副标题描边);
			gb显示副标题.Controls.Add(gb副标题描边);
			gb显示副标题.Location = new Point(360, 67);
			gb显示副标题.Margin = new Padding(2);
			gb显示副标题.Name = "gb显示副标题";
			gb显示副标题.Padding = new Padding(2);
			gb显示副标题.Size = new Size(317, 479);
			gb显示副标题.TabIndex = 9;
			gb显示副标题.TabStop = false;
			// 
			// nud副标题垂直坐标
			// 
			nud副标题垂直坐标.Location = new Point(226, 429);
			nud副标题垂直坐标.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
			nud副标题垂直坐标.Name = "nud副标题垂直坐标";
			nud副标题垂直坐标.Size = new Size(72, 23);
			nud副标题垂直坐标.TabIndex = 19;
			// 
			// tb副标题
			// 
			tb副标题.Location = new Point(74, 20);
			tb副标题.Margin = new Padding(2);
			tb副标题.Name = "tb副标题";
			tb副标题.Size = new Size(226, 23);
			tb副标题.TabIndex = 1;
			// 
			// l副标题垂直坐标
			// 
			l副标题垂直坐标.AutoSize = true;
			l副标题垂直坐标.Location = new Point(178, 432);
			l副标题垂直坐标.Margin = new Padding(2, 0, 2, 0);
			l副标题垂直坐标.Name = "l副标题垂直坐标";
			l副标题垂直坐标.Size = new Size(39, 17);
			l副标题垂直坐标.TabIndex = 18;
			l副标题垂直坐标.Text = "Y坐标";
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(15, 22);
			label17.Margin = new Padding(2, 0, 2, 0);
			label17.Name = "label17";
			label17.Size = new Size(44, 17);
			label17.TabIndex = 0;
			label17.Text = "副标题";
			// 
			// nud副标题水平坐标
			// 
			nud副标题水平坐标.Location = new Point(226, 389);
			nud副标题水平坐标.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
			nud副标题水平坐标.Name = "nud副标题水平坐标";
			nud副标题水平坐标.Size = new Size(72, 23);
			nud副标题水平坐标.TabIndex = 15;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(179, 111);
			label7.Name = "label7";
			label7.Size = new Size(32, 17);
			label7.TabIndex = 6;
			label7.Text = "大小";
			// 
			// l副标题水平坐标
			// 
			l副标题水平坐标.AutoSize = true;
			l副标题水平坐标.Location = new Point(178, 392);
			l副标题水平坐标.Margin = new Padding(2, 0, 2, 0);
			l副标题水平坐标.Name = "l副标题水平坐标";
			l副标题水平坐标.Size = new Size(40, 17);
			l副标题水平坐标.TabIndex = 14;
			l副标题水平坐标.Text = "X坐标";
			// 
			// cb副标题字体
			// 
			cb副标题字体.DrawMode = DrawMode.OwnerDrawVariable;
			cb副标题字体.DropDownStyle = ComboBoxStyle.DropDownList;
			cb副标题字体.FormattingEnabled = true;
			cb副标题字体.Location = new Point(74, 64);
			cb副标题字体.Margin = new Padding(2);
			cb副标题字体.Name = "cb副标题字体";
			cb副标题字体.Size = new Size(226, 24);
			cb副标题字体.TabIndex = 3;
			cb副标题字体.DrawItem += cb副标题字体_DrawItem;
			cb副标题字体.MeasureItem += cb副标题字体_MeasureItem;
			// 
			// cb副标题垂直对齐方式
			// 
			cb副标题垂直对齐方式.DropDownStyle = ComboBoxStyle.DropDownList;
			cb副标题垂直对齐方式.FormattingEnabled = true;
			cb副标题垂直对齐方式.Location = new Point(76, 429);
			cb副标题垂直对齐方式.Margin = new Padding(2);
			cb副标题垂直对齐方式.Name = "cb副标题垂直对齐方式";
			cb副标题垂直对齐方式.Size = new Size(85, 25);
			cb副标题垂直对齐方式.TabIndex = 17;
			cb副标题垂直对齐方式.SelectedIndexChanged += cb副标题垂直对齐方式_SelectedIndexChanged;
			// 
			// nud副标题字号
			// 
			nud副标题字号.Location = new Point(226, 109);
			nud副标题字号.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
			nud副标题字号.Minimum = new decimal(new int[] { 24, 0, 0, 0 });
			nud副标题字号.Name = "nud副标题字号";
			nud副标题字号.Size = new Size(72, 23);
			nud副标题字号.TabIndex = 7;
			nud副标题字号.Value = new decimal(new int[] { 24, 0, 0, 0 });
			// 
			// label23
			// 
			label23.AutoSize = true;
			label23.Location = new Point(12, 432);
			label23.Margin = new Padding(2, 0, 2, 0);
			label23.Name = "label23";
			label23.Size = new Size(56, 17);
			label23.TabIndex = 16;
			label23.Text = "垂直对齐";
			// 
			// btn副标题颜色
			// 
			btn副标题颜色.Location = new Point(74, 106);
			btn副标题颜色.Margin = new Padding(2);
			btn副标题颜色.Name = "btn副标题颜色";
			btn副标题颜色.Size = new Size(75, 25);
			btn副标题颜色.TabIndex = 5;
			btn副标题颜色.UseVisualStyleBackColor = true;
			btn副标题颜色.Click += btn副标题文本颜色_Click;
			// 
			// cb副标题水平对齐方式
			// 
			cb副标题水平对齐方式.DropDownStyle = ComboBoxStyle.DropDownList;
			cb副标题水平对齐方式.FormattingEnabled = true;
			cb副标题水平对齐方式.Location = new Point(76, 389);
			cb副标题水平对齐方式.Margin = new Padding(2);
			cb副标题水平对齐方式.Name = "cb副标题水平对齐方式";
			cb副标题水平对齐方式.Size = new Size(85, 25);
			cb副标题水平对齐方式.TabIndex = 13;
			cb副标题水平对齐方式.SelectedIndexChanged += cb副标题水平对齐方式_SelectedIndexChanged;
			// 
			// label22
			// 
			label22.AutoSize = true;
			label22.Location = new Point(12, 392);
			label22.Margin = new Padding(2, 0, 2, 0);
			label22.Name = "label22";
			label22.Size = new Size(56, 17);
			label22.TabIndex = 12;
			label22.Text = "水平对齐";
			// 
			// cb显示副标题阴影
			// 
			cb显示副标题阴影.AutoSize = true;
			cb显示副标题阴影.Checked = true;
			cb显示副标题阴影.CheckState = CheckState.Checked;
			cb显示副标题阴影.Location = new Point(24, 241);
			cb显示副标题阴影.Margin = new Padding(2);
			cb显示副标题阴影.Name = "cb显示副标题阴影";
			cb显示副标题阴影.Size = new Size(75, 21);
			cb显示副标题阴影.TabIndex = 10;
			cb显示副标题阴影.Text = "显示阴影";
			cb显示副标题阴影.UseVisualStyleBackColor = true;
			cb显示副标题阴影.CheckedChanged += cb副标题显示阴影_CheckedChanged;
			// 
			// gb显示副标题阴影
			// 
			gb显示副标题阴影.Controls.Add(nud副标题阴影距离);
			gb显示副标题阴影.Controls.Add(label8);
			gb显示副标题阴影.Controls.Add(nud副标题阴影的透明度);
			gb显示副标题阴影.Controls.Add(label9);
			gb显示副标题阴影.Controls.Add(cb副标题阴影描边);
			gb显示副标题阴影.Controls.Add(label11);
			gb显示副标题阴影.Controls.Add(btn副标题阴影的描边颜色);
			gb显示副标题阴影.Location = new Point(16, 242);
			gb显示副标题阴影.Margin = new Padding(2);
			gb显示副标题阴影.Name = "gb显示副标题阴影";
			gb显示副标题阴影.Padding = new Padding(2);
			gb显示副标题阴影.Size = new Size(282, 127);
			gb显示副标题阴影.TabIndex = 11;
			gb显示副标题阴影.TabStop = false;
			// 
			// nud副标题阴影距离
			// 
			nud副标题阴影距离.Location = new Point(74, 25);
			nud副标题阴影距离.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
			nud副标题阴影距离.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nud副标题阴影距离.Name = "nud副标题阴影距离";
			nud副标题阴影距离.Size = new Size(61, 23);
			nud副标题阴影距离.TabIndex = 1;
			nud副标题阴影距离.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(11, 27);
			label8.Name = "label8";
			label8.Size = new Size(56, 17);
			label8.TabIndex = 0;
			label8.Text = "阴影距离";
			// 
			// nud副标题阴影的透明度
			// 
			nud副标题阴影的透明度.Location = new Point(204, 25);
			nud副标题阴影的透明度.Margin = new Padding(2);
			nud副标题阴影的透明度.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
			nud副标题阴影的透明度.Name = "nud副标题阴影的透明度";
			nud副标题阴影的透明度.Size = new Size(67, 23);
			nud副标题阴影的透明度.TabIndex = 3;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(150, 27);
			label9.Margin = new Padding(2, 0, 2, 0);
			label9.Name = "label9";
			label9.Size = new Size(44, 17);
			label9.TabIndex = 2;
			label9.Text = "透明度";
			// 
			// cb副标题阴影描边
			// 
			cb副标题阴影描边.AutoSize = true;
			cb副标题阴影描边.Location = new Point(15, 71);
			cb副标题阴影描边.Margin = new Padding(2);
			cb副标题阴影描边.Name = "cb副标题阴影描边";
			cb副标题阴影描边.Size = new Size(75, 21);
			cb副标题阴影描边.TabIndex = 4;
			cb副标题阴影描边.Text = "阴影描边";
			cb副标题阴影描边.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(112, 72);
			label11.Margin = new Padding(2, 0, 2, 0);
			label11.Name = "label11";
			label11.Size = new Size(32, 17);
			label11.TabIndex = 5;
			label11.Text = "颜色";
			// 
			// btn副标题阴影的描边颜色
			// 
			btn副标题阴影的描边颜色.Location = new Point(152, 68);
			btn副标题阴影的描边颜色.Margin = new Padding(2);
			btn副标题阴影的描边颜色.Name = "btn副标题阴影的描边颜色";
			btn副标题阴影的描边颜色.Size = new Size(75, 25);
			btn副标题阴影的描边颜色.TabIndex = 6;
			btn副标题阴影的描边颜色.UseVisualStyleBackColor = true;
			btn副标题阴影的描边颜色.Click += btn副标题阴影的描边颜色_Click;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(15, 111);
			label12.Margin = new Padding(2, 0, 2, 0);
			label12.Name = "label12";
			label12.Size = new Size(32, 17);
			label12.TabIndex = 4;
			label12.Text = "颜色";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(15, 66);
			label13.Margin = new Padding(2, 0, 2, 0);
			label13.Name = "label13";
			label13.Size = new Size(32, 17);
			label13.TabIndex = 2;
			label13.Text = "字体";
			// 
			// cb副标题描边
			// 
			cb副标题描边.AutoSize = true;
			cb副标题描边.Checked = true;
			cb副标题描边.CheckState = CheckState.Checked;
			cb副标题描边.Location = new Point(24, 146);
			cb副标题描边.Margin = new Padding(2);
			cb副标题描边.Name = "cb副标题描边";
			cb副标题描边.Size = new Size(51, 21);
			cb副标题描边.TabIndex = 8;
			cb副标题描边.Text = "描边";
			cb副标题描边.UseVisualStyleBackColor = true;
			cb副标题描边.CheckedChanged += cb副标题描边_CheckedChanged;
			// 
			// gb副标题描边
			// 
			gb副标题描边.Controls.Add(label15);
			gb副标题描边.Controls.Add(btn副标题描边颜色);
			gb副标题描边.Location = new Point(16, 147);
			gb副标题描边.Margin = new Padding(2);
			gb副标题描边.Name = "gb副标题描边";
			gb副标题描边.Padding = new Padding(2);
			gb副标题描边.Size = new Size(282, 77);
			gb副标题描边.TabIndex = 9;
			gb副标题描边.TabStop = false;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(14, 27);
			label15.Margin = new Padding(2, 0, 2, 0);
			label15.Name = "label15";
			label15.Size = new Size(32, 17);
			label15.TabIndex = 0;
			label15.Text = "颜色";
			// 
			// btn副标题描边颜色
			// 
			btn副标题描边颜色.Location = new Point(60, 22);
			btn副标题描边颜色.Margin = new Padding(2);
			btn副标题描边颜色.Name = "btn副标题描边颜色";
			btn副标题描边颜色.Size = new Size(75, 25);
			btn副标题描边颜色.TabIndex = 1;
			btn副标题描边颜色.UseVisualStyleBackColor = true;
			btn副标题描边颜色.Click += btn副标题描边颜色_Click;
			// 
			// cb显示副标题
			// 
			cb显示副标题.AutoSize = true;
			cb显示副标题.Checked = true;
			cb显示副标题.CheckState = CheckState.Checked;
			cb显示副标题.Location = new Point(368, 65);
			cb显示副标题.Margin = new Padding(2);
			cb显示副标题.Name = "cb显示副标题";
			cb显示副标题.Size = new Size(87, 21);
			cb显示副标题.TabIndex = 8;
			cb显示副标题.Text = "显示副标题";
			cb显示副标题.UseVisualStyleBackColor = true;
			cb显示副标题.CheckedChanged += cb显示副标题_CheckedChanged;
			// 
			// label20
			// 
			label20.AutoSize = true;
			label20.Location = new Point(41, 22);
			label20.Margin = new Padding(2, 0, 2, 0);
			label20.Name = "label20";
			label20.Size = new Size(44, 17);
			label20.TabIndex = 0;
			label20.Text = "背景色";
			// 
			// btn背景颜色
			// 
			btn背景颜色.Location = new Point(98, 18);
			btn背景颜色.Margin = new Padding(2);
			btn背景颜色.Name = "btn背景颜色";
			btn背景颜色.Size = new Size(75, 25);
			btn背景颜色.TabIndex = 1;
			btn背景颜色.UseVisualStyleBackColor = true;
			btn背景颜色.Click += btn背景颜色_Click;
			// 
			// cb窗体置顶
			// 
			cb窗体置顶.AutoSize = true;
			cb窗体置顶.Location = new Point(586, 20);
			cb窗体置顶.Margin = new Padding(2);
			cb窗体置顶.Name = "cb窗体置顶";
			cb窗体置顶.Size = new Size(75, 21);
			cb窗体置顶.TabIndex = 5;
			cb窗体置顶.Text = "置顶显示";
			cb窗体置顶.UseVisualStyleBackColor = true;
			// 
			// cb背景图像布局
			// 
			cb背景图像布局.DropDownStyle = ComboBoxStyle.DropDownList;
			cb背景图像布局.FormattingEnabled = true;
			cb背景图像布局.Location = new Point(470, 18);
			cb背景图像布局.Name = "cb背景图像布局";
			cb背景图像布局.Size = new Size(107, 25);
			cb背景图像布局.TabIndex = 4;
			// 
			// SettingForm
			// 
			AcceptButton = btn保存;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btn取消;
			ClientSize = new Size(699, 615);
			Controls.Add(cb背景图像布局);
			Controls.Add(cb窗体置顶);
			Controls.Add(label20);
			Controls.Add(btn背景颜色);
			Controls.Add(cb显示副标题);
			Controls.Add(gb显示副标题);
			Controls.Add(cb显示主标题);
			Controls.Add(gb显示主标题);
			Controls.Add(label6);
			Controls.Add(cb背景图文件);
			Controls.Add(btn取消);
			Controls.Add(btn保存);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(2);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "SettingForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "设置";
			TopMost = true;
			gb主标题描边.ResumeLayout(false);
			gb主标题描边.PerformLayout();
			gb显示主标题阴影.ResumeLayout(false);
			gb显示主标题阴影.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nud主标题阴影距离).EndInit();
			((System.ComponentModel.ISupportInitialize)nud主标题阴影的透明度).EndInit();
			((System.ComponentModel.ISupportInitialize)nud主标题字号).EndInit();
			gb显示主标题.ResumeLayout(false);
			gb显示主标题.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nud主标题垂直坐标).EndInit();
			((System.ComponentModel.ISupportInitialize)nud主标题水平坐标).EndInit();
			gb显示副标题.ResumeLayout(false);
			gb显示副标题.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nud副标题垂直坐标).EndInit();
			((System.ComponentModel.ISupportInitialize)nud副标题水平坐标).EndInit();
			((System.ComponentModel.ISupportInitialize)nud副标题字号).EndInit();
			gb显示副标题阴影.ResumeLayout(false);
			gb显示副标题阴影.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nud副标题阴影距离).EndInit();
			((System.ComponentModel.ISupportInitialize)nud副标题阴影的透明度).EndInit();
			gb副标题描边.ResumeLayout(false);
			gb副标题描边.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ColorDialog colorDialog1;
        private Label label1;
        private CheckBox cb主标题描边;
        private CheckBox cb显示主标题阴影;
        private CheckBox cb主标题阴影描边;
        private Button btn主标题描边颜色;
        private Button btn主标题阴影的描边颜色;
        private Button btn主标题颜色;
        private Button btn保存;
        private Button btn取消;
        private ComboBox cb主标题字体;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox gb主标题描边;
        private GroupBox gb显示主标题阴影;
        private Label label5;
        private Label label6;
        private ComboBox cb背景图文件;
        private NumericUpDown nud主标题阴影的透明度;
		private Label label10;
		private NumericUpDown nud主标题字号;
		private Label label14;
		private NumericUpDown nud主标题阴影距离;
        private GroupBox gb显示主标题;
        private CheckBox cb显示主标题;
        private GroupBox gb显示副标题;
        private Label label7;
        private ComboBox cb副标题字体;
        private NumericUpDown nud副标题字号;
        private Button btn副标题颜色;
        private CheckBox cb显示副标题阴影;
        private GroupBox gb显示副标题阴影;
        private NumericUpDown nud副标题阴影距离;
        private Label label8;
        private NumericUpDown nud副标题阴影的透明度;
        private Label label9;
        private CheckBox cb副标题阴影描边;
        private Label label11;
        private Button btn副标题阴影的描边颜色;
        private Label label12;
        private Label label13;
        private CheckBox cb副标题描边;
        private GroupBox gb副标题描边;
        private Label label15;
        private Button btn副标题描边颜色;
        private CheckBox cb显示副标题;
        private TextBox tb主标题;
        private Label label16;
        private TextBox tb副标题;
        private Label label17;
        private ComboBox cb主标题水平对齐方式;
        private ComboBox cb主标题垂直对齐方式;
        private NumericUpDown nud主标题水平坐标;
        private NumericUpDown nud主标题垂直坐标;
        private Label l主标题垂直坐标;
        private Label l主标题水平坐标;
        private Label label19;
        private Label label18;
        private NumericUpDown nud副标题垂直坐标;
        private Label l副标题垂直坐标;
        private NumericUpDown nud副标题水平坐标;
        private Label l副标题水平坐标;
        private ComboBox cb副标题垂直对齐方式;
        private Label label23;
        private ComboBox cb副标题水平对齐方式;
        private Label label22;
        private Label label20;
        private Button btn背景颜色;
        private CheckBox cb窗体置顶;
		private ComboBox cb背景图像布局;
	}
}