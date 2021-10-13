
namespace OLAP
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ádToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXCELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ádasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ádadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ádToolStripMenuItem,
            this.ádasdToolStripMenuItem,
            this.ádadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ádToolStripMenuItem
            // 
            this.ádToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ádToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLToolStripMenuItem,
            this.eXCELToolStripMenuItem});
            this.ádToolStripMenuItem.Image = global::OLAP.Properties.Resources.export_excel;
            this.ádToolStripMenuItem.Name = "ádToolStripMenuItem";
            this.ádToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.ádToolStripMenuItem.Text = "Dữ liệu";
            this.ádToolStripMenuItem.Click += new System.EventHandler(this.ádToolStripMenuItem_Click);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.Image = global::OLAP.Properties.Resources.iconfinder_edit_32183;
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // eXCELToolStripMenuItem
            // 
            this.eXCELToolStripMenuItem.Image = global::OLAP.Properties.Resources.iconfinder_edit_32183;
            this.eXCELToolStripMenuItem.Name = "eXCELToolStripMenuItem";
            this.eXCELToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.eXCELToolStripMenuItem.Text = "EXCEL";
            this.eXCELToolStripMenuItem.Click += new System.EventHandler(this.eXCELToolStripMenuItem_Click);
            // 
            // ádasdToolStripMenuItem
            // 
            this.ádasdToolStripMenuItem.Image = global::OLAP.Properties.Resources.kisspng_computer_icons_sql_server_reporting_services_finan_call_report_icon_5ab0d6b842f533_3012570015215387442743;
            this.ádasdToolStripMenuItem.Name = "ádasdToolStripMenuItem";
            this.ádasdToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.ádasdToolStripMenuItem.Text = "MDX";
            this.ádasdToolStripMenuItem.Click += new System.EventHandler(this.ádasdToolStripMenuItem_Click);
            // 
            // ádadToolStripMenuItem
            // 
            this.ádadToolStripMenuItem.Image = global::OLAP.Properties.Resources._5727520iconreport24;
            this.ádadToolStripMenuItem.Name = "ádadToolStripMenuItem";
            this.ádadToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.ádadToolStripMenuItem.Text = "Biểu đồ";
            this.ádadToolStripMenuItem.Click += new System.EventHandler(this.ádadToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(715, 423);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Chăn Nuôi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ádToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ádasdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ádadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXCELToolStripMenuItem;
    }
}