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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.maildestekbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.geributon = new Guna.UI2.WinForms.Guna2GradientButton();
            this.kayitbuton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.mailtext = new Guna.UI2.WinForms.Guna2TextBox();
            this.destekbox = new System.Windows.Forms.RichTextBox();
            this.destekgonderb = new Guna.UI2.WinForms.Guna2GradientButton();
            this.destekboxcerceve = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.destekbutonn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.kayitolbuton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.girisbuton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtgirissifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtgiris = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.firmalogo = new System.Windows.Forms.PictureBox();
            this.minimizebuton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cikisbuton = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destekboxcerceve)).BeginInit();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmalogo)).BeginInit();
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ucakotomasyon.Properties.Resources.arkapan_giriş;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.guna2GradientButton1);
            this.panel1.Controls.Add(this.maildestekbox);
            this.panel1.Controls.Add(this.geributon);
            this.panel1.Controls.Add(this.kayitbuton2);
            this.panel1.Controls.Add(this.mailtext);
            this.panel1.Controls.Add(this.destekbox);
            this.panel1.Controls.Add(this.destekgonderb);
            this.panel1.Controls.Add(this.destekboxcerceve);
            this.panel1.Controls.Add(this.destekbutonn);
            this.panel1.Controls.Add(this.kayitolbuton);
            this.panel1.Controls.Add(this.girisbuton);
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
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BackgroundImage = global::ucakotomasyon.Properties.Resources.yonetici;
            this.guna2GradientButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2GradientButton1.BorderRadius = 22;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(12, 460);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.PressedColor = System.Drawing.Color.DeepPink;
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(47, 46);
            this.guna2GradientButton1.TabIndex = 17;
            this.guna2GradientButton1.UseTransparentBackground = true;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // maildestekbox
            // 
            this.maildestekbox.Animated = true;
            this.maildestekbox.AutoRoundedCorners = true;
            this.maildestekbox.BackColor = System.Drawing.Color.Transparent;
            this.maildestekbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maildestekbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(141)))), ((int)(((byte)(251)))));
            this.maildestekbox.BorderRadius = 16;
            this.maildestekbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maildestekbox.DefaultText = "Mail Adresi";
            this.maildestekbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.maildestekbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.maildestekbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maildestekbox.DisabledState.Parent = this.maildestekbox;
            this.maildestekbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maildestekbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maildestekbox.FocusedState.Parent = this.maildestekbox;
            this.maildestekbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maildestekbox.HoverState.Parent = this.maildestekbox;
            this.maildestekbox.IconLeft = global::ucakotomasyon.Properties.Resources.mailbox;
            this.maildestekbox.IconLeftSize = new System.Drawing.Size(25, 25);
            this.maildestekbox.Location = new System.Drawing.Point(800, 445);
            this.maildestekbox.Name = "maildestekbox";
            this.maildestekbox.PasswordChar = '\0';
            this.maildestekbox.PlaceholderText = "";
            this.maildestekbox.SelectedText = "";
            this.maildestekbox.SelectionStart = 11;
            this.maildestekbox.ShadowDecoration.Parent = this.maildestekbox;
            this.maildestekbox.Size = new System.Drawing.Size(173, 34);
            this.maildestekbox.TabIndex = 16;
            this.maildestekbox.Visible = false;
            this.maildestekbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maildestekbox_KeyPress);
            // 
            // geributon
            // 
            this.geributon.Animated = true;
            this.geributon.AutoRoundedCorners = true;
            this.geributon.BackColor = System.Drawing.Color.Transparent;
            this.geributon.BackgroundImage = global::ucakotomasyon.Properties.Resources.icons8_undo_32;
            this.geributon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.geributon.BorderColor = System.Drawing.Color.Transparent;
            this.geributon.BorderRadius = 15;
            this.geributon.CheckedState.Parent = this.geributon;
            this.geributon.CustomImages.Parent = this.geributon;
            this.geributon.FillColor = System.Drawing.Color.Transparent;
            this.geributon.FillColor2 = System.Drawing.Color.Transparent;
            this.geributon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geributon.ForeColor = System.Drawing.Color.White;
            this.geributon.HoverState.Parent = this.geributon;
            this.geributon.Location = new System.Drawing.Point(76, 308);
            this.geributon.Name = "geributon";
            this.geributon.PressedColor = System.Drawing.Color.MediumVioletRed;
            this.geributon.ShadowDecoration.BorderRadius = 20;
            this.geributon.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.geributon.ShadowDecoration.Depth = 12;
            this.geributon.ShadowDecoration.Enabled = true;
            this.geributon.ShadowDecoration.Parent = this.geributon;
            this.geributon.Size = new System.Drawing.Size(37, 33);
            this.geributon.TabIndex = 15;
            this.geributon.UseTransparentBackground = true;
            this.geributon.Visible = false;
            this.geributon.Click += new System.EventHandler(this.geributon_Click);
            // 
            // kayitbuton2
            // 
            this.kayitbuton2.Animated = true;
            this.kayitbuton2.AutoRoundedCorners = true;
            this.kayitbuton2.BackColor = System.Drawing.Color.Transparent;
            this.kayitbuton2.BorderColor = System.Drawing.Color.Crimson;
            this.kayitbuton2.BorderRadius = 15;
            this.kayitbuton2.CheckedState.Parent = this.kayitbuton2;
            this.kayitbuton2.CustomImages.Parent = this.kayitbuton2;
            this.kayitbuton2.FillColor = System.Drawing.Color.DarkOrchid;
            this.kayitbuton2.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.kayitbuton2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitbuton2.ForeColor = System.Drawing.Color.White;
            this.kayitbuton2.HoverState.Parent = this.kayitbuton2;
            this.kayitbuton2.Location = new System.Drawing.Point(119, 308);
            this.kayitbuton2.Name = "kayitbuton2";
            this.kayitbuton2.PressedColor = System.Drawing.Color.MediumVioletRed;
            this.kayitbuton2.ShadowDecoration.BorderRadius = 20;
            this.kayitbuton2.ShadowDecoration.Depth = 12;
            this.kayitbuton2.ShadowDecoration.Enabled = true;
            this.kayitbuton2.ShadowDecoration.Parent = this.kayitbuton2;
            this.kayitbuton2.Size = new System.Drawing.Size(131, 33);
            this.kayitbuton2.TabIndex = 14;
            this.kayitbuton2.Text = "Kaydı Tamamla";
            this.kayitbuton2.Visible = false;
            this.kayitbuton2.Click += new System.EventHandler(this.kayitbuton2_Click);
            // 
            // mailtext
            // 
            this.mailtext.Animated = true;
            this.mailtext.AutoRoundedCorners = true;
            this.mailtext.BackColor = System.Drawing.Color.Transparent;
            this.mailtext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mailtext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(141)))), ((int)(((byte)(251)))));
            this.mailtext.BorderRadius = 19;
            this.mailtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mailtext.DefaultText = "Mail Adresi";
            this.mailtext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mailtext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mailtext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mailtext.DisabledState.Parent = this.mailtext;
            this.mailtext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mailtext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mailtext.FocusedState.Parent = this.mailtext;
            this.mailtext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mailtext.HoverState.Parent = this.mailtext;
            this.mailtext.IconLeft = global::ucakotomasyon.Properties.Resources.mailbox;
            this.mailtext.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.mailtext.IconRightOffset = new System.Drawing.Point(10, 0);
            this.mailtext.IconRightSize = new System.Drawing.Size(25, 25);
            this.mailtext.Location = new System.Drawing.Point(65, 261);
            this.mailtext.Name = "mailtext";
            this.mailtext.PasswordChar = '\0';
            this.mailtext.PlaceholderText = "";
            this.mailtext.SelectedText = "";
            this.mailtext.SelectionStart = 11;
            this.mailtext.ShadowDecoration.Parent = this.mailtext;
            this.mailtext.Size = new System.Drawing.Size(243, 41);
            this.mailtext.TabIndex = 13;
            this.mailtext.Visible = false;
            this.mailtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mailtext_KeyPress);
            // 
            // destekbox
            // 
            this.destekbox.BackColor = System.Drawing.Color.White;
            this.destekbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.destekbox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destekbox.Location = new System.Drawing.Point(809, 241);
            this.destekbox.Name = "destekbox";
            this.destekbox.Size = new System.Drawing.Size(218, 156);
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
            this.destekgonderb.FillColor = System.Drawing.Color.Blue;
            this.destekgonderb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.destekgonderb.ForeColor = System.Drawing.Color.White;
            this.destekgonderb.HoverState.Parent = this.destekgonderb;
            this.destekgonderb.Location = new System.Drawing.Point(838, 481);
            this.destekgonderb.Name = "destekgonderb";
            this.destekgonderb.ShadowDecoration.Parent = this.destekgonderb;
            this.destekgonderb.Size = new System.Drawing.Size(113, 30);
            this.destekgonderb.TabIndex = 11;
            this.destekgonderb.Text = "Gönder";
            this.destekgonderb.UseTransparentBackground = true;
            this.destekgonderb.Visible = false;
            this.destekgonderb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.destekgonderb_MouseDown);
            // 
            // destekboxcerceve
            // 
            this.destekboxcerceve.BackColor = System.Drawing.Color.Transparent;
            this.destekboxcerceve.BaseColor = System.Drawing.Color.Black;
            this.destekboxcerceve.Image = global::ucakotomasyon.Properties.Resources.Destekkutusu1;
            this.destekboxcerceve.Location = new System.Drawing.Point(800, 230);
            this.destekboxcerceve.Name = "destekboxcerceve";
            this.destekboxcerceve.Size = new System.Drawing.Size(237, 209);
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
            this.destekbutonn.Location = new System.Drawing.Point(979, 445);
            this.destekbutonn.Name = "destekbutonn";
            this.destekbutonn.PressedColor = System.Drawing.Color.DeepPink;
            this.destekbutonn.ShadowDecoration.Parent = this.destekbutonn;
            this.destekbutonn.Size = new System.Drawing.Size(58, 61);
            this.destekbutonn.TabIndex = 9;
            this.destekbutonn.UseTransparentBackground = true;
            this.destekbutonn.Click += new System.EventHandler(this.destekbutonn_Click);
            this.destekbutonn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.destekbutonn_MouseDown);
            // 
            // kayitolbuton
            // 
            this.kayitolbuton.Animated = true;
            this.kayitolbuton.AutoRoundedCorners = true;
            this.kayitolbuton.BackColor = System.Drawing.Color.Transparent;
            this.kayitolbuton.BorderColor = System.Drawing.Color.Crimson;
            this.kayitolbuton.BorderRadius = 15;
            this.kayitolbuton.CheckedState.Parent = this.kayitolbuton;
            this.kayitolbuton.CustomImages.Parent = this.kayitolbuton;
            this.kayitolbuton.FillColor = System.Drawing.Color.DarkOrchid;
            this.kayitolbuton.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.kayitolbuton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitolbuton.ForeColor = System.Drawing.Color.White;
            this.kayitolbuton.HoverState.Parent = this.kayitolbuton;
            this.kayitolbuton.Location = new System.Drawing.Point(119, 308);
            this.kayitolbuton.Name = "kayitolbuton";
            this.kayitolbuton.PressedColor = System.Drawing.Color.MediumVioletRed;
            this.kayitolbuton.ShadowDecoration.BorderRadius = 20;
            this.kayitolbuton.ShadowDecoration.Depth = 12;
            this.kayitolbuton.ShadowDecoration.Enabled = true;
            this.kayitolbuton.ShadowDecoration.Parent = this.kayitolbuton;
            this.kayitolbuton.Size = new System.Drawing.Size(131, 33);
            this.kayitolbuton.TabIndex = 4;
            this.kayitolbuton.Text = "Kayıt Ol";
            this.kayitolbuton.Click += new System.EventHandler(this.kayitolbuton_Click);
            // 
            // girisbuton
            // 
            this.girisbuton.Animated = true;
            this.girisbuton.AutoRoundedCorners = true;
            this.girisbuton.BackColor = System.Drawing.Color.Transparent;
            this.girisbuton.BorderColor = System.Drawing.Color.Crimson;
            this.girisbuton.BorderRadius = 15;
            this.girisbuton.CheckedState.Parent = this.girisbuton;
            this.girisbuton.CustomImages.Parent = this.girisbuton;
            this.girisbuton.FillColor = System.Drawing.Color.DarkOrchid;
            this.girisbuton.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.girisbuton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisbuton.ForeColor = System.Drawing.Color.White;
            this.girisbuton.HoverState.Parent = this.girisbuton;
            this.girisbuton.Location = new System.Drawing.Point(119, 269);
            this.girisbuton.Name = "girisbuton";
            this.girisbuton.PressedColor = System.Drawing.Color.MediumVioletRed;
            this.girisbuton.ShadowDecoration.BorderRadius = 20;
            this.girisbuton.ShadowDecoration.Depth = 12;
            this.girisbuton.ShadowDecoration.Enabled = true;
            this.girisbuton.ShadowDecoration.Parent = this.girisbuton;
            this.girisbuton.Size = new System.Drawing.Size(131, 33);
            this.girisbuton.TabIndex = 3;
            this.girisbuton.Text = "Giriş Yap";
            this.girisbuton.Click += new System.EventHandler(this.girisbuton_Click);
            this.girisbuton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.girisbuton_MouseDown);
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
            this.txtgirissifre.Location = new System.Drawing.Point(65, 200);
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
            this.txtgiris.DefaultText = "T.C. Kimlik Numarası";
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
            this.txtgiris.Location = new System.Drawing.Point(65, 138);
            this.txtgiris.Name = "txtgiris";
            this.txtgiris.PasswordChar = '\0';
            this.txtgiris.PlaceholderText = "";
            this.txtgiris.SelectedText = "";
            this.txtgiris.SelectionStart = 20;
            this.txtgiris.ShadowDecoration.Parent = this.txtgiris;
            this.txtgiris.Size = new System.Drawing.Size(243, 41);
            this.txtgiris.TabIndex = 1;
            this.txtgiris.TextChanged += new System.EventHandler(this.txtgiris_TextChanged);
            this.txtgiris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgiris_KeyPress);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2GradientPanel2.BackgroundImage = global::ucakotomasyon.Properties.Resources.arkaplan_üst;
            this.guna2GradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2GradientPanel2.Controls.Add(this.firmalogo);
            this.guna2GradientPanel2.Controls.Add(this.minimizebuton);
            this.guna2GradientPanel2.Controls.Add(this.cikisbuton);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(-14, -1);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(1081, 68);
            this.guna2GradientPanel2.TabIndex = 0;
            this.guna2GradientPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2GradientPanel2_MouseDown);
            // 
            // firmalogo
            // 
            this.firmalogo.BackColor = System.Drawing.Color.Transparent;
            this.firmalogo.Image = global::ucakotomasyon.Properties.Resources.logolar;
            this.firmalogo.Location = new System.Drawing.Point(-14, -30);
            this.firmalogo.Name = "firmalogo";
            this.firmalogo.Size = new System.Drawing.Size(424, 134);
            this.firmalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.firmalogo.TabIndex = 5;
            this.firmalogo.TabStop = false;
            this.firmalogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // minimizebuton
            // 
            this.minimizebuton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizebuton.Animated = true;
            this.minimizebuton.BackColor = System.Drawing.Color.Transparent;
            this.minimizebuton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimizebuton.FillColor = System.Drawing.Color.Transparent;
            this.minimizebuton.HoverState.FillColor = System.Drawing.Color.Gray;
            this.minimizebuton.HoverState.IconColor = System.Drawing.Color.White;
            this.minimizebuton.HoverState.Parent = this.minimizebuton;
            this.minimizebuton.IconColor = System.Drawing.Color.Black;
            this.minimizebuton.Location = new System.Drawing.Point(959, 0);
            this.minimizebuton.Name = "minimizebuton";
            this.minimizebuton.ShadowDecoration.Parent = this.minimizebuton;
            this.minimizebuton.Size = new System.Drawing.Size(50, 31);
            this.minimizebuton.TabIndex = 2;
            this.minimizebuton.UseTransparentBackground = true;
            // 
            // cikisbuton
            // 
            this.cikisbuton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cikisbuton.Animated = true;
            this.cikisbuton.BackColor = System.Drawing.Color.Transparent;
            this.cikisbuton.FillColor = System.Drawing.Color.Transparent;
            this.cikisbuton.HoverState.FillColor = System.Drawing.Color.Red;
            this.cikisbuton.HoverState.IconColor = System.Drawing.Color.White;
            this.cikisbuton.HoverState.Parent = this.cikisbuton;
            this.cikisbuton.IconColor = System.Drawing.Color.Black;
            this.cikisbuton.Location = new System.Drawing.Point(1015, 1);
            this.cikisbuton.Name = "cikisbuton";
            this.cikisbuton.ShadowDecoration.Parent = this.cikisbuton;
            this.cikisbuton.Size = new System.Drawing.Size(50, 31);
            this.cikisbuton.TabIndex = 0;
            this.cikisbuton.UseTransparentBackground = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 519);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.destekboxcerceve)).EndInit();
            this.guna2GradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firmalogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2ControlBox minimizebuton;
        private Guna.UI2.WinForms.Guna2ControlBox cikisbuton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public Guna.UI2.WinForms.Guna2TextBox txtgirissifre;
        internal System.Windows.Forms.PictureBox firmalogo;
        private Guna.UI2.WinForms.Guna2GradientButton destekbutonn;
        private Guna.UI2.WinForms.Guna2GradientButton destekgonderb;
        private Guna.UI.WinForms.GunaTransfarantPictureBox destekboxcerceve;
        private System.Windows.Forms.RichTextBox destekbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public Guna.UI2.WinForms.Guna2TextBox txtgiris;
        public Guna.UI2.WinForms.Guna2TextBox mailtext;
        public Guna.UI2.WinForms.Guna2GradientButton kayitbuton2;
        public Guna.UI2.WinForms.Guna2GradientButton geributon;
        public Guna.UI2.WinForms.Guna2GradientButton girisbuton;
        public Guna.UI2.WinForms.Guna2GradientButton kayitolbuton;
        public Guna.UI2.WinForms.Guna2GradientPanel panel1;
        public Guna.UI2.WinForms.Guna2TextBox maildestekbox;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}

