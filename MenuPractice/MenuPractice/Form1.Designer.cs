﻿namespace MenuPractice
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工程路图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中文类图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.外文类图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.newToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
            this.fileToolStripMenuItem.Text = "新书入库(&N)";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工程路图书ToolStripMenuItem,
            this.中文类图书ToolStripMenuItem,
            this.外文类图书ToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.searchToolStripMenuItem.Text = "查询书目(&S)";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.newToolStripMenuItem.Text = "菜单管理(&M)";
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.退出系统ToolStripMenuItem.Text = "退出系统(&E)";
            // 
            // 工程路图书ToolStripMenuItem
            // 
            this.工程路图书ToolStripMenuItem.Name = "工程路图书ToolStripMenuItem";
            this.工程路图书ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.工程路图书ToolStripMenuItem.Text = "工程类图书";
            // 
            // 中文类图书ToolStripMenuItem
            // 
            this.中文类图书ToolStripMenuItem.Name = "中文类图书ToolStripMenuItem";
            this.中文类图书ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.中文类图书ToolStripMenuItem.Text = "中文类图书";
            // 
            // 外文类图书ToolStripMenuItem
            // 
            this.外文类图书ToolStripMenuItem.Name = "外文类图书ToolStripMenuItem";
            this.外文类图书ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.外文类图书ToolStripMenuItem.Text = "外文类图书";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "图书管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工程路图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中文类图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 外文类图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
    }
}

