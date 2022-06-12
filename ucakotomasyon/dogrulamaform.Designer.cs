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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dogrulamaform));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.arkapanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt = new Guna.UI.WinForms.GunaLabel();
            this.anamenulabel = new Guna.UI.WinForms.GunaLabel();
            this.dogrulabuton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dogrulamabox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ustpanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
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
            this.arkapanel.BackgroundImage = global::ucakotomasyon.Properties.Resources.Varlık_2;
            this.arkapanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arkapanel.Controls.Add(this.gunaLabel2);
            this.arkapanel.Controls.Add(this.gunaLabel1);
            this.arkapanel.Controls.Add(this.txt);
            this.arkapanel.Controls.Add(this.anamenulabel);
            this.arkapanel.Controls.Add(this.dogrulabuton);
            this.arkapanel.Controls.Add(this.dogrulamabox);
            this.arkapanel.Controls.Add(this.ustpanel);
            this.arkapanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arkapanel.FillColor = System.Drawing.Color.Transparent;
            this.arkapanel.FillColor2 = System.Drawing.Color.Transparent;
            this.arkapanel.Location = new System.Drawing.Point(0, 0);
            this.arkapanel.Name = "arkapanel";
            this.arkapanel.ShadowDecoration.Parent = this.arkapanel;
            this.arkapanel.Size = new System.Drawing.Size(344, 313);
            this.arkapanel.TabIndex = 0;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Exo 2 ExtraBold", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(270, 89);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(75, 22);
            this.gunaLabel2.TabIndex = 20;
            this.gunaLabel2.Text = "Adresine";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Exo 2 ExtraBold", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(-2, 88);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(57, 22);
            this.gunaLabel1.TabIndex = 19;
            this.gunaLabel1.Text = "Lütfen\n";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.Transparent;
            this.txt.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Italic);
            this.txt.ForeColor = System.Drawing.Color.Cyan;
            this.txt.Location = new System.Drawing.Point(58, 88);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(192, 22);
            this.txt.TabIndex = 18;
            this.txt.Text = "y.emrekaranfil@gmail.com";
            this.txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt.Click += new System.EventHandler(this.txt_Click);
            // 
            // anamenulabel
            // 
            this.anamenulabel.AutoSize = true;
            this.anamenulabel.BackColor = System.Drawing.Color.Transparent;
            this.anamenulabel.Font = new System.Drawing.Font("Exo 2 ExtraBold", 11F, System.Drawing.FontStyle.Bold);
            this.anamenulabel.ForeColor = System.Drawing.Color.White;
            this.anamenulabel.Location = new System.Drawing.Point(24, 115);
            this.anamenulabel.Name = "anamenulabel";
            this.anamenulabel.Size = new System.Drawing.Size(280, 22);
            this.anamenulabel.TabIndex = 17;
            this.anamenulabel.Text = "Gönderilen Doğrulama Kodunu Giriniz";
            // 
            // dogrulabuton
            // 
            this.dogrulabuton.Animated = true;
            this.dogrulabuton.AutoRoundedCorners = true;
            this.dogrulabuton.BackColor = System.Drawing.Color.Transparent;
            this.dogrulabuton.BorderColor = System.Drawing.Color.Brown;
            this.dogrulabuton.BorderRadius = 18;
            this.dogrulabuton.BorderThickness = 1;
            this.dogrulabuton.CheckedState.BorderColor = System.Drawing.Color.Cyan;
            this.dogrulabuton.CheckedState.Parent = this.dogrulabuton;
            this.dogrulabuton.CustomImages.Parent = this.dogrulabuton;
            this.dogrulabuton.FillColor = System.Drawing.Color.Transparent;
            this.dogrulabuton.FillColor2 = System.Drawing.Color.Transparent;
            this.dogrulabuton.Font = new System.Drawing.Font("Exo 2", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogrulabuton.ForeColor = System.Drawing.Color.White;
            this.dogrulabuton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dogrulabuton.HoverState.Parent = this.dogrulabuton;
            this.dogrulabuton.Location = new System.Drawing.Point(98, 208);
            this.dogrulabuton.Name = "dogrulabuton";
            this.dogrulabuton.ShadowDecoration.Parent = this.dogrulabuton;
            this.dogrulabuton.Size = new System.Drawing.Size(129, 38);
            this.dogrulabuton.TabIndex = 2;
            this.dogrulabuton.Text = "Doğrula";
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
            this.dogrulamabox.ForeColor = System.Drawing.Color.Black;
            this.dogrulamabox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dogrulamabox.HoverState.Parent = this.dogrulamabox;
            this.dogrulamabox.IconLeft = global::ucakotomasyon.Properties.Resources.icons8_verified_account_32;
            this.dogrulamabox.IconLeftOffset = new System.Drawing.Point(0, -1);
            this.dogrulamabox.Location = new System.Drawing.Point(62, 153);
            this.dogrulamabox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dogrulamabox.Name = "dogrulamabox";
            this.dogrulamabox.PasswordChar = '\0';
            this.dogrulamabox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dogrulamabox.PlaceholderText = "";
            this.dogrulamabox.SelectedText = "";
            this.dogrulamabox.ShadowDecoration.Parent = this.dogrulamabox;
            this.dogrulamabox.Size = new System.Drawing.Size(200, 36);
            this.dogrulamabox.TabIndex = 1;
            this.dogrulamabox.TextOffset = new System.Drawing.Point(0, -2);
            // 
            // ustpanel
            // 
            this.ustpanel.BackgroundImage = global::ucakotomasyon.Properties.Resources.Varlık_2;
            this.ustpanel.Controls.Add(this.guna2ControlBox1);
            this.ustpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustpanel.FillColor = System.Drawing.Color.Transparent;
            this.ustpanel.FillColor2 = System.Drawing.Color.Transparent;
            this.ustpanel.Location = new System.Drawing.Point(0, 0);
            this.ustpanel.Name = "ustpanel";
            this.ustpanel.ShadowDecoration.Parent = this.ustpanel;
            this.ustpanel.Size = new System.Drawing.Size(344, 27);
            this.ustpanel.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(303, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(41, 20);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // dogrulamaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 313);
            this.Controls.Add(this.arkapanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.PrintDialog printDialog1;
        private Guna.UI.WinForms.GunaLabel txt;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}