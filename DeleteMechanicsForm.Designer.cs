namespace TransportDB_GUI
{
    partial class DeleteMechanicsForm
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
            this.btnDeleteMechanic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMechanicID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDeleteMechanic
            // 
            this.btnDeleteMechanic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMechanic.Location = new System.Drawing.Point(343, 155);
            this.btnDeleteMechanic.Name = "btnDeleteMechanic";
            this.btnDeleteMechanic.Size = new System.Drawing.Size(140, 39);
            this.btnDeleteMechanic.TabIndex = 0;
            this.btnDeleteMechanic.Text = "Delete Mechanic";
            this.btnDeleteMechanic.UseVisualStyleBackColor = true;
            this.btnDeleteMechanic.Click += new System.EventHandler(this.btnDeleteMechanic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mechanic ID";
            // 
            // txtMechanicID
            // 
            this.txtMechanicID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMechanicID.Location = new System.Drawing.Point(460, 82);
            this.txtMechanicID.Name = "txtMechanicID";
            this.txtMechanicID.Size = new System.Drawing.Size(100, 27);
            this.txtMechanicID.TabIndex = 2;
            // 
            // DeleteMechanicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMechanicID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteMechanic);
            this.Name = "DeleteMechanicsForm";
            this.Text = "DeleteMechanicsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteMechanic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMechanicID;
    }
}
