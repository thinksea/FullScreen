namespace FullScreen
{
    /// <summary>
    /// 为 <see cref="System.Text.Json.JsonSerializer"/> 组件提供 <see cref="System.Drawing.Color"/> 类型的序列化与反序列化功能。
    /// </summary>
    internal class ColorConverter : System.Text.Json.Serialization.JsonConverter<System.Drawing.Color>
    {
        /// <summary>
        /// 读取 JSON 并转换为类型 <see cref="System.Drawing.Color"/>。
        /// </summary>
        /// <param name="reader">读取器。</param>
        /// <param name="typeToConvert">要转换的类型。</param>
        /// <param name="options">一个对象，指定要使用的序列化选项。</param>
        /// <returns>转换后的值。</returns>
        public override System.Drawing.Color Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
        {
            return System.Drawing.ColorTranslator.FromHtml(reader.GetString());
        }

        /// <summary>
        /// 将指定值作为 JSON 写入。
        /// </summary>
        /// <param name="writer">要写入到的编写器。</param>
        /// <param name="value">要转换为 JSON 的值。</param>
        /// <param name="options">一个对象，指定要使用的序列化选项。</param>
        public override void Write(System.Text.Json.Utf8JsonWriter writer, System.Drawing.Color value, System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(System.Drawing.ColorTranslator.ToHtml(value));
        }

    }

}
