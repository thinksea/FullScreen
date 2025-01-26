using System.Drawing.Drawing2D;

namespace FullScreen
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// ��ȡ������ѡ�
        /// </summary>
        private Setting Setting
        {
            get;
            set;
        }

        /// <summary>
        /// ȫ����ͼƬ��Ϣ��
        /// </summary>
        public System.Collections.Generic.SortedDictionary<string, System.Drawing.Image?> Images = new();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ��ȡ�ı���ʽ��
        /// </summary>
        /// <param name="horizontalAlignment">ˮƽ���뷽ʽ��</param>
        /// <param name="verticalAlignment">��ֱ���뷽ʽ��</param>
        /// <returns></returns>
        private StringFormat GetStringFormat(StringAlignment horizontalAlignment, StringAlignment verticalAlignment)
        {
            //�ı�������Ϣ ��ϸ������鿴ע��
            StringFormat format = StringFormat.GenericTypographic;
            format.Alignment = horizontalAlignment; //�ı�ˮƽ���뷽ʽ
            format.LineAlignment = verticalAlignment; //�ı���ֱ���뷽ʽ
            format.Trimming = StringTrimming.None; //���ı�������ʾ���򾡿��ܶ�ı����ַ����ӡ�
            return format;
        }

        //��ȡ��Ҫ���Ƶ�path 
        private GraphicsPath GetStringPath(string s, float dpi, RectangleF rect, System.Drawing.Font font, StringFormat format)
        {
            GraphicsPath path = new GraphicsPath();
            //�������ָ߶�
            float emSize = dpi * font.SizeInPoints / 72;
            //��path������ַ�������Ӧ��Ϣ 
            path.AddString(s, font.FontFamily, (int)font.Style, emSize, rect, format);
            return path;
        }

        private void DrawText(Graphics g, Text text)
        {
            System.Drawing.Font font = new System.Drawing.Font(text.FontName, text.FontSize);
            const float borderWidth = 1;
            RectangleF textRect = this.ClientRectangle;//�����ı�������
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
            //float dy = (textRect.Height - textBoxSize.Height) / 2.0f; //���㴹ֱƫ����
            //float dx = (textRect.Width - textBoxSize.Width) / 2.0f; //����ˮƽƫ��
            //textRect.Offset(dx, dy); //��������ʾ�Ĺ�����ƫ��dx,dy��ʵ�����־��С�ˮƽ���С���ֱ����

            StringFormat format = this.GetStringFormat(text.HorizontalAlignment, text.VerticalAlignment);

            g.SmoothingMode = SmoothingMode.HighQuality;//ָ������ݵĳ��֡�
            g.InterpolationMode = InterpolationMode.HighQualityBicubic; //ָ����������˫���β�ֵ����
            g.CompositingQuality = CompositingQuality.HighQuality; //�����������ٶȸ��ϡ�
            g.PixelOffsetMode = PixelOffsetMode.HighQuality; //ָ�������������ٶȳ��֡�
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit; //������ʾ�������ʹ��ÿ���ַ��ı�־���� ClearType λͼ�������ַ��� ����������ߵ����á� �������� ClearType ���幦�ܡ�

            float dpi = g.DpiY;
            using (GraphicsPath path = GetStringPath(text.TextContent, dpi, textRect, font, format))
            {
                if (text.ShowShadow)
                {
                    //��Ӱ����
                    RectangleF off = textRect;
                    off.Offset(text.ShadowOffset, text.ShadowOffset);//��Ӱƫ��
                    using (GraphicsPath offPath = GetStringPath(text.TextContent, dpi, off, font, format))
                    {
                        using (Brush b = new System.Drawing.SolidBrush(Color.FromArgb(text.ShadowAlpha, 0, 0, 0))) //��Ӱ��ɫ
                        {
                            g.FillPath(b, offPath);
                            if (text.ShowShadowStroke)
                            {
                                System.Drawing.Pen borderPen = new System.Drawing.Pen(text.ShadowStrokeColor, borderWidth);
                                g.DrawPath(borderPen, offPath);//����Ӱ���
                            }
                            //b.Dispose();
                        }
                    }
                }
                var fillBrush = new System.Drawing.SolidBrush(text.TextColor);

                g.FillPath(fillBrush, path);//�����������䣩 fillBrush ���ɫ
                if (text.ShowStroke)
                {
                    System.Drawing.Pen borderPen = new System.Drawing.Pen(text.StrokeColor, borderWidth);

                    g.DrawPath(borderPen, path);//������������ߣ� borderPen ���ɫ
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

        private void ��������()
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
                    MessageBox.Show(this, "δ�ҵ�ָ����ͼƬ��" + fileName + "����");
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
            this.��������();
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
            this.��������();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string settingFile = Define.SettingFile;
            if (System.IO.File.Exists(settingFile))
            {
                string jsonSetting = System.IO.File.ReadAllText(settingFile);
                this.Setting = System.Text.Json.JsonSerializer.Deserialize<Setting>(jsonSetting, Define.JsonDeserializeSettings);
                #region У��������ʾ���꣬���ⳬ����Ļ���ӷ�Χ��
                var clientSize = this.ClientSize;
                const int fixX = 30, fixY = 20; //�������ƫ������������ⲻ�ɼ���
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
                this.�ö�ToolStripMenuItem.Checked = this.Setting.TopMost;
                this.BackColor = this.Setting.BackgroundColor;
                this.BackgroundImageLayout = this.Setting.BackgroundImageLayout;
            }

            #region ����ͼƬ�ļ��б�
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

            #region ���ͼƬ�˵���(�����Ĳ˵�)��
            int index = 0;
            foreach (var item in this.Images)
            {
                string fileName = item.Key;
                string displayText;
                if (string.IsNullOrEmpty(fileName))
                {
                    displayText = "[��]";
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
            this.CursorPosition = Cursor.Position; //��¼���λ�á�
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
                    this.����ToolStripMenuItem_Click(null, null);
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
                if (MessageBox.Show(this, "ȷ���˳�������", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
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
                this.��������();
            }
        }

        private void �ö�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Setting.TopMost = !this.Setting.TopMost;
            this.TopMost = this.Setting.TopMost;
            this.�ö�ToolStripMenuItem.Checked = this.Setting.TopMost;
            this.��������();
        }

        private void ѡ��ToolStripMenuItem_Click(object sender, EventArgs e)
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
                this.�ö�ToolStripMenuItem.Checked = this.Setting.TopMost;
                this.BackColor = this.Setting.BackgroundColor;
				this.BackgroundImageLayout = this.Setting.BackgroundImageLayout;
				this.ShowImage(this.Setting.BackgroundImage);
                this.Refresh();
            }
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.ShowDialog(this);
        }

        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region ʵ����ʱ�������ָ�롣
        /// <summary>
        /// ���ڼ�¼����Ƿ�ɼ���
        /// </summary>
        private bool CursorShowed = true;
        /// <summary>
        /// ��ʾ���ָ�롣
        /// </summary>
        private void ShowCursor()
        {
            this.timer�������ָ���ʱ��.Stop();
            if (!this.CursorShowed)
            {
                Cursor.Show();
                this.CursorShowed = true;
            }
        }

        /// <summary>
        /// �������ָ�롣
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
        /// ���ڼ�¼���λ�á�
        /// </summary>
        private System.Drawing.Point CursorPosition;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            System.Drawing.Point currentPosition = Cursor.Position;
            double distance = Math.Sqrt(Math.Pow(currentPosition.X - this.CursorPosition.X, 2) + Math.Pow(currentPosition.Y - this.CursorPosition.Y, 2)); //�������ָ���ƶ����롣
            if (distance > 5)
            {
                this.ShowCursor();
            }
            this.CursorPosition = currentPosition; //��¼���λ�á�
            #region ���¿�ʼ����Ƿ�Ӧ���������ָ�롣
            this.timer�������ָ���ʱ��.Start();
            #endregion
        }

        private void timer�������ָ���ʱ��_Tick(object sender, EventArgs e)
        {
            this.HideCursor();
        }
        #endregion

    }
}
