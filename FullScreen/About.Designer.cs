namespace FullScreen
{
    partial class About
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
            richTextBox1 = new RichTextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Font = new Font("宋体", 16.1F, FontStyle.Regular, GraphicsUnit.Point, 134);
            richTextBox1.Location = new Point(48, 44);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(895, 528);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "全屏显示图片 v1.0\n修改图片：\n将图片文件放置在“images”目录即可。\n支持的图片格式：jpg,png,bmp,gif\n快捷键：\nESC键：退出程序\n左键：上一张图片\n右键：下一张图片";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.Location = new Point(360, 626);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(195, 78);
            btnClose.TabIndex = 1;
            btnClose.Text = "关闭(&C)";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1000, 758);
            Controls.Add(btnClose);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "帮助";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnClose;
    }
}