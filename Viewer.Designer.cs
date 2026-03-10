namespace DocxViewer2
{
    partial class Viewer
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
            this.ViewerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuStripHeading = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseFileMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewerStatusStrip = new System.Windows.Forms.StatusStrip();
            this.ViewerWebBrowser = new System.Windows.Forms.WebBrowser();
            this.ViewerStatusStripShowFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.ViewerMenuStrip.SuspendLayout();
            this.ViewerStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewerMenuStrip
            // 
            this.ViewerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuStripHeading});
            this.ViewerMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ViewerMenuStrip.Name = "ViewerMenuStrip";
            this.ViewerMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.ViewerMenuStrip.TabIndex = 0;
            this.ViewerMenuStrip.Text = "menuStrip1";
            // 
            // FileMenuStripHeading
            // 
            this.FileMenuStripHeading.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileMenuStripItem,
            this.CloseFileMenuStripItem,
            this.toolStripSeparator1,
            this.ExitMenuStripItem});
            this.FileMenuStripHeading.Name = "FileMenuStripHeading";
            this.FileMenuStripHeading.Size = new System.Drawing.Size(37, 20);
            this.FileMenuStripHeading.Text = "File";
            // 
            // OpenFileMenuStripItem
            // 
            this.OpenFileMenuStripItem.Name = "OpenFileMenuStripItem";
            this.OpenFileMenuStripItem.Size = new System.Drawing.Size(103, 22);
            this.OpenFileMenuStripItem.Text = "Open";
            this.OpenFileMenuStripItem.Click += new System.EventHandler(this.OpenFileMenuStripItem_Click);
            // 
            // CloseFileMenuStripItem
            // 
            this.CloseFileMenuStripItem.Name = "CloseFileMenuStripItem";
            this.CloseFileMenuStripItem.Size = new System.Drawing.Size(103, 22);
            this.CloseFileMenuStripItem.Text = "Close";
            this.CloseFileMenuStripItem.Click += new System.EventHandler(this.CloseFileMenuStripItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // ExitMenuStripItem
            // 
            this.ExitMenuStripItem.Name = "ExitMenuStripItem";
            this.ExitMenuStripItem.Size = new System.Drawing.Size(103, 22);
            this.ExitMenuStripItem.Text = "Exit";
            this.ExitMenuStripItem.Click += new System.EventHandler(this.ExitMenuStripItem_Click);
            // 
            // ViewerStatusStrip
            // 
            this.ViewerStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewerStatusStripShowFileName});
            this.ViewerStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.ViewerStatusStrip.Name = "ViewerStatusStrip";
            this.ViewerStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.ViewerStatusStrip.TabIndex = 1;
            this.ViewerStatusStrip.Text = "statusStrip1";
            // 
            // ViewerWebBrowser
            // 
            this.ViewerWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewerWebBrowser.Location = new System.Drawing.Point(0, 24);
            this.ViewerWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.ViewerWebBrowser.Name = "ViewerWebBrowser";
            this.ViewerWebBrowser.Size = new System.Drawing.Size(800, 404);
            this.ViewerWebBrowser.TabIndex = 2;
            // 
            // ViewerStatusStripShowFileName
            // 
            this.ViewerStatusStripShowFileName.Name = "ViewerStatusStripShowFileName";
            this.ViewerStatusStripShowFileName.Size = new System.Drawing.Size(37, 17);
            this.ViewerStatusStripShowFileName.Text = "          ";
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewerWebBrowser);
            this.Controls.Add(this.ViewerStatusStrip);
            this.Controls.Add(this.ViewerMenuStrip);
            this.MainMenuStrip = this.ViewerMenuStrip;
            this.Name = "Viewer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ViewerMenuStrip.ResumeLayout(false);
            this.ViewerMenuStrip.PerformLayout();
            this.ViewerStatusStrip.ResumeLayout(false);
            this.ViewerStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ViewerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuStripHeading;
        private System.Windows.Forms.ToolStripMenuItem OpenFileMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem CloseFileMenuStripItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuStripItem;
        private System.Windows.Forms.StatusStrip ViewerStatusStrip;
        private System.Windows.Forms.WebBrowser ViewerWebBrowser;
        private System.Windows.Forms.ToolStripStatusLabel ViewerStatusStripShowFileName;
    }
}

