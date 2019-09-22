namespace ToplamaIslemi
{
    partial class Toplamaİşlemi
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
            this.TabToplama = new System.Windows.Forms.TabPage();
            this.btnİleri = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.lblsayi2 = new System.Windows.Forms.Label();
            this.BtnToplama = new System.Windows.Forms.Button();
            this.lblsayi1 = new System.Windows.Forms.Label();
            this.TabToplamGenel = new System.Windows.Forms.TabControl();
            this.TabLog = new System.Windows.Forms.TabPage();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.lvLog = new System.Windows.Forms.ListView();
            this.TabToplama.SuspendLayout();
            this.TabToplamGenel.SuspendLayout();
            this.TabLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabToplama
            // 
            this.TabToplama.Controls.Add(this.btnİleri);
            this.TabToplama.Controls.Add(this.txtSonuc);
            this.TabToplama.Controls.Add(this.lblSonuc);
            this.TabToplama.Controls.Add(this.txtsayi2);
            this.TabToplama.Controls.Add(this.txtsayi1);
            this.TabToplama.Controls.Add(this.lblsayi2);
            this.TabToplama.Controls.Add(this.BtnToplama);
            this.TabToplama.Controls.Add(this.lblsayi1);
            this.TabToplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TabToplama.Location = new System.Drawing.Point(4, 25);
            this.TabToplama.Margin = new System.Windows.Forms.Padding(4);
            this.TabToplama.Name = "TabToplama";
            this.TabToplama.Padding = new System.Windows.Forms.Padding(4);
            this.TabToplama.Size = new System.Drawing.Size(1011, 472);
            this.TabToplama.TabIndex = 0;
            this.TabToplama.Text = "Toplama";
            this.TabToplama.UseVisualStyleBackColor = true;
            // 
            // btnİleri
            // 
            this.btnİleri.Location = new System.Drawing.Point(262, 268);
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(122, 31);
            this.btnİleri.TabIndex = 16;
            this.btnİleri.Text = "İleri";
            this.btnİleri.UseVisualStyleBackColor = true;
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Location = new System.Drawing.Point(140, 197);
            this.txtSonuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(159, 22);
            this.txtSonuc.TabIndex = 14;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(27, 206);
            this.lblSonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(61, 20);
            this.lblSonuc.TabIndex = 15;
            this.lblSonuc.Text = "Sonuç";
            // 
            // txtsayi2
            // 
            this.txtsayi2.Location = new System.Drawing.Point(140, 76);
            this.txtsayi2.Margin = new System.Windows.Forms.Padding(4);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(159, 22);
            this.txtsayi2.TabIndex = 2;
            this.txtsayi2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsayi2_KeyPress);
            // 
            // txtsayi1
            // 
            this.txtsayi1.Location = new System.Drawing.Point(140, 44);
            this.txtsayi1.Margin = new System.Windows.Forms.Padding(4);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(159, 22);
            this.txtsayi1.TabIndex = 1;
            this.txtsayi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsayi1_KeyPress);
            // 
            // lblsayi2
            // 
            this.lblsayi2.AutoSize = true;
            this.lblsayi2.Location = new System.Drawing.Point(27, 85);
            this.lblsayi2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsayi2.Name = "lblsayi2";
            this.lblsayi2.Size = new System.Drawing.Size(53, 17);
            this.lblsayi2.TabIndex = 13;
            this.lblsayi2.Text = "2.Sayi";
            // 
            // BtnToplama
            // 
            this.BtnToplama.Location = new System.Drawing.Point(140, 132);
            this.BtnToplama.Margin = new System.Windows.Forms.Padding(4);
            this.BtnToplama.Name = "BtnToplama";
            this.BtnToplama.Size = new System.Drawing.Size(160, 37);
            this.BtnToplama.TabIndex = 3;
            this.BtnToplama.Text = "Toplama";
            this.BtnToplama.UseVisualStyleBackColor = true;
            this.BtnToplama.Click += new System.EventHandler(this.BtnToplama_Click);
            // 
            // lblsayi1
            // 
            this.lblsayi1.AutoSize = true;
            this.lblsayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsayi1.Location = new System.Drawing.Point(27, 44);
            this.lblsayi1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsayi1.Name = "lblsayi1";
            this.lblsayi1.Size = new System.Drawing.Size(53, 17);
            this.lblsayi1.TabIndex = 11;
            this.lblsayi1.Text = "1.Sayı";
            // 
            // TabToplamGenel
            // 
            this.TabToplamGenel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabToplamGenel.Controls.Add(this.TabToplama);
            this.TabToplamGenel.Controls.Add(this.TabLog);
            this.TabToplamGenel.Location = new System.Drawing.Point(13, 13);
            this.TabToplamGenel.Margin = new System.Windows.Forms.Padding(4);
            this.TabToplamGenel.Name = "TabToplamGenel";
            this.TabToplamGenel.SelectedIndex = 0;
            this.TabToplamGenel.Size = new System.Drawing.Size(1019, 501);
            this.TabToplamGenel.TabIndex = 1;
            // 
            // TabLog
            // 
            this.TabLog.Controls.Add(this.BtnGeri);
            this.TabLog.Controls.Add(this.BtnTemizle);
            this.TabLog.Controls.Add(this.lvLog);
            this.TabLog.Location = new System.Drawing.Point(4, 25);
            this.TabLog.Name = "TabLog";
            this.TabLog.Padding = new System.Windows.Forms.Padding(3);
            this.TabLog.Size = new System.Drawing.Size(1011, 472);
            this.TabLog.TabIndex = 1;
            this.TabLog.Text = "Log";
            this.TabLog.UseVisualStyleBackColor = true;
            // 
            // BtnGeri
            // 
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGeri.Location = new System.Drawing.Point(79, 405);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(106, 33);
            this.BtnGeri.TabIndex = 3;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Location = new System.Drawing.Point(294, 405);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(109, 33);
            this.BtnTemizle.TabIndex = 4;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // lvLog
            // 
            this.lvLog.HideSelection = false;
            this.lvLog.Location = new System.Drawing.Point(6, 0);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(511, 458);
            this.lvLog.TabIndex = 2;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.List;
            // 
            // Toplamaİşlemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 508);
            this.Controls.Add(this.TabToplamGenel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Toplamaİşlemi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplama İşlemi";
            this.Load += new System.EventHandler(this.Toplamaİşlemi_Load);
            this.Shown += new System.EventHandler(this.Toplamaİşlemi_Shown);
            this.TabToplama.ResumeLayout(false);
            this.TabToplama.PerformLayout();
            this.TabToplamGenel.ResumeLayout(false);
            this.TabLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TabToplama;
        private System.Windows.Forms.TextBox txtsayi2;
        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.Label lblsayi2;
        private System.Windows.Forms.Button BtnToplama;
        private System.Windows.Forms.Label lblsayi1;
        private System.Windows.Forms.TabControl TabToplamGenel;
        private System.Windows.Forms.TabPage TabLog;
        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnİleri;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Button BtnTemizle;
    }
}

