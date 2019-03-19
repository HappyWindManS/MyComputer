namespace arithmetic
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.语言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.英语ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日语ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.语言ToolStripMenuItem,
            this.反馈ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 语言ToolStripMenuItem
            // 
            this.语言ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中文ToolStripMenuItem,
            this.英语ToolStripMenuItem,
            this.日语ToolStripMenuItem});
            this.语言ToolStripMenuItem.Name = "语言ToolStripMenuItem";
            this.语言ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.语言ToolStripMenuItem.Text = "语言";
            // 
            // 反馈ToolStripMenuItem
            // 
            this.反馈ToolStripMenuItem.Name = "反馈ToolStripMenuItem";
            this.反馈ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.反馈ToolStripMenuItem.Text = "反馈";
            // 
            // 中文ToolStripMenuItem
            // 
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            this.中文ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.中文ToolStripMenuItem.Text = "中文";
            // 
            // 英语ToolStripMenuItem
            // 
            this.英语ToolStripMenuItem.Name = "英语ToolStripMenuItem";
            this.英语ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.英语ToolStripMenuItem.Text = "英语";
            this.英语ToolStripMenuItem.Click += new System.EventHandler(this.英语ToolStripMenuItem_Click);
            // 
            // 日语ToolStripMenuItem
            // 
            this.日语ToolStripMenuItem.Name = "日语ToolStripMenuItem";
            this.日语ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.日语ToolStripMenuItem.Text = "日语";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 语言ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 英语ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日语ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反馈ToolStripMenuItem;
    }
}

