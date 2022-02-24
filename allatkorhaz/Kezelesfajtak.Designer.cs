namespace allatkorhaz
{
    partial class Kezelesfajtak
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
            this.dgvKezelesfajtak = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKezelesfajtak)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKezelesfajtak
            // 
            this.dgvKezelesfajtak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKezelesfajtak.Location = new System.Drawing.Point(109, 108);
            this.dgvKezelesfajtak.Name = "dgvKezelesfajtak";
            this.dgvKezelesfajtak.RowHeadersWidth = 62;
            this.dgvKezelesfajtak.RowTemplate.Height = 28;
            this.dgvKezelesfajtak.Size = new System.Drawing.Size(553, 166);
            this.dgvKezelesfajtak.TabIndex = 0;
            // 
            // Kezelesfajtak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKezelesfajtak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kezelesfajtak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kezelesfajtak";
            this.Shown += new System.EventHandler(this.Kezelesfajtak_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKezelesfajtak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKezelesfajtak;
    }
}