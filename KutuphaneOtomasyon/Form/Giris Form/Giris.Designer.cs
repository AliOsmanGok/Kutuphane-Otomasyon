
namespace KutuphaneOtomasyon
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.btnGiris = new System.Windows.Forms.Button();
            this.cikisButton = new System.Windows.Forms.Button();
            this.txtLogPass = new System.Windows.Forms.TextBox();
            this.txtLogMail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiris.BackgroundImage")));
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(762, 462);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(118, 37);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // cikisButton
            // 
            this.cikisButton.AutoEllipsis = true;
            this.cikisButton.BackColor = System.Drawing.Color.White;
            this.cikisButton.BackgroundImage = global::KutuphaneOtomasyon.Properties.Resources.giriş_butonu0_400x94;
            this.cikisButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cikisButton.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.cikisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisButton.ForeColor = System.Drawing.Color.White;
            this.cikisButton.Location = new System.Drawing.Point(766, 505);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(109, 29);
            this.cikisButton.TabIndex = 4;
            this.cikisButton.Text = "ÇIKIŞ";
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // txtLogPass
            // 
            this.txtLogPass.BackColor = System.Drawing.Color.White;
            this.txtLogPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogPass.ForeColor = System.Drawing.Color.Gray;
            this.txtLogPass.Location = new System.Drawing.Point(743, 415);
            this.txtLogPass.Name = "txtLogPass";
            this.txtLogPass.PasswordChar = '*';
            this.txtLogPass.Size = new System.Drawing.Size(152, 20);
            this.txtLogPass.TabIndex = 2;
            this.txtLogPass.Click += new System.EventHandler(this.txtLogPass_Click);
            // 
            // txtLogMail
            // 
            this.txtLogMail.BackColor = System.Drawing.Color.White;
            this.txtLogMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLogMail.ForeColor = System.Drawing.Color.Black;
            this.txtLogMail.Location = new System.Drawing.Point(743, 339);
            this.txtLogMail.Name = "txtLogMail";
            this.txtLogMail.Size = new System.Drawing.Size(152, 20);
            this.txtLogMail.TabIndex = 1;
            this.txtLogMail.Click += new System.EventHandler(this.txtLogMail_Click);
            this.txtLogMail.Leave += new System.EventHandler(this.txtLogMail_Leave);
            // 
            // Giris
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.cikisButton;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.txtLogMail);
            this.Controls.Add(this.txtLogPass);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.btnGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Giris_FormClosing);
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.TextBox txtLogPass;
        private System.Windows.Forms.TextBox txtLogMail;
    }
}