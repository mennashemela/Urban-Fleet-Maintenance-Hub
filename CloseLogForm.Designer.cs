namespace TransportDB_GUI
{
    partial class CloseLogForm
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
            this.btnCloseLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogID = new System.Windows.Forms.TextBox();
            this.txtCloseDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCloseLog
            // 
            this.btnCloseLog.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLog.Location = new System.Drawing.Point(343, 211);
            this.btnCloseLog.Name = "btnCloseLog";
            this.btnCloseLog.Size = new System.Drawing.Size(126, 39);
            this.btnCloseLog.TabIndex = 0;
            this.btnCloseLog.Text = "Close Log";
            this.btnCloseLog.UseVisualStyleBackColor = true;
            this.btnCloseLog.Click += new System.EventHandler(this.btnCloseLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Close Date (yyyy-mm-dd)";
            // 
            // txtLogID
            // 
            this.txtLogID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogID.Location = new System.Drawing.Point(460, 63);
            this.txtLogID.Name = "txtLogID";
            this.txtLogID.Size = new System.Drawing.Size(100, 27);
            this.txtLogID.TabIndex = 3;
            // 
            // txtCloseDate
            // 
            this.txtCloseDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCloseDate.Location = new System.Drawing.Point(460, 131);
            this.txtCloseDate.Name = "txtCloseDate";
            this.txtCloseDate.Size = new System.Drawing.Size(150, 27);
            this.txtCloseDate.TabIndex = 4;
            // 
            // CloseLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCloseDate);
            this.Controls.Add(this.txtLogID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseLog);
            this.Name = "CloseLogForm";
            this.Text = "CloseLogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogID;
        private System.Windows.Forms.TextBox txtCloseDate;
    }
}
