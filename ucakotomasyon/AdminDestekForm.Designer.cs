namespace ucakotomasyon
{
    partial class AdminDestekForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.ucustable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.metintxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucustable)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.metintxt);
            this.guna2GradientPanel1.Controls.Add(this.ucustable);
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.CornflowerBlue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Cyan;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1007, 582);
            this.guna2GradientPanel1.TabIndex = 58;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Exo 2", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(686, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 28);
            this.label6.TabIndex = 55;
            this.label6.Text = "ŞİKAYET - ÖNERİ";
            // 
            // ucustable
            // 
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            this.ucustable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.ucustable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ucustable.BackgroundColor = System.Drawing.Color.Cyan;
            this.ucustable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ucustable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ucustable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.ucustable.ColumnHeadersHeight = 25;
            this.ucustable.ColumnHeadersVisible = false;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ucustable.DefaultCellStyle = dataGridViewCellStyle33;
            this.ucustable.EnableHeadersVisualStyles = false;
            this.ucustable.GridColor = System.Drawing.Color.Blue;
            this.ucustable.Location = new System.Drawing.Point(7, 104);
            this.ucustable.Name = "ucustable";
            this.ucustable.ReadOnly = true;
            this.ucustable.RowHeadersVisible = false;
            this.ucustable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ucustable.Size = new System.Drawing.Size(992, 280);
            this.ucustable.TabIndex = 84;
            this.ucustable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ucustable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ucustable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ucustable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ucustable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ucustable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ucustable.ThemeStyle.BackColor = System.Drawing.Color.Cyan;
            this.ucustable.ThemeStyle.GridColor = System.Drawing.Color.Blue;
            this.ucustable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ucustable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.ucustable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ucustable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ucustable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ucustable.ThemeStyle.HeaderStyle.Height = 25;
            this.ucustable.ThemeStyle.ReadOnly = true;
            this.ucustable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ucustable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ucustable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ucustable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ucustable.ThemeStyle.RowsStyle.Height = 22;
            this.ucustable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ucustable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ucustable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ucustable_CellClick);
            // 
            // metintxt
            // 
            this.metintxt.BackColor = System.Drawing.Color.Cyan;
            this.metintxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metintxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.metintxt.Location = new System.Drawing.Point(691, 412);
            this.metintxt.Name = "metintxt";
            this.metintxt.ReadOnly = true;
            this.metintxt.Size = new System.Drawing.Size(316, 138);
            this.metintxt.TabIndex = 85;
            this.metintxt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Exo 2", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(666, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 86;
            this.label1.Text = "Mail Adresi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Exo 2", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(337, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 28);
            this.label2.TabIndex = 87;
            this.label2.Text = "Şikayet - Öneri";
            // 
            // AdminDestekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 582);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDestekForm";
            this.Text = "AdminDestekForm";
            this.Load += new System.EventHandler(this.AdminDestekForm_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucustable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView ucustable;
        private System.Windows.Forms.RichTextBox metintxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}