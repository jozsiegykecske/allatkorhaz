namespace allatkorhaz
{
    partial class Fomenu
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
            this.btnKezelesek = new System.Windows.Forms.Button();
            this.btnKutyafajtak = new System.Windows.Forms.Button();
            this.btnGazdak = new System.Windows.Forms.Button();
            this.btnKutyak = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.btnKezelesfajtak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKezelesek
            // 
            this.btnKezelesek.Location = new System.Drawing.Point(205, 33);
            this.btnKezelesek.Name = "btnKezelesek";
            this.btnKezelesek.Size = new System.Drawing.Size(353, 49);
            this.btnKezelesek.TabIndex = 0;
            this.btnKezelesek.Text = "Kezelések";
            this.btnKezelesek.UseVisualStyleBackColor = true;
            this.btnKezelesek.Click += new System.EventHandler(this.btnKezelesek_Click);
            // 
            // btnKutyafajtak
            // 
            this.btnKutyafajtak.Location = new System.Drawing.Point(205, 88);
            this.btnKutyafajtak.Name = "btnKutyafajtak";
            this.btnKutyafajtak.Size = new System.Drawing.Size(353, 49);
            this.btnKutyafajtak.TabIndex = 0;
            this.btnKutyafajtak.Text = "Kutyafajták";
            this.btnKutyafajtak.UseVisualStyleBackColor = true;
            this.btnKutyafajtak.Click += new System.EventHandler(this.btnKutyafajtak_Click);
            // 
            // btnGazdak
            // 
            this.btnGazdak.Location = new System.Drawing.Point(205, 143);
            this.btnGazdak.Name = "btnGazdak";
            this.btnGazdak.Size = new System.Drawing.Size(353, 49);
            this.btnGazdak.TabIndex = 0;
            this.btnGazdak.Text = "Gazdák";
            this.btnGazdak.UseVisualStyleBackColor = true;
            this.btnGazdak.Click += new System.EventHandler(this.btnGazdak_Click);
            // 
            // btnKutyak
            // 
            this.btnKutyak.Location = new System.Drawing.Point(205, 198);
            this.btnKutyak.Name = "btnKutyak";
            this.btnKutyak.Size = new System.Drawing.Size(353, 49);
            this.btnKutyak.TabIndex = 0;
            this.btnKutyak.Text = "Kutyák";
            this.btnKutyak.UseVisualStyleBackColor = true;
            this.btnKutyak.Click += new System.EventHandler(this.btnKutyak_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(205, 360);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(353, 49);
            this.btnKilepes.TabIndex = 0;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // btnKezelesfajtak
            // 
            this.btnKezelesfajtak.Location = new System.Drawing.Point(205, 253);
            this.btnKezelesfajtak.Name = "btnKezelesfajtak";
            this.btnKezelesfajtak.Size = new System.Drawing.Size(353, 49);
            this.btnKezelesfajtak.TabIndex = 0;
            this.btnKezelesfajtak.Text = "Kezelésfajták";
            this.btnKezelesfajtak.UseVisualStyleBackColor = true;
            this.btnKezelesfajtak.Click += new System.EventHandler(this.btnKezelesfajtak_Click);
            // 
            // Fomenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnKezelesfajtak);
            this.Controls.Add(this.btnKutyak);
            this.Controls.Add(this.btnGazdak);
            this.Controls.Add(this.btnKutyafajtak);
            this.Controls.Add(this.btnKezelesek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Fomenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fomenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fomenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKezelesek;
        private System.Windows.Forms.Button btnKutyafajtak;
        private System.Windows.Forms.Button btnGazdak;
        private System.Windows.Forms.Button btnKutyak;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Button btnKezelesfajtak;
    }
}