namespace TransportDB_GUI
{
    partial class ViewMechanicsForm
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
            this.dgvMechanics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMechanics)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMechanics
            // 
            this.dgvMechanics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMechanics.Location = new System.Drawing.Point(12, 12);
            this.dgvMechanics.Name = "dgvMechanics";
            this.dgvMechanics.Size = new System.Drawing.Size(776, 394);
            this.dgvMechanics.TabIndex = 0;
            // 
            // ViewMechanicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMechanics);
            this.Name = "ViewMechanicsForm";
            this.Text = "ViewMechanicsForm";
            this.Load += new System.EventHandler(this.ViewMechanicsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMechanics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMechanics;
    }
}