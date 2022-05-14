namespace ucakotomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.destekbox = new System.Windows.Forms.RichTextBox();
            this.destekgonderb = new Guna.UI2.WinForms.Guna2GradientButton();
            this.destekboxcerceve = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.destekbutonn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtgirissifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtgiris = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destekboxcerceve)).BeginInit();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ucakotomasyon.Properties.Resources.arkapan_giriş;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.destekbox);
            this.panel1.Controls.Add(this.destekgonderb);
            this.panel1.Controls.Add(this.destekboxcerceve);
            this.panel1.Controls.Add(this.destekbutonn);
            this.panel1.Controls.Add(this.guna2GradientButton2);
            this.panel1.Controls.Add(this.guna2GradientButton1);
            this.panel1.Controls.Add(this.txtgirissifre);
            this.panel1.Controls.Add(this.txtgiris);
            this.panel1.Controls.Add(this.guna2GradientPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDecoration.Parent = this.panel1;
            this.panel1.Size = new System.Drawing.Size(1051, 519);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseEnter += new System.EventHandler(this.guna2GradientPanel1_MouseEnter);
            // 
            // destekbox
            // 
            this.destekbox.BackColor = System.Drawing.Color.White;
            this.destekbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.destekbox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destekbox.Location = new System.Drawing.Point(45, 227);
            this.destekbox.Name = "destekbox";
            this.destekbox.Size = new System.Drawing.Size(196, 182);
            this.destekbox.TabIndex = 12;
            this.destekbox.Text = "";
            this.destekbox.Visible = false;
            // 
            // destekgonderb
            // 
            this.destekgonderb.AutoRoundedCorners = true;
            this.destekgonderb.BackColor = System.Drawing.Color.Transparent;
            this.destekgonderb.BorderRadius = 14;
            this.destekgonderb.CheckedState.Parent = this.destekgonderb;
            this.destekgonderb.CustomImages.Parent = this.destekgonderb;
            this.destekgonderb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.destekgonderb.ForeColor = System.Drawing.Color.White;
            this.destekgonderb.HoverState.Parent = this.destekgonderb;
            this.destekgonderb.Location = new System.Drawing.Point(128, 463);
            this.destekgonderb.Name = "destekgonderb";
            this.destekgonderb.ShadowDecoration.Parent = this.destekgonderb;
            this.destekgonderb.Size = new System.Drawing.Size(113, 30);
            this.destekgonderb.TabIndex = 11;
            this.destekgonderb.Text = "Gönder";
            this.destekgonderb.UseTransparentBackground = true;
            this.destekgonderb.Visible = false;
            this.destekgonderb.Click += new System.EventHandler(this.destekgonderb_Click);
            this.destekgonderb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.destekgonderb_MouseDown);
            // 
            // destekboxcerceve
            // 
            this.destekboxcerceve.BackColor = System.Drawing.Color.Transparent;
            this.destekboxcerceve.BaseColor = System.Drawing.Color.Black;
            this.destekboxcerceve.Image = global::ucakotomasyon.Properties.Resources.chatbox2;
            this.destekboxcerceve.Location = new System.Drawing.Point(-5, 184);
            this.destekboxcerceve.Name = "destekboxcerceve";
            this.destekboxcerceve.Size = new System.Drawing.Size(297, 280);
            this.destekboxcerceve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.destekboxcerceve.TabIndex = 10;
            this.destekboxcerceve.TabStop = false;
            this.destekboxcerceve.Visible = false;
            // 
            // destekbutonn
            // 
            this.destekbutonn.Animated = true;
            this.destekbutonn.AutoRoundedCorners = true;
            this.destekbutonn.BackColor = System.Drawing.Color.Transparent;
            this.destekbutonn.BackgroundImage = global::ucakotomasyon.Properties.Resources._2840156;
            this.destekbutonn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.destekbutonn.BorderRadius = 28;
            this.destekbutonn.CheckedState.Parent = this.destekbutonn;
            this.destekbutonn.CustomImages.Parent = this.destekbutonn;
            this.destekbutonn.FillColor = System.Drawing.Color.Transparent;
            this.destekbutonn.FillColor2 = System.Drawing.Color.Transparent;
            this.destekbutonn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.destekbutonn.ForeColor = System.Drawing.Color.White;
            this.destekbutonn.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.destekbutonn.HoverState.Parent = this.destekbutonn;
            this.destekbutonn.Location = new System.Drawing.Point(12, 446);
            this.destekbutonn.Name = "destekbutonn";
            this.destekbutonn.PressedColor = System.Drawing.Color.DeepPink;
            this.destekbutonn.ShadowDecoration.Parent = this.destekbutonn;
            this.destekbutonn.Size = new System.Drawing.Size(58, 61);
            this.destekbutonn.TabIndex = 9;
            this.destekbutonn.UseTransparentBackground = true;
            this.destekbutonn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.destekbutonn_MouseDown);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.AutoRoundedCorners = true;
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BorderColor = System.Drawing.Color.Crimson;
            this.guna2GradientButton2.BorderRadius = 15;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.DarkOrchid;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(119, 308);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.PressedColor = System.Drawing.Color.MediumVioletRed;
            this.guna2GradientButton2.ShadowDecoration.BorderRadius = 20;
            this.guna2GradientButton2.ShadowDecoration.Depth = 12;
            this.guna2GradientButton2.ShadowDecoration.Enabled = true;
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(131, 33);
            this.guna2GradientButton2.TabIndex = 4;
            this.guna2GradientButton2.Text = "Kayıt Ol";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.Crimson;
            this.guna2GradientButton1.BorderRadius = 15;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.DarkOrchid;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(119, 269);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.PressedColor = System.Drawing.Color.MediumVioletRed;
            this.guna2GradientButton1.ShadowDecoration.BorderRadius = 20;
            this.guna2GradientButton1.ShadowDecoration.Depth = 12;
            this.guna2GradientButton1.ShadowDecoration.Enabled = true;
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(131, 33);
            this.guna2GradientButton1.TabIndex = 3;
            this.guna2GradientButton1.Text = "Giriş Yap";
            // 
            // txtgirissifre
            // 
            this.txtgirissifre.Animated = true;
            this.txtgirissifre.AutoRoundedCorners = true;
            this.txtgirissifre.BackColor = System.Drawing.Color.Transparent;
            this.txtgirissifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtgirissifre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(141)))), ((int)(((byte)(251)))));
            this.txtgirissifre.BorderRadius = 19;
            this.txtgirissifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgirissifre.DefaultText = "Şifre";
            this.txtgirissifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtgirissifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtgirissifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgirissifre.DisabledState.Parent = this.txtgirissifre;
            this.txtgirissifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgirissifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgirissifre.FocusedState.Parent = this.txtgirissifre;
            this.txtgirissifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgirissifre.HoverState.Parent = this.txtgirissifre;
            this.txtgirissifre.IconLeft = global::ucakotomasyon.Properties.Resources.resim_2022_05_13_203358808_removebg_preview;
            this.txtgirissifre.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.txtgirissifre.IconLeftSize = new System.Drawing.Size(23, 20);
            this.txtgirissifre.Location = new System.Drawing.Point(65, 208);
            this.txtgirissifre.Name = "txtgirissifre";
            this.txtgirissifre.PasswordChar = '\0';
            this.txtgirissifre.PlaceholderText = "";
            this.txtgirissifre.SelectedText = "";
            this.txtgirissifre.SelectionStart = 5;
            this.txtgirissifre.ShadowDecoration.Parent = this.txtgirissifre;
            this.txtgirissifre.Size = new System.Drawing.Size(243, 41);
            this.txtgirissifre.TabIndex = 2;
            this.txtgirissifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgirissifre_KeyPress);
            // 
            // txtgiris
            // 
            this.txtgiris.Animated = true;
            this.txtgiris.AutoRoundedCorners = true;
            this.txtgiris.BackColor = System.Drawing.Color.Transparent;
            this.txtgiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtgiris.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(141)))), ((int)(((byte)(251)))));
            this.txtgiris.BorderRadius = 19;
            this.txtgiris.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgiris.DefaultText = "Kullanıcı adı";
            this.txtgiris.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtgiris.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtgiris.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgiris.DisabledState.Parent = this.txtgiris;
            this.txtgiris.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgiris.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgiris.FocusedState.Parent = this.txtgiris;
            this.txtgiris.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgiris.HoverState.Parent = this.txtgiris;
            this.txtgiris.IconLeft = global::ucakotomasyon.Properties.Resources.user;
            this.txtgiris.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtgiris.Location = new System.Drawing.Point(65, 149);
            this.txtgiris.Name = "txtgiris";
            this.txtgiris.PasswordChar = '\0';
            this.txtgiris.PlaceholderText = "";
            this.txtgiris.SelectedText = "";
            this.txtgiris.SelectionStart = 13;
            this.txtgiris.ShadowDecoration.Parent = this.txtgiris;
            this.txtgiris.Size = new System.Drawing.Size(243, 41);
            this.txtgiris.TabIndex = 1;
            this.txtgiris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgiris_KeyPress);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2GradientPanel2.BackgroundImage = global::ucakotomasyon.Properties.Resources.arkaplan_üst;
            this.guna2GradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2GradientPanel2.Controls.Add(this.pictureBox2);
            this.guna2GradientPanel2.Controls.Add(this.guna2ControlBox3);
            this.guna2GradientPanel2.Controls.Add(this.guna2ControlBox1);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(-14, -1);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(1081, 68);
            this.guna2GradientPanel2.TabIndex = 0;
            this.guna2GradientPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2GradientPanel2_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ucakotomasyon.Properties.Resources.logolar;
            this.pictureBox2.Location = new System.Drawing.Point(-14, -30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(424, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.Gray;
            this.guna2ControlBox3.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(959, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(50, 31);
            this.guna2ControlBox3.TabIndex = 2;
            this.guna2ControlBox3.UseTransparentBackground = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1015, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(50, 31);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.UseTransparentBackground = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 519);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.destekboxcerceve)).EndInit();
            this.guna2GradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel panel1;
        public Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtgiris;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public Guna.UI2.WinForms.Guna2TextBox txtgirissifre;
        internal System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GradientButton destekbutonn;
        private Guna.UI2.WinForms.Guna2GradientButton destekgonderb;
        private Guna.UI.WinForms.GunaTransfarantPictureBox destekboxcerceve;
        private System.Windows.Forms.RichTextBox destekbox;
    }
}

