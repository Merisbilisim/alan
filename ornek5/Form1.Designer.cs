namespace ornek5
{
    partial class Form1
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
            this.lblKısaKenar = new System.Windows.Forms.Label();
            this.lblUzunKenar = new System.Windows.Forms.Label();
            this.txtKısakenar = new System.Windows.Forms.TextBox();
            this.txtUzunkenar = new System.Windows.Forms.TextBox();
            this.lblAlan = new System.Windows.Forms.Label();
            this.lblÇevre = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKısaKenar
            // 
            this.lblKısaKenar.AutoSize = true;
            this.lblKısaKenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKısaKenar.Location = new System.Drawing.Point(48, 80);
            this.lblKısaKenar.Name = "lblKısaKenar";
            this.lblKısaKenar.Size = new System.Drawing.Size(100, 24);
            this.lblKısaKenar.TabIndex = 0;
            this.lblKısaKenar.Text = "Kısa Kenar";
            // 
            // lblUzunKenar
            // 
            this.lblUzunKenar.AutoSize = true;
            this.lblUzunKenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUzunKenar.Location = new System.Drawing.Point(48, 139);
            this.lblUzunKenar.Name = "lblUzunKenar";
            this.lblUzunKenar.Size = new System.Drawing.Size(109, 24);
            this.lblUzunKenar.TabIndex = 1;
            this.lblUzunKenar.Text = "Uzun Kenar";
            // 
            // txtKısakenar
            // 
            this.txtKısakenar.Location = new System.Drawing.Point(154, 85);
            this.txtKısakenar.Name = "txtKısakenar";
            this.txtKısakenar.Size = new System.Drawing.Size(123, 20);
            this.txtKısakenar.TabIndex = 2;
            this.txtKısakenar.TextChanged += new System.EventHandler(this.txtKısakenar_TextChanged);
            // 
            // txtUzunkenar
            // 
            this.txtUzunkenar.Location = new System.Drawing.Point(154, 142);
            this.txtUzunkenar.Name = "txtUzunkenar";
            this.txtUzunkenar.Size = new System.Drawing.Size(123, 20);
            this.txtUzunkenar.TabIndex = 3;
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlan.Location = new System.Drawing.Point(112, 249);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(59, 24);
            this.lblAlan.TabIndex = 4;
            this.lblAlan.Text = "Alan=";
            // 
            // lblÇevre
            // 
            this.lblÇevre.AutoSize = true;
            this.lblÇevre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÇevre.Location = new System.Drawing.Point(112, 297);
            this.lblÇevre.Name = "lblÇevre";
            this.lblÇevre.Size = new System.Drawing.Size(71, 24);
            this.lblÇevre.TabIndex = 5;
            this.lblÇevre.Text = "Çevre=";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(154, 182);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(115, 45);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Hesaplama";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblÇevre);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.txtUzunkenar);
            this.Controls.Add(this.txtKısakenar);
            this.Controls.Add(this.lblUzunKenar);
            this.Controls.Add(this.lblKısaKenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKısaKenar;
        private System.Windows.Forms.Label lblUzunKenar;
        private System.Windows.Forms.TextBox txtKısakenar;
        private System.Windows.Forms.TextBox txtUzunkenar;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.Label lblÇevre;
        private System.Windows.Forms.Button btnHesapla;
    }
}

