
namespace Lab4Proxy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnMoveMouse = new System.Windows.Forms.ToolStripButton();
            this.btnCreateMouse = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnMoveMouse,
            this.btnCreateMouse});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(820, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Загрузить картинку";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Загрузить картинку";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnMoveMouse
            // 
            this.btnMoveMouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMoveMouse.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveMouse.Image")));
            this.btnMoveMouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoveMouse.Name = "btnMoveMouse";
            this.btnMoveMouse.Size = new System.Drawing.Size(23, 22);
            this.btnMoveMouse.Text = "Select and move";
            this.btnMoveMouse.Click += new System.EventHandler(this.btnMoveMouse_Click);
            // 
            // btnCreateMouse
            // 
            this.btnCreateMouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCreateMouse.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateMouse.Image")));
            this.btnCreateMouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateMouse.Name = "btnCreateMouse";
            this.btnCreateMouse.Size = new System.Drawing.Size(23, 22);
            this.btnCreateMouse.Text = "Create Rectangle";
            this.btnCreateMouse.Click += new System.EventHandler(this.btnCreateMouse_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 425);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnMoveMouse;
        private System.Windows.Forms.ToolStripButton btnCreateMouse;
    }
}

