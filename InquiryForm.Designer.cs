namespace TransportDB_GUI
{
    partial class InquiryForm
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
            this.dgvInquiry = new System.Windows.Forms.DataGridView();
            this.btnQ1 = new System.Windows.Forms.Button();
            this.btnQ2 = new System.Windows.Forms.Button();
            this.btnQ3 = new System.Windows.Forms.Button();
            this.btnQ4 = new System.Windows.Forms.Button();
            this.btnQ5 = new System.Windows.Forms.Button();
            this.btnQ6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquiry)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInquiry
            // 
            this.dgvInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInquiry.Location = new System.Drawing.Point(-1, 131);
            this.dgvInquiry.Name = "dgvInquiry";
            this.dgvInquiry.Size = new System.Drawing.Size(916, 405);
            this.dgvInquiry.TabIndex = 0;
            // 
            // btnQ1
            // 
            this.btnQ1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1.Location = new System.Drawing.Point(12, 25);
            this.btnQ1.Name = "btnQ1";
            this.btnQ1.Size = new System.Drawing.Size(71, 54);
            this.btnQ1.TabIndex = 1;
            this.btnQ1.Text = "Q1";
            this.btnQ1.UseVisualStyleBackColor = true;
            this.btnQ1.Click += new System.EventHandler(this.btnQ1_Click);
            // 
            // btnQ2
            // 
            this.btnQ2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ2.Location = new System.Drawing.Point(184, 25);
            this.btnQ2.Name = "btnQ2";
            this.btnQ2.Size = new System.Drawing.Size(71, 54);
            this.btnQ2.TabIndex = 2;
            this.btnQ2.Text = "Q2";
            this.btnQ2.UseVisualStyleBackColor = true;
            this.btnQ2.Click += new System.EventHandler(this.btnQ2_Click);
            // 
            // btnQ3
            // 
            this.btnQ3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ3.Location = new System.Drawing.Point(345, 25);
            this.btnQ3.Name = "btnQ3";
            this.btnQ3.Size = new System.Drawing.Size(71, 54);
            this.btnQ3.TabIndex = 3;
            this.btnQ3.Text = "Q3";
            this.btnQ3.UseVisualStyleBackColor = true;
            this.btnQ3.Click += new System.EventHandler(this.btnQ3_Click);
            // 
            // btnQ4
            // 
            this.btnQ4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ4.Location = new System.Drawing.Point(501, 25);
            this.btnQ4.Name = "btnQ4";
            this.btnQ4.Size = new System.Drawing.Size(71, 54);
            this.btnQ4.TabIndex = 4;
            this.btnQ4.Text = "Q4";
            this.btnQ4.UseVisualStyleBackColor = true;
            this.btnQ4.Click += new System.EventHandler(this.btnQ4_Click);
            // 
            // btnQ5
            // 
            this.btnQ5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ5.Location = new System.Drawing.Point(665, 25);
            this.btnQ5.Name = "btnQ5";
            this.btnQ5.Size = new System.Drawing.Size(71, 54);
            this.btnQ5.TabIndex = 5;
            this.btnQ5.Text = "Q5";
            this.btnQ5.UseVisualStyleBackColor = true;
            this.btnQ5.Click += new System.EventHandler(this.btnQ5_Click);
            // 
            // btnQ6
            // 
            this.btnQ6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ6.Location = new System.Drawing.Point(832, 25);
            this.btnQ6.Name = "btnQ6";
            this.btnQ6.Size = new System.Drawing.Size(71, 54);
            this.btnQ6.TabIndex = 6;
            this.btnQ6.Text = "Q6";
            this.btnQ6.UseVisualStyleBackColor = true;
            this.btnQ6.Click += new System.EventHandler(this.btnQ6_Click);
            // 
            // InquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 537);
            this.Controls.Add(this.btnQ6);
            this.Controls.Add(this.btnQ5);
            this.Controls.Add(this.btnQ4);
            this.Controls.Add(this.btnQ3);
            this.Controls.Add(this.btnQ2);
            this.Controls.Add(this.btnQ1);
            this.Controls.Add(this.dgvInquiry);
            this.Name = "InquiryForm";
            this.Text = "InquiryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquiry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInquiry;
        private System.Windows.Forms.Button btnQ1;
        private System.Windows.Forms.Button btnQ2;
        private System.Windows.Forms.Button btnQ3;
        private System.Windows.Forms.Button btnQ4;
        private System.Windows.Forms.Button btnQ5;
        private System.Windows.Forms.Button btnQ6;
    }
}