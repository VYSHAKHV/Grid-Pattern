using System.Threading;
namespace MatrixGrid
{
    partial class FormMatrixGrid
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.matrixSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSize4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSize5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSize6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSize7 = new System.Windows.Forms.ToolStripMenuItem();
            this.threadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matrixSizeToolStripMenuItem,
            this.threadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // matrixSizeToolStripMenuItem
            // 
            this.matrixSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSize4,
            this.toolStripMenuItemSize5,
            this.toolStripMenuItemSize6,
            this.toolStripMenuItemSize7});
            this.matrixSizeToolStripMenuItem.Name = "matrixSizeToolStripMenuItem";
            this.matrixSizeToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.matrixSizeToolStripMenuItem.Text = "Matrix Size";
            // 
            // toolStripMenuItemSize4
            // 
            this.toolStripMenuItemSize4.Name = "toolStripMenuItemSize4";
            this.toolStripMenuItemSize4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemSize4.Text = "4";
            this.toolStripMenuItemSize4.Click += new System.EventHandler(this.toolStripMenuItemSize4_Click);
            // 
            // toolStripMenuItemSize5
            // 
            this.toolStripMenuItemSize5.Name = "toolStripMenuItemSize5";
            this.toolStripMenuItemSize5.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemSize5.Text = "5";
            this.toolStripMenuItemSize5.Click += new System.EventHandler(this.toolStripMenuItemSize5_Click);
            // 
            // toolStripMenuItemSize6
            // 
            this.toolStripMenuItemSize6.Name = "toolStripMenuItemSize6";
            this.toolStripMenuItemSize6.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemSize6.Text = "6";
            this.toolStripMenuItemSize6.Click += new System.EventHandler(this.toolStripMenuItemSize6_Click);
            // 
            // toolStripMenuItemSize7
            // 
            this.toolStripMenuItemSize7.Name = "toolStripMenuItemSize7";
            this.toolStripMenuItemSize7.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemSize7.Text = "7";
            this.toolStripMenuItemSize7.Click += new System.EventHandler(this.toolStripMenuItemSize7_Click);
            // 
            // threadToolStripMenuItem
            // 
            this.threadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.resumeToolStripMenuItem});
            this.threadToolStripMenuItem.Name = "threadToolStripMenuItem";
            this.threadToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.threadToolStripMenuItem.Text = "Thread";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resumeToolStripMenuItem.Text = "Resume";
            this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
            // 
            // FormMatrixGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMatrixGrid";
            this.Text = "Matrix Grid";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem matrixSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSize4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSize5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSize6;
        private System.Windows.Forms.ToolStripMenuItem threadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSize7;
        public Thread CounterThread;
        public bool bThreasStatus;
    }
}

