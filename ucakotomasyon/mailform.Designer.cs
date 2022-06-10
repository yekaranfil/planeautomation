namespace ucakotomasyon
{
    partial class mailform
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
            this.gonderbtn = new System.Windows.Forms.Button();
            this.konubox = new System.Windows.Forms.TextBox();
            this.mailmesajbox = new System.Windows.Forms.RichTextBox();
            this.kimebox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gonderbtn
            // 
            this.gonderbtn.Location = new System.Drawing.Point(478, 357);
            this.gonderbtn.Name = "gonderbtn";
            this.gonderbtn.Size = new System.Drawing.Size(141, 44);
            this.gonderbtn.TabIndex = 0;
            this.gonderbtn.Text = "button1";
            this.gonderbtn.UseVisualStyleBackColor = true;
            this.gonderbtn.Click += new System.EventHandler(this.gonderbtn_Click);
            // 
            // konubox
            // 
            this.konubox.Location = new System.Drawing.Point(302, 191);
            this.konubox.Name = "konubox";
            this.konubox.Size = new System.Drawing.Size(189, 20);
            this.konubox.TabIndex = 1;
            // 
            // mailmesajbox
            // 
            this.mailmesajbox.Location = new System.Drawing.Point(344, 244);
            this.mailmesajbox.Name = "mailmesajbox";
            this.mailmesajbox.Size = new System.Drawing.Size(100, 96);
            this.mailmesajbox.TabIndex = 2;
            this.mailmesajbox.Text = "";
            // 
            // kimebox
            // 
            this.kimebox.Location = new System.Drawing.Point(302, 151);
            this.kimebox.Name = "kimebox";
            this.kimebox.Size = new System.Drawing.Size(189, 20);
            this.kimebox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mailform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kimebox);
            this.Controls.Add(this.mailmesajbox);
            this.Controls.Add(this.konubox);
            this.Controls.Add(this.gonderbtn);
            this.Name = "mailform";
            this.Text = "mailform";
            this.Load += new System.EventHandler(this.mailform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gonderbtn;
        private System.Windows.Forms.TextBox konubox;
        private System.Windows.Forms.RichTextBox mailmesajbox;
        private System.Windows.Forms.TextBox kimebox;
        private System.Windows.Forms.Button button1;
    }
}