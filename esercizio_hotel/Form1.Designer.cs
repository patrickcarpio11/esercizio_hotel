namespace esercizio_hotel
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.cmb_n1 = new System.Windows.Forms.ComboBox();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.cmb_n2 = new System.Windows.Forms.ComboBox();
            this.chk_n1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_n5 = new System.Windows.Forms.Label();
            this.nud_n1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_n6 = new System.Windows.Forms.Label();
            this.lbl_n7 = new System.Windows.Forms.Label();
            this.lbl_n8 = new System.Windows.Forms.Label();
            this.btn_n1 = new System.Windows.Forms.Button();
            this.btn_n2 = new System.Windows.Forms.Button();
            this.lbl_n9 = new System.Windows.Forms.Label();
            this.grp_n1 = new System.Windows.Forms.GroupBox();
            this.lbl_n10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n1)).BeginInit();
            this.grp_n1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_n1.Location = new System.Drawing.Point(119, 11);
            this.lbl_n1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(337, 29);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = " PATRICK RESORT HOTEL";
            // 
            // cmb_n1
            // 
            this.cmb_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_n1.FormattingEnabled = true;
            this.cmb_n1.Items.AddRange(new object[] {
            "Bassa Stagione",
            "Media Stagione",
            "Alta Stagione"});
            this.cmb_n1.Location = new System.Drawing.Point(18, 69);
            this.cmb_n1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_n1.Name = "cmb_n1";
            this.cmb_n1.Size = new System.Drawing.Size(230, 33);
            this.cmb_n1.TabIndex = 1;
            this.cmb_n1.Text = "Seleziona Stagione";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(35, 49);
            this.lbl_n2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(0, 16);
            this.lbl_n2.TabIndex = 2;
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.Location = new System.Drawing.Point(13, 36);
            this.lbl_n3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(117, 29);
            this.lbl_n3.TabIndex = 3;
            this.lbl_n3.Text = "Stagione";
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n4.Location = new System.Drawing.Point(13, 122);
            this.lbl_n4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(148, 29);
            this.lbl_n4.TabIndex = 4;
            this.lbl_n4.Text = "Tipo stanza";
            // 
            // cmb_n2
            // 
            this.cmb_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_n2.FormattingEnabled = true;
            this.cmb_n2.Items.AddRange(new object[] {
            "Bassa ",
            "Media ",
            "Alta"});
            this.cmb_n2.Location = new System.Drawing.Point(18, 179);
            this.cmb_n2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_n2.Name = "cmb_n2";
            this.cmb_n2.Size = new System.Drawing.Size(229, 33);
            this.cmb_n2.TabIndex = 5;
            this.cmb_n2.Text = "Seleziona stanza";
            // 
            // chk_n1
            // 
            this.chk_n1.AutoSize = true;
            this.chk_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_n1.Location = new System.Drawing.Point(18, 327);
            this.chk_n1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_n1.Name = "chk_n1";
            this.chk_n1.Size = new System.Drawing.Size(192, 29);
            this.chk_n1.TabIndex = 6;
            this.chk_n1.Text = "Parcheggio 5€/g";
            this.chk_n1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(255, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_n5
            // 
            this.lbl_n5.AutoSize = true;
            this.lbl_n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n5.Location = new System.Drawing.Point(13, 230);
            this.lbl_n5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n5.Name = "lbl_n5";
            this.lbl_n5.Size = new System.Drawing.Size(215, 29);
            this.lbl_n5.TabIndex = 8;
            this.lbl_n5.Text = "Giorni di alloggio";
            // 
            // nud_n1
            // 
            this.nud_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_n1.Location = new System.Drawing.Point(18, 271);
            this.nud_n1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nud_n1.Name = "nud_n1";
            this.nud_n1.Size = new System.Drawing.Size(229, 30);
            this.nud_n1.TabIndex = 9;
            // 
            // lbl_n6
            // 
            this.lbl_n6.AutoSize = true;
            this.lbl_n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n6.Location = new System.Drawing.Point(260, 239);
            this.lbl_n6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n6.Name = "lbl_n6";
            this.lbl_n6.Size = new System.Drawing.Size(196, 25);
            this.lbl_n6.TabIndex = 10;
            this.lbl_n6.Text = " 2 giorni sconto 0%";
            // 
            // lbl_n7
            // 
            this.lbl_n7.AutoSize = true;
            this.lbl_n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n7.Location = new System.Drawing.Point(269, 264);
            this.lbl_n7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n7.Name = "lbl_n7";
            this.lbl_n7.Size = new System.Drawing.Size(222, 25);
            this.lbl_n7.TabIndex = 11;
            this.lbl_n7.Text = "3-7 giorni sconto 25%";
            // 
            // lbl_n8
            // 
            this.lbl_n8.AutoSize = true;
            this.lbl_n8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n8.Location = new System.Drawing.Point(269, 290);
            this.lbl_n8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n8.Name = "lbl_n8";
            this.lbl_n8.Size = new System.Drawing.Size(201, 25);
            this.lbl_n8.TabIndex = 12;
            this.lbl_n8.Text = "7 in poi sconto 35%";
            // 
            // btn_n1
            // 
            this.btn_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n1.Location = new System.Drawing.Point(13, 381);
            this.btn_n1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(195, 41);
            this.btn_n1.TabIndex = 13;
            this.btn_n1.Text = "Prenota";
            this.btn_n1.UseVisualStyleBackColor = true;
            this.btn_n1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // btn_n2
            // 
            this.btn_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n2.Location = new System.Drawing.Point(684, 278);
            this.btn_n2.Name = "btn_n2";
            this.btn_n2.Size = new System.Drawing.Size(89, 32);
            this.btn_n2.TabIndex = 14;
            this.btn_n2.Text = "?";
            this.btn_n2.UseVisualStyleBackColor = true;
            this.btn_n2.Click += new System.EventHandler(this.btn_n2_Click);
            // 
            // lbl_n9
            // 
            this.lbl_n9.AutoSize = true;
            this.lbl_n9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n9.Location = new System.Drawing.Point(620, 246);
            this.lbl_n9.Name = "lbl_n9";
            this.lbl_n9.Size = new System.Drawing.Size(217, 25);
            this.lbl_n9.TabIndex = 15;
            this.lbl_n9.Text = "Maggiori informazioni";
            // 
            // grp_n1
            // 
            this.grp_n1.Controls.Add(this.lbl_n10);
            this.grp_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_n1.Location = new System.Drawing.Point(237, 313);
            this.grp_n1.Name = "grp_n1";
            this.grp_n1.Size = new System.Drawing.Size(690, 133);
            this.grp_n1.TabIndex = 16;
            this.grp_n1.TabStop = false;
            this.grp_n1.Text = "Info :";
            this.grp_n1.Visible = false;
            // 
            // lbl_n10
            // 
            this.lbl_n10.AutoSize = true;
            this.lbl_n10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n10.Location = new System.Drawing.Point(6, 26);
            this.lbl_n10.Name = "lbl_n10";
            this.lbl_n10.Size = new System.Drawing.Size(680, 96);
            this.lbl_n10.TabIndex = 17;
            this.lbl_n10.Text = resources.GetString("lbl_n10.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(924, 435);
            this.Controls.Add(this.grp_n1);
            this.Controls.Add(this.lbl_n9);
            this.Controls.Add(this.btn_n2);
            this.Controls.Add(this.btn_n1);
            this.Controls.Add(this.lbl_n8);
            this.Controls.Add(this.lbl_n7);
            this.Controls.Add(this.lbl_n6);
            this.Controls.Add(this.nud_n1);
            this.Controls.Add(this.lbl_n5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chk_n1);
            this.Controls.Add(this.cmb_n2);
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.cmb_n1);
            this.Controls.Add(this.lbl_n1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n1)).EndInit();
            this.grp_n1.ResumeLayout(false);
            this.grp_n1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.ComboBox cmb_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.ComboBox cmb_n2;
        private System.Windows.Forms.CheckBox chk_n1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_n5;
        private System.Windows.Forms.NumericUpDown nud_n1;
        private System.Windows.Forms.Label lbl_n6;
        private System.Windows.Forms.Label lbl_n7;
        private System.Windows.Forms.Label lbl_n8;
        private System.Windows.Forms.Button btn_n1;
        private System.Windows.Forms.Button btn_n2;
        private System.Windows.Forms.Label lbl_n9;
        private System.Windows.Forms.GroupBox grp_n1;
        private System.Windows.Forms.Label lbl_n10;
    }
}

