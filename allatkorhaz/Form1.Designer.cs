namespace allatkorhaz
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
            this.tbFnev = new System.Windows.Forms.TextBox();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKuldes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFnev
            // 
            this.tbFnev.Location = new System.Drawing.Point(421, 114);
            this.tbFnev.Name = "tbFnev";
            this.tbFnev.Size = new System.Drawing.Size(100, 26);
            this.tbFnev.TabIndex = 1;
            // 
            // tbJelszo
            // 
            this.tbJelszo.Location = new System.Drawing.Point(421, 199);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.PasswordChar = '*';
            this.tbJelszo.Size = new System.Drawing.Size(100, 26);
            this.tbJelszo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Felhasználónév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelszó:";
            // 
            // btnKuldes
            // 
            this.btnKuldes.Location = new System.Drawing.Point(329, 261);
            this.btnKuldes.Name = "btnKuldes";
            this.btnKuldes.Size = new System.Drawing.Size(112, 30);
            this.btnKuldes.TabIndex = 3;
            this.btnKuldes.Text = "Küldés";
            this.btnKuldes.UseVisualStyleBackColor = true;
            this.btnKuldes.Click += new System.EventHandler(this.btnKuldes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKuldes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbJelszo);
            this.Controls.Add(this.tbFnev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Belépés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFnev;
        private System.Windows.Forms.TextBox tbJelszo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKuldes;
    }
}

