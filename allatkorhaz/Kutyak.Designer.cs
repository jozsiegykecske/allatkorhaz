namespace allatkorhaz
{
    partial class Kutyak
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
            this.dgvKutyak = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKutyak)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKutyak
            // 
            this.dgvKutyak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKutyak.Location = new System.Drawing.Point(117, 109);
            this.dgvKutyak.Name = "dgvKutyak";
            this.dgvKutyak.RowHeadersWidth = 62;
            this.dgvKutyak.RowTemplate.Height = 28;
            this.dgvKutyak.Size = new System.Drawing.Size(588, 146);
            this.dgvKutyak.TabIndex = 0;
            // 
            // Kutyak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKutyak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kutyak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kutyak";
            this.Shown += new System.EventHandler(this.Kutyak_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKutyak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKutyak;
    }
}