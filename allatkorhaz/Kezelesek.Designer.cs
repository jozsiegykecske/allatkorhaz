namespace allatkorhaz
{
    partial class Kezelesek
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
            this.dgvKezelesek = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKezelesek)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKezelesek
            // 
            this.dgvKezelesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKezelesek.Location = new System.Drawing.Point(139, 93);
            this.dgvKezelesek.Name = "dgvKezelesek";
            this.dgvKezelesek.RowHeadersWidth = 62;
            this.dgvKezelesek.RowTemplate.Height = 28;
            this.dgvKezelesek.Size = new System.Drawing.Size(567, 150);
            this.dgvKezelesek.TabIndex = 0;
            // 
            // Kezelesek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKezelesek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kezelesek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kezelesek";
            this.Shown += new System.EventHandler(this.Kezelesek_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKezelesek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKezelesek;
    }
}