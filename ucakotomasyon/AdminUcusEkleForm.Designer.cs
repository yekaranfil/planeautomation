﻿namespace ucakotomasyon
{
    partial class AdminUcusEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUcusEkleForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.plakabox = new Guna.UI2.WinForms.Guna2TextBox();
            this.firmabox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.onaylabuton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.koltukbox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.logobox = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this;
            // 
            // plakabox
            // 
            this.plakabox.Animated = true;
            this.plakabox.AutoRoundedCorners = true;
            this.plakabox.BackColor = System.Drawing.Color.Transparent;
            this.plakabox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.plakabox.BorderRadius = 17;
            this.plakabox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.plakabox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.plakabox.DefaultText = "";
            this.plakabox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.plakabox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.plakabox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.plakabox.DisabledState.Parent = this.plakabox;
            this.plakabox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.plakabox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.plakabox.FocusedState.Parent = this.plakabox;
            this.plakabox.Font = new System.Drawing.Font("Exo 2", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plakabox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.plakabox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.plakabox.HoverState.Parent = this.plakabox;
            this.plakabox.Location = new System.Drawing.Point(226, 195);
            this.plakabox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plakabox.Name = "plakabox";
            this.plakabox.PasswordChar = '\0';
            this.plakabox.PlaceholderText = "";
            this.plakabox.SelectedText = "";
            this.plakabox.ShadowDecoration.Parent = this.plakabox;
            this.plakabox.Size = new System.Drawing.Size(185, 36);
            this.plakabox.TabIndex = 0;
            // 
            // firmabox
            // 
            this.firmabox.Animated = true;
            this.firmabox.AutoRoundedCorners = true;
            this.firmabox.BackColor = System.Drawing.Color.Transparent;
            this.firmabox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.firmabox.BorderRadius = 17;
            this.firmabox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.firmabox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firmabox.FocusedColor = System.Drawing.Color.Empty;
            this.firmabox.FocusedState.Parent = this.firmabox;
            this.firmabox.Font = new System.Drawing.Font("Exo 2", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmabox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firmabox.FormattingEnabled = true;
            this.firmabox.HoverState.Parent = this.firmabox;
            this.firmabox.ItemHeight = 30;
            this.firmabox.ItemsAppearance.Parent = this.firmabox;
            this.firmabox.Location = new System.Drawing.Point(226, 140);
            this.firmabox.Name = "firmabox";
            this.firmabox.ShadowDecoration.Parent = this.firmabox;
            this.firmabox.Size = new System.Drawing.Size(185, 36);
            this.firmabox.TabIndex = 2;
            this.firmabox.SelectedIndexChanged += new System.EventHandler(this.firmabox_SelectedIndexChanged);
            // 
            // onaylabuton
            // 
            this.onaylabuton.Animated = true;
            this.onaylabuton.AutoRoundedCorners = true;
            this.onaylabuton.BackColor = System.Drawing.Color.Transparent;
            this.onaylabuton.BorderRadius = 15;
            this.onaylabuton.CheckedState.Parent = this.onaylabuton;
            this.onaylabuton.CustomImages.Parent = this.onaylabuton;
            this.onaylabuton.FillColor = System.Drawing.Color.Blue;
            this.onaylabuton.FillColor2 = System.Drawing.Color.Teal;
            this.onaylabuton.Font = new System.Drawing.Font("Exo 2", 9.749999F);
            this.onaylabuton.ForeColor = System.Drawing.Color.White;
            this.onaylabuton.HoverState.Parent = this.onaylabuton;
            this.onaylabuton.Location = new System.Drawing.Point(211, 302);
            this.onaylabuton.Name = "onaylabuton";
            this.onaylabuton.ShadowDecoration.Parent = this.onaylabuton;
            this.onaylabuton.Size = new System.Drawing.Size(103, 33);
            this.onaylabuton.TabIndex = 4;
            this.onaylabuton.Text = "ONAYLA";
            this.onaylabuton.UseTransparentBackground = true;
            this.onaylabuton.Click += new System.EventHandler(this.onaylabuton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Exo 2", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(78, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 28);
            this.label6.TabIndex = 53;
            this.label6.Text = "FİRMA SEÇİMİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Exo 2", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(78, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 54;
            this.label1.Text = "PLAKA ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Exo 2", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(78, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 55;
            this.label2.Text = "KOLTUK SAYISI";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.koltukbox);
            this.guna2GradientPanel1.Controls.Add(this.firmabox);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Controls.Add(this.onaylabuton);
            this.guna2GradientPanel1.Controls.Add(this.plakabox);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.logobox);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(69)))), ((int)(((byte)(114)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1007, 582);
            this.guna2GradientPanel1.TabIndex = 56;
            // 
            // koltukbox
            // 
            this.koltukbox.Animated = true;
            this.koltukbox.AutoRoundedCorners = true;
            this.koltukbox.BackColor = System.Drawing.Color.Transparent;
            this.koltukbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.koltukbox.BorderRadius = 17;
            this.koltukbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.koltukbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.koltukbox.FocusedColor = System.Drawing.Color.Empty;
            this.koltukbox.FocusedState.Parent = this.koltukbox;
            this.koltukbox.Font = new System.Drawing.Font("Exo 2", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.koltukbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.koltukbox.FormattingEnabled = true;
            this.koltukbox.HoverState.Parent = this.koltukbox;
            this.koltukbox.ItemHeight = 30;
            this.koltukbox.Items.AddRange(new object[] {
            "40",
            "56",
            "72"});
            this.koltukbox.ItemsAppearance.Parent = this.koltukbox;
            this.koltukbox.Location = new System.Drawing.Point(226, 246);
            this.koltukbox.Name = "koltukbox";
            this.koltukbox.ShadowDecoration.Parent = this.koltukbox;
            this.koltukbox.Size = new System.Drawing.Size(185, 36);
            this.koltukbox.TabIndex = 56;
            // 
            // logobox
            // 
            this.logobox.BackColor = System.Drawing.Color.Transparent;
            this.logobox.BaseColor = System.Drawing.Color.Black;
            this.logobox.Location = new System.Drawing.Point(432, 60);
            this.logobox.Name = "logobox";
            this.logobox.Size = new System.Drawing.Size(522, 311);
            this.logobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logobox.TabIndex = 5;
            this.logobox.TabStop = false;
            // 
            // AdminUcusEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1007, 582);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminUcusEkleForm";
            this.Text = "AdminUcusEkleForm";
            this.Load += new System.EventHandler(this.AdminUcusEkleForm_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI2.WinForms.Guna2ComboBox firmabox;
        private Guna.UI2.WinForms.Guna2TextBox plakabox;
        private Guna.UI.WinForms.GunaTransfarantPictureBox logobox;
        public Guna.UI2.WinForms.Guna2GradientButton onaylabuton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox koltukbox;
    }
}