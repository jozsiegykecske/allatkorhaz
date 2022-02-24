namespace allatkorhaz
{
    partial class Kutyafajtak
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
            this.dgvKutyafajtak = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKutyafajtak)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKutyafajtak
            // 
            this.dgvKutyafajtak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKutyafajtak.Location = new System.Drawing.Point(179, 69);
            this.dgvKutyafajtak.Name = "dgvKutyafajtak";
            this.dgvKutyafajtak.RowHeadersWidth = 62;
            this.dgvKutyafajtak.RowTemplate.Height = 28;
            this.dgvKutyafajtak.Size = new System.Drawing.Size(478, 260);
            this.dgvKutyafajtak.TabIndex = 0;
            // 
            // Kutyafajtak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKutyafajtak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kutyafajtak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kutyafajtak";
            this.Shown += new System.EventHandler(this.Kutyafajtak_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKutyafajtak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKutyafajtak;
    }
}