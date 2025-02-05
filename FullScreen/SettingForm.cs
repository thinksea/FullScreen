namespace FullScreen
{
	public partial class SettingForm : Form
	{
		/// <summary>
		/// 图片文件。
		/// </summary>
		private System.Collections.Generic.Dictionary<string, string> Images = new();

		/// <summary>
		/// 获取或设置选项。
		/// </summary>
		public Setting Setting
		{
			get
			{
				Setting setting = new();
				setting.MainTitle = new();
				setting.SubTitle = new();

				setting.BackgroundColor = this.btn背景颜色.BackColor;
				setting.BackgroundImage = System.IO.Path.GetFileName((string)this.cb背景图文件.SelectedValue);
				setting.BackgroundImageLayout = (ImageLayout)this.cb背景图像布局.SelectedValue;
				setting.TopMost = this.cb窗体置顶.Checked;

				setting.MainTitle.Show = this.cb显示主标题.Checked;
				setting.MainTitle.TextContent = this.tb主标题.Text;
				setting.MainTitle.FontName = this.cb主标题字体.Text;
				setting.MainTitle.TextColor = this.btn主标题颜色.BackColor;
				setting.MainTitle.FontSize = System.Convert.ToInt32(this.nud主标题字号.Value);
				setting.MainTitle.ShowStroke = this.cb主标题描边.Checked;
				setting.MainTitle.StrokeColor = this.btn主标题描边颜色.BackColor;
				setting.MainTitle.ShowShadow = this.cb显示主标题阴影.Checked;
				setting.MainTitle.ShadowOffset = System.Convert.ToInt32(this.nud主标题阴影距离.Value);
				setting.MainTitle.ShadowAlpha = System.Convert.ToInt32(this.nud主标题阴影的透明度.Value);
				setting.MainTitle.ShowShadowStroke = this.cb主标题阴影描边.Checked;
				setting.MainTitle.ShadowStrokeColor = this.btn主标题阴影的描边颜色.BackColor;
				setting.MainTitle.HorizontalAlignment = (StringAlignment)this.cb主标题水平对齐方式.SelectedValue;
				setting.MainTitle.VerticalAlignment = (StringAlignment)this.cb主标题垂直对齐方式.SelectedValue;
				setting.MainTitle.X = System.Convert.ToInt32(this.nud主标题水平坐标.Value);
				setting.MainTitle.Y = System.Convert.ToInt32(this.nud主标题垂直坐标.Value);

				setting.SubTitle.Show = this.cb显示副标题.Checked;
				setting.SubTitle.TextContent = this.tb副标题.Text;
				setting.SubTitle.FontName = this.cb副标题字体.Text;
				setting.SubTitle.TextColor = this.btn副标题颜色.BackColor;
				setting.SubTitle.FontSize = System.Convert.ToInt32(this.nud副标题字号.Value);
				setting.SubTitle.ShowStroke = this.cb副标题描边.Checked;
				setting.SubTitle.StrokeColor = this.btn副标题描边颜色.BackColor;
				setting.SubTitle.ShowShadow = this.cb显示副标题阴影.Checked;
				setting.SubTitle.ShadowOffset = System.Convert.ToInt32(this.nud副标题阴影距离.Value);
				setting.SubTitle.ShadowAlpha = System.Convert.ToInt32(this.nud副标题阴影的透明度.Value);
				setting.SubTitle.ShowShadowStroke = this.cb副标题阴影描边.Checked;
				setting.SubTitle.ShadowStrokeColor = this.btn副标题阴影的描边颜色.BackColor;
				setting.SubTitle.HorizontalAlignment = (StringAlignment)this.cb副标题水平对齐方式.SelectedValue;
				setting.SubTitle.VerticalAlignment = (StringAlignment)this.cb副标题垂直对齐方式.SelectedValue;
				setting.SubTitle.X = System.Convert.ToInt32(this.nud副标题水平坐标.Value);
				setting.SubTitle.Y = System.Convert.ToInt32(this.nud副标题垂直坐标.Value);

				return setting;
			}
			set
			{
				this.btn背景颜色.BackColor = value.BackgroundColor;
				if (string.IsNullOrEmpty(value.BackgroundImage))
				{
					this.cb背景图文件.SelectedValue = "";
				}
				else
				{
					this.cb背景图文件.SelectedValue = Define.GetImageFile(value.BackgroundImage);
				}
				this.cb背景图像布局.SelectedValue = value.BackgroundImageLayout;
				this.cb窗体置顶.Checked = value.TopMost;

				this.cb显示主标题.Checked = value.MainTitle.ShowShadow;
				this.tb主标题.Text = value.MainTitle.TextContent;
				this.cb主标题字体.Text = value.MainTitle.FontName;
				this.btn主标题颜色.BackColor = value.MainTitle.TextColor;
				this.nud主标题字号.Value = value.MainTitle.FontSize;
				this.cb主标题描边.Checked = value.MainTitle.ShowStroke;
				this.btn主标题描边颜色.BackColor = value.MainTitle.StrokeColor;
				this.cb显示主标题阴影.Checked = value.MainTitle.ShowShadow;
				this.nud主标题阴影距离.Value = value.MainTitle.ShadowOffset;
				this.nud主标题阴影的透明度.Value = value.MainTitle.ShadowAlpha;
				this.cb主标题阴影描边.Checked = value.MainTitle.ShowShadowStroke;
				this.btn主标题阴影的描边颜色.BackColor = value.MainTitle.ShadowStrokeColor;
				this.cb主标题水平对齐方式.SelectedValue = value.MainTitle.HorizontalAlignment;
				this.cb主标题垂直对齐方式.SelectedValue = value.MainTitle.VerticalAlignment;
				this.nud主标题水平坐标.Value = value.MainTitle.X;
				this.nud主标题垂直坐标.Value = value.MainTitle.Y;

				this.cb显示副标题.Checked = value.SubTitle.ShowShadow;
				this.tb副标题.Text = value.SubTitle.TextContent;
				this.cb副标题字体.Text = value.SubTitle.FontName;
				this.btn副标题颜色.BackColor = value.SubTitle.TextColor;
				this.nud副标题字号.Value = value.SubTitle.FontSize;
				this.cb副标题描边.Checked = value.SubTitle.ShowStroke;
				this.btn副标题描边颜色.BackColor = value.SubTitle.StrokeColor;
				this.cb显示副标题阴影.Checked = value.SubTitle.ShowShadow;
				this.nud副标题阴影距离.Value = value.SubTitle.ShadowOffset;
				this.nud副标题阴影的透明度.Value = value.SubTitle.ShadowAlpha;
				this.cb副标题阴影描边.Checked = value.SubTitle.ShowShadowStroke;
				this.btn副标题阴影的描边颜色.BackColor = value.SubTitle.ShadowStrokeColor;
				this.cb副标题水平对齐方式.SelectedValue = value.SubTitle.HorizontalAlignment;
				this.cb副标题垂直对齐方式.SelectedValue = value.SubTitle.VerticalAlignment;
				this.nud副标题水平坐标.Value = value.SubTitle.X;
				this.nud副标题垂直坐标.Value = value.SubTitle.Y;
			}
		}

		private event System.EventHandler _SettingChanged;
		/// <summary>
		/// 当设置更改时引发此事件。
		/// </summary>
		public event System.EventHandler SettingChanged
		{
			add
			{
				this._SettingChanged += value;
			}
			remove
			{
				this._SettingChanged -= value;
			}
		}

		private void 发送设置已更改通知()
		{
			if (this._SettingChanged != null)
			{
				this._SettingChanged(this, EventArgs.Empty);
			}
		}

		public SettingForm()
		{
			InitializeComponent();

			#region 背景图像布局
			System.Collections.Generic.Dictionary<string, ImageLayout> enums背景图像布局 = new();
			enums背景图像布局.Add("平铺", ImageLayout.Tile);
			enums背景图像布局.Add("居中", ImageLayout.Center);
			enums背景图像布局.Add("拉伸满屏", ImageLayout.Stretch);
			enums背景图像布局.Add("等比例缩放", ImageLayout.Zoom);

			this.cb背景图像布局.DisplayMember = "Key";
			this.cb背景图像布局.ValueMember = "Value";
			this.cb背景图像布局.DataSource = new BindingSource(enums背景图像布局, null);
			#endregion

			#region 加载图片文件列表。
			this.Images.Add("[空]", "");
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
						this.Images.Add(System.IO.Path.GetFileNameWithoutExtension(file), file);
					}
				}
			}

			this.cb背景图文件.DisplayMember = "Key";
			this.cb背景图文件.ValueMember = "Value";
			this.cb背景图文件.DataSource = new BindingSource(this.Images, null);
			#endregion

			#region 加载字体列表。
			System.Drawing.Text.InstalledFontCollection objFont = new System.Drawing.Text.InstalledFontCollection();
			foreach (System.Drawing.FontFamily fm in objFont.Families)
			{
				this.cb主标题字体.Items.Add(fm.Name.ToString());
				this.cb副标题字体.Items.Add(fm.Name.ToString());
			}
			this.cb主标题字体.SelectedIndex = 0;
			this.cb副标题字体.SelectedIndex = 0;
			#endregion

			#region 加载对齐方式。
			System.Collections.Generic.Dictionary<string, StringAlignment> enums水平对齐方式 = new();
			enums水平对齐方式.Add("左", StringAlignment.Near);
			enums水平对齐方式.Add("居中", StringAlignment.Center);
			enums水平对齐方式.Add("右", StringAlignment.Far);

			this.cb主标题水平对齐方式.DisplayMember = "Key";
			this.cb主标题水平对齐方式.ValueMember = "Value";
			this.cb主标题水平对齐方式.DataSource = new BindingSource(enums水平对齐方式, null);

			this.cb副标题水平对齐方式.DisplayMember = "Key";
			this.cb副标题水平对齐方式.ValueMember = "Value";
			this.cb副标题水平对齐方式.DataSource = new BindingSource(enums水平对齐方式, null);

			System.Collections.Generic.Dictionary<string, StringAlignment> enums垂直对齐方式 = new();
			enums垂直对齐方式.Add("顶部", StringAlignment.Near);
			enums垂直对齐方式.Add("居中", StringAlignment.Center);
			enums垂直对齐方式.Add("底部", StringAlignment.Far);

			this.cb主标题垂直对齐方式.DisplayMember = "Key";
			this.cb主标题垂直对齐方式.ValueMember = "Value";
			this.cb主标题垂直对齐方式.DataSource = new BindingSource(enums垂直对齐方式, null);

			this.cb副标题垂直对齐方式.DisplayMember = "Key";
			this.cb副标题垂直对齐方式.ValueMember = "Value";
			this.cb副标题垂直对齐方式.DataSource = new BindingSource(enums垂直对齐方式, null);
			#endregion
		}

		/// <summary>
		/// 设置显示区域尺寸。
		/// </summary>
		public void SetDrawBoxSize(System.Drawing.Size size)
		{
			this.nud主标题水平坐标.Maximum = size.Width;
			this.nud主标题垂直坐标.Maximum = size.Height;
			this.nud副标题水平坐标.Maximum = size.Width;
			this.nud副标题垂直坐标.Maximum = size.Height;
		}

		private void btn背景颜色_Click(object sender, EventArgs e)
		{
			this.colorDialog1.Color = this.btn背景颜色.BackColor;
			if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
			{
				this.btn背景颜色.BackColor = this.colorDialog1.Color;
				this.发送设置已更改通知();
			}
		}

		private void cb背景图文件_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		private void cb背景图像布局_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		private void cb窗体置顶_CheckedChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		#region 主标题。
		private void cb显示主标题_CheckedChanged(object sender, EventArgs e)
		{
			this.gb显示主标题.Enabled = this.cb显示主标题.Checked;
			this.发送设置已更改通知();
		}

		private void tb主标题_TextChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		private void cb主标题字体_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		private void cb主标题字体_MeasureItem(object sender, MeasureItemEventArgs e)
		{
			System.Drawing.Font objFonts = new Font(this.cb主标题字体.Items[e.Index].ToString(), this.Font.Size);
			e.ItemHeight = objFonts.Height;
		}

		private void cb主标题字体_DrawItem(object sender, DrawItemEventArgs e)
		{
			System.Drawing.Font objFonts = new Font(this.cb主标题字体.Items[e.Index].ToString(), this.Font.Size);
			e.DrawBackground();
			e.Graphics.DrawString(this.cb主标题字体.Items[e.Index].ToString(), objFonts, new SolidBrush(e.ForeColor), new Point(e.Bounds.Left, e.Bounds.Top));
		}

		private void btn主标题文本颜色_Click(object sender, EventArgs e)
		{
			this.colorDialog1.Color = this.btn主标题颜色.BackColor;
			if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
			{
				this.btn主标题颜色.BackColor = this.colorDialog1.Color;
				this.发送设置已更改通知();
			}
		}

		private void nud主标题字号_ValueChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		private void cb主标题描边_CheckedChanged(object sender, EventArgs e)
		{
			this.gb主标题描边.Enabled = this.cb主标题描边.Checked;
			this.发送设置已更改通知();
		}

		private void btn主标题描边颜色_Click(object sender, EventArgs e)
		{
			this.colorDialog1.Color = this.btn主标题描边颜色.BackColor;
			if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
			{
				this.btn主标题描边颜色.BackColor = this.colorDialog1.Color;
				this.发送设置已更改通知();
			}
		}

		private void cb主标题显示阴影_CheckedChanged(object sender, EventArgs e)
		{
			this.gb显示主标题阴影.Enabled = this.cb显示主标题阴影.Checked;
			this.发送设置已更改通知();
		}

		private void btn主标题阴影的描边颜色_Click(object sender, EventArgs e)
		{
			this.colorDialog1.Color = this.btn主标题阴影的描边颜色.BackColor;
			if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
			{
				this.btn主标题阴影的描边颜色.BackColor = this.colorDialog1.Color;
				this.发送设置已更改通知();
			}
		}

		private void nud主标题阴影距离_ValueChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		private void nud主标题阴影的透明度_ValueChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		private void cb主标题阴影描边_CheckedChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		private void cb主标题水平对齐方式_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.l主标题水平坐标.Enabled = this.nud主标题水平坐标.Enabled = ((StringAlignment)this.cb主标题水平对齐方式.SelectedValue != StringAlignment.Center);
			this.发送设置已更改通知();
		}

		private void cb主标题垂直对齐方式_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.l主标题垂直坐标.Enabled = this.nud主标题垂直坐标.Enabled = ((StringAlignment)this.cb主标题垂直对齐方式.SelectedValue != StringAlignment.Center);
			this.发送设置已更改通知();
		}

		private void nud主标题水平坐标_ValueChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		private void nud主标题垂直坐标_ValueChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		#endregion

		#region 副标题。
		private void cb显示副标题_CheckedChanged(object sender, EventArgs e)
		{
			this.gb显示副标题.Enabled = this.cb显示副标题.Checked;
			this.发送设置已更改通知();
		}

		private void tb副标题_TextChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		private void cb副标题字体_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		private void cb副标题字体_MeasureItem(object sender, MeasureItemEventArgs e)
		{
			System.Drawing.Font objFonts = new Font(this.cb副标题字体.Items[e.Index].ToString(), this.Font.Size);
			e.ItemHeight = objFonts.Height;
		}

		private void cb副标题字体_DrawItem(object sender, DrawItemEventArgs e)
		{
			System.Drawing.Font objFonts = new Font(this.cb副标题字体.Items[e.Index].ToString(), this.Font.Size);
			e.DrawBackground();
			e.Graphics.DrawString(this.cb副标题字体.Items[e.Index].ToString(), objFonts, new SolidBrush(e.ForeColor), new Point(e.Bounds.Left, e.Bounds.Top));
		}

		private void btn副标题文本颜色_Click(object sender, EventArgs e)
		{
			this.colorDialog1.Color = this.btn副标题颜色.BackColor;
			if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
			{
				this.btn副标题颜色.BackColor = this.colorDialog1.Color;
				this.发送设置已更改通知();
			}
		}

		private void nud副标题字号_ValueChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		private void cb副标题描边_CheckedChanged(object sender, EventArgs e)
		{
			this.gb副标题描边.Enabled = this.cb副标题描边.Checked;
			this.发送设置已更改通知();
		}

		private void btn副标题描边颜色_Click(object sender, EventArgs e)
		{
			this.colorDialog1.Color = this.btn副标题描边颜色.BackColor;
			if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
			{
				this.btn副标题描边颜色.BackColor = this.colorDialog1.Color;
				this.发送设置已更改通知();
			}
		}

		private void cb副标题显示阴影_CheckedChanged(object sender, EventArgs e)
		{
			this.gb显示副标题阴影.Enabled = this.cb显示副标题阴影.Checked;
			this.发送设置已更改通知();
		}

		private void nud副标题阴影距离_ValueChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		private void nud副标题阴影的透明度_ValueChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		private void cb副标题阴影描边_CheckedChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		private void btn副标题阴影的描边颜色_Click(object sender, EventArgs e)
		{
			this.colorDialog1.Color = this.btn副标题阴影的描边颜色.BackColor;
			if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
			{
				this.btn副标题阴影的描边颜色.BackColor = this.colorDialog1.Color;
				this.发送设置已更改通知();
			}
		}

		private void cb副标题水平对齐方式_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.l副标题水平坐标.Enabled = this.nud副标题水平坐标.Enabled = ((StringAlignment)this.cb副标题水平对齐方式.SelectedValue != StringAlignment.Center);
			this.发送设置已更改通知();
		}

		private void cb副标题垂直对齐方式_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.l副标题垂直坐标.Enabled = this.nud副标题垂直坐标.Enabled = ((StringAlignment)this.cb副标题垂直对齐方式.SelectedValue != StringAlignment.Center);
			this.发送设置已更改通知();
		}

		private void nud副标题水平坐标_ValueChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}

		private void nud副标题垂直坐标_ValueChanged(object sender, EventArgs e)
		{
			this.发送设置已更改通知();
		}
		#endregion

		private void btn保存_Click(object sender, EventArgs e)
		{
			string jsonSetting = System.Text.Json.JsonSerializer.Serialize(this.Setting, Define.JsonSerializerSettings);
			System.IO.File.WriteAllText(Define.SettingFile, jsonSetting);

			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
