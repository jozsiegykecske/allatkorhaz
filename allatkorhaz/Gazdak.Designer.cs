namespace allatkorhaz
{
    partial class Gazdak
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
            this.dgvGazdak = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGazdak)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGazdak
            // 
            this.dgvGazdak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGazdak.Location = new System.Drawing.Point(149, 100);
            this.dgvGazdak.Name = "dgvGazdak";
            this.dgvGazdak.RowHeadersWidth = 62;
            this.dgvGazdak.RowTemplate.Height = 28;
            this.dgvGazdak.Size = new System.Drawing.Size(569, 177);
            this.dgvGazdak.TabIndex = 0;
            // 
            // Gazdak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvGazdak);
            this.Name = "Gazdak";
            this.Text = "Gazdak";
            this.Shown += new System.EventHandler(this.Gazdak_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGazdak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGazdak;
    }
}