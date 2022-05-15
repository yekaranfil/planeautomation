namespace ucakotomasyon
{
    partial class HataBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HataBox));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.onayresim = new System.Windows.Forms.PictureBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.hatayazi = new System.Windows.Forms.Label();
            this.hataresim = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.hatamesaj = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onayresim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hataresim)).BeginInit();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.onayresim);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientButton1);
            this.guna2GradientPanel1.Controls.Add(this.hatayazi);
            this.guna2GradientPanel1.Controls.Add(this.hataresim);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientPanel2);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(358, 157);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // onayresim
            // 
            this.onayresim.Image = global::ucakotomasyon.Properties.Resources.Onay;
            this.onayresim.Location = new System.Drawing.Point(12, 62);
            this.onayresim.Name = "onayresim";
            this.onayresim.Size = new System.Drawing.Size(100, 57);
            this.onayresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.onayresim.TabIndex = 5;
            this.onayresim.TabStop = false;
            this.onayresim.Visible = false;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 13;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Teal;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(250, 126);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(96, 28);
            this.guna2GradientButton1.TabIndex = 4;
            this.guna2GradientButton1.Text = "TAMAM";
            this.guna2GradientButton1.UseTransparentBackground = true;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // hatayazi
            // 
            this.hatayazi.AutoSize = true;
            this.hatayazi.BackColor = System.Drawing.Color.Transparent;
            this.hatayazi.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hatayazi.Location = new System.Drawing.Point(118, 62);
            this.hatayazi.Name = "hatayazi";
            this.hatayazi.Size = new System.Drawing.Size(42, 17);
            this.hatayazi.TabIndex = 3;
            this.hatayazi.Text = "HATA";
            // 
            // hataresim
            // 
            this.hataresim.Image = ((System.Drawing.Image)(resources.GetObject("hataresim.Image")));
            this.hataresim.Location = new System.Drawing.Point(12, 62);
            this.hataresim.Name = "hataresim";
            this.hataresim.Size = new System.Drawing.Size(100, 57);
            this.hataresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hataresim.TabIndex = 1;
            this.hataresim.TabStop = false;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.hatamesaj);
            this.guna2GradientPanel2.Controls.Add(this.guna2ControlBox3);
            this.guna2GradientPanel2.Controls.Add(this.guna2ControlBox1);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.MediumPurple;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientPanel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(358, 40);
            this.guna2GradientPanel2.TabIndex = 0;
            this.guna2GradientPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2GradientPanel2_MouseDown);
            // 
            // hatamesaj
            // 
            this.hatamesaj.AutoSize = true;
            this.hatamesaj.BackColor = System.Drawing.Color.Transparent;
            this.hatamesaj.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hatamesaj.Location = new System.Drawing.Point(8, 9);
            this.hatamesaj.Name = "hatamesaj";
            this.hatamesaj.Size = new System.Drawing.Size(53, 21);
            this.hatamesaj.TabIndex = 2;
            this.hatamesaj.Text = "HATA";
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.Animated = true;
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(250, 3);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 2;
            this.guna2ControlBox3.UseTransparentBackground = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(301, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.UseTransparentBackground = true;
            // 
            // HataBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 157);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HataBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HataBox";
            this.Load += new System.EventHandler(this.HataBox_Load_1);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onayresim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hataresim)).EndInit();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.Label hatayazi;
        private System.Windows.Forms.Label hatamesaj;
        public System.Windows.Forms.PictureBox hataresim;
        public System.Windows.Forms.PictureBox onayresim;
    }
}