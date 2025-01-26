using System.Drawing.Drawing2D;

namespace FullScreen
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 获取或设置选项。
        /// </summary>
        private Setting Setting
        {
            get;
            set;
        }

        /// <summary>
        /// 全部的图片信息。
        /// </summary>
        public System.Collections.Generic.SortedDictionary<string, System.Drawing.Image?> Images = new();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取文本格式。
        /// </summary>
        /// <param name="horizontalAlignment">水平对齐方式。</param>
        /// <param name="verticalAlignment">垂直对齐方式。</param>
        /// <returns></returns>
        private StringFormat GetStringFormat(StringAlignment horizontalAlignment, StringAlignment verticalAlignment)
        {
            //文本布局信息 详细功能请查看注释
            StringFormat format = StringFormat.GenericTypographic;
            format.Alignment = horizontalAlignment; //文本水平对齐方式
            format.LineAlignment = verticalAlignment; //文本垂直对齐方式
            format.Trimming = StringTrimming.None; //当文本超出显示区域尽可能多的保留字符可视。
            return format;
        }

        //获取需要绘制的path 
        private GraphicsPath GetStringPath(string s, float dpi, RectangleF rect, System.Drawing.Font font, StringFormat format)
        {
            GraphicsPath path = new GraphicsPath();
            //计算文字高度
            float emSize = dpi * font.SizeInPoints / 72;
            //向path中添加字符串及相应信息 
            path.AddString(s, font.FontFamily, (int)font.Style, emSize, rect, format);
            return path;
        }

        private void DrawText(Graphics g, Text text)
        {
            System.Drawing.Font font = new System.Drawing.Font(text.FontName, text.FontSize);
            const float borderWidth = 1;
            RectangleF textRect = this.ClientRectangle;//绘制文本的区域。
            switch (text.HorizontalAlignment)
            {
                case StringAlignment.Near:
                    if (text.X > 0)
                    {
                        textRect.X = text.X;
                        textRect.Width -= text.X;
                    }
                    break;
                case StringAlignment.Center:
                    break;
                case StringAlignment.Far:
                    if (text.X > 0)
                    {
                        textRect.Width -= text.X;
                    }
                    break;
            }
            switch (text.VerticalAlignment)
            {
                case StringAlignment.Near:
                    if (text.Y > 0)
                    {
                        textRect.Y = text.Y;
                        textRect.Height -= text.Y;
                    }
                    break;
                case StringAlignment.Center:
                    break;
                case StringAlignment.Far:
                    if (text.Y > 0)
                    {
                        textRect.Height -= text.Y;
                    }
                    break;
            }
            //var textBoxSize = g.MeasureString(textSetting.TextContent, font);
            //float dy = (textRect.Height - textBoxSize.Height) / 2.0f; //计算垂直偏移量
            //float dx = (textRect.Width - textBoxSize.Width) / 2.0f; //计算水平偏移
            //textRect.Offset(dx, dy); //将文字显示的工作区偏移dx,dy，实现文字居中、水平居中、垂直居中

            StringFormat format = this.GetStringFormat(text.HorizontalAlignment, text.VerticalAlignment);

            g.SmoothingMode = SmoothingMode.HighQuality;//指定抗锯齿的呈现。
            g.InterpolationMode = InterpolationMode.HighQualityBicubic; //指定高质量的双三次插值法。
            g.CompositingQuality = CompositingQuality.HighQuality; //高质量、低速度复合。
            g.PixelOffsetMode = PixelOffsetMode.HighQuality; //指定高质量、低速度呈现。
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit; //在有提示的情况下使用每个字符的标志符号 ClearType 位图来绘制字符。 这是质量最高的设置。 用于利用 ClearType 字体功能。

            float dpi = g.DpiY;
            using (GraphicsPath path = GetStringPath(text.TextContent, dpi, textRect, font, format))
            {
                if (text.ShowShadow)
                {
                    //阴影代码
                    RectangleF off = textRect;
                    off.Offset(text.ShadowOffset, text.ShadowOffset);//阴影偏移
                    using (GraphicsPath offPath = GetStringPath(text.TextContent, dpi, off, font, format))
                    {
                        using (Brush b = new System.Drawing.SolidBrush(Color.FromArgb(text.ShadowAlpha, 0, 0, 0))) //阴影颜色
                        {
                            g.FillPath(b, offPath);
                            if (text.ShowShadowStroke)
                            {
                                System.Drawing.Pen borderPen = new System.Drawing.Pen(text.ShadowStrokeColor, borderWidth);
                                g.DrawPath(borderPen, offPath);//给阴影描边
                            }
                            //b.Dispose();
                        }
                    }
                }
                var fillBrush = new System.Drawing.SolidBrush(text.TextColor);

                g.FillPath(fillBrush, path);//填充轮廓（填充） fillBrush 填充色
                if (text.ShowStroke)
                {
                    System.Drawing.Pen borderPen = new System.Drawing.Pen(text.StrokeColor, borderWidth);

                    g.DrawPath(borderPen, path);//绘制轮廓（描边） borderPen 描边色
                }

                //e.Graphics.DrawString(textSetting.TextContent, font: font, fillBrush, System.Drawing.Point.Empty);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (this.Setting.MainTitle.Show)
            {
                this.DrawText(g, this.Setting.MainTitle);
            }
            if (this.Setting.SubTitle.Show)
            {
                this.DrawText(g, this.Setting.SubTitle);
            }
        }

        private void 保存设置()
        {
            string jsonSetting = System.Text.Json.JsonSerializer.Serialize(this.Setting, Define.JsonSerializerSettings);
            System.IO.File.WriteAllText(Define.SettingFile, jsonSetting);
        }

        public void ShowImage(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                this.BackgroundImage = null;
            }
            else
            {
                System.Drawing.Image? image = null;
                if (this.Images.TryGetValue(fileName, out image) == false)
                {
                    MessageBox.Show(this, "未找到指定的图片“" + fileName + "”。");
                }
				this.BackgroundImage = image;
            }
            foreach (System.Windows.Forms.ToolStripItem item in this.contextMenuStrip1.Items)
            {
                System.Windows.Forms.ToolStripMenuItem menuItem = item as System.Windows.Forms.ToolStripMenuItem;
                if (menuItem != null)
                {
                    if (menuItem.Tag != null && System.Convert.ToString(menuItem.Tag) == "image")
                    {
                        if (menuItem.Name == fileName)
                        {
                            menuItem.Checked = true;
                        }
                        else
                        {
                            menuItem.Checked = false;
                        }
                    }
                }
            }
        }

        public void ShowPreImage()
        {
            System.Collections.Generic.List<string> imageFiles = this.Images.Keys.ToList();
            int index = imageFiles.IndexOf(this.Setting.BackgroundImage);
            if (index > 0)
            {
                index--;
            }
            else
            {
                index = imageFiles.Count - 1;
            }
            string fileName = imageFiles[index];
            this.Setting.BackgroundImage = fileName;
            this.ShowImage(fileName);
            this.保存设置();
        }

        public void ShowNextImage()
        {
            System.Collections.Generic.List<string> imageFiles = this.Images.Keys.ToList();
            int index = imageFiles.IndexOf(this.Setting.BackgroundImage);
            if (index < this.Images.Count - 1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
            string fileName = imageFiles[index];
            this.Setting.BackgroundImage = fileName;
            this.ShowImage(fileName);
            this.保存设置();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string settingFile = Define.SettingFile;
            if (System.IO.File.Exists(settingFile))
            {
                string jsonSetting = System.IO.File.ReadAllText(settingFile);
                this.Setting = System.Text.Json.JsonSerializer.Deserialize<Setting>(jsonSetting, Define.JsonDeserializeSettings);
                #region 校正标题显示坐标，避免超出屏幕可视范围。
                var clientSize = this.ClientSize;
                const int fixX = 30, fixY = 20; //最大坐标偏移量，避免标题不可见。
                if (this.Setting.MainTitle.X > clientSize.Width - fixX)
                {
                    this.Setting.MainTitle.X = clientSize.Width - fixX;
                }
                if (this.Setting.MainTitle.Y > clientSize.Height - fixY)
                {
                    this.Setting.MainTitle.Y = clientSize.Height - fixY;
                }
                if (this.Setting.SubTitle.X > clientSize.Width - fixX)
                {
                    this.Setting.SubTitle.X = clientSize.Width - fixX;
                }
                if (this.Setting.SubTitle.Y > clientSize.Height - fixY)
                {
                    this.Setting.SubTitle.Y = clientSize.Height - fixY;
                }
                #endregion
                this.TopMost = this.Setting.TopMost;
                this.置顶ToolStripMenuItem.Checked = this.Setting.TopMost;
                this.BackColor = this.Setting.BackgroundColor;
                this.BackgroundImageLayout = this.Setting.BackgroundImageLayout;
            }

            #region 加载图片文件列表。
            this.Images.Add("", null);
            if (!System.IO.Directory.Exists(Define.ImageDirectory))
            {
                System.IO.Directory.CreateDirectory(Define.ImageDirectory);
            }
            else
            {
                foreach (string ext in Define.ImageFileExtension)
                {
                    string[] files = System.IO.Directory.GetFiles(Define.ImageDirectory, "*" + ext, System.IO.SearchOption.AllDirectories);
                    foreach (string file in files)
                    {
                        System.Drawing.Image image = System.Drawing.Bitmap.FromFile(file);
                        this.Images.Add(System.IO.Path.GetFileName(file), image);
                    }
                }
            }
            #endregion

            #region 填充图片菜单项(上下文菜单)。
            int index = 0;
            foreach (var item in this.Images)
            {
                string fileName = item.Key;
                string displayText;
                if (string.IsNullOrEmpty(fileName))
                {
                    displayText = "[空]";
                }
                else
                {
                    displayText = System.IO.Path.GetFileNameWithoutExtension(fileName);
                }
                System.Drawing.Image? image = item.Value;
                var menuItem = new System.Windows.Forms.ToolStripMenuItem(displayText, image);
                menuItem.Tag = "image";
                menuItem.Name = fileName;
                this.contextMenuStrip1.Items.Insert(index++, menuItem);
            }
            #endregion
            this.ShowImage(this.Setting.BackgroundImage);
            this.CursorPosition = Cursor.Position; //记录鼠标位置。
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Left:
                    this.ShowPreImage();
                    break;
                case Keys.Right:
                    this.ShowNextImage();
                    break;
                case Keys.F1:
                    this.帮助ToolStripMenuItem_Click(null, null);
                    break;
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.ShowCursor();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.ShowCursor();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show(this, "确认退出程序吗？", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var menuItem = e.ClickedItem;
            if (menuItem.Tag != null && System.Convert.ToString(menuItem.Tag) == "image")
            {
                string fileName = menuItem.Name;
                this.Setting.BackgroundImage = fileName;
                this.ShowImage(fileName);
                this.保存设置();
            }
        }

        private void 置顶ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Setting.TopMost = !this.Setting.TopMost;
            this.TopMost = this.Setting.TopMost;
            this.置顶ToolStripMenuItem.Checked = this.Setting.TopMost;
            this.保存设置();
        }

        private void 选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm form = new();
            form.SetDrawBoxSize(this.ClientSize);
            if (this.Setting != null)
            {
                form.Setting = this.Setting;
            }
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                this.Setting = form.Setting;
                this.TopMost = this.Setting.TopMost;
                this.置顶ToolStripMenuItem.Checked = this.Setting.TopMost;
                this.BackColor = this.Setting.BackgroundColor;
				this.BackgroundImageLayout = this.Setting.BackgroundImageLayout;
				this.ShowImage(this.Setting.BackgroundImage);
                this.Refresh();
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.ShowDialog(this);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 实现延时隐藏鼠标指针。
        /// <summary>
        /// 用于记录鼠标是否可见。
        /// </summary>
        private bool CursorShowed = true;
        /// <summary>
        /// 显示鼠标指针。
        /// </summary>
        private void ShowCursor()
        {
            this.timer隐藏鼠标指针计时器.Stop();
            if (!this.CursorShowed)
            {
                Cursor.Show();
                this.CursorShowed = true;
            }
        }

        /// <summary>
        /// 隐藏鼠标指针。
        /// </summary>
        private void HideCursor()
        {
            if (this.CursorShowed)
            {
                Cursor.Hide();
                this.CursorShowed = false;
            }
        }

        /// <summary>
        /// 用于记录鼠标位置。
        /// </summary>
        private System.Drawing.Point CursorPosition;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            System.Drawing.Point currentPosition = Cursor.Position;
            double distance = Math.Sqrt(Math.Pow(currentPosition.X - this.CursorPosition.X, 2) + Math.Pow(currentPosition.Y - this.CursorPosition.Y, 2)); //计算鼠标指针移动距离。
            if (distance > 5)
            {
                this.ShowCursor();
            }
            this.CursorPosition = currentPosition; //记录鼠标位置。
            #region 重新开始检测是否应该隐藏鼠标指针。
            this.timer隐藏鼠标指针计时器.Start();
            #endregion
        }

        private void timer隐藏鼠标指针计时器_Tick(object sender, EventArgs e)
        {
            this.HideCursor();
        }
        #endregion

    }
}
