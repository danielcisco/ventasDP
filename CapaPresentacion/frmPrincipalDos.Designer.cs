namespace CapaPresentacion
{
    partial class frmPrincipalDos
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
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.zddfgsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zddfgsToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(124, 28);
            // 
            // zddfgsToolStripMenuItem
            // 
            this.zddfgsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdfssToolStripMenuItem});
            this.zddfgsToolStripMenuItem.Name = "zddfgsToolStripMenuItem";
            this.zddfgsToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.zddfgsToolStripMenuItem.Text = "zddfgs";
            // 
            // sdfssToolStripMenuItem
            // 
            this.sdfssToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdfsToolStripMenuItem});
            this.sdfssToolStripMenuItem.Name = "sdfssToolStripMenuItem";
            this.sdfssToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sdfssToolStripMenuItem.Text = "sdfss";
            // 
            // sdfsToolStripMenuItem
            // 
            this.sdfsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdfToolStripMenuItem});
            this.sdfsToolStripMenuItem.Name = "sdfsToolStripMenuItem";
            this.sdfsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sdfsToolStripMenuItem.Text = "sdfs";
            // 
            // sdfToolStripMenuItem
            // 
            this.sdfToolStripMenuItem.Name = "sdfToolStripMenuItem";
            this.sdfToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sdfToolStripMenuItem.Text = "sdf";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.ContextMenuStrip = this.materialContextMenuStrip1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(63, 37);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(75, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // frmPrincipalDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 531);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "frmPrincipalDos";
            this.Text = "frmPrincipalDos";
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zddfgsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdfssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdfsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdfToolStripMenuItem;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    }
}