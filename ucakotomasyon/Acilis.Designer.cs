namespace ucakotomasyon
{
    partial class Acilis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acilis));
            this.arkapanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.hatayazi = new System.Windows.Forms.Label();
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.arkapanel.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // arkapanel
            // 
            this.arkapanel.Controls.Add(this.hatayazi);
            this.arkapanel.Controls.Add(this.panel);
            this.arkapanel.Controls.Add(this.gunaTransfarantPictureBox1);
            this.arkapanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arkapanel.FillColor = System.Drawing.Color.Teal;
            this.arkapanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.arkapanel.Location = new System.Drawing.Point(0, 0);
            this.arkapanel.Name = "arkapanel";
            this.arkapanel.ShadowDecoration.Parent = this.arkapanel;
            this.arkapanel.Size = new System.Drawing.Size(800, 450);
            this.arkapanel.TabIndex = 1;
            // 
            // hatayazi
            // 
            this.hatayazi.AutoSize = true;
            this.hatayazi.BackColor = System.Drawing.Color.Transparent;
            this.hatayazi.Font = new System.Drawing.Font("Exo 2 SemiBold", 13.25F, System.Drawing.FontStyle.Bold);
            this.hatayazi.Location = new System.Drawing.Point(326, 404);
            this.hatayazi.Name = "hatayazi";
            this.hatayazi.Size = new System.Drawing.Size(112, 27);
            this.hatayazi.TabIndex = 4;
            this.hatayazi.Text = "Yükleniyor...";
            // 
            // panel
            // 
            this.panel.AutoRoundedCorners = true;
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel.BorderRadius = 5;
            this.panel.BorderThickness = 2;
            this.panel.Controls.Add(this.panel2);
            this.panel.Location = new System.Drawing.Point(99, 389);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(576, 12);
            this.panel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 12);
            this.panel2.TabIndex = 0;
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Image = global::ucakotomasyon.Properties.Resources.TUNEXLOGOturizm;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(9, 12);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(779, 426);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaTransfarantPictureBox1.TabIndex = 1;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Acilis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.arkapanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Acilis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acilis";
            this.Load += new System.EventHandler(this.Acilis_Load);
            this.arkapanel.ResumeLayout(false);
            this.arkapanel.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel arkapanel;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private Guna.UI2.WinForms.Guna2Panel panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label hatayazi;
    }
}