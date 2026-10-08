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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(145, 9);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(43, 13);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "HOTEL";
            // 
            // cmb_n1
            // 
            this.cmb_n1.FormattingEnabled = true;
            this.cmb_n1.Items.AddRange(new object[] {
            "Bassa Stagione",
            "Media Stagione",
            "Alta Stagione"});
            this.cmb_n1.Location = new System.Drawing.Point(26, 56);
            this.cmb_n1.Name = "cmb_n1";
            this.cmb_n1.Size = new System.Drawing.Size(115, 21);
            this.cmb_n1.TabIndex = 1;
            this.cmb_n1.Text = "Seleziona Stagione";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(26, 40);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(0, 13);
            this.lbl_n2.TabIndex = 2;
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Location = new System.Drawing.Point(26, 40);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(49, 13);
            this.lbl_n3.TabIndex = 3;
            this.lbl_n3.Text = "Stagione";
            this.lbl_n3.Click += new System.EventHandler(this.lbl_n3_Click);
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.Location = new System.Drawing.Point(23, 102);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(62, 13);
            this.lbl_n4.TabIndex = 4;
            this.lbl_n4.Text = "Tipo stanza";
            // 
            // cmb_n2
            // 
            this.cmb_n2.FormattingEnabled = true;
            this.cmb_n2.Items.AddRange(new object[] {
            "Bassa ",
            "Media ",
            "Alta"});
            this.cmb_n2.Location = new System.Drawing.Point(26, 143);
            this.cmb_n2.Name = "cmb_n2";
            this.cmb_n2.Size = new System.Drawing.Size(115, 21);
            this.cmb_n2.TabIndex = 5;
            this.cmb_n2.Text = "Seleziona stanza";
            // 
            // chk_n1
            // 
            this.chk_n1.AutoSize = true;
            this.chk_n1.Location = new System.Drawing.Point(29, 188);
            this.chk_n1.Name = "chk_n1";
            this.chk_n1.Size = new System.Drawing.Size(80, 17);
            this.chk_n1.TabIndex = 6;
            this.chk_n1.Text = "Parcheggio";
            this.chk_n1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 291);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chk_n1);
            this.Controls.Add(this.cmb_n2);
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.cmb_n1);
            this.Controls.Add(this.lbl_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

