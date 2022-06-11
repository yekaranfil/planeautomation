namespace ucakotomasyon
{
    partial class dogrulamaform
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.arkapanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.anamenulabel = new Guna.UI.WinForms.GunaLabel();
            this.dogrulabuton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dogrulamabox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ustpanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.arkapanel.SuspendLayout();
            this.ustpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // arkapanel
            // 
            this.arkapanel.Controls.Add(this.anamenulabel);
            this.arkapanel.Controls.Add(this.dogrulabuton);
            this.arkapanel.Controls.Add(this.dogrulamabox);
            this.arkapanel.Controls.Add(this.ustpanel);
            this.arkapanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arkapanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(69)))), ((int)(((byte)(114)))));
            this.arkapanel.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.arkapanel.Location = new System.Drawing.Point(0, 0);
            this.arkapanel.Name = "arkapanel";
            this.arkapanel.ShadowDecoration.Parent = this.arkapanel;
            this.arkapanel.Size = new System.Drawing.Size(344, 313);
            this.arkapanel.TabIndex = 0;
            // 
            // anamenulabel
            // 
            this.anamenulabel.AutoSize = true;
            this.anamenulabel.BackColor = System.Drawing.Color.Transparent;
            this.anamenulabel.Font = new System.Drawing.Font("Exo 2 ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.anamenulabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.anamenulabel.Location = new System.Drawing.Point(2, 94);
            this.anamenulabel.Name = "anamenulabel";
            this.anamenulabel.Size = new System.Drawing.Size(306, 54);
            this.anamenulabel.TabIndex = 17;
            this.anamenulabel.Text = "Lütfen Mail Adresinize Gönderilen\r\n       Doğrulama Kodunu Giriniz\r\n";
            // 
            // dogrulabuton
            // 
            this.dogrulabuton.Animated = true;
            this.dogrulabuton.AutoRoundedCorners = true;
            this.dogrulabuton.BackColor = System.Drawing.Color.Transparent;
            this.dogrulabuton.BorderRadius = 18;
            this.dogrulabuton.CheckedState.Parent = this.dogrulabuton;
            this.dogrulabuton.CustomImages.Parent = this.dogrulabuton;
            this.dogrulabuton.FillColor = System.Drawing.Color.DodgerBlue;
            this.dogrulabuton.FillColor2 = System.Drawing.Color.Cyan;
            this.dogrulabuton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dogrulabuton.ForeColor = System.Drawing.Color.Black;
            this.dogrulabuton.HoverState.Parent = this.dogrulabuton;
            this.dogrulabuton.Location = new System.Drawing.Point(99, 218);
            this.dogrulabuton.Name = "dogrulabuton";
            this.dogrulabuton.ShadowDecoration.Parent = this.dogrulabuton;
            this.dogrulabuton.Size = new System.Drawing.Size(129, 38);
            this.dogrulabuton.TabIndex = 2;
            this.dogrulabuton.Text = "DOĞRULA";
            this.dogrulabuton.Click += new System.EventHandler(this.dogrulabuton_Click);
            // 
            // dogrulamabox
            // 
            this.dogrulamabox.AutoRoundedCorners = true;
            this.dogrulamabox.BackColor = System.Drawing.Color.Transparent;
            this.dogrulamabox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dogrulamabox.BorderRadius = 17;
            this.dogrulamabox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dogrulamabox.DefaultText = "";
            this.dogrulamabox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dogrulamabox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dogrulamabox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dogrulamabox.DisabledState.Parent = this.dogrulamabox;
            this.dogrulamabox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dogrulamabox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dogrulamabox.FocusedState.Parent = this.dogrulamabox;
            this.dogrulamabox.Font = new System.Drawing.Font("Exo 2", 9.749999F);
            this.dogrulamabox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dogrulamabox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dogrulamabox.HoverState.Parent = this.dogrulamabox;
            this.dogrulamabox.Location = new System.Drawing.Point(65, 176);
            this.dogrulamabox.MaxLength = 6;
            this.dogrulamabox.Name = "dogrulamabox";
            this.dogrulamabox.PasswordChar = '\0';
            this.dogrulamabox.PlaceholderText = "";
            this.dogrulamabox.SelectedText = "";
            this.dogrulamabox.ShadowDecoration.Parent = this.dogrulamabox;
            this.dogrulamabox.Size = new System.Drawing.Size(200, 36);
            this.dogrulamabox.TabIndex = 1;
            this.dogrulamabox.TextOffset = new System.Drawing.Point(0, -2);
            // 
            // ustpanel
            // 
            this.ustpanel.Controls.Add(this.guna2ControlBox1);
            this.ustpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustpanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(69)))), ((int)(((byte)(114)))));
            this.ustpanel.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.ustpanel.Location = new System.Drawing.Point(0, 0);
            this.ustpanel.Name = "ustpanel";
            this.ustpanel.ShadowDecoration.Parent = this.ustpanel;
            this.ustpanel.Size = new System.Drawing.Size(344, 49);
            this.ustpanel.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(266, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(78, 42);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // dogrulamaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 313);
            this.Controls.Add(this.arkapanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dogrulamaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dogrulamaform";
            this.Load += new System.EventHandler(this.dogrulamaform_Load);
            this.arkapanel.ResumeLayout(false);
            this.arkapanel.PerformLayout();
            this.ustpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel arkapanel;
        private Guna.UI2.WinForms.Guna2TextBox dogrulamabox;
        private Guna.UI2.WinForms.Guna2GradientPanel ustpanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GradientButton dogrulabuton;
        private Guna.UI.WinForms.GunaLabel anamenulabel;
    }
}