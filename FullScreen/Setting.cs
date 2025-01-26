using System.Windows.Forms;

namespace FullScreen
{
    /// <summary>
    /// 描述一条文本信息。
    /// </summary>
    public class Text
    {
        /// <summary>
        /// 指示是否显示此项文本内容。
        /// </summary>
        public bool Show { get; set; }
        /// <summary>
        /// 文本内容。
        /// </summary>
        public string TextContent { get; set; }
        /// <summary>
        /// 字体
        /// </summary>
        public string FontName { get; set; }
        /// <summary>
        /// 字号
        /// </summary>
        public int FontSize { get; set; }
        /// <summary>
        /// 颜色
        /// </summary>
        public System.Drawing.Color TextColor { get; set; }
        /// <summary>
        /// 是否描边。
        /// </summary>
        public bool ShowStroke { get; set; }
        /// <summary>
        /// 描边颜色。
        /// </summary>
        public System.Drawing.Color StrokeColor { get; set; }
        /// <summary>
        /// 是否显示阴影。
        /// </summary>
        public bool ShowShadow { get; set; }
        /// <summary>
        /// 阴影距离。
        /// </summary>
        public int ShadowOffset { get; set; }
        /// <summary>
        /// 阴影的透明度。
        /// </summary>
        public int ShadowAlpha { get; set; }
        /// <summary>
        /// 是否显示阴影的描边。
        /// </summary>
        public bool ShowShadowStroke { get; set; }
        /// <summary>
        /// 阴影的描边颜色。
        /// </summary>
        public System.Drawing.Color ShadowStrokeColor { get; set; }
        /// <summary>
        /// 水平对齐方式。
        /// </summary>
        public StringAlignment HorizontalAlignment {  get; set; }

        /// <summary>
        /// 水平对齐方式。
        /// </summary>
        public StringAlignment VerticalAlignment {  get; set; }
        /// <summary>
        /// 水平显示位置。当 <see cref="HorizontalAlignment"/> == <see cref="StringAlignment.Center"/> 时无效。
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// 垂直显示位置。当 <see cref="VerticalAlignment"/> == <see cref="StringAlignment.Center"/> 时无效。
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// 一个构造方法。
        /// </summary>
        public Text()
        {

        }
    }

    /// <summary>
    /// 设置实体类。
    /// </summary>
    public class Setting
    {
        /// <summary>
        /// 背景色。
        /// </summary>
        public System.Drawing.Color BackgroundColor { get; set; }
        /// <summary>
        /// 背景图片。
        /// </summary>
        public string BackgroundImage { get; set; }
		/// <summary>
		/// 背景图像布局。
		/// </summary>
		public ImageLayout BackgroundImageLayout { get; set; }
        /// <summary>
        /// 窗体置顶
        /// </summary>
        public bool TopMost {  get; set; }
        /// <summary>
        /// 主标题。
        /// </summary>
        public Text MainTitle { get; set; }
        /// <summary>
        /// 副标题。
        /// </summary>
        public Text SubTitle { get; set; }

        /// <summary>
        /// 一个构造方法。
        /// </summary>
        public Setting()
        {
        }
    }
}
